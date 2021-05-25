using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Dashboard
{
    public partial class Form_Bai2 : Form
    {
        /// <summary>
        /// Child functions
        /// </summary>

        public string Post_HTML(string url, string command)
        {
            byte[] arr_bytes = Encoding.UTF8.GetBytes(command);
            try
            {
                // Web request
                WebRequest web_request = WebRequest.Create(url);
                web_request.Credentials = CredentialCache.DefaultCredentials;
                web_request.Method = "POST";
                web_request.ContentLength = arr_bytes.Length;
                web_request.ContentType = "application/x-www-form-urlencoded";

                Stream stream = web_request.GetRequestStream();
                stream.Write(arr_bytes, 0, arr_bytes.Length);
                stream.Close();

                // Web response
                WebResponse web_response = web_request.GetResponse();
                Console.WriteLine(((HttpWebResponse)web_response).StatusDescription);
                stream = web_response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string html = reader.ReadToEnd();

                stream.Close();
                web_response.Close();

                return html;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            return string.Empty;
        }

        /// <summary>
        /// Main functions
        /// </summary>

        public Form_Bai2()
        {
            InitializeComponent();
        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (txt_URL.Text != string.Empty)
            {
                rich_html.Text = Post_HTML(txt_URL.Text, txt_command.Text);
            }
        }

        private void txt_command_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_URL.Text != string.Empty)
                {
                    rich_html.Text = Post_HTML(txt_URL.Text, txt_command.Text);
                }
            }
        }
    }
}
