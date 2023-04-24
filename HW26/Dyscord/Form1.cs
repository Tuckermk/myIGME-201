using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyscord
{
    public partial class SettingsForm : Form
    {
        public int myPort;
        public SettingsForm(Form owner, int nPort)
        {
            InitializeComponent();


            this.Owner = owner;
            this.CenterToParent();
            this.myPort = nPort;
            this.portTextBox.Text = nPort.ToString();
            this.startButton.Click += new EventHandler(startButton_Click);
            this.portTextBox.KeyPress += new KeyPressEventHandler(portTextBox_KeyPress);

        }
        private void startButton_Click(object sender, EventArgs e)
        {
            this.myPort = int.Parse(this.portTextBox.Text);
            this.Close();
        }
        private void portTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
