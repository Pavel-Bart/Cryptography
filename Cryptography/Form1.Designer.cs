
namespace Cryptography
{
    partial class Form1
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
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnTDES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(12, 67);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(169, 49);
            this.btnMD5.TabIndex = 0;
            this.btnMD5.Text = "MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // btnTDES
            // 
            this.btnTDES.Location = new System.Drawing.Point(220, 67);
            this.btnTDES.Name = "btnTDES";
            this.btnTDES.Size = new System.Drawing.Size(169, 49);
            this.btnTDES.TabIndex = 1;
            this.btnTDES.Text = "TDES";
            this.btnTDES.UseVisualStyleBackColor = true;
            this.btnTDES.Click += new System.EventHandler(this.btnTDES_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 208);
            this.Controls.Add(this.btnTDES);
            this.Controls.Add(this.btnMD5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Button btnTDES;
    }
}

