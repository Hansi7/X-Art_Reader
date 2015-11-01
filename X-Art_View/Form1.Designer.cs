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
            this.components = new System.ComponentModel.Container();
            this.btn_Video = new System.Windows.Forms.Button();
            this.bgw_VideoWorker = new System.ComponentModel.BackgroundWorker();
            this.nud_maxPage = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_prograss = new System.Windows.Forms.Label();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制该标题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_GetMagLink = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_keyword = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_pasteAndSearch = new System.Windows.Forms.Button();
            this.rb_katcr = new System.Windows.Forms.RadioButton();
            this.rb_extratorrent = new System.Windows.Forms.RadioButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_tab2Control = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制磁力链接地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Clear_tab2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxPage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel_tab2Control.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Video
            // 
            this.btn_Video.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Video.Location = new System.Drawing.Point(70, 4);
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
            this.nud_maxPage.Location = new System.Drawing.Point(6, 6);
            this.nud_maxPage.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_maxPage.Name = "nud_maxPage";
            this.nud_maxPage.Size = new System.Drawing.Size(58, 21);
            this.nud_maxPage.TabIndex = 1;
            this.nud_maxPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 33);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // lbl_prograss
            // 
            this.lbl_prograss.AutoSize = true;
            this.lbl_prograss.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_prograss.Location = new System.Drawing.Point(348, 36);
            this.lbl_prograss.Name = "lbl_prograss";
            this.lbl_prograss.Size = new System.Drawing.Size(43, 17);
            this.lbl_prograss.TabIndex = 3;
            this.lbl_prograss.Text = "label1";
            // 
            // btn_Previous
            // 
            this.btn_Previous.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Previous.Location = new System.Drawing.Point(6, 62);
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
            this.btn_Next.Location = new System.Drawing.Point(87, 62);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.groupBox1.Controls.Add(this.lbl_type);
            this.groupBox1.Controls.Add(this.btn_GetMagLink);
            this.groupBox1.Controls.Add(this.btn_Extratorrent);
            this.groupBox1.Controls.Add(this.btn_TorrentZ);
            this.groupBox1.Controls.Add(this.btn_ART);
            this.groupBox1.Controls.Add(this.lbl_desc);
            this.groupBox1.Controls.Add(this.lbl_title);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 473);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制该标题ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // 复制该标题ToolStripMenuItem
            // 
            this.复制该标题ToolStripMenuItem.Name = "复制该标题ToolStripMenuItem";
            this.复制该标题ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.复制该标题ToolStripMenuItem.Text = "复制该标题";
            this.复制该标题ToolStripMenuItem.Click += new System.EventHandler(this.复制该标题ToolStripMenuItem_Click);
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
            this.btn_Extratorrent.Location = new System.Drawing.Point(346, 437);
            this.btn_Extratorrent.Name = "btn_Extratorrent";
            this.btn_Extratorrent.Size = new System.Drawing.Size(241, 26);
            this.btn_Extratorrent.TabIndex = 10;
            this.btn_Extratorrent.Text = "ExtraTorrent";
            this.btn_Extratorrent.UseVisualStyleBackColor = true;
            this.btn_Extratorrent.Click += new System.EventHandler(this.btn_Extratorrent_Click);
            // 
            // btn_TorrentZ
            // 
            this.btn_TorrentZ.Location = new System.Drawing.Point(346, 407);
            this.btn_TorrentZ.Name = "btn_TorrentZ";
            this.btn_TorrentZ.Size = new System.Drawing.Size(241, 26);
            this.btn_TorrentZ.TabIndex = 9;
            this.btn_TorrentZ.Text = "TorrentZ";
            this.btn_TorrentZ.UseVisualStyleBackColor = true;
            this.btn_TorrentZ.Click += new System.EventHandler(this.btn_TorrentZ_Click);
            // 
            // btn_ART
            // 
            this.btn_ART.Location = new System.Drawing.Point(346, 377);
            this.btn_ART.Name = "btn_ART";
            this.btn_ART.Size = new System.Drawing.Size(241, 26);
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
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.Location = new System.Drawing.Point(524, 2);
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
            this.btn_Load.Location = new System.Drawing.Point(524, 30);
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
            this.btn_hideAndShow.Location = new System.Drawing.Point(524, 59);
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
            this.trackBar1.Location = new System.Drawing.Point(168, 62);
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
            this.lbl_ViewProgress.Location = new System.Drawing.Point(349, 68);
            this.lbl_ViewProgress.Name = "lbl_ViewProgress";
            this.lbl_ViewProgress.Size = new System.Drawing.Size(27, 17);
            this.lbl_ViewProgress.TabIndex = 11;
            this.lbl_ViewProgress.Text = "1/1";
            // 
            // btn_AllUpdates
            // 
            this.btn_AllUpdates.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AllUpdates.Location = new System.Drawing.Point(151, 4);
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
            this.btn_model.Location = new System.Drawing.Point(250, 4);
            this.btn_model.Name = "btn_model";
            this.btn_model.Size = new System.Drawing.Size(93, 23);
            this.btn_model.TabIndex = 13;
            this.btn_model.Text = "Models";
            this.btn_model.UseVisualStyleBackColor = true;
            this.btn_model.Click += new System.EventHandler(this.btn_model_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(405, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "BuildDB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_GetMagLink
            // 
            this.btn_GetMagLink.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_GetMagLink.Location = new System.Drawing.Point(346, 347);
            this.btn_GetMagLink.Name = "btn_GetMagLink";
            this.btn_GetMagLink.Size = new System.Drawing.Size(241, 26);
            this.btn_GetMagLink.TabIndex = 15;
            this.btn_GetMagLink.Text = "GetMagLink";
            this.btn_GetMagLink.UseVisualStyleBackColor = true;
            this.btn_GetMagLink.Click += new System.EventHandler(this.btn_GetMagLink_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 609);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nud_maxPage);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.btn_Video);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.btn_model);
            this.tabPage1.Controls.Add(this.lbl_prograss);
            this.tabPage1.Controls.Add(this.btn_AllUpdates);
            this.tabPage1.Controls.Add(this.btn_Previous);
            this.tabPage1.Controls.Add(this.lbl_ViewProgress);
            this.tabPage1.Controls.Add(this.btn_Next);
            this.tabPage1.Controls.Add(this.btn_hideAndShow);
            this.tabPage1.Controls.Add(this.btn_Save);
            this.tabPage1.Controls.Add(this.btn_Load);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "X-Art Reader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_tab2Control);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GetMagnetLink";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_keyword
            // 
            this.txt_keyword.Location = new System.Drawing.Point(3, 3);
            this.txt_keyword.Name = "txt_keyword";
            this.txt_keyword.Size = new System.Drawing.Size(100, 21);
            this.txt_keyword.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip2;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(6, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(683, 537);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(109, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_pasteAndSearch
            // 
            this.btn_pasteAndSearch.Location = new System.Drawing.Point(190, 2);
            this.btn_pasteAndSearch.Name = "btn_pasteAndSearch";
            this.btn_pasteAndSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_pasteAndSearch.TabIndex = 3;
            this.btn_pasteAndSearch.Text = "paste";
            this.btn_pasteAndSearch.UseVisualStyleBackColor = true;
            this.btn_pasteAndSearch.Click += new System.EventHandler(this.btn_pasteAndSearch_Click);
            // 
            // rb_katcr
            // 
            this.rb_katcr.AutoSize = true;
            this.rb_katcr.Checked = true;
            this.rb_katcr.Location = new System.Drawing.Point(469, 4);
            this.rb_katcr.Name = "rb_katcr";
            this.rb_katcr.Size = new System.Drawing.Size(59, 16);
            this.rb_katcr.TabIndex = 4;
            this.rb_katcr.TabStop = true;
            this.rb_katcr.Text = "kat.cr";
            this.rb_katcr.UseVisualStyleBackColor = true;
            // 
            // rb_extratorrent
            // 
            this.rb_extratorrent.AutoSize = true;
            this.rb_extratorrent.Location = new System.Drawing.Point(534, 4);
            this.rb_extratorrent.Name = "rb_extratorrent";
            this.rb_extratorrent.Size = new System.Drawing.Size(113, 16);
            this.rb_extratorrent.TabIndex = 5;
            this.rb_extratorrent.Text = "extratorrent.cc";
            this.rb_extratorrent.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 418;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MagnetLink";
            this.columnHeader3.Width = 148;
            // 
            // panel_tab2Control
            // 
            this.panel_tab2Control.Controls.Add(this.btn_Clear_tab2);
            this.panel_tab2Control.Controls.Add(this.txt_keyword);
            this.panel_tab2Control.Controls.Add(this.rb_extratorrent);
            this.panel_tab2Control.Controls.Add(this.btn_search);
            this.panel_tab2Control.Controls.Add(this.rb_katcr);
            this.panel_tab2Control.Controls.Add(this.btn_pasteAndSearch);
            this.panel_tab2Control.Location = new System.Drawing.Point(6, 6);
            this.panel_tab2Control.Name = "panel_tab2Control";
            this.panel_tab2Control.Size = new System.Drawing.Size(650, 28);
            this.panel_tab2Control.TabIndex = 6;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制磁力链接地址ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(173, 26);
            // 
            // 复制磁力链接地址ToolStripMenuItem
            // 
            this.复制磁力链接地址ToolStripMenuItem.Name = "复制磁力链接地址ToolStripMenuItem";
            this.复制磁力链接地址ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.复制磁力链接地址ToolStripMenuItem.Text = "复制磁力链接地址";
            this.复制磁力链接地址ToolStripMenuItem.Click += new System.EventHandler(this.复制磁力链接地址ToolStripMenuItem_Click);
            // 
            // btn_Clear_tab2
            // 
            this.btn_Clear_tab2.Location = new System.Drawing.Point(271, 1);
            this.btn_Clear_tab2.Name = "btn_Clear_tab2";
            this.btn_Clear_tab2.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear_tab2.TabIndex = 6;
            this.btn_Clear_tab2.Text = "Clear";
            this.btn_Clear_tab2.UseVisualStyleBackColor = true;
            this.btn_Clear_tab2.Click += new System.EventHandler(this.btn_Clear_tab2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 629);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxPage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel_tab2Control.ResumeLayout(false);
            this.panel_tab2Control.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制该标题ToolStripMenuItem;
        private System.Windows.Forms.Button btn_GetMagLink;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_pasteAndSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txt_keyword;
        private System.Windows.Forms.RadioButton rb_extratorrent;
        private System.Windows.Forms.RadioButton rb_katcr;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel_tab2Control;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 复制磁力链接地址ToolStripMenuItem;
        private System.Windows.Forms.Button btn_Clear_tab2;
    }
}

