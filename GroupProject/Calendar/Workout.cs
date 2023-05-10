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
using Calendar;
using GoalsPage;


namespace WindowsFormsApp1
{
    /* Class : Workout
    Author : Sawyer Nicastro
    Purpose : Recommend workouts
    Restricitions: none? idk Tucker put in this little comment block */
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
            Form homeForm = new HomeForm();
            homeForm.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form calenderForm = new Calendar.Calendar();
            calenderForm.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form goalsForm = new GoalsPage.Goals();
            goalsForm.ShowDialog();
            this.Show();
        }
    }
}
