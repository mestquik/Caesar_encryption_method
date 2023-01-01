using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SezarSifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtVeri_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            
            string veri = "";
            veri = txtVeri.Text;
            char[] karakterler = veri.ToCharArray();

            foreach (char eleman in karakterler)
            {
                txtSifreliVeri.Text += Convert.ToChar(eleman + 3).ToString();
            }
        }

        private void btnSifreyiCoz_Click(object sender, EventArgs e)
        {
            txtVeri.Clear();
            string veri = "";
            veri = txtSifreliVeri.Text;
            char[] karakterler = veri.ToCharArray();

            foreach (char eleman in karakterler)
            {
                txtVeri.Text += Convert.ToChar(eleman - 3).ToString();
            }
        }
    }
}
