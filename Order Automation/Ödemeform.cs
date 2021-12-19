using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Automation
{
    public partial class Ödemeform : Form
    {
        public Ödemeform()
        {
            InitializeComponent();
        }

        private void Ödemeform_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Kredi Kartı")
            {
                panel2.Enabled = true;
                panel1.Enabled = false;
                panel3.Enabled = false;
            }
            else if (comboBox1.Text == "Nakit")
            {

                panel2.Enabled = false;
                panel1.Enabled = true;
                panel3.Enabled = false;

            }
            else if (comboBox1.Text == "Çek")
            {

                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
