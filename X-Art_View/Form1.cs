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
            vp.IsDownloadCoverPicture = true;
        }

        #region Video
        private void bgw_VideoWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < nud_maxPage.Value + 1; i++)
            {
                AllList.AddRange(vp.GetVideoPage(i));
                bgw_VideoWorker.ReportProgress((int)(100 * i / (double)nud_maxPage.Value), i.ToString() + "/" + nud_maxPage.Value.ToString());
            }
        }

        private void bgw_VideoWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.lbl_prograss.Text = e.UserState as string;
        }

        private void bgw_VideoWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\VideoUpdates_AutoSave" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".dat", System.IO.FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, AllList);
            fs.Close();
            MessageBox.Show("Work is Done & Auto Saved!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Video_Click(object sender, EventArgs e)
        {
            AllList.Clear();
            bgw_VideoWorker.RunWorkerAsync();
        } 
        #endregion


        List<ArtMovie> AllList = new List<ArtMovie>();
        List<ArtModel> AllModels = new List<ArtModel>();

        ArtPage vp = new ArtPage();

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "dat file|*.dat";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.FileStream fs = new System.IO.FileStream(sfd.FileName, System.IO.FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, AllList);
                fs.Close();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < AllList.Count; i++)
                {
                    sb.AppendLine(AllList[i].ToString());
                }
                System.IO.File.WriteAllText(System.IO.Path.ChangeExtension(sfd.FileName, "txt"), sb.ToString());

                MessageBox.Show("Saved!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "dat File|*.dat";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AllList.Clear();
                using (System.IO.FileStream fs = new System.IO.FileStream(ofd.FileName, System.IO.FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    this.AllList = bf.Deserialize(fs) as List<ArtMovie>;
                    MessageBox.Show("Loaded!");
                }
                
            }
            
        }

        #region UI Control

        int currentIndex = -1;

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (AllList.Count > 0 && AllList.Count > currentIndex + 1)
            {
                currentIndex += 1;
                SetShowBox();
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (AllList.Count > 0 && currentIndex > 0)
            {
                currentIndex += -1;
                SetShowBox();
            }

        }

        private void SetShowBox()
        {
            try
            {
                this.trackBar1.Maximum = AllList.Count;
                this.trackBar1.Minimum = 1;
                this.trackBar1.Value = currentIndex + 1;
                this.lbl_ViewProgress.Text = (currentIndex + 1) + "/" + AllList.Count;
                var m = this.AllList[currentIndex];
                
                this.lbl_desc.Text = m.Description;
                this.lbl_title.Text = m.Title;
                this.lbl_type.Text = m.Type;
                this.pictureBox1.Image = Image.FromFile(m.CoverFile);
                this.pictureBox1.Tag = m.CoverFile;
            }
            catch (Exception)
            {

            }
        }

        int togleNumber = 1;

        private void btn_hideAndShow_Click(object sender, EventArgs e)
        {
            if (togleNumber++ % 2 == 0)
            {
                this.Size = new Size(this.Size.Width, 620);
            }
            else
            {
                this.Size = new Size(this.Size.Width, 137);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.currentIndex = trackBar1.Value - 1;
            SetShowBox();
        }

        #endregion



        #region AllUpdates
        private void bgw_AllUpdatesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < nud_maxPage.Value + 1; i++)
            {

                AllList.AddRange(vp.GetAllUpdatePage(i));
                bgw_AllUpdatesWorker.ReportProgress((int)(100 * i / (double)nud_maxPage.Value), i.ToString() + "/" + nud_maxPage.Value.ToString());
            }
        }

        private void bgw_AllUpdatesWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.lbl_prograss.Text = e.UserState as string;
        }

        private void bgw_AllUpdatesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\AllUpdates_AutoSave" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".dat", System.IO.FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, AllList);
            fs.Close();
            MessageBox.Show("Work is Done & Auto Saved!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_AllUpdates_Click(object sender, EventArgs e)
        {
            AllList.Clear();
            bgw_AllUpdatesWorker.RunWorkerAsync();
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


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            DB.DBControl con = new DB.DBControl();
            foreach (ArtMovie item in AllList)
            {
                con.Insert(item);
            }
            MessageBox.Show("Test");
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

        private void 复制该标题ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_title.Text);
        }
    }
}
