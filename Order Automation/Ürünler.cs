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
    }
}
