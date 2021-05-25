using System;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Dashboard
{
    public partial class Form_Bai1 : Form
    {
        /// <summary>
        /// Child functions
        /// </summary>

        public string Get_HTML(string url)
        {
            string html = string.Empty;
            try
            {
                WebRequest web_request = WebRequest.Create(url);
                web_request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse web_response = web_request.GetResponse();
                Stream stream = web_response.GetResponseStream();

                StreamReader reader = new StreamReader(stream);

                html = reader.ReadToEnd();

                stream.Close();
                web_response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            return html;
        }

        /// <summary>
        /// Main functions
        /// </summary>

        public Form_Bai1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            if (txt_URL.Text != string.Empty)
            {
                rich_html.Text = Get_HTML(txt_URL.Text);
            }
        }

        private void txt_URL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_URL.Text != string.Empty)
                {
                    rich_html.Text = Get_HTML(txt_URL.Text);
                }
            }
        }
    }
}
