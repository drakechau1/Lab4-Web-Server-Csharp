
namespace Dashboard
{
    partial class Form_Bai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bai4));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_back = new System.Windows.Forms.ToolStripButton();
            this.btn_forward = new System.Windows.Forms.ToolStripButton();
            this.btn_home = new System.Windows.Forms.ToolStripButton();
            this.combox_URL = new System.Windows.Forms.ToolStripComboBox();
            this.btn_download = new System.Windows.Forms.ToolStripButton();
            this.btn_sourcesCode = new System.Windows.Forms.ToolStripButton();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_back,
            this.btn_forward,
            this.btn_home,
            this.combox_URL,
            this.btn_download,
            this.btn_sourcesCode});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(847, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_back
            // 
            this.btn_back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_back.Name = "btn_back";
            this.btn_back.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.btn_back.Size = new System.Drawing.Size(29, 25);
            this.btn_back.Text = "toolStripButton1";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_forward.Image = ((System.Drawing.Image)(resources.GetObject("btn_forward.Image")));
            this.btn_forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.btn_forward.Size = new System.Drawing.Size(29, 25);
            this.btn_forward.Text = "toolStripButton2";
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_home
            // 
            this.btn_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_home.Name = "btn_home";
            this.btn_home.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.btn_home.Size = new System.Drawing.Size(29, 25);
            this.btn_home.Text = "toolStripButton3";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // combox_URL
            // 
            this.combox_URL.Items.AddRange(new object[] {
            "https://google.com"});
            this.combox_URL.Name = "combox_URL";
            this.combox_URL.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.combox_URL.Size = new System.Drawing.Size(500, 28);
            this.combox_URL.Text = "URL";
            this.combox_URL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combox_URL_KeyPress);
            // 
            // btn_download
            // 
            this.btn_download.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_download.Image = ((System.Drawing.Image)(resources.GetObject("btn_download.Image")));
            this.btn_download.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(29, 25);
            this.btn_download.Text = "toolStripButton4";
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_sourcesCode
            // 
            this.btn_sourcesCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_sourcesCode.Image = ((System.Drawing.Image)(resources.GetObject("btn_sourcesCode.Image")));
            this.btn_sourcesCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sourcesCode.Name = "btn_sourcesCode";
            this.btn_sourcesCode.Size = new System.Drawing.Size(29, 25);
            this.btn_sourcesCode.Text = "toolStripButton5";
            this.btn_sourcesCode.Click += new System.EventHandler(this.btn_sourcesCode_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 31);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(847, 502);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 533);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_Bai4";
            this.Text = "Form_Bai4";
            this.Load += new System.EventHandler(this.Form_Bai4_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_back;
        private System.Windows.Forms.ToolStripButton btn_forward;
        private System.Windows.Forms.ToolStripButton btn_home;
        private System.Windows.Forms.ToolStripComboBox combox_URL;
        private System.Windows.Forms.ToolStripButton btn_download;
        private System.Windows.Forms.ToolStripButton btn_sourcesCode;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}