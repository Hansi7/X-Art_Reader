using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TryXPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            xParam_Section.Applied += xParam_Section_Applied;
            xParam_Section.SelectorName = "nodes";
        }

        void xParam_Section_Applied(object sender, EventArgs e)
        {
            init();
        }

        System.Net.WebClient wc = new System.Net.WebClient();

        string html = "";

        private void button1_Click(object sender, EventArgs e)
        {
            //html =  this.wc.DownloadString(txt_URL.Text);

            var bytesData = this.wc.DownloadData(txt_URL.Text);

            html = Encoding.UTF8.GetString(bytesData);


            xParam_Section.SelectorHtml = html;
            txt_source.Text = html;
            MessageBox.Show("LOADED!");
        }

        void init()
        {
            x1.SelectorHtml = xParam_Section.SelectorOutput;
            x2.SelectorHtml = xParam_Section.SelectorOutput;
            x3.SelectorHtml = xParam_Section.SelectorOutput;
            x4.SelectorHtml = xParam_Section.SelectorOutput;
            x5.SelectorHtml = xParam_Section.SelectorOutput;
            x6.SelectorHtml = xParam_Section.SelectorOutput;
            x7.SelectorHtml = xParam_Section.SelectorOutput;
            x8.SelectorHtml = xParam_Section.SelectorOutput;
            x9.SelectorHtml = xParam_Section.SelectorOutput;
            x10.SelectorHtml = xParam_Section.SelectorOutput;
            x11.SelectorHtml = xParam_Section.SelectorOutput;
            x12.SelectorHtml = xParam_Section.SelectorOutput;
            x13.SelectorHtml = xParam_Section.SelectorOutput;
            x14.SelectorHtml = xParam_Section.SelectorOutput;
        }

        private void btn_fromText_Click(object sender, EventArgs e)
        {
            html = txt_source.Text;
            xParam_Section.SelectorHtml = html;
            MessageBox.Show("LOADED!");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("lastParse.txt", txt_source.Text);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("var " + xParam_Section.SelectorName + "=doc.DocumentNode.SelectNodes(\"" + xParam_Section.SelectorXPath + "\")"+ xParam_Section.lbl_endFix.Text +";");

            for (int i = 1; i < 15; i++)
            {
                var x = Controls.Find("x" + i, true)[0] as XpathParam;
                
                sb.AppendLine("var " + x.SelectorName + "=" + "item" + ".SelectSingleNode(\"" + x.SelectorXPath + "\")"+ x.lbl_endFix.Text +";");
            }

            TextViewer t = new TextViewer();
            t.colorTextBox1.Text = sb.ToString();
            t.ShowDialog();

            System.IO.File.WriteAllText("lastCodes.txt", sb.ToString());
        }
    }
}
