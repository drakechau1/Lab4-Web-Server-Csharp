
namespace Dashboard
{
    partial class Form_Bai1
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
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.rich_html = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_URL
            // 
            this.txt_URL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_URL.Location = new System.Drawing.Point(26, 20);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(623, 30);
            this.txt_URL.TabIndex = 0;
            this.txt_URL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_URL_KeyPress);
            // 
            // btn_get
            // 
            this.btn_get.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_get.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get.Location = new System.Drawing.Point(669, 14);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(91, 43);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "GET";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // rich_html
            // 
            this.rich_html.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rich_html.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_html.Location = new System.Drawing.Point(26, 75);
            this.rich_html.Name = "rich_html";
            this.rich_html.ReadOnly = true;
            this.rich_html.Size = new System.Drawing.Size(734, 457);
            this.rich_html.TabIndex = 2;
            this.rich_html.Text = "";
            // 
            // Form_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 552);
            this.Controls.Add(this.rich_html);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.txt_URL);
            this.Name = "Form_Bai1";
            this.Text = "Form_Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.RichTextBox rich_html;
    }
}