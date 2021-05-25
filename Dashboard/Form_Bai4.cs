using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form_Bai4 : Form
    {
        string url_homepage = "https://google.com";

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
            webBrowser.Navigate(url_homepage);
        }

        private void combox_URL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (combox_URL.Text != string.Empty)
                {
                    combox_URL.Items.Add(combox_URL.Text);
                    webBrowser.Navigate(combox_URL.Text);
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
            combox_URL.Text = url_homepage;
            webBrowser.Navigate(url_homepage);

            //webBrowser.GoHome();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {

        }

        private void btn_sourcesCode_Click(object sender, EventArgs e)
        {

        }
    }
}
