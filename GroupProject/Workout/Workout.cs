using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOME;



namespace WindowsFormsApp1
{
    public partial class Workout : Form
    {
        public Workout()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form home = new HOME.HomeForm();
            home.ShowDialog();
            this.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form calenderForm = new Calendar.calendar();
            calenderform.showdialog();
            this.Show();
        }
    }
}
