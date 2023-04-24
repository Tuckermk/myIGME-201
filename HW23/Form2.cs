using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw21
{
    public partial class MyEditorParent : Form
    {
        public MyEditorParent()
        {
            InitializeComponent();

            this.newToolStripMenuItem.Click += new EventHandler(newToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new EventHandler(exitToolStripMenuItem_Click);
            this.tileToolStripMenuItem.Click += new EventHandler(tileToolStripMenuItem_Click);
            this.cascadeToolStripMenuItem.Click += new EventHandler(cascadeToolStripMenuItem_Click);

            Form1 form1 = new Form1(this);
            form1.Show();
        }


        private void tileToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void cascadeToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void newToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
        }
        private void exitToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
