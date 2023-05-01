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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            mathText.KeyUp += new KeyEventHandler(MathText_KeyUp);
            //exitButton.Click += new EventHandler(exitButton_Click);
            
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }
        private void MathText_KeyUp(object sender, KeyEventArgs e)
        {
            Form form = new Form1();
            if (mathText.Text != "5")
            {
                
                form.Text = "Literally 1984";
                this.Hide();
                form.ShowDialog();
                
            }
            else
            {
                var message = "Are we at war with Eastasia";
                var result = MessageBox.Show(message,"1984", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        
                        if (form.Text == "Section of the way there")
                        Application.Exit();
                        break;
                    case DialogResult.No:
                        
                        form.Text = "Good citizen";
                        this.Hide();
                        form.ShowDialog();
                        break;
                }
            }
        }
    }
}
