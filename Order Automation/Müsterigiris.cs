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
    public partial class Müsterigiris : Form
    {
        public Müsterigiris()
        {
            InitializeComponent();
        }
        string[] usernames = { "username1", "username2" };
        string[] password = { "password1", "password2" };
        List<string> users = new List<string>();
        List<string> pass = new List<string>();
        Ürünler urun = new Ürünler();

        private void Müsterigiris_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("vars.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] komut = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                users.Add(komut[0]);
                pass.Add(komut[1]);
            }
            sr.Close();
        }
        private void Btn_Mgiris_Click(object sender, EventArgs e)
        {
            if (usernames.Contains(TxtKullanici.Text) && password.Contains(TxtKpass.Text) && password[Array.IndexOf(usernames, TxtKullanici.Text)] == TxtKpass.Text)
            {
                this.Hide();
                urun.ShowDialog();
            }
            else if (users.Contains(TxtKullanici.Text) && pass.Contains(TxtKpass.Text) && pass[users.IndexOf(TxtKullanici.Text)] == TxtKpass.Text)
            {
                this.Hide();
                urun.ShowDialog();
            }
            else
                MessageBox.Show("Kullanıcı adı şifre yanlış.");
                label3.Text = "Kullanıcı adı şifre yanlış!!";
                TxtKullanici.Text = "";
                TxtKpass.Text = "";
        }
    }
}
