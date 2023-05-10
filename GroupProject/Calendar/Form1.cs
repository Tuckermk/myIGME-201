using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoalsPage;
using WindowsFormsApp1;

namespace HOME
{
    /* Class : HomeForm
    Author : Yanzhi Wang
    Purpose : Homepage of app
    Restricitions: none? idk Tucker put in this little comment block */
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            /*
             * The code for the images are being overridden by Tucker as getting the 2 forms to link has been annoying
             * Images are still there I just implemented them slightly differently
             * 
            // Set the image for homePictureBox
            this.homePictureBox.Image = global::HOME.Properties.Resources.logo;
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // Set the image for calendarPictureBox
            this.calenderpictureBox.Image = global::HOME.Properties.Resources.calendar;
            this.calenderpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // Set the image for newWorkoutPictureBox
            this.newworkoutpictureBox.Image = global::HOME.Properties.Resources.new_workout;
            this.newworkoutpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // Set the image for exercisePictureBox
            this.exercisepictureBox.Image = global::HOME.Properties.Resources.exercise_goals;
            this.exercisepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            */
            // Set the Click event for the calendarButton
            this.calenderButton.Click += new EventHandler(calendarButton_Click);

            // Set the Click event for the newworkoutButton
            this.newworkoutButton.Click += new EventHandler(newworkoutButton_Click);

            // Set the Click event for the exerciseButton
            this.exceriseButton.Click += new EventHandler(exerciseButton_Click);
            /*
            // Set the image for ritlogopictureBox
            this.ritlogopictureBox.Image = global::HOME.Properties.Resources.rit_logo;
            this.ritlogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            */
        }

        // Event handler for the calendarButton Click event
        private void calendarButton_Click(object sender, EventArgs e)
        {
            // Navigate to the Calendar page
            this.Hide();
            Form calenderForm = new Calendar.Calendar();
            calenderForm.ShowDialog();
            this.Show();
        }

        // Event handler for the newworkoutButton Click event
        private void newworkoutButton_Click(object sender, EventArgs e)
        {
            // Navigate to the New_Workout page
            this.Hide();
            Form newWorkoutForm = new WindowsFormsApp1.Workout();
            newWorkoutForm.ShowDialog();
            this.Show();
        }

        // Event handler for the exerciseButton Click event
        private void exerciseButton_Click(object sender, EventArgs e)
        {
            // Navigate to the Exercise_Goal page
            this.Hide();
            Form exerciseGoalForm = new GoalsPage.Goals();
            exerciseGoalForm.ShowDialog();
            this.Show();
        }
    }
}
