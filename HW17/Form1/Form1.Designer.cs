namespace Form1
{
    partial class Form1
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
            this.theButton = new System.Windows.Forms.Button();
            this.highEndValueTextBox = new System.Windows.Forms.TextBox();
            this.lowEndValueTextBox = new System.Windows.Forms.TextBox();
            this.highLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // theButton
            // 
            this.theButton.Location = new System.Drawing.Point(231, 179);
            this.theButton.Name = "theButton";
            this.theButton.Size = new System.Drawing.Size(75, 23);
            this.theButton.TabIndex = 0;
            this.theButton.Text = "Start Button";
            this.theButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.theButton.UseVisualStyleBackColor = true;
            // 
            // highEndValueTextBox
            // 
            this.highEndValueTextBox.Location = new System.Drawing.Point(218, 109);
            this.highEndValueTextBox.Name = "highEndValueTextBox";
            this.highEndValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.highEndValueTextBox.TabIndex = 1;
            // 
            // lowEndValueTextBox
            // 
            this.lowEndValueTextBox.Location = new System.Drawing.Point(218, 265);
            this.lowEndValueTextBox.Name = "lowEndValueTextBox";
            this.lowEndValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowEndValueTextBox.TabIndex = 2;
            // 
            // highLabel
            // 
            this.highLabel.AutoSize = true;
            this.highLabel.Location = new System.Drawing.Point(215, 93);
            this.highLabel.Name = "highLabel";
            this.highLabel.Size = new System.Drawing.Size(81, 13);
            this.highLabel.TabIndex = 3;
            this.highLabel.Text = "High End Value";
            // 
            // lowLabel
            // 
            this.lowLabel.AutoSize = true;
            this.lowLabel.Location = new System.Drawing.Point(215, 249);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(79, 13);
            this.lowLabel.TabIndex = 4;
            this.lowLabel.Text = "Low End Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.highLabel);
            this.Controls.Add(this.lowEndValueTextBox);
            this.Controls.Add(this.highEndValueTextBox);
            this.Controls.Add(this.theButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button theButton;
        private System.Windows.Forms.TextBox highEndValueTextBox;
        private System.Windows.Forms.TextBox lowEndValueTextBox;
        private System.Windows.Forms.Label highLabel;
        private System.Windows.Forms.Label lowLabel;
    }
}

