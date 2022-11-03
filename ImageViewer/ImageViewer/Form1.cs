using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        Image img;
        public Form1()
        {
            InitializeComponent();
            img = pictureBox1.Image;
            scrollBar.Minimum = 500;
            scrollBar.Maximum = 2000;
            pictureBox1.Left = (ClientSize.Width - pictureBox1.Width)/2;
            pictureBox1.Top = (ClientSize.Height - pictureBox1.Height)/2;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            pictureBox1.Image = Image.FromFile(ofd.FileName);
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = pictureBox1.Image;

        }

        private void btnRotate1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
            pictureBox1.Image=pictureBox1.Image;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = img;
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            pictureBox1.Width += Width + 1/2;
            pictureBox1.Height += Height + 1/2;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            pictureBox1.Width -= Width - 1/2;
            pictureBox1.Height -= Height - 1/2;
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Size = new Size(scrollBar.Value, pictureBox1.Size.Height);
            pictureBox1.Left = (ClientSize.Width - pictureBox1.Width) / 2;
            pictureBox1.Top = (ClientSize.Height - pictureBox1.Height) / 2;
        }
    }
}

