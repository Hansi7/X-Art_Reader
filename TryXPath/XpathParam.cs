using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TryXPath
{
    public partial class XpathParam : UserControl
    {
        public XpathParam()
        {
            InitializeComponent();
        }

        private String _html="";

        public String SelectorHtml
        {
            get { return _html; }
            set { _html = value; }
        }

        private string _output="";

        public string SelectorOutput
        {
            get { return _output; }
            set { _output = value; }
        }

        public string SelectorName
        {
            get { return txt_Name.Text.Trim(); }
            set { this.txt_Name.Text = value; }
        }

        public string SelectorXPath
        {
            get
            {
                return this.txt_xpath.Text;
            }
        }

        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (txt_xpath.Text.Trim()==string.Empty)
            {
                return;
            }
            try
            {

                doc.LoadHtml(_html);
                var nodes = doc.DocumentNode.SelectNodes(txt_xpath.Text);
                

                if (nodes == null)
                {
                    this.lbl_mutiResult.Text = "N";
                    this._output = "";
                }
                else
                {
                    if (nodes.Count == 1)
                    {
                        this.lbl_mutiResult.Text = "S";
                    }
                    else
                    {
                        this.lbl_mutiResult.Text = "M";
                    }
                    this._output = nodes[0].OuterHtml;
                }
                OnApplied();
                var t = new TextViewer();
                t.colorTextBox1.Text = _output;
                t.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"错误", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        
        private void btn_SViewer_Click(object sender, EventArgs e)
        {
            var t = new TextViewer();
            t.colorTextBox1.Text = _html;
            t.Show();
        }

        public event EventHandler Applied;

        protected virtual void OnApplied()
        {
            if (this.Applied!=null)
            {
                this.Applied(this, new EventArgs());
            }
        }

        private void innerTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lbl_endFix.Text = ".InnerText.Trim()";
        }

        private void attribhrefValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lbl_endFix.Text = ".Attributes[\"href\"].Value.ToString().Trim()";
        }

        private void attribsrcValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lbl_endFix.Text = ".Attributes[\"src\"].Value.ToString().Trim()";
        }

        private void nullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lbl_endFix.Text = "";
        }


    }
}
