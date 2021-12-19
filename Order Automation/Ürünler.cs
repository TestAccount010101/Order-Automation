using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Automation
{
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void Ürünler_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Marka", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Tür", typeof(string));
            table.Columns.Add("Marka1", typeof(string));
            table.Columns.Add("Model1", typeof(string));
            table.Columns.Add("Tür1", typeof(string));

            dataGridView1.DataSource = table;
            string[] lines = File.ReadAllLines("ürünler.txt");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int k = 0; k < values.Length; k++)
                {
                    row[k] = values[k].Trim();
                }
                table.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
