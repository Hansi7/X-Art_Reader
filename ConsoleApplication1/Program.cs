using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBackGroundWorker<object, List<X_Art_View.ArtMovie>> mbg = new MyBackGroundWorker<object, List<X_Art_View.ArtMovie>>(10);

            mbg.DoSingleWork += mbg_DoSingleWork;
            mbg.ProgressChanged += mbg_ProgressChanged;
            mbg.RunWorkCompleted += mbg_RunWorkCompleted;
            
            List<object> list = new List<object>()
            {
            11,12,13,14,15,16,17,18,19,20
            };

            mbg.Inputs = list;
            mbg.RunWorkerAsync();

            Console.WriteLine("STart!");
            Console.ReadKey();
        }

        static void mbg_RunWorkCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("AllComplete!");

        }

        static void mbg_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Console.WriteLine(e.ProgressPercentage + "% ====");
        }
        
        static void mbg_DoSingleWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            X_Art_View.HegrePage p = new X_Art_View.HegrePage();
            p.IsDownloadBoardPicture = true;
            p.IsDownloadCoverPicture = true;
            p.CompleteOneItem += p_CompleteOneItem;
            int k = ((int)e.Argument);
            e.Result = p.GetGalleries(k);
        }

        static void p_CompleteOneItem(object sender, X_Art_View.OneCompleteEventArg e)
        {
            Console.WriteLine(e.Tag as string);
        }

        private static void MethodOne()
        {

            System.ComponentModel.BackgroundWorker bw = new System.ComponentModel.BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += bw_ProgressChanged;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;

            bw.RunWorkerAsync();
            Console.ReadKey();
        }

        static void bw_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Done!");
        }

        static void bw_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Console.WriteLine(e.ProgressPercentage.ToString());
        }

        static void bw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<X_Art_View.ArtMovie> list = new List<X_Art_View.ArtMovie>();
            X_Art_View.HegrePage h = new X_Art_View.HegrePage();
            h.CompleteOneItem += h_CompleteOneItem;
            h.IsDownloadBoardPicture = true;
            h.IsDownloadCoverPicture = true;
            for (int i = 1  ; i < 11; i++)
            {
                list.AddRange(h.GetGalleries(i));
                (sender as System.ComponentModel.BackgroundWorker).ReportProgress(i * 10);
            }
        }

        static void h_CompleteOneItem(object sender, X_Art_View.OneCompleteEventArg e)
        {
            Console.WriteLine(e.Tag as string);
        }
    }
}
