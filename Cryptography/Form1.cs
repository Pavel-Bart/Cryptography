using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnMD5_Click(object sender, EventArgs e)
        {
            new MainForm("MD5").ShowDialog();
        }

        private void btnTDES_Click(object sender, EventArgs e)
        {
            new MainForm("TDES").ShowDialog();
        }
    }
}
