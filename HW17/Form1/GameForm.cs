using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class GameForm : Form
    {
        public int NUMBER;
        public int nGuesses = 0;
        public GameForm(int low, int high)
        {
            InitializeComponent();
            Random rand = new Random();
            NUMBER = rand.Next(low, high);
            guessButton.Click += new EventHandler(guessButton_Click);
            guessTextBox.KeyDown += new KeyEventHandler(guessTextBox_KeyDown);
        }

        private void guessTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                guessButton_Click(sender, e);
            }
        }

        private void guessButton_Click(object sender,EventArgs e)
        {
           nGuesses += 1;
           if (Int32.Parse(guessTextBox.Text) == NUMBER)
            {
                MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");
                this.Close();
            }
           else if (Int32.Parse(guessTextBox.Text) > NUMBER)
            {
                outputLabel.Text = guessTextBox.Text + " is to high";
            }
            else if (Int32.Parse(guessTextBox.Text) < NUMBER)
            {
                outputLabel.Text = guessTextBox.Text + " is to low";
            }
            else
            {
                MessageBox.Show("not sure what you input is but it broke it");
                this.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Update();
        }
    }
}
