
namespace Dashboard
{
    partial class Form_ViewSourceCode
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
            this.rich_html = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rich_html
            // 
            this.rich_html.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_html.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_html.Location = new System.Drawing.Point(0, 0);
            this.rich_html.Name = "rich_html";
            this.rich_html.ReadOnly = true;
            this.rich_html.Size = new System.Drawing.Size(800, 450);
            this.rich_html.TabIndex = 0;
            this.rich_html.Text = "";
            // 
            // Form_ViewSourceCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rich_html);
            this.Name = "Form_ViewSourceCode";
            this.Text = "Form_ViewSourceCode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rich_html;
    }
}