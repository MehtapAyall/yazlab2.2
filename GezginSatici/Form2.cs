using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GezginSatici
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static string kullanici = "admin";
        static string sifre1 = "1234";
        private void button1_Click(object sender, EventArgs e)
        {
            if (ad.Text == kullanici && sifre.Text == sifre1)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
        }

        private void sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
