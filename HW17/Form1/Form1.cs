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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            theButton.Click += new EventHandler(theButton_Click);
        }

        private void theButton_Click(object sender, EventArgs e)
        {
            //bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse
            highNumber = int.Parse(highEndValueTextBox.Text);
            lowNumber = int.Parse(lowEndValueTextBox.Text);
            
            // if not a valid range
            if (lowNumber < 1 || highNumber < 1 || lowNumber > 100 || highNumber > 100 || lowNumber > highNumber)
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }
    }
}
