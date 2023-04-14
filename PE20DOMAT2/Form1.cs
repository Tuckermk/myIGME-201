using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20DOMAT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }
            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");


        }

        

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            //HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;
            HtmlElementCollection htmlElementCollection = webBrowser.Document.Body.Children;
            int i = 0;
            //Giving every thing in body a id number starting at 0
            foreach (HtmlElement htmlElement1 in htmlElementCollection)
            {
                htmlElement1.Id = i.ToString();
                i++;
            }
            htmlElement = webBrowser.Document.GetElementById("0");
            htmlElement.InnerText = "My UFO Page";

            htmlElement = webBrowser.Document.GetElementById("1");
            htmlElement.InnerText = "My UFO Info";

            htmlElement = webBrowser.Document.GetElementById("2");
            htmlElement.InnerText = "My UFO Pictures";

            htmlElement = webBrowser.Document.GetElementById("3");
            htmlElement.InnerText = " ";

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style = "font-family:sans-serif; color: #800000;";

            htmlElement = webBrowser.Document.GetElementById("4");
            
            htmlElement.Style = "color:#00f000;font-weight:bold;font-size:2em;text-transform:uppercase;text-shadow:3px 2px #A44;";          
            htmlElement.InnerHtml = " Report your UFO sightings here: <a href=\"www.nuforc.org\">www.nuforc.org</a>";

            htmlElement = webBrowser.Document.GetElementById("5");
            htmlElement.InnerText = " ";

            htmlElement = webBrowser.Document.GetElementById("6");
            htmlElement.InnerHtml = "<img src=\"https://bloximages.chicago2.vip.townnews.com/postregister.com/content/tncms/assets/v3/editorial/5/05/5058d9af-e14c-51fe-8ae6-237ee3738bca/5ffe13ead5eef.hires.jpg\" width=\"300\" height=\"300\" > Blah Blah Blah";

            htmlElement = webBrowser1.Document.CreateElement("footer");
            htmlElement.InnerText = "© 2023 T. Knapman";
            htmlElement.SetAttribute("id", "footer");
            webBrowser1.Document.Body.AppendChild(htmlElement);

        }
    }
}
