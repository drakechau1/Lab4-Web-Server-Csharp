using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;

namespace Dashboard
{
    public partial class Form_Bai4 : Form
    {
        string url_homepage = "https://google.com";
        string current_url;

        /// <summary>
        /// Child functions
        /// </summary>

        /// <summary>
        /// Main functions
        /// </summary>

        public Form_Bai4()
        {
            InitializeComponent();
        }

        private void Form_Bai4_Load(object sender, EventArgs e)
        {
            combox_URL.Text = url_homepage;
            current_url = combox_URL.Text;
            webBrowser.Navigate(url_homepage);
        }

        private void combox_URL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (current_url != string.Empty)
                {
                    current_url = combox_URL.Text;

                    if (combox_URL.FindString(current_url) == -1) // If current_url no match in combox_URL, It will add to items
                    {
                        combox_URL.Items.Add(current_url);
                    }

                    webBrowser.Navigate(current_url);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            current_url = url_homepage;
            combox_URL.Text = url_homepage;
            webBrowser.Navigate(url_homepage);
            //webBrowser.GoHome();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_sourcesCode_Click(object sender, EventArgs e)
        {
            WebRequest webRequest = WebRequest.Create(current_url);
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            WebResponse webResponse = webRequest.GetResponse();
            Stream stream = webResponse.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            Form form_viewSourceCode = new Form_ViewSourceCode(current_url, reader.ReadToEnd());
            form_viewSourceCode.Show();

            stream.Close();
            webResponse.Close();
        }
    }
}
