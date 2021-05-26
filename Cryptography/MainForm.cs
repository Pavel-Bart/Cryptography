using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Cryptography
{
    public partial class MainForm : Form
    {
        private string EncryptionMethod; //property

        public MainForm(string encryptionAlgorythm) // konstruktorium
        {
            InitializeComponent();
            this.EncryptionMethod = encryptionAlgorythm;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(EncryptionMethod);

            //Setinam formos view pagal pasirinkta algoritma
            switch (EncryptionMethod)
            {
                case "MD5":
                    groupBoxMD5.Visible = true;
                    gropBoxTDES.Visible = false;
                    break;

                case "TDES":
                    groupBoxMD5.Visible = false;
                    gropBoxTDES.Visible = true;

                    gropBoxTDES.Location = groupBoxMD5.Location;
                    break;


                default:
                    break;
            }

        }

        private void btnMD5Encode_Click(object sender, EventArgs e)
        {
            txtEncodedMD5String.Text = Crypto.MD5EncodeString(txtInitialMD5String.Text);
        }

        private void btnMD5EncodeFile_Click(object sender, EventArgs e)
        {
            txtMD5EncodedFileString.Text = Crypto.MD5EncodeFile(File.ReadAllBytes(txtMD5InitialFile.Text)); //Paduodam funkcijai Path
        }

        private void btnMD5SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtMD5InitialFile.Text = fileDialog.FileName;
                btnMD5EncodeFile.Enabled = true;
            }
        }

        private void groupBoxMD5_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTDESStringEncode_Click(object sender, EventArgs e)
        {
            txtTDESEncodedString.Text = Crypto.TDESEncodeString(txtTDESInitialString.Text , txtTDESPassword.Text);
        }

        private void txtTDESStringDecode_Click(object sender, EventArgs e)
        {
            txtTDESDecodedString.Text = Crypto.TDESDecodeString(txtTDESEncodedString.Text, txtTDESPassword.Text);
        }

        private void gropBoxTDES_Enter(object sender, EventArgs e)
        {

        }
    }
}
