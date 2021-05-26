
namespace Cryptography
{
    partial class MainForm
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
            this.groupBoxMD5 = new System.Windows.Forms.GroupBox();
            this.btnMD5EncodeFile = new System.Windows.Forms.Button();
            this.btnMD5SelectFile = new System.Windows.Forms.Button();
            this.btnMD5Encode = new System.Windows.Forms.Button();
            this.txtMD5EncodedFileString = new System.Windows.Forms.TextBox();
            this.txtMD5InitialFile = new System.Windows.Forms.TextBox();
            this.txtEncodedMD5String = new System.Windows.Forms.TextBox();
            this.txtInitialMD5String = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gropBoxTDES = new System.Windows.Forms.GroupBox();
            this.txtTDESStringDecode = new System.Windows.Forms.Button();
            this.txtTDESDecodedString = new System.Windows.Forms.TextBox();
            this.txtTDESEncodedString = new System.Windows.Forms.TextBox();
            this.txtTDESPassword = new System.Windows.Forms.TextBox();
            this.txtTDESInitialString = new System.Windows.Forms.TextBox();
            this.txtTDESStringEncode = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxMD5.SuspendLayout();
            this.gropBoxTDES.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMD5
            // 
            this.groupBoxMD5.Controls.Add(this.btnMD5EncodeFile);
            this.groupBoxMD5.Controls.Add(this.btnMD5SelectFile);
            this.groupBoxMD5.Controls.Add(this.btnMD5Encode);
            this.groupBoxMD5.Controls.Add(this.txtMD5EncodedFileString);
            this.groupBoxMD5.Controls.Add(this.txtMD5InitialFile);
            this.groupBoxMD5.Controls.Add(this.txtEncodedMD5String);
            this.groupBoxMD5.Controls.Add(this.txtInitialMD5String);
            this.groupBoxMD5.Controls.Add(this.label4);
            this.groupBoxMD5.Controls.Add(this.label3);
            this.groupBoxMD5.Controls.Add(this.label2);
            this.groupBoxMD5.Controls.Add(this.label1);
            this.groupBoxMD5.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMD5.Name = "groupBoxMD5";
            this.groupBoxMD5.Size = new System.Drawing.Size(989, 334);
            this.groupBoxMD5.TabIndex = 0;
            this.groupBoxMD5.TabStop = false;
            this.groupBoxMD5.Text = "MD5 Encryption";
            this.groupBoxMD5.Enter += new System.EventHandler(this.groupBoxMD5_Enter);
            // 
            // btnMD5EncodeFile
            // 
            this.btnMD5EncodeFile.Enabled = false;
            this.btnMD5EncodeFile.Location = new System.Drawing.Point(221, 265);
            this.btnMD5EncodeFile.Name = "btnMD5EncodeFile";
            this.btnMD5EncodeFile.Size = new System.Drawing.Size(151, 50);
            this.btnMD5EncodeFile.TabIndex = 9;
            this.btnMD5EncodeFile.Text = "Encode file";
            this.btnMD5EncodeFile.UseVisualStyleBackColor = true;
            this.btnMD5EncodeFile.Click += new System.EventHandler(this.btnMD5EncodeFile_Click);
            // 
            // btnMD5SelectFile
            // 
            this.btnMD5SelectFile.Location = new System.Drawing.Point(685, 158);
            this.btnMD5SelectFile.Name = "btnMD5SelectFile";
            this.btnMD5SelectFile.Size = new System.Drawing.Size(109, 30);
            this.btnMD5SelectFile.TabIndex = 8;
            this.btnMD5SelectFile.Text = "...";
            this.btnMD5SelectFile.UseVisualStyleBackColor = true;
            this.btnMD5SelectFile.Click += new System.EventHandler(this.btnMD5SelectFile_Click);
            // 
            // btnMD5Encode
            // 
            this.btnMD5Encode.Location = new System.Drawing.Point(11, 265);
            this.btnMD5Encode.Name = "btnMD5Encode";
            this.btnMD5Encode.Size = new System.Drawing.Size(151, 50);
            this.btnMD5Encode.TabIndex = 0;
            this.btnMD5Encode.Text = "Encode";
            this.btnMD5Encode.UseVisualStyleBackColor = true;
            this.btnMD5Encode.Click += new System.EventHandler(this.btnMD5Encode_Click);
            // 
            // txtMD5EncodedFileString
            // 
            this.txtMD5EncodedFileString.Location = new System.Drawing.Point(238, 214);
            this.txtMD5EncodedFileString.Name = "txtMD5EncodedFileString";
            this.txtMD5EncodedFileString.Size = new System.Drawing.Size(423, 26);
            this.txtMD5EncodedFileString.TabIndex = 7;
            // 
            // txtMD5InitialFile
            // 
            this.txtMD5InitialFile.Location = new System.Drawing.Point(238, 158);
            this.txtMD5InitialFile.Name = "txtMD5InitialFile";
            this.txtMD5InitialFile.ReadOnly = true;
            this.txtMD5InitialFile.Size = new System.Drawing.Size(423, 26);
            this.txtMD5InitialFile.TabIndex = 6;
            // 
            // txtEncodedMD5String
            // 
            this.txtEncodedMD5String.Location = new System.Drawing.Point(238, 103);
            this.txtEncodedMD5String.Name = "txtEncodedMD5String";
            this.txtEncodedMD5String.Size = new System.Drawing.Size(423, 26);
            this.txtEncodedMD5String.TabIndex = 5;
            // 
            // txtInitialMD5String
            // 
            this.txtInitialMD5String.Location = new System.Drawing.Point(238, 52);
            this.txtInitialMD5String.Name = "txtInitialMD5String";
            this.txtInitialMD5String.Size = new System.Drawing.Size(423, 26);
            this.txtInitialMD5String.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Encoded file string";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Initial file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encoded string";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial string";
            // 
            // gropBoxTDES
            // 
            this.gropBoxTDES.Controls.Add(this.txtTDESStringDecode);
            this.gropBoxTDES.Controls.Add(this.txtTDESDecodedString);
            this.gropBoxTDES.Controls.Add(this.txtTDESEncodedString);
            this.gropBoxTDES.Controls.Add(this.txtTDESPassword);
            this.gropBoxTDES.Controls.Add(this.txtTDESInitialString);
            this.gropBoxTDES.Controls.Add(this.txtTDESStringEncode);
            this.gropBoxTDES.Controls.Add(this.label9);
            this.gropBoxTDES.Controls.Add(this.label7);
            this.gropBoxTDES.Controls.Add(this.label6);
            this.gropBoxTDES.Controls.Add(this.label5);
            this.gropBoxTDES.Location = new System.Drawing.Point(12, 357);
            this.gropBoxTDES.Name = "gropBoxTDES";
            this.gropBoxTDES.Size = new System.Drawing.Size(989, 334);
            this.gropBoxTDES.TabIndex = 1;
            this.gropBoxTDES.TabStop = false;
            this.gropBoxTDES.Text = "TDES Encryption";
            this.gropBoxTDES.Enter += new System.EventHandler(this.gropBoxTDES_Enter);
            // 
            // txtTDESStringDecode
            // 
            this.txtTDESStringDecode.Location = new System.Drawing.Point(238, 267);
            this.txtTDESStringDecode.Name = "txtTDESStringDecode";
            this.txtTDESStringDecode.Size = new System.Drawing.Size(147, 35);
            this.txtTDESStringDecode.TabIndex = 16;
            this.txtTDESStringDecode.Text = "Decode";
            this.txtTDESStringDecode.UseVisualStyleBackColor = true;
            this.txtTDESStringDecode.Click += new System.EventHandler(this.txtTDESStringDecode_Click);
            // 
            // txtTDESDecodedString
            // 
            this.txtTDESDecodedString.Location = new System.Drawing.Point(238, 182);
            this.txtTDESDecodedString.Name = "txtTDESDecodedString";
            this.txtTDESDecodedString.Size = new System.Drawing.Size(423, 26);
            this.txtTDESDecodedString.TabIndex = 15;
            // 
            // txtTDESEncodedString
            // 
            this.txtTDESEncodedString.Location = new System.Drawing.Point(238, 134);
            this.txtTDESEncodedString.Name = "txtTDESEncodedString";
            this.txtTDESEncodedString.Size = new System.Drawing.Size(423, 26);
            this.txtTDESEncodedString.TabIndex = 14;
            // 
            // txtTDESPassword
            // 
            this.txtTDESPassword.Location = new System.Drawing.Point(238, 89);
            this.txtTDESPassword.Name = "txtTDESPassword";
            this.txtTDESPassword.Size = new System.Drawing.Size(423, 26);
            this.txtTDESPassword.TabIndex = 13;
            // 
            // txtTDESInitialString
            // 
            this.txtTDESInitialString.Location = new System.Drawing.Point(238, 47);
            this.txtTDESInitialString.Name = "txtTDESInitialString";
            this.txtTDESInitialString.Size = new System.Drawing.Size(423, 26);
            this.txtTDESInitialString.TabIndex = 10;
            // 
            // txtTDESStringEncode
            // 
            this.txtTDESStringEncode.Location = new System.Drawing.Point(25, 267);
            this.txtTDESStringEncode.Name = "txtTDESStringEncode";
            this.txtTDESStringEncode.Size = new System.Drawing.Size(147, 35);
            this.txtTDESStringEncode.TabIndex = 12;
            this.txtTDESStringEncode.Text = "Encode";
            this.txtTDESStringEncode.UseVisualStyleBackColor = true;
            this.txtTDESStringEncode.Click += new System.EventHandler(this.txtTDESStringEncode_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Original text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Encoded string";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Initial string";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 844);
            this.Controls.Add(this.gropBoxTDES);
            this.Controls.Add(this.groupBoxMD5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxMD5.ResumeLayout(false);
            this.groupBoxMD5.PerformLayout();
            this.gropBoxTDES.ResumeLayout(false);
            this.gropBoxTDES.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMD5;
        private System.Windows.Forms.GroupBox gropBoxTDES;
        private System.Windows.Forms.Button btnMD5Encode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMD5EncodedFileString;
        private System.Windows.Forms.TextBox txtMD5InitialFile;
        private System.Windows.Forms.TextBox txtEncodedMD5String;
        private System.Windows.Forms.TextBox txtInitialMD5String;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMD5EncodeFile;
        private System.Windows.Forms.Button btnMD5SelectFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtTDESStringDecode;
        private System.Windows.Forms.TextBox txtTDESDecodedString;
        private System.Windows.Forms.TextBox txtTDESEncodedString;
        private System.Windows.Forms.TextBox txtTDESPassword;
        private System.Windows.Forms.TextBox txtTDESInitialString;
        private System.Windows.Forms.Button txtTDESStringEncode;
    }
}