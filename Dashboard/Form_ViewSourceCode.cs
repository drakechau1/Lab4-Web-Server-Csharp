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
    public partial class Form_ViewSourceCode : Form
    {
        public Form_ViewSourceCode()
        {
            InitializeComponent();
        }

        public Form_ViewSourceCode(string url, string html)
        {
            InitializeComponent();
            this.Text = $"Source code: {url}";
            rich_html.Text = html;
        }
    }
}
