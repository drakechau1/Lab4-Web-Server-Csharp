using System;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Dashboard
{
    public partial class Form_Bai3 : Form
    {
        /// <summary>
        ///  Global variables
        /// </summary>
        private string file_path = string.Empty;
        /// <summary>
        /// Child functions
        /// </summary>
        public string Get_Saved_Path()
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Hypertext Transfer Protocol | *.html";
            sfd.DefaultExt = "html";
            sfd.ShowDialog();

            if (sfd.FileName != string.Empty)
            {
                return sfd.FileName;
            }

            return string.Empty;
        }

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
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            StreamWriter writer = File.CreateText(path);
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

        private void txt_savedPath_MouseClick(object sender, MouseEventArgs e)
        {
            file_path = Get_Saved_Path();
            txt_savedPath.Text = file_path;
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if (file_path != string.Empty)
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
    }
}
