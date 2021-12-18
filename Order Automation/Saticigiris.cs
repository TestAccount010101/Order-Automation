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
    public partial class Saticigiris : Form
    {
        public Saticigiris()
        {
            InitializeComponent();
        }
        string[] kullanici_adi = { "deneme1", "deneme2" };
        string[] Parola = { "sifre1", "sifre2" };
        List<string> kgiris = new List<string>();
        List<string> ksifre = new List<string>();
        private void Saticigiris_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("vars.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                kgiris.Add(components[0]);
                ksifre.Add(components[1]);
            }
            sr.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Saticiform sf = new Saticiform();

            if (kullanici_adi.Contains(textBox1.Text) && Parola.Contains(textBox2.Text) && Parola[Array.IndexOf(kullanici_adi, textBox1.Text)] == textBox2.Text)
            {
                this.Hide();
                sf.ShowDialog();
            }
            else if (kgiris.Contains(textBox1.Text) && ksifre.Contains(textBox2.Text) && ksifre[kgiris.IndexOf(textBox1.Text)] == textBox2.Text)
            {
                this.Hide();
                sf.ShowDialog();
            }
            else

                MessageBox.Show("Kullanıcı Adı yada şifre yanlış");
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "Kullanıcı adı şifre yanlış!!";
        }
    }
}
