using System;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Dashboard
{
    public partial class Form_Bai3 : Form
    {
        /// <summary>
        /// Child functions
        /// </summary>
        
        public string Get_HTML(string url)
        {
            string html = string.Empty;

            try
            {
                WebClient web_client = new WebClient();
                web_client.Credentials = CredentialCache.DefaultCredentials;

                Stream stream = web_client.OpenRead(url);
                StreamReader reader = new StreamReader(stream);

                html = reader.ReadToEnd();

                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            return html;
        }

        public void Write_File(string path, string data)
        {
            if (File.Exists(txt_savedPath.Text))
            {
                File.Delete(txt_savedPath.Text);
            }

            StreamWriter writer = File.CreateText(txt_savedPath.Text);
            writer.WriteLine(data);
            writer.Flush();
            writer.Close();

            MessageBox.Show("Downloaded", "Success");
        }

        /// <summary>
        /// Main functions
        /// </summary>

        public Form_Bai3()
        {
            InitializeComponent();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            string file_path = txt_savedPath.Text;
            if (txt_URL.Text != string.Empty)
            {
                if (file_path == string.Empty)
                {
                    MessageBox.Show("Saved path is empty", "Error");
                }
                else
                { 
                    string html = Get_HTML(txt_URL.Text);

                    rich_html.Text = html;

                    Write_File(file_path, html);
                }
            }
        }

        private void txt_savedPath_MouseClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Hypertext Transfer Protocol | *.html";
            sfd.DefaultExt = "html";

            sfd.ShowDialog();
            if (sfd.FileName != string.Empty)
            {
                txt_savedPath.Text = sfd.FileName;
            }
        }
    }
}
