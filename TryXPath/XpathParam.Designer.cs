namespace TryXPath
{
    partial class XpathParam
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_xpath = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.lbl_mutiResult = new System.Windows.Forms.Label();
            this.btn_SViewer = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.innerTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attribhrefValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attribsrcValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_endFix = new System.Windows.Forms.Label();
            this.nullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_xpath
            // 
            this.txt_xpath.Location = new System.Drawing.Point(121, 6);
            this.txt_xpath.Name = "txt_xpath";
            this.txt_xpath.Size = new System.Drawing.Size(222, 21);
            this.txt_xpath.TabIndex = 0;
            this.txt_xpath.Text = ".";
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(349, 4);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // lbl_mutiResult
            // 
            this.lbl_mutiResult.AutoSize = true;
            this.lbl_mutiResult.Location = new System.Drawing.Point(430, 9);
            this.lbl_mutiResult.Name = "lbl_mutiResult";
            this.lbl_mutiResult.Size = new System.Drawing.Size(11, 12);
            this.lbl_mutiResult.TabIndex = 3;
            this.lbl_mutiResult.Text = "-";
            // 
            // btn_SViewer
            // 
            this.btn_SViewer.Location = new System.Drawing.Point(74, 4);
            this.btn_SViewer.Name = "btn_SViewer";
            this.btn_SViewer.Size = new System.Drawing.Size(41, 23);
            this.btn_SViewer.TabIndex = 4;
            this.btn_SViewer.Text = "S";
            this.btn_SViewer.UseVisualStyleBackColor = true;
            this.btn_SViewer.Click += new System.EventHandler(this.btn_SViewer_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(3, 6);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(65, 21);
            this.txt_Name.TabIndex = 5;
            this.txt_Name.Text = "Selector";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.innerTextToolStripMenuItem,
            this.attribhrefValueToolStripMenuItem,
            this.attribsrcValueToolStripMenuItem,
            this.nullToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 114);
            // 
            // innerTextToolStripMenuItem
            // 
            this.innerTextToolStripMenuItem.Name = "innerTextToolStripMenuItem";
            this.innerTextToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.innerTextToolStripMenuItem.Text = "InnerText";
            this.innerTextToolStripMenuItem.Click += new System.EventHandler(this.innerTextToolStripMenuItem_Click);
            // 
            // attribhrefValueToolStripMenuItem
            // 
            this.attribhrefValueToolStripMenuItem.Name = "attribhrefValueToolStripMenuItem";
            this.attribhrefValueToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.attribhrefValueToolStripMenuItem.Text = "Attrib[href].Value";
            this.attribhrefValueToolStripMenuItem.Click += new System.EventHandler(this.attribhrefValueToolStripMenuItem_Click);
            // 
            // attribsrcValueToolStripMenuItem
            // 
            this.attribsrcValueToolStripMenuItem.Name = "attribsrcValueToolStripMenuItem";
            this.attribsrcValueToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.attribsrcValueToolStripMenuItem.Text = "Attrib[src].Value";
            this.attribsrcValueToolStripMenuItem.Click += new System.EventHandler(this.attribsrcValueToolStripMenuItem_Click);
            // 
            // lbl_endFix
            // 
            this.lbl_endFix.AutoSize = true;
            this.lbl_endFix.Location = new System.Drawing.Point(447, 9);
            this.lbl_endFix.Name = "lbl_endFix";
            this.lbl_endFix.Size = new System.Drawing.Size(11, 12);
            this.lbl_endFix.TabIndex = 7;
            this.lbl_endFix.Text = "-";
            // 
            // nullToolStripMenuItem
            // 
            this.nullToolStripMenuItem.Name = "nullToolStripMenuItem";
            this.nullToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nullToolStripMenuItem.Text = "Null";
            this.nullToolStripMenuItem.Click += new System.EventHandler(this.nullToolStripMenuItem_Click);
            // 
            // XpathParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lbl_endFix);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_SViewer);
            this.Controls.Add(this.lbl_mutiResult);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.txt_xpath);
            this.Name = "XpathParam";
            this.Size = new System.Drawing.Size(608, 27);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_xpath;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label lbl_mutiResult;
        private System.Windows.Forms.Button btn_SViewer;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem innerTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attribhrefValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attribsrcValueToolStripMenuItem;
        public System.Windows.Forms.Label lbl_endFix;
        private System.Windows.Forms.ToolStripMenuItem nullToolStripMenuItem;
    }
}
