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
        string url_homepage = "https://html-agility-pack.net/knowledge-base/7341856/html-agility-pack-link-and-img-src-extraction";
        string current_url;

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

        public void Download_HTML(string path, string data)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            StreamWriter writer = File.CreateText(path);
            writer.WriteLine(data);
            writer.Flush();
            writer.Close();

            Console.WriteLine("Get html has been successful");
        }

        public List<string> Get_Files_Links(HtmlAgilityPack.HtmlDocument document, string xpath)
        {
            List<string> links = new List<string>();

            var nodes = document.DocumentNode.SelectNodes(xpath);

            foreach (var node in nodes)
            {
                string link = node.GetAttributeValue("src", string.Empty);
                if (link != string.Empty)
                {
                    Console.WriteLine(link);
                    links.Add(link);
                }
            }

            Console.WriteLine("Get link files have done");

            return links;
        }

        public void Download_1_File(string url, string saved_path)
        {
            if (url[0] == '/')
            {
                if (url[1] == '/')
                    url = "https:" + url;
                else
                    url = "https:/" + url;
            }

            Console.WriteLine(url);

            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(url, saved_path);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);  
            }
        }

        public void Download_All_Files(List<string> URLs, string saved_directory)
        {
            foreach (string url in URLs)
            {
                string saved_path = Path.Combine(saved_directory, Path.GetFileName(url));
                //Console.WriteLine(saved_path);
                Download_1_File(url, saved_path);
            }
        }


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

            // Allow to run javascript files in browser
            webBrowser.ScriptErrorsSuppressed = true;
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


        /*
         Việc download source code dự trên ý tưởng hoạt động của trình duyệt "Chrome":
         Khi download sẽ tạo 1 file html và 1 folder chứa các file hình ảnh, script, css.         

        !! Ứng dụng tạm thời chỉ download được một số ảnh, scipt, css của website, chửa thể download toàn bộ file như kỳ vọng.
         */
        private void btn_download_Click(object sender, EventArgs e)
        {
            string saved_path = Get_Saved_Path();

            if (saved_path != string.Empty)
            {

                string html = Get_HTML(current_url);
                Download_HTML(saved_path, html);

                HtmlAgilityPack.HtmlDocument document = new HtmlWeb().Load(current_url);
                List<string> img_URLs = Get_Files_Links(document, "//img");
                List<string> script_URLs = Get_Files_Links(document, "//script");
                //List<string> css_URLs = Get_Files_Links(document, "//img");

                string current_directory = Path.GetDirectoryName(saved_path);
                string file_name_without_ext = Path.GetFileNameWithoutExtension(saved_path);
                string saved_directory = Path.Combine(current_directory, file_name_without_ext);
                Directory.CreateDirectory(saved_directory);
                Download_All_Files(img_URLs, saved_directory);
                Download_All_Files(script_URLs, saved_directory);
                //Download_All_Files(img_URLs, saved_directory);

                MessageBox.Show("Downloading has been successful", "Success");
            }
            else
            {
                Console.WriteLine("Saved path is empty");
            }
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
