using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Question2
{
    public partial class Form : System.Windows.Forms.Form
    {
        string url;
        int correct;
        public Form()
        {
            InitializeComponent();
        

            //Press buttons
            harButton.Click += new EventHandler(HarButton_Click);
            fDRButton.Click += new EventHandler(FDRButton_Click);
            clintonButton.Click += new EventHandler(ClintonButton_Click);
            buchButton.Click += new EventHandler(BuchButton_Click);
            pierceButton.Click += new EventHandler(PierceButton_Click);
            bushButton.Click += new EventHandler(BushButton_Click);
            obamaButton.Click += new EventHandler(ObamaButton_Click);
            jFKButton.Click += new EventHandler(JFKButton_Click);

            mcKinleyButton.Click += new EventHandler(McKinleyButton_Click);
            reaganButton.Click += new EventHandler(ReaganButton_Click);
            eisenButton.Click += new EventHandler(EisenButton_Click);
            vanBurButton.Click += new EventHandler(VanBurButton_Click);
            washingtonButton.Click += new EventHandler(WashingtonButton_Click);
            adamsButton.Click += new EventHandler(AdamsButton_Click);
            teddyButton.Click += new EventHandler(TeddyButton_Click);
            jeffButton.Click += new EventHandler(JeffButton_Click);

            //tips
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(harButton, "What # President");
            toolTip.SetToolTip(fDRButton, "What # President");
            toolTip.SetToolTip(clintonButton, "What # President");
            toolTip.SetToolTip(buchButton, "What # President");
            toolTip.SetToolTip(pierceButton, "What # President");
            toolTip.SetToolTip(bushButton, "What # President");
            toolTip.SetToolTip(obamaButton, "What # President");
            toolTip.SetToolTip(jFKButton, "What # President");

            toolTip.SetToolTip(mcKinleyButton, "What # President");
            toolTip.SetToolTip(reaganButton, "What # President");
            toolTip.SetToolTip(eisenButton, "What # President");
            toolTip.SetToolTip(vanBurButton, "What # President");
            toolTip.SetToolTip(washingtonButton, "What # President");
            toolTip.SetToolTip(adamsButton, "What # President");
            toolTip.SetToolTip(teddyButton, "What # President");
            toolTip.SetToolTip(jeffButton, "What # President");

            toolTip.SetToolTip(harWrongPic, "Wrong");
            toolTip.SetToolTip(fDRWrongPic, "Wrong");
            toolTip.SetToolTip(clintonWrongPic, "Wrong");
            toolTip.SetToolTip(buchWrongPic, "Wrong");
            toolTip.SetToolTip(pierceWrongPic, "Wrong");
            toolTip.SetToolTip(bushWrongPic, "Wrong");
            toolTip.SetToolTip(obamaWrongPic, "Wrong");
            toolTip.SetToolTip(jFKWrongPic, "Wrong");

            toolTip.SetToolTip(mcKinleyWrongPic, "Wrong");
            toolTip.SetToolTip(reaganWrongPic, "Wrong");
            toolTip.SetToolTip(eisenWrongPic, "Wrong");
            toolTip.SetToolTip(vanBurWrongPic, "Wrong");
            toolTip.SetToolTip(washingtonWrongPic, "Wrong");
            toolTip.SetToolTip(adamsWrongPic, "Wrong");
            toolTip.SetToolTip(teddyWrongPic, "Wrong");
            toolTip.SetToolTip(jeffWrongPic, "Wrong");

            //Filter buttons
            allButton.Click += new EventHandler(AllButton_Click);
            demButton.Click += new EventHandler(DemButton_Click);
            repButton.Click += new EventHandler(RepButton_Click);
            dRButton.Click += new EventHandler(DRButton_Click);
            fedButton.Click += new EventHandler(FedButton_Click);

            //exitButton
            exitButton.Click += new EventHandler(ExitButton_Click);
            //mouse pic box events
            picBox.MouseHover += new EventHandler(PicBox_MouseHover);
            picBox.MouseLeave += new EventHandler(PicBox_MouseLeave);

            //timer
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Enabled = true;

            //textbox
            harTextBox.KeyPress += new KeyPressEventHandler(HarTextBox_KeyPress);
            fDRTextBox.KeyPress += new KeyPressEventHandler(FDRTextBox_KeyPress);
            clintonTextBox.KeyPress += new KeyPressEventHandler(ClintonTextBox_KeyPress);
            buchTextBox.KeyPress += new KeyPressEventHandler(BuchTextBox_KeyPress);
            pierceTextBox.KeyPress += new KeyPressEventHandler(PierceTextBox_KeyPress);
            bushTextBox.KeyPress += new KeyPressEventHandler(BushTextBox_KeyPress);
            obamaTextBox.KeyPress += new KeyPressEventHandler(ObamaTextBox_KeyPress);
            jFKTextBox.KeyPress += new KeyPressEventHandler(JFKTextBox_KeyPress);
            mcKinleyTextBox.KeyPress += new KeyPressEventHandler(McKinleyTextBox_KeyPress);
            reaganTextBox.KeyPress += new KeyPressEventHandler(ReaganTextBox_KeyPress);
            eisenTextBox.KeyPress += new KeyPressEventHandler(EisenTextBox_KeyPress);
            vanBurTextBox.KeyPress += new KeyPressEventHandler(VanBurTextBox_KeyPress);
            washingtonTextBox.KeyPress += new KeyPressEventHandler(WashingtonTextBox_KeyPress);
            adamsTextBox.KeyPress += new KeyPressEventHandler(AdamsTextBox_KeyPress);
            teddyTextBox.KeyPress += new KeyPressEventHandler(TeddyTextBox_KeyPress);
            jeffTextBox.KeyPress += new KeyPressEventHandler(JeffTextBox_KeyPress);

            //starting stuff patchwork
            
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value == 0) { exitButton.Enabled = true; }
            else { progressBar.Value -= 1; }

            
        }


        public void PicBox_MouseLeave(Object sender, EventArgs e)
        {
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void PicBox_MouseHover(Object sender, EventArgs e)
        {
            picBox.Size = new System.Drawing.Size(251, 278);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void HarButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            picBox.Load("https://people.rit.edu/dxsigm/BenjaminHarrison.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void FDRButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/Franklin_D._Roosevelt";
            picBox.Load("https://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void ClintonButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/Bill_Clinton";
            picBox.Load("https://people.rit.edu/dxsigm/WilliamJClinton.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void BuchButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/James_Buchanan";
            picBox.Load("https://people.rit.edu/dxsigm/JamesBuchanan.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void PierceButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
            picBox.Load("https://people.rit.edu/dxsigm/FranklinPierce.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        

        public void BushButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/George_W._Bush";
            picBox.Load("https://people.rit.edu/dxsigm/GeorgeWBush.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void ObamaButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/Barack_Obama";
            picBox.Load("https://people.rit.edu/dxsigm/BarackObama.png");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void JFKButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/John_F._Kennedy";
            picBox.Load("https://people.rit.edu/dxsigm/JohnFKennedy.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void McKinleyButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/William_McKinley";
            picBox.Load("https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }
        public void ReaganButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
            picBox.Load("https://people.rit.edu/dxsigm/RonaldReagan.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void EisenButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/Dwight_D._Eisenhower";
            picBox.Load("https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }
        public void VanBurButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/Martin_VanBuren";
            picBox.Load("https://people.rit.edu/dxsigm/MartinVanBuren.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void WashingtonButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/George_Washington";
            picBox.Load("https://people.rit.edu/dxsigm/GeorgeWashington.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void AdamsButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/John_Adams";
            picBox.Load("https://people.rit.edu/dxsigm/JohnAdams.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }
        public void TeddyButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
            picBox.Load("https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }

        public void JeffButton_Click(object sender, EventArgs e)
        {
            url = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
            picBox.Load("https://people.rit.edu/dxsigm/ThomasJefferson.jpeg");
            picBox.Size = new System.Drawing.Size(151, 178);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            webPageGroupBox.Text = url;
            wikiBrowser.Navigate(url);
        }


        public void HarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 23;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(harTextBox.Text) != correct)
                {
                    harWrongPic.Visible = true;
                }
                else if(int.Parse(harTextBox.Text) == correct)
                {
                    harWrongPic.Visible = false;
                }
            }
            catch
            {
                
            }
        }
        public void FDRTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 32;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(fDRTextBox.Text) != correct)
                {
                    fDRWrongPic.Visible = true;
                }
                else if (int.Parse(fDRTextBox.Text) == correct)
                {
                    fDRWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }

        public void ClintonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 42;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(clintonTextBox.Text) != correct)
                {
                    clintonWrongPic.Visible = true;
                }
                else if (int.Parse(clintonTextBox.Text) == correct)
                {
                    clintonWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void BuchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 15;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(buchTextBox.Text) != correct)
                {
                    buchWrongPic.Visible = true;
                }
                else if (int.Parse(buchTextBox.Text) == correct)
                {
                    buchWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void PierceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 14;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(pierceTextBox.Text) != correct)
                {
                    pierceWrongPic.Visible = true;
                }
                else if (int.Parse(pierceTextBox.Text) == correct)
                {
                    pierceWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void BushTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 43;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(bushTextBox.Text) != correct)
                {
                    bushWrongPic.Visible = true;
                }
                else if (int.Parse(bushTextBox.Text) == correct)
                {
                    bushWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }

        public void ObamaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 44;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(obamaTextBox.Text) != correct)
                {
                    obamaWrongPic.Visible = true;
                }
                else if (int.Parse(obamaTextBox.Text) == correct)
                {
                    obamaWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void JFKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 35;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(jFKTextBox.Text) != correct)
                {
                    jFKWrongPic.Visible = true;
                }
                else if (int.Parse(jFKTextBox.Text) == correct)
                {
                    jFKWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void McKinleyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 25;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(mcKinleyTextBox.Text) != correct)
                {
                    mcKinleyWrongPic.Visible = true;
                    mcKinleyTextBox.Text += "";
                }
                else if (int.Parse(mcKinleyTextBox.Text) == correct)
                {
                    mcKinleyWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void ReaganTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 40;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(reaganTextBox.Text) != correct)
                {
                    reaganWrongPic.Visible = true;
                }
                else if (int.Parse(reaganTextBox.Text) == correct)
                {
                    reaganWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void EisenTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 34;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(eisenTextBox.Text) != correct)
                {
                    eisenWrongPic.Visible = true;
                }
                else if (int.Parse(eisenTextBox.Text) == correct)
                {
                    eisenWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void VanBurTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 8;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(vanBurTextBox.Text) != correct)
                {
                    vanBurWrongPic.Visible = true;
                }
                else if (int.Parse(vanBurTextBox.Text) == correct)
                {
                    vanBurWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void WashingtonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 1;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(washingtonTextBox.Text) != correct)
                {
                    washingtonWrongPic.Visible = true;
                }
                else if (int.Parse(washingtonTextBox.Text) == correct)
                {
                    washingtonWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void AdamsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 2;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(adamsTextBox.Text) != correct)
                {
                    adamsWrongPic.Visible = true;
                }
                else if (int.Parse(adamsTextBox.Text) == correct)
                {
                    adamsWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void TeddyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 26;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(teddyTextBox.Text) != correct)
                {
                    teddyWrongPic.Visible = true;
                }
                else if (int.Parse(teddyTextBox.Text) == correct)
                {
                    teddyWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }
        public void JeffTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            correct = 3;
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            try
            {
                if (int.Parse(jeffTextBox.Text) != correct)
                {
                    jeffWrongPic.Visible = true;
                }
                else if (int.Parse(jeffTextBox.Text) == correct)
                {
                    jeffWrongPic.Visible = false;
                }
            }
            catch
            {

            }
        }

        public void AllButton_Click(object sender, EventArgs e)
        {
            harButton.Visible = true;
            fDRButton.Visible = true;
            clintonButton.Visible = true;
            buchButton.Visible = true;
            pierceButton.Visible = true;
            bushButton.Visible = true;
            obamaButton.Visible = true;
            jFKButton.Visible = true;

            mcKinleyButton.Visible = true;
            reaganButton.Visible = true;
            eisenButton.Visible = true;
            vanBurButton.Visible = true;
            washingtonButton.Visible = true;
            adamsButton.Visible = true;
            teddyButton.Visible = true;
            jeffButton.Visible = true;
            harButton.PerformClick();
        }
        public void DemButton_Click(object sender, EventArgs e)
        {
            harButton.Visible = false;
            fDRButton.Visible = true;
            clintonButton.Visible = true;
            buchButton.Visible = true;
            pierceButton.Visible = true;
            bushButton.Visible = false;
            obamaButton.Visible = true;
            jFKButton.Visible = true;

            mcKinleyButton.Visible = false;
            reaganButton.Visible = false;
            eisenButton.Visible = false;
            vanBurButton.Visible = true;
            washingtonButton.Visible = false;
            adamsButton.Visible = false;
            teddyButton.Visible = false;
            jeffButton.Visible = false;
            fDRButton.PerformClick();
        }
        public void RepButton_Click(object sender, EventArgs e)
        {
            harButton.Visible = true;
            fDRButton.Visible = false;
            clintonButton.Visible = false;
            buchButton.Visible = false;
            pierceButton.Visible = false;
            bushButton.Visible = true;
            obamaButton.Visible = false;
            jFKButton.Visible = false;

            mcKinleyButton.Visible = true;
            reaganButton.Visible = true;
            eisenButton.Visible = true;
            vanBurButton.Visible = false;
            washingtonButton.Visible = false;
            adamsButton.Visible = false;
            teddyButton.Visible = true;
            jeffButton.Visible = false;
            harButton.PerformClick();
        }
        public void DRButton_Click(object sender, EventArgs e)
        {
            harButton.Visible = false;
            fDRButton.Visible = false;
            clintonButton.Visible = false;
            buchButton.Visible = false;
            pierceButton.Visible = false;
            bushButton.Visible = false;
            obamaButton.Visible = false;
            jFKButton.Visible = false;

            mcKinleyButton.Visible = false;
            reaganButton.Visible = false;
            eisenButton.Visible = false;
            vanBurButton.Visible = false;
            washingtonButton.Visible = false;
            adamsButton.Visible = false;
            teddyButton.Visible = false;
            jeffButton.Visible = true;
            jeffButton.PerformClick();
        }
        public void FedButton_Click(object sender, EventArgs e)
        {
            harButton.Visible = false;
            fDRButton.Visible = false;
            clintonButton.Visible = false;
            buchButton.Visible = false;
            pierceButton.Visible = false;
            bushButton.Visible = false;
            obamaButton.Visible = false;
            jFKButton.Visible = false;

            mcKinleyButton.Visible = false;
            reaganButton.Visible = false;
            eisenButton.Visible = false;
            vanBurButton.Visible = false;
            washingtonButton.Visible = true;
            adamsButton.Visible = true;
            teddyButton.Visible = false;
            jeffButton.Visible = false;
            washingtonButton.PerformClick();
        }


    }
}
