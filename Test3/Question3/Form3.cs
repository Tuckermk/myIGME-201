using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3
{
    public partial class Form3 : Form
    {

        Form form = new Form1();
        public Form3()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Enabled = true;
            button1.Click += new EventHandler(button1_Click);
            dateTimePicker1.Value = DateTime.Now;
            //exitButton.Click += new EventHandler(exitButton_Click);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Parse("2/2/2022");
            if (dateTimePicker1.Value == dateTime)
            {
                timer.Enabled = false;
                form.Text = "Section of the way there";
                this.Hide();
                form.ShowDialog();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Parse("2/2/2022");
            if (dateTimePicker1.Value == dateTime)
            {
                timer.Enabled = false;

                
                this.Hide();
                form.Text = "Section of the way there";
                form.ShowDialog();
                
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == 0) {

                form.Text = "its 2sday whats so hard";
                this.Hide();
                form.ShowDialog();
            }
            else { progressBar.Value -= 1; }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
