using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


    /// <summary>
    /// 多线程后台Worker
    /// </summary>
    /// <typeparam name="T">输入列表的类型</typeparam>
    /// <typeparam name="T2">输出列表的类型</typeparam>
    public class MyBackGroundWorker<T,T2> 
        where T:class 
        where T2:class
    {
        private List<T> _inputs;
        /// <summary>
        /// 输入列表
        /// </summary>
        public List<T> Inputs
        {
            get { return _inputs; }
            set { _inputs = value; }
        }

        private List<T2> _result = new List<T2>();
        /// <summary>
        /// 输出结果列表
        /// </summary>
        public List<T2> Result
        {
            get { return _result; }
            set { _result = value; }
        }

        private int _threadCount;
        /// <summary>
        /// 后台工作线程数量
        /// </summary>
        public int ThreadCount
        {
            get { return _threadCount; }
            set { 
                _threadCount = value;
                resetSemaphore();
            }
        }

        private void resetSemaphore()
        {
            this.semaphore = new Semaphore(0, _threadCount);
        }
        /// <summary>
        /// 是否在运行异步操作
        /// </summary>
        public bool IsBusy
        {
            get { return this.mainWorker.IsBusy; }
        }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="threadCount">后台工作线程数量</param>
        public MyBackGroundWorker(int threadCount)
        {
            this._threadCount = threadCount;
            resetSemaphore();
            mainWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(mainWorker_DoWork);
            mainWorker.WorkerReportsProgress = true;
            mainWorker.WorkerSupportsCancellation = true;
        }

        long c = 0;
        System.ComponentModel.BackgroundWorker mainWorker = new System.ComponentModel.BackgroundWorker();
        Semaphore semaphore;

        Exception errException;

        public void RunWorkerAsync()
        {
            try
            {
                if (mainWorker.IsBusy)
                {
                    throw new InvalidOperationException("已经开始运行了");
                }

                if (this.Inputs == null)
                {
                    throw new ArgumentException("Input对象不能为空");
                }
                Interlocked.Add(ref c, Inputs.Count);
                mainWorker.RunWorkerAsync();
            }
            catch (Exception err)
            {
                this.errException = err;
            }
        }

        public void CancleAsync()
        {
            if (!this.mainWorker.WorkerSupportsCancellation)
            {
                mainWorker.CancelAsync();
            }
        }

        void mainWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (this.Inputs==null)
            {
                OnRunWorkCompleted();
                throw new ArgumentException("没有输入参数请给赋值");
                
            }

            semaphore.Release(this.ThreadCount);

            for (int i = 0; i < Inputs.Count; i++)
            {
                if (mainWorker.CancellationPending)
                {
                    e.Cancel = true;
                }

                if (Interlocked.Read(ref c) > 0)
                {
                    semaphore.WaitOne();
                    System.ComponentModel.BackgroundWorker bgw = new System.ComponentModel.BackgroundWorker();
                    bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(bgw_DoWork);
                    bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
                    bgw.RunWorkerAsync(Inputs[i]);
                    //开始一个新的线程工作。
                    
                }
            }
        }

        void bgw_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.Result.Add(e.Result as T2);
            var k = Interlocked.Decrement(ref c);
            semaphore.Release(1);
        
            if (Interlocked.Read(ref c) == 0)
            {
                //this.ProgressChanged.Invoke(this,new System.ComponentModel.ProgressChangedEventArgs(100,e.Result as T2));
                OnProgressChanged(100, e.Result);
                OnRunWorkCompleted();
            }
            else
            {

                //this.ProgressChanged.Invoke(this, new System.ComponentModel.ProgressChangedEventArgs(100, e.Result as T2));
                OnProgressChanged((int)(100 - k * 100 / Inputs.Count), e.Result);
            }
        }

        void bgw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (this.DoSingleWork != null)
            {
                this.DoSingleWork(this, e);
            }
        }

        protected virtual void OnRunWorkCompleted()
        {
            if (this.RunWorkCompleted!=null)
            {
                RunWorkCompleted(this, new System.ComponentModel.RunWorkerCompletedEventArgs(this.Result, this.errException, mainWorker.CancellationPending));
            }
        }

        protected virtual void OnProgressChanged(int prograssPercent, object userState)
        {
            if (this.ProgressChanged!=null)
            {
                this.ProgressChanged(this, new System.ComponentModel.ProgressChangedEventArgs(prograssPercent, userState));
            }
        }

        public event System.ComponentModel.DoWorkEventHandler DoSingleWork;

        public event System.ComponentModel.RunWorkerCompletedEventHandler RunWorkCompleted;

        public event System.ComponentModel.ProgressChangedEventHandler ProgressChanged;


    }
