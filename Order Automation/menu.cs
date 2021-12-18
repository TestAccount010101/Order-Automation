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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Müsterigiris MM= new Müsterigiris();
            this.Hide();
            MM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Saticigiris MM = new Saticigiris();
            this.Hide();
            MM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Müsterikayit Mk = new Müsterikayit();
            this.Hide();
            Mk.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ödemeform sds = new Ödemeform();
            sds.Show();
            this.Hide();
        }
    }
}
