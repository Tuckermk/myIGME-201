namespace Calendar
{
    partial class Calendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.modifyLabel = new System.Windows.Forms.Label();
            this.modifyTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.addSomeThingLabel = new System.Windows.Forms.Label();
            this.newTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.workOutPictureBox = new System.Windows.Forms.PictureBox();
            this.goalsPictureBox = new System.Windows.Forms.PictureBox();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.ritlogopictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritlogopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 21);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(370, 509);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 1;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(66, 5);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.modifyButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.modifyLabel);
            this.groupBox1.Controls.Add(this.modifyTextBox);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.addSomeThingLabel);
            this.groupBox1.Controls.Add(this.newTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(364, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Orange;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(280, 56);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(74, 23);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            // 
            // modifyButton
            // 
            this.modifyButton.BackColor = System.Drawing.Color.Orange;
            this.modifyButton.FlatAppearance.BorderSize = 0;
            this.modifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.modifyButton.ForeColor = System.Drawing.Color.White;
            this.modifyButton.Location = new System.Drawing.Point(280, 32);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(74, 23);
            this.modifyButton.TabIndex = 7;
            this.modifyButton.Text = "Update";
            this.modifyButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Orange;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(280, 8);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // modifyLabel
            // 
            this.modifyLabel.AutoSize = true;
            this.modifyLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.modifyLabel.ForeColor = System.Drawing.Color.White;
            this.modifyLabel.Location = new System.Drawing.Point(13, 32);
            this.modifyLabel.Name = "modifyLabel";
            this.modifyLabel.Size = new System.Drawing.Size(103, 14);
            this.modifyLabel.TabIndex = 7;
            this.modifyLabel.Text = "Update progress!";
            // 
            // modifyTextBox
            // 
            this.modifyTextBox.Location = new System.Drawing.Point(125, 32);
            this.modifyTextBox.Name = "modifyTextBox";
            this.modifyTextBox.Size = new System.Drawing.Size(149, 20);
            this.modifyTextBox.TabIndex = 6;
            this.modifyTextBox.Tag = "";
            this.modifyTextBox.Text = "(Update your progress)";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateLabel.Location = new System.Drawing.Point(13, 62);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 16);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "label";
            // 
            // addSomeThingLabel
            // 
            this.addSomeThingLabel.AutoSize = true;
            this.addSomeThingLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.addSomeThingLabel.ForeColor = System.Drawing.Color.White;
            this.addSomeThingLabel.Location = new System.Drawing.Point(3, 11);
            this.addSomeThingLabel.Name = "addSomeThingLabel";
            this.addSomeThingLabel.Size = new System.Drawing.Size(122, 14);
            this.addSomeThingLabel.TabIndex = 2;
            this.addSomeThingLabel.Text = "Add something new!";
            // 
            // newTextBox
            // 
            this.newTextBox.Location = new System.Drawing.Point(125, 8);
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.Size = new System.Drawing.Size(149, 20);
            this.newTextBox.TabIndex = 1;
            this.newTextBox.Text = "(Input workout & count)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.workOutPictureBox);
            this.groupBox2.Controls.Add(this.goalsPictureBox);
            this.groupBox2.Controls.Add(this.homePictureBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 537);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(78, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 26);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // workOutPictureBox
            // 
            this.workOutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("workOutPictureBox.Image")));
            this.workOutPictureBox.Location = new System.Drawing.Point(268, 16);
            this.workOutPictureBox.Name = "workOutPictureBox";
            this.workOutPictureBox.Size = new System.Drawing.Size(63, 36);
            this.workOutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.workOutPictureBox.TabIndex = 2;
            this.workOutPictureBox.TabStop = false;
            // 
            // goalsPictureBox
            // 
            this.goalsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("goalsPictureBox.Image")));
            this.goalsPictureBox.Location = new System.Drawing.Point(147, 16);
            this.goalsPictureBox.Name = "goalsPictureBox";
            this.goalsPictureBox.Size = new System.Drawing.Size(63, 36);
            this.goalsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goalsPictureBox.TabIndex = 1;
            this.goalsPictureBox.TabStop = false;
            this.goalsPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // homePictureBox
            // 
            this.homePictureBox.Image = global::Calendar.Properties.Resources.OrangeHome;
            this.homePictureBox.Location = new System.Drawing.Point(22, 16);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(63, 36);
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePictureBox.TabIndex = 0;
            this.homePictureBox.TabStop = false;
            // 
            // ritlogopictureBox
            // 
            this.ritlogopictureBox.BackColor = System.Drawing.Color.Orange;
            this.ritlogopictureBox.Image = global::Calendar.Properties.Resources.rit_logo;
            this.ritlogopictureBox.Location = new System.Drawing.Point(-4, -7);
            this.ritlogopictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.ritlogopictureBox.Name = "ritlogopictureBox";
            this.ritlogopictureBox.Size = new System.Drawing.Size(85, 34);
            this.ritlogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ritlogopictureBox.TabIndex = 11;
            this.ritlogopictureBox.TabStop = false;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ritlogopictureBox);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritlogopictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label addSomeThingLabel;
        private System.Windows.Forms.TextBox newTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox homePictureBox;
        private System.Windows.Forms.PictureBox workOutPictureBox;
        private System.Windows.Forms.PictureBox goalsPictureBox;
        private System.Windows.Forms.Label modifyLabel;
        private System.Windows.Forms.TextBox modifyTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ritlogopictureBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}

