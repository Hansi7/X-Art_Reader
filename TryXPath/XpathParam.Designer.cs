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
            this.txt_xpath = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.lbl_mutiResult = new System.Windows.Forms.Label();
            this.btn_SViewer = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
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
            // XpathParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_SViewer);
            this.Controls.Add(this.lbl_mutiResult);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.txt_xpath);
            this.Name = "XpathParam";
            this.Size = new System.Drawing.Size(608, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_xpath;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label lbl_mutiResult;
        private System.Windows.Forms.Button btn_SViewer;
        private System.Windows.Forms.TextBox txt_Name;
    }
}
