using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace X_Art_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initComboBox();
        }
        void initComboBox()
        {
            ArtPage x = new ArtPage();
            HegrePage hegre = new HegrePage();

            cb_scraper.Items.Add(x);
            cb_scraper.Items.Add(hegre);

            cb_scraper.DisplayMember = "DisplayName";
        }

        List<ArtMovie> AllList = new List<ArtMovie>();
        List<ArtModel> AllModels = new List<ArtModel>();
        ArtPage vp = new ArtPage();


        #region UI Control

        int currentIndex = -1;

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (AllList.Count > 0 && AllList.Count > currentIndex + 1)
            {
                currentIndex += 1;
                SetShowBox(null);
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (AllList.Count > 0 && currentIndex > 0)
            {
                currentIndex += -1;
                SetShowBox(null);
            }

        }

        /// <summary>
        /// show detail
        /// </summary>
        /// <param name="movie">if this param is null ,the show the currentindex Movie,else show the param movie</param>
        private void SetShowBox(ArtMovie movie)
        {
            try
            {
                if (movie == null)
                {
                    this.trackBar1.Maximum = AllList.Count;
                    this.trackBar1.Minimum = 1;
                    this.trackBar1.Value = currentIndex + 1;
                    this.lbl_ViewProgress.Text = (currentIndex + 1) + "/" + AllList.Count;

                    var m = this.AllList[currentIndex];
                    this.lbl_desc.Text = m.Description;
                    this.lbl_title.Text = m.Title;
                    this.lbl_type.Text = m.Type;
                    if (!string.IsNullOrEmpty(m.CoverFile))
                    {
                        this.pictureBox1.Image = Image.FromFile(m.CoverFile);
                        this.pictureBox1.Tag = m.CoverFile;
                    }
                }
                else
                {
                    this.trackBar1.Maximum = AllList.Count;
                    this.trackBar1.Minimum = 1;
                    this.trackBar1.Value = AllList.Count;
                    this.lbl_ViewProgress.Text = this.trackBar1.Value + "/" + (AllList.Count+1);
                    var m = movie;
                    this.lbl_desc.Text = m.Description;
                    this.lbl_title.Text = m.Title;
                    this.lbl_type.Text = m.Type;
                    if (!string.IsNullOrEmpty(m.CoverFile))
                    {
                        this.pictureBox1.Image = Image.FromFile(m.CoverFile);
                        this.pictureBox1.Tag = m.CoverFile;
                    }
                }
            }
            catch (Exception err)
            {

            }
        }

        int togleNumber = 1;

        private void btn_hideAndShow_Click(object sender, EventArgs e)
        {
            if (togleNumber++ % 2 == 0)
            {
                this.Size = new Size(this.Size.Width, 736);
            }
            else
            {
                this.Size = new Size(this.Size.Width, 200);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.currentIndex = trackBar1.Value - 1;
            SetShowBox(null);
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start((sender as PictureBox).Tag.ToString());
            }
            catch
            {

            }

        }
        #endregion



        private void btn_model_Click(object sender, EventArgs e)
        {
            var modelfile = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Models.dat");
            BinaryFormatter bf = new BinaryFormatter();
            System.IO.FileStream fs=null;
            try
            {
                if (System.IO.File.Exists(modelfile))
                {
                    fs = new System.IO.FileStream(modelfile, System.IO.FileMode.Open);
                    AllModels = bf.Deserialize(fs) as List<ArtModel>;
                }
                else
                {
                    AllModels.Clear();
                    AllModels.AddRange(vp.GetAllModels());
                    fs = new System.IO.FileStream(modelfile, System.IO.FileMode.Create);
                    bf.Serialize(fs, AllModels);
                }
            }
            finally
            {
                fs.Close();
            }

            ModelViewer mv = new ModelViewer(AllModels);
            mv.ModelList = AllModels;
            mv.Show();
        }

        #region GoTo Buttons
        private void btn_ART_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AllList[currentIndex].Url);
        }

        private void btn_TorrentZ_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://torrentz.eu/search?f=" + this.lbl_title.Text);
        }

        private void btn_Extratorrent_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://extratorrent.cc/search/?search=" + this.lbl_title.Text + "&new=1&x=0&y=0");
        }

        private void btn_GetMagLink_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);

            txt_keyword.Text = lbl_title.Text;
            btn_search_Click(sender, e);
        }
        #endregion

        private void 复制该标题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_title.Text);
        }


        #region Table2
        private void btn_search_Click(object sender, EventArgs e)
        {
            panel_tab2Control.Enabled = false;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        private void btn_pasteAndSearch_Click(object sender, EventArgs e)
        {
            txt_keyword.Text = Clipboard.GetText();
            btn_search_Click(sender, e);
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error!=null)
            {
                listView1.Items.Add(new ListViewItem(e.Error.Message));
                listView1.Items.Add(new ListViewItem("===Error==="));
                panel_tab2Control.Enabled = true;
            }

            var result = e.Result as List<MagnetResult>;
            if (result!=null)
            {
                foreach (var item in result)
                {
                    ListViewItem li = new ListViewItem(item.Title);
                    li.SubItems.Add(item.Size);
                    li.SubItems.Add(item.MagLink);

                    listView1.Items.Add(li);
                }
            }

            listView1.Items.Add(new ListViewItem("====="));
            panel_tab2Control.Enabled = true;

        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            MagnetGet get = new MagnetGet();
            List<MagnetResult> res = new List<MagnetResult>();
            if (rb_katcr.Checked)
            {
                res = get.GetMagLink_Kat_cr(txt_keyword.Text);
            }
            else
            {
                res = get.GetMagLink_Extratorrent_cc(txt_keyword.Text);
            }
            e.Result = res;
        }
        private void 复制磁力链接地址ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count==1)
            {
                Clipboard.SetText(listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text.ToString());
            }
        }

        private void btn_Clear_tab2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        #endregion

        #region DB controls
        private void button1_Click(object sender, EventArgs e)
        {
            DB.DBControl con = new DB.DBControl();
            if (!System.IO.File.Exists(DB.DBConfig.DatabaseFile))
            {
                con.CreateDatabase();
            }

            con.InsertMany(AllList);
            MessageBox.Show("Done!");
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "dat file|*.dat";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ArtMovieSaveLoad.Save(sfd.FileName, this.AllList))
                {
                    MessageBox.Show("Saved!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "dat File|*.dat";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var mvs = ArtMovieSaveLoad.Load(ofd.FileName);
                if (mvs.Count > 0)
                {
                    this.AllList.Clear();
                    this.AllList = mvs;
                }
            }

        }
        #endregion

        private void btn_scraperVideo_Click(object sender, EventArgs e)
        {
            var scraper = (cb_scraper.SelectedItem as IMovieScraper);
            if (!isSelectedScraper(scraper)) return;
            BackgroundWorker MainWorker = WorkerInit();
            Func<int, List<ArtMovie>> fun = new Func<int, List<ArtMovie>>(scraper.GetVideoPage);
            MainWorker.RunWorkerAsync(fun);
        }
        private void btn_scraperAllUpdates_Click(object sender, EventArgs e)
        {
            var scraper = (cb_scraper.SelectedItem as IMovieScraper);
            if (!isSelectedScraper(scraper)) return;
            BackgroundWorker MainWorker = WorkerInit();
            Func<int, List<ArtMovie>> fun = new Func<int, List<ArtMovie>>(scraper.GetAllUpdate);
            MainWorker.RunWorkerAsync(fun);
        }
        private void btn_scraperPicture_Click(object sender, EventArgs e)
        {
            var scraper = (cb_scraper.SelectedItem as IMovieScraper);
            if (!isSelectedScraper(scraper)) return;
            BackgroundWorker MainWorker = WorkerInit();
            Func<int, List<ArtMovie>> fun = new Func<int, List<ArtMovie>>(scraper.GetPicturePage);
            MainWorker.RunWorkerAsync(fun);

        }
        private bool isSelectedScraper(IMovieScraper scraper)
        {
            if (scraper == null)
            {
                MessageBox.Show("Please Select One Scraper First!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private BackgroundWorker WorkerInit()
        {
            BackgroundWorker MainWorker = new BackgroundWorker();
            MainWorker.WorkerReportsProgress = true;
            MainWorker.WorkerSupportsCancellation = true;
            MainWorker.DoWork += MainWorker_DoWork;
            MainWorker.ProgressChanged += MainWorker_ProgressChanged;
            MainWorker.RunWorkerCompleted += MainWorker_RunWorkerCompleted;
            return MainWorker;
        }

        void scraper_CompleteOneItem(object sender, OneCompleteEventArg e)
        {
            var movie = e.Tag as ArtMovie;
            this.AllList.Add(movie);
            if (cb_UpdateOnceDownloadOne.Checked)
            {
                Action<ArtMovie> action = new Action<ArtMovie>(SetShowBox);
                this.Invoke(action, new ArtMovie[] { movie });
            }


        }

        void MainWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error!=null)
            {
                MessageBox.Show(e.Error.Message);
            }

            MessageBox.Show("Done");
        }

        void MainWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        void MainWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var fun = e.Argument as Func<int, List<ArtMovie>>;

            var scraper = fun.Target as IMovieScraper;

            var pageTo = (int)nud_scraper_page.Value;

            scraper.IsDownloadCoverPicture = cb_scraper_pic1.Checked;
            scraper.IsDownloadExtraPicture = cb_scraper_pic2.Checked;

            scraper.CompleteOneItem += scraper_CompleteOneItem;

            for (int i = 1; i <= pageTo; i++)
            {
                fun.Invoke(i);
            }

            ArtMovieSaveLoad.Save(AppDomain.CurrentDomain.BaseDirectory + "\\" + scraper.DisplayName + "_AutoSave" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".dat", AllList);
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            this.AllList.Clear();
        }

    }
}
