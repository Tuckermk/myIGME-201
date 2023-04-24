using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GifFinder
{
    public partial class ImageForm : Form
    {
        string title;
        public ImageForm(GifFinder parent, string url, string title)
        {
            InitializeComponent();
            this.MdiParent = parent;
            this.Text = title;
            this.title = title;

            parent.closeAllToolStripMenuItem.Click += new EventHandler(closeAllToolStripMenuItem_Click);
            parent.saveToolStripMenuItem.Click += new EventHandler(saveToolStripMenuItem_Click);

            this.FormClosing += new FormClosingEventHandler(imageForm_FormClosing);

            pictureBox1.ImageLocation = url;
        }
        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void imageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GifFinder parent = (GifFinder)MdiParent;
            parent.closeAllToolStripMenuItem.Click -= new EventHandler(closeAllToolStripMenuItem_Click);
            parent.saveToolStripMenuItem.Click -= new EventHandler(saveToolStripMenuItem_Click);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this != this.MdiParent.ActiveMdiChild)
            {
                return;
            }
            saveFileDialog1.Filter = "Bmp(*.BMP)|*.BMP|Jpg(*.JPG)|Png(*.PNG)|Gif(*.GIF)|*.GIF";
            saveFileDialog1.FileName = this.title;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(saveFileDialog1.FileName).ToUpper())
                {
                    case ".BMP":
                        pictureBox1.Image.Save(saveFileDialog1.FileName,System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case ".JPG":
                    case ".JPEG":
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case ".PNG":
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case ".GIf":
                        pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
            }
        }
    }
}
