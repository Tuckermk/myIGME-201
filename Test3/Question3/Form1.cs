using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            //exitButton.Click += new EventHandler(exitButton_click);            
            InitializeComponent();
            startButton.Click += new EventHandler(StartButton_Click);
            startButton.MouseHover += new EventHandler(StartButton_MouseHover);
            startButton.MouseMove += new MouseEventHandler(StartButton_MouseMove);
            startButton.MouseLeave += new EventHandler(StartButton_MouseLeave);
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        public void StartButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                int z = random.Next(0, 3);
                if (z == 0)
                {
                    Form form = new Form1();
                    form.ShowDialog();
                    this.Hide();
                }
                else if (z == 1)
                {
                    Form form = new Form2();
                    form.ShowDialog();
                    this.Hide();

                }
                else
                {
                    Form form = new Form3();
                    form.ShowDialog();
                    this.Hide();
                }
            });
            thread.Start();
            
        }
        public void StartButton_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
        }
        public void StartButton_MouseMove(object sender, MouseEventArgs e)
        {
            int x = random.Next(-7, 7);
            int y = random.Next(-7, 7);
            if (startButton.Location.X + x > 0 && startButton.Location.X + x < 816 && startButton.Location.X + y > 0 && startButton.Location.X + y < 489)
            startButton.Location = new Point(startButton.Location.X + x, startButton.Location.X + y);

        }
        public void StartButton_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor= Color.Red;
        }
    }
}
