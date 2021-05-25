using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                WebRequest web_request = WebRequest.Create(url);
                web_request.Credentials = CredentialCache.DefaultCredentials;
                WebResponse web_response = web_request.GetResponse();
                Stream stream = web_response.GetResponseStream();

                StreamReader reader = new StreamReader(stream);

                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            return string.Empty;
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
    }
}
