namespace TryXPath
{
    partial class TextViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorTextBox1 = new TryXPath.ColorTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.colorTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // colorTextBox1
            // 
            this.colorTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.colorTextBox1.AutoIndentCharsPatterns = "";
            this.colorTextBox1.AutoScrollMinSize = new System.Drawing.Size(131, 14);
            this.colorTextBox1.BackBrush = null;
            this.colorTextBox1.CharHeight = 14;
            this.colorTextBox1.CharWidth = 8;
            this.colorTextBox1.CommentPrefix = null;
            this.colorTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.colorTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.colorTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorTextBox1.IsReplaceMode = false;
            this.colorTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
            this.colorTextBox1.LeftBracket = '<';
            this.colorTextBox1.LeftBracket2 = '(';
            this.colorTextBox1.Location = new System.Drawing.Point(0, 0);
            this.colorTextBox1.Name = "colorTextBox1";
            this.colorTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.colorTextBox1.RightBracket = '>';
            this.colorTextBox1.RightBracket2 = ')';
            this.colorTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.colorTextBox1.Size = new System.Drawing.Size(784, 561);
            this.colorTextBox1.TabIndex = 0;
            this.colorTextBox1.Text = "colorTextBox1";
            this.colorTextBox1.Zoom = 100;
            // 
            // TextViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.colorTextBox1);
            this.Name = "TextViewer";
            this.Text = "TextViewer";
            ((System.ComponentModel.ISupportInitialize)(this.colorTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal ColorTextBox colorTextBox1;



    }
}