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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            Form form = new Form_Bai1();
            form.Show();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            Form form = new Form_Bai2();
            form.Show();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            Form form = new Form_Bai3();
            form.Show();
        }

        private void btn_bai4_Click(object sender, EventArgs e)
        {
            Form form = new Form_Bai4();
            form.Show();
        }
    }
}
