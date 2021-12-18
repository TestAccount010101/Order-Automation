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

namespace Order_Automation
{
    public partial class Müsterikayit : Form
    {
        public Müsterikayit()
        {
            InitializeComponent();
        }
        public bool IsPasswordsEqual(string password1, string password2)
        {
            if (password1.Equals(password2))
            {
                return true;
            }

            return false;
        }


        private void BtnKydt_Click(object sender, EventArgs e)
        {
            if (!IsPasswordsEqual(Txtsifre.Text, TxtsifreTekrar.Text))
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }
            else
            {
                if (File.Exists("vars.txt"))
                {

                    if (TxtAd.Text == " ")
                    {
                        MessageBox.Show("Herhangi bir giriş yapmadınız");
                    }
                    else
                    {
                        StreamWriter SW;
                        SW = File.AppendText("vars.txt");
                        SW.WriteLine("");
                        SW.WriteLine(Txt_Kullaniciad.Text + " " + Txtsifre.Text + " " + TxtAd.Text + " " + TxtSoyad.Text + " " + TxtAdres.Text);
                        SW.Close();
                        MessageBox.Show("Kayıt Eklendi!");
                        TxtAd.Text = "";
                        TxtSoyad.Text = "";
                        Txt_Kullaniciad.Text = "";
                        Txtsifre.Text = "";
                        TxtsifreTekrar.Text = "";
                        TxtAdres.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("https://www.youtube.com/watch?v=E5rAuWLTTao");
                }
            }
        }

        private void Müsterikayit_Load(object sender, EventArgs e)
        {

        }
    }
}
