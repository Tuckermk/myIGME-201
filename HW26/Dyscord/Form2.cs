﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Dyscord
{
    public delegate void UpdateConversationDelegate(string text);
    public partial class DyscordForm : Form
    {
        string targetUser = ""; 
        string targetIp = "";
	    int targetPort; 
	    string myIp = "";
	    int myPort = 2222;
        Thread thread;
	    Socket listener;

        public DyscordForm()
        {
            InitializeComponent();
            this.Show();
            SettingsForm settingsForm = new SettingsForm(this, myPort);
            settingsForm.ShowDialog();
            this.myPort = settingsForm.myPort;

            ThreadStart threadStart = new ThreadStart(Listen);
            thread = new Thread(threadStart);
            thread.Start();

            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iPAddress in ipHost.AddressList)
            {
                if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    this.myIp = iPAddress.ToString();
                    break;
                }
            }

            this.loginButton.Click += new EventHandler(loginButton_Click);
            this.usersButton.Click += new EventHandler(usersButton_Click);
            this.loginButton.Click += new EventHandler(loginButton_Click);
            this.sendButton.Click += new EventHandler(sendButton_Click);
            this.exitButton.Click += new EventHandler(exitButton_Click);
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            if(userTextBox.TextLength > 0)
            {
                webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?login=" + userTextBox.Text + "&ip=" + myIp + ":" + myPort);
                webBrowser1.Visible = false;
                userTextBox.Enabled = false;
                loginButton.Enabled = false;
            }
        }
        public void usersButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?logins");
            webBrowser1.Visible = true;
            convRichTextBox.SendToBack();

        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection htmlElementCollection;
            htmlElementCollection = webBrowser1.Document.GetElementsByTagName("button");
            foreach(HtmlElement htmlElement in htmlElementCollection)
            {
                htmlElement.Click += new HtmlElementEventHandler(htmlElement_Click);

            }
        }

        private void htmlElement_Click(object sender, HtmlElementEventArgs e)
        {
            string title;
            string[] ipPort;
            HtmlElement htmlElement = (HtmlElement)sender;
            title = htmlElement.GetAttribute("title");
            ipPort = title.Split(':');
            this.targetPort = Int32.Parse(ipPort[1]);
            this.targetUser = htmlElement.GetAttribute("name");
            this.groupBox1.Text = "Conversing with " + targetUser;

            webBrowser1.Visible = false;
            webBrowser1.SendToBack();
        }

        public void sendButton_Click(object sender, EventArgs e)
        {
            if(targetIp.Length > 0)
            {
                IPAddress iPAddress = IPAddress.Parse(this.targetIp);
                IPEndPoint remoteEndPoint = new IPEndPoint(iPAddress, this.targetPort);
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Connect(remoteEndPoint);
                Stream netStream = new NetworkStream(server);
                StreamWriter writer = new StreamWriter(netStream);
                string msg = userTextBox.Text + ": " + msgRichTextBox.Text;
                writer.Write(msg.ToCharArray(), 0, msg.Length);
                writer.Close();
                netStream.Close();
                server.Close();

                this.convRichTextBox.Text += "> " + this.targetUser + ": " + msgRichTextBox.Text + "\n";
                msgRichTextBox.Clear();
            }
        }

        public void exitButton_Click(object sender, EventArgs e)
        {
            listener.Close();
            thread.Abort();
            Application.Exit();
        }


            public void UpdateConversation(string text)
        {
            this.convRichTextBox.Text += text + "\n";
        }
        public void Listen()
        {
            UpdateConversationDelegate updateConversationDelegate;
            updateConversationDelegate = new UpdateConversationDelegate(UpdateConversation);
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, myPort);
            this.listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.listener.Bind(serverEndPoint);
            this.listener.Listen(300);
            while (true)
            {
                Socket client = listener.Accept();
                Stream netStream = new NetworkStream(client);
                StreamReader reader = new StreamReader(netStream);
                string result = reader.ReadToEnd();
                Invoke(updateConversationDelegate, result);
                reader.Close();
                netStream.Close();
                client.Close();
            }
        }
    }
}
