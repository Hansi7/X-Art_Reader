using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace X_Art_View
{

    public partial class ModelViewer : Form
    {
        const int ROWSPAN = 15;
        const int COLUMNSPAN = 10;
        const int STARTPOINTX = 6;
        const int STARTPOINTY = 12;


        public ModelViewer(List<ArtModel> modellist)
        {
            this.ModelList = modellist;
            InitializeComponent();
            refillPictureBox();
            
        }
        public List<ArtModel> ModelList { get; set; }

        int currentIndex = 0;

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (ModelList.Count > 0 && ModelList.Count > currentIndex)
            {
                if (currentIndex + PictureBoxes.Count>ModelList.Count)
                {

                }
                else
                {
                    currentIndex += PictureBoxes.Count;
                    refillPictures();
                }
            }
        }


        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (ModelList.Count > 0 && currentIndex !=0)
            {
                if (currentIndex - PictureBoxes.Count>0)
                {
                    currentIndex -= PictureBoxes.Count;
                }
                else
                {
                    currentIndex = 0;
                }
                refillPictures();
            }
            else
            {
                
            }


        }

        List<PictureBox> PictureBoxes = new List<PictureBox>();

        Size pbSize = new Size(300, 200);

        int c, r;

        private void refillPictureBox()
        {
            PictureBoxes.Clear();

            c = (groupBox1.Size.Width - ROWSPAN) / (pbSize.Width + COLUMNSPAN);
            r = (groupBox1.Size.Height - COLUMNSPAN) / (pbSize.Height + ROWSPAN);

            while (PictureBoxes.Count < c * r)
            {
                PictureBox p = new PictureBox();
                p.Size = pbSize;
                p.Location = getLocation(PictureBoxes.Count);
                p.SizeMode = PictureBoxSizeMode.Zoom;
                p.BorderStyle = BorderStyle.FixedSingle;
                p.MouseEnter += p_MouseEnter;
                p.MouseLeave += p_MouseLeave;
                PictureBoxes.Add(p);
            }
            groupBox1.Controls.Clear();
            groupBox1.Controls.AddRange(PictureBoxes.ToArray());
            refillPictures();
        }

        void p_MouseLeave(object sender, EventArgs e)
        {
            var tip = ((sender as PictureBox).Tag as ToolTip);
            tip.Hide(sender as PictureBox);
        }

        void p_MouseEnter(object sender, EventArgs e)
        {
            var tip = ((sender as PictureBox).Tag as ToolTip);
            tip.Show(tip.Tag.ToString(),sender as PictureBox,1000);
        }

        private void refillPictures()
        {
            for (int i = 0; i < PictureBoxes.Count; i++)
            {
                try
                {
                    PictureBoxes[i].Image = Image.FromFile(ModelList[i + currentIndex].PictureFile);

                }
                catch 
                {
                    PictureBoxes[i].Image = null;
                }
                try
                {
                    PictureBoxes[i].Tag = null;
                    var t = new ToolTip();
                    t.Tag = ModelList[i + currentIndex].ToString();
                    PictureBoxes[i].Tag = t;
                }
                catch 
                {

                    
                }
                
            }
        }

        private Point getLocation(int p)
        {
            int x = COLUMNSPAN + (p % c) * (pbSize.Width + COLUMNSPAN) + STARTPOINTX;
            int y = ROWSPAN + (p / c) * (pbSize.Height + ROWSPAN) + STARTPOINTY;
            return new Point(x, y);
        }

        private void ModelViewer_Resize(object sender, EventArgs e)
        {
            groupBox1.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 80);
            
        }

        private void ModelViewer_ResizeEnd(object sender, EventArgs e)
        {
            groupBox1.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 80);
            refillPictureBox();
        }

        private void ModelViewer_SizeChanged(object sender, EventArgs e)
        {
            groupBox1.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 80);
        }
    }
}
