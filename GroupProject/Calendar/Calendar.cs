using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOME;
using GoalsPage;
using WindowsFormsApp1;

namespace Calendar
{
    /* Class : Calender
    Author : Tucker Knapman
    Purpose : be a calendar that a user can input and remove stuff into
    Restricitions: Selecting multiple days on calendar doesnt work */
    //
    public partial class Calendar : Form
    {
        List<ListBox> dateset = new List<ListBox>();
        ListBox thebox = null;
        public Calendar()
        {
            InitializeComponent();

            //Good ol' event handler for button and enter
            addButton.Click += new EventHandler(AddButton_Click);
            modifyButton.Click += new EventHandler(ModifyButton_Click);
            removeButton.Click += new EventHandler(RemoveButton_Click);
            homePictureBox.Click += new EventHandler(HomePictureBox_Click);
            workOutPictureBox.Click += new EventHandler(WorkOutPictureBox_Click);
            goalsPictureBox.Click += new EventHandler(GoalsPictureBox_Click);
            newTextBox.KeyPress += new KeyPressEventHandler(NewTextBox_KeyPress);
            


            //Startup declaring everything for today as selected
            dateLabel.Text = monthCalendar.TodayDate.ToShortDateString();
            monthCalendar.SelectionStart = monthCalendar.TodayDate;
            monthCalendar.SelectionEnd = monthCalendar.TodayDate;

         //make a new list box for the day
            //Sizing/placing box
            ListBox newBox = new ListBox();
            newBox.Location = new Point(13, 290);
            newBox.Size = new Size(362, 251);
            //Naming the box
            newBox.Name = monthCalendar.TodayDate.ToShortDateString();
            newBox.Tag = monthCalendar.TodayDate.ToShortDateString();
            newBox.Text = monthCalendar.TodayDate.ToShortDateString();

            //Coloring it
            newBox.ForeColor = Color.Black;
            newBox.BackColor = Color.Goldenrod;
            newBox.BorderStyle = BorderStyle.FixedSingle;

            //Making sure its visible
            newBox.Visible = true;

            //Make the generally used "thebox" the new box
            this.thebox = newBox;
            this.thebox.Visible = true;
            
            //Adding it to everything and bringing it to front
            dateset.Add(this.thebox);
            Controls.Add(this.thebox);
            this.thebox.BringToFront();
        }
      

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateLabel.Text = monthCalendar.SelectionStart.ToShortDateString();
            
            //bool used to determine if the listbox is already created and date
            bool checker = true;
            foreach(ListBox dateIterator in dateset)
            {
                if(dateLabel.Text == dateIterator.Text)
                {
                    //set the checker bool to true as its in the list
                    checker = false;
                    this.thebox.Visible = false;
                    this.thebox = dateIterator;
                    this.thebox.Visible = true;
                    this.thebox.BringToFront();
                    break;
                }
                checker = true;
            }
            if (checker)
            {
                
                //hide current box
                this.thebox.Visible = false;
         //make a new list box for the day
                //Sizing/placing box
                ListBox newBox = new ListBox();
                newBox.Location = new Point(13, 290);
                newBox.Size = new Size(362, 251);
                //Naming the box
                newBox.Name = monthCalendar.SelectionStart.ToShortDateString();
                newBox.Tag = monthCalendar.SelectionStart.ToShortDateString();
                newBox.Text = monthCalendar.SelectionStart.ToShortDateString();

                //Coloring it
                newBox.ForeColor = Color.Black;
                newBox.BackColor = Color.Goldenrod;
                newBox.BorderStyle = BorderStyle.FixedSingle;

                newBox.Visible = true;
                
                //Make the generally used "thebox" the new box
                this.thebox = newBox;
                this.thebox.Visible = true;
                

                dateset.Add(newBox);
                Controls.Add(newBox);
                this.thebox.BringToFront();
            }
        }

        

        private void AddButton_Click(Object sender, EventArgs e)
        {
            
            int max = 0;
            string[] input = newTextBox.Text.Split(' ');
            string output = "";
            bool number = false;
            foreach(string s in input)
            {
                try 
                { 
                    max = int.Parse(s);
                    number = true;
                }
                catch
                {
                    output += s + " ";
                }
            }
            if (number)
            {

                string bar = "0/" + max;
                //string[] array = {output, bar};
                output += bar;
                this.thebox.Items.Add(output);
            }
            else
            {
                this.thebox.Items.Add(output);
            }
        }

        private void NewTextBox_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addButton.PerformClick();
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            //Try catch to ignore bad inputs
            try {
                string input = this.thebox.SelectedItem.ToString();
                string output = "";
                string[] numbers;
                string final = "";
                int num;
                try
                {
                    string[] split = input.Split(' ');
                    foreach (string s in split)
                    {
                        if (s.Contains('/'))
                        {
                            numbers = s.Split('/');
                            final = numbers[1];
                        }
                        else
                        {
                            output += s + " ";
                        }


                    }
                    num = int.Parse(modifyTextBox.Text);
                    output += num + "/" + final;
                    

                    string removeditem = this.thebox.SelectedItem.ToString();
                    int index = 0;
                    foreach (string item in this.thebox.Items)
                    {
                        
                        if (item == input)
                        {
                            thebox.Items.Remove(item);
                            this.thebox.Items.Insert(index,output);
                        }
                        index++;
                    }
                }
                catch
                {

                }
            }
            catch
            {

            }
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Try catch to ignore bad inputs
            try
            {
                string removeditem = this.thebox.SelectedItem.ToString();
                foreach(string item in this.thebox.Items)
                {
                    if(item == removeditem)
                    {
                        thebox.Items.Remove(item);
                    }
                }
            }
            catch
            {

            }
        }

        //To the other pages buttons
        private void HomePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form home = new HOME.HomeForm();
            home.ShowDialog();
        }
        private void GoalsPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form goals = new GoalsPage.Goals();
            
            goals.ShowDialog();
            this.Show();
        }
        private void WorkOutPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form workout = new WindowsFormsApp1.Workout();
            workout.ShowDialog();
            this.Show();
        }


        //this is randomly generated
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
