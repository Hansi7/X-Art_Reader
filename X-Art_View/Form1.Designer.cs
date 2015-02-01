namespace X_Art_View
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Video = new System.Windows.Forms.Button();
            this.bgw_VideoWorker = new System.ComponentModel.BackgroundWorker();
            this.nud_maxPage = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_prograss = new System.Windows.Forms.Label();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.btn_Extratorrent = new System.Windows.Forms.Button();
            this.btn_TorrentZ = new System.Windows.Forms.Button();
            this.btn_ART = new System.Windows.Forms.Button();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_hideAndShow = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_ViewProgress = new System.Windows.Forms.Label();
            this.btn_AllUpdates = new System.Windows.Forms.Button();
            this.bgw_AllUpdatesWorker = new System.ComponentModel.BackgroundWorker();
            this.btn_model = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxPage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Video
            // 
            this.btn_Video.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Video.Location = new System.Drawing.Point(53, 12);
            this.btn_Video.Name = "btn_Video";
            this.btn_Video.Size = new System.Drawing.Size(75, 23);
            this.btn_Video.TabIndex = 0;
            this.btn_Video.Text = "Videos";
            this.btn_Video.UseVisualStyleBackColor = true;
            this.btn_Video.Click += new System.EventHandler(this.btn_Video_Click);
            // 
            // bgw_VideoWorker
            // 
            this.bgw_VideoWorker.WorkerReportsProgress = true;
            this.bgw_VideoWorker.WorkerSupportsCancellation = true;
            this.bgw_VideoWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_VideoWorker_DoWork);
            this.bgw_VideoWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_VideoWorker_ProgressChanged);
            this.bgw_VideoWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_VideoWorker_RunWorkerCompleted);
            // 
            // nud_maxPage
            // 
            this.nud_maxPage.Location = new System.Drawing.Point(12, 12);
            this.nud_maxPage.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_maxPage.Name = "nud_maxPage";
            this.nud_maxPage.Size = new System.Drawing.Size(35, 21);
            this.nud_maxPage.TabIndex = 1;
            this.nud_maxPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 39);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // lbl_prograss
            // 
            this.lbl_prograss.AutoSize = true;
            this.lbl_prograss.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_prograss.Location = new System.Drawing.Point(354, 42);
            this.lbl_prograss.Name = "lbl_prograss";
            this.lbl_prograss.Size = new System.Drawing.Size(43, 17);
            this.lbl_prograss.TabIndex = 3;
            this.lbl_prograss.Text = "label1";
            // 
            // btn_Previous
            // 
            this.btn_Previous.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Previous.Location = new System.Drawing.Point(12, 68);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(75, 23);
            this.btn_Previous.TabIndex = 4;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Next.Location = new System.Drawing.Point(93, 68);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_type);
            this.groupBox1.Controls.Add(this.btn_Extratorrent);
            this.groupBox1.Controls.Add(this.btn_TorrentZ);
            this.groupBox1.Controls.Add(this.btn_ART);
            this.groupBox1.Controls.Add(this.lbl_desc);
            this.groupBox1.Controls.Add(this.lbl_title);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 473);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(343, 48);
            this.lbl_type.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(36, 17);
            this.lbl_type.TabIndex = 11;
            this.lbl_type.Text = "Type";
            // 
            // btn_Extratorrent
            // 
            this.btn_Extratorrent.Location = new System.Drawing.Point(343, 437);
            this.btn_Extratorrent.Name = "btn_Extratorrent";
            this.btn_Extratorrent.Size = new System.Drawing.Size(244, 23);
            this.btn_Extratorrent.TabIndex = 10;
            this.btn_Extratorrent.Text = "ExtraTorrent";
            this.btn_Extratorrent.UseVisualStyleBackColor = true;
            this.btn_Extratorrent.Click += new System.EventHandler(this.btn_Extratorrent_Click);
            // 
            // btn_TorrentZ
            // 
            this.btn_TorrentZ.Location = new System.Drawing.Point(343, 408);
            this.btn_TorrentZ.Name = "btn_TorrentZ";
            this.btn_TorrentZ.Size = new System.Drawing.Size(244, 23);
            this.btn_TorrentZ.TabIndex = 9;
            this.btn_TorrentZ.Text = "TorrentZ";
            this.btn_TorrentZ.UseVisualStyleBackColor = true;
            this.btn_TorrentZ.Click += new System.EventHandler(this.btn_TorrentZ_Click);
            // 
            // btn_ART
            // 
            this.btn_ART.Location = new System.Drawing.Point(343, 379);
            this.btn_ART.Name = "btn_ART";
            this.btn_ART.Size = new System.Drawing.Size(244, 23);
            this.btn_ART.TabIndex = 7;
            this.btn_ART.Text = "X-Art";
            this.btn_ART.UseVisualStyleBackColor = true;
            this.btn_ART.Click += new System.EventHandler(this.btn_ART_Click);
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(342, 79);
            this.lbl_desc.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(36, 17);
            this.lbl_desc.TabIndex = 8;
            this.lbl_desc.Text = "Desc";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(343, 20);
            this.lbl_title.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(32, 17);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 440);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.Location = new System.Drawing.Point(530, 8);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Load.Location = new System.Drawing.Point(530, 36);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 8;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_hideAndShow
            // 
            this.btn_hideAndShow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_hideAndShow.Location = new System.Drawing.Point(530, 65);
            this.btn_hideAndShow.Name = "btn_hideAndShow";
            this.btn_hideAndShow.Size = new System.Drawing.Size(75, 23);
            this.btn_hideAndShow.TabIndex = 9;
            this.btn_hideAndShow.Text = "H/S";
            this.btn_hideAndShow.UseVisualStyleBackColor = true;
            this.btn_hideAndShow.Click += new System.EventHandler(this.btn_hideAndShow_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar1.Location = new System.Drawing.Point(174, 68);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(175, 31);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lbl_ViewProgress
            // 
            this.lbl_ViewProgress.AutoSize = true;
            this.lbl_ViewProgress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ViewProgress.Location = new System.Drawing.Point(355, 74);
            this.lbl_ViewProgress.Name = "lbl_ViewProgress";
            this.lbl_ViewProgress.Size = new System.Drawing.Size(27, 17);
            this.lbl_ViewProgress.TabIndex = 11;
            this.lbl_ViewProgress.Text = "1/1";
            // 
            // btn_AllUpdates
            // 
            this.btn_AllUpdates.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AllUpdates.Location = new System.Drawing.Point(134, 12);
            this.btn_AllUpdates.Name = "btn_AllUpdates";
            this.btn_AllUpdates.Size = new System.Drawing.Size(93, 23);
            this.btn_AllUpdates.TabIndex = 12;
            this.btn_AllUpdates.Text = "AllUpdates";
            this.btn_AllUpdates.UseVisualStyleBackColor = true;
            this.btn_AllUpdates.Click += new System.EventHandler(this.btn_AllUpdates_Click);
            // 
            // bgw_AllUpdatesWorker
            // 
            this.bgw_AllUpdatesWorker.WorkerReportsProgress = true;
            this.bgw_AllUpdatesWorker.WorkerSupportsCancellation = true;
            this.bgw_AllUpdatesWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_AllUpdatesWorker_DoWork);
            this.bgw_AllUpdatesWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_AllUpdatesWorker_ProgressChanged);
            this.bgw_AllUpdatesWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_AllUpdatesWorker_RunWorkerCompleted);
            // 
            // btn_model
            // 
            this.btn_model.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_model.Location = new System.Drawing.Point(233, 12);
            this.btn_model.Name = "btn_model";
            this.btn_model.Size = new System.Drawing.Size(93, 23);
            this.btn_model.TabIndex = 13;
            this.btn_model.Text = "Models";
            this.btn_model.UseVisualStyleBackColor = true;
            this.btn_model.Click += new System.EventHandler(this.btn_model_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 581);
            this.Controls.Add(this.btn_model);
            this.Controls.Add(this.btn_AllUpdates);
            this.Controls.Add(this.lbl_ViewProgress);
            this.Controls.Add(this.btn_hideAndShow);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.lbl_prograss);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.nud_maxPage);
            this.Controls.Add(this.btn_Video);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxPage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Video;
        private System.ComponentModel.BackgroundWorker bgw_VideoWorker;
        private System.Windows.Forms.NumericUpDown nud_maxPage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_prograss;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Button btn_TorrentZ;
        private System.Windows.Forms.Button btn_ART;
        private System.Windows.Forms.Button btn_Extratorrent;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_hideAndShow;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_ViewProgress;
        private System.Windows.Forms.Button btn_AllUpdates;
        private System.ComponentModel.BackgroundWorker bgw_AllUpdatesWorker;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Button btn_model;
    }
}

