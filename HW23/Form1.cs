using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hw21
{
    public partial class Form1 : Form
    {
        public Form1(MyEditorParent myEditorParent)
        {
            InitializeComponent();

            this.MdiParent = myEditorParent;



            //this.newToolStripMenuItem.Click += new EventHandler(newToolStripMenuItem_Click);
            myEditorParent.openToolStripMenuItem.Click += new EventHandler(openToolStripMenuItem_Click);
            myEditorParent.saveToolStripMenuItem.Click += new EventHandler(saveToolStripMenuItem_Click);
            //this.exitToolStripMenuItem.Click += new EventHandler(exitToolStripMenuItem_Click);

            myEditorParent.copyToolStripMenuItem.Click += new EventHandler(copyToolStripMenuItem_Click);
            myEditorParent.cutToolStripMenuItem.Click += new EventHandler(cutToolStripMenuItem_Click);
            myEditorParent.pasteToolStripMenuItem.Click += new EventHandler(pasteToolStripMenuItem_Click);

            myEditorParent.closeAllToolStripMenuItem.Click += new EventHandler(closeAllToolStripMenuItem_Click);
            this.toolStrip1.ItemClicked += new ToolStripItemClickedEventHandler(toolStrip1_ItemClicked);


            this.boldToolStripMenuItem.Click += new EventHandler(boldToolStripMenuItem_Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(italicsToolStripMenuItem_Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(underlineToolStripMenuItem_Click);

            this.mSSansSerifToolStripMenuItem.Click += new EventHandler(mSSansSerifToolStripMenuItem_Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(timesNewRomanToolStripMenuItem_Click);

            this.richTextBox.SelectionChanged += new EventHandler(richTextBox_SelectionChanged);

            this.testToolStripButton.Click += new EventHandler(testToolStripButton_Click);
            this.countdownLabel.Visible = false;
            this.timer.Tick += new EventHandler(timer_Tick);

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            this.Text = "MyEditor";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyEditorParent myEditorParent = (MyEditorParent)this.MdiParent;
            myEditorParent.openToolStripMenuItem.Click -= new EventHandler(openToolStripMenuItem_Click);
            myEditorParent.saveToolStripMenuItem.Click -= new EventHandler(saveToolStripMenuItem_Click);

            myEditorParent.copyToolStripMenuItem.Click -= new EventHandler(copyToolStripMenuItem_Click);
            myEditorParent.cutToolStripMenuItem.Click -= new EventHandler(cutToolStripMenuItem_Click);
            myEditorParent.pasteToolStripMenuItem.Click -= new EventHandler(pasteToolStripMenuItem_Click);

            myEditorParent.closeAllToolStripMenuItem.Click -= new EventHandler(closeAllToolStripMenuItem_Click);

        }
        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                if (openFileDialog1.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.LoadFile(openFileDialog1.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + openFileDialog1.FileName + ")";
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;
                if (saveFileDialog1.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.SaveFile(saveFileDialog1.FileName, richTextBoxStreamType);

                this.Text = "MyEditor (" + saveFileDialog1.FileName + ")";
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            richTextBox.Copy();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            richTextBox.Cut();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiParent.ActiveMdiChild != this)
            {
                return;
            }

            richTextBox.Paste();
        }


        private void boldToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Bold);

        }

        private void testToolStripButton_Click(object sender, EventArgs e)
        {
            timer.Interval = 500;
            toolStripProgressBar.Value = 60;
            countdownLabel.Text = "3";
            countdownLabel.Visible = true;
            richTextBox.Visible = false;
            richTextBox.Clear();
            for(int i = 3; i > 0; i--)
            {
                countdownLabel.Text = i.ToString();
                Refresh();
                Thread.Sleep(1000);
            }
            countdownLabel.Visible = false;
            richTextBox.Visible = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar.Value;
            if (this.toolStripProgressBar.Value == 0)
            {
                timer.Stop();
                string performance = "Congratulations! you typed " + Math.Round(this.richTextBox.TextLength / 30.0, 2) + " letters per second";
                MessageBox.Show(performance);
            }
            
        }

        private void italicsToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Italic);

        }

        private void underlineToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Underline);

        }

        private void mSSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("MS Sans Serif", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);
            richTextBox.SelectionFont = newFont;
        }
        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont = new Font("Times New Roman", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);
            richTextBox.SelectionFont = newFont;
        }


        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            if(this.richTextBox.SelectionFont != null)
            {
                this.boldToolStripButton.Checked = richTextBox.SelectionFont.Bold;
                this.italicsToolStripButton.Checked = richTextBox.SelectionFont.Italic;
                this.underlineToolStripButton.Checked = richTextBox.SelectionFont.Underline;
            }
            this.colorToolStripButton.BackColor = richTextBox.SelectionColor;
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;

            ToolStripButton toolStripButton = null;

            if(e.ClickedItem == this.boldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;
            }
            else if (e.ClickedItem == this.italicsToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton;
            }
            else if (e.ClickedItem == this.underlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            }
            else if (e.ClickedItem == this.colorToolStripButton)
            {
                if(colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog1.Color;
                    colorToolStripButton.BackColor = colorDialog1.Color;
                }
            }

            if(fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }
        private void SetSelectionFont( FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;
            selectionFont = richTextBox.SelectionFont;
            if(selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }
            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);

            }
            else
            {
                //underline = 4. Bold = 1, Italic = 2
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }
            this.richTextBox.SelectionFont = newFont;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
