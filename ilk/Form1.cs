using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ilk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string telefon = mtxtTelefon.Text;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(telefon))
            {
                MessageBox.Show("hata");
            }
            else
            {
                lstAD.Items.Add(ad.Substring(0, 1).ToUpper() + ad.Substring(1));
                lstSoyad.Items.Add(soyad.ToUpper());
                lstEmail.Items.Add(ad + soyad +"@bil.omu.edu.tr");
                lstTelefon.Items.Add(telefon);
            }
        }
    }
}
