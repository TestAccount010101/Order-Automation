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
    public partial class Saticiform : Form
    {
        int tiklama = 0;
        public Saticiform()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void Saticiform_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Marka", typeof(string));
            table.Columns.Add("Model", typeof(string));
            table.Columns.Add("Tür", typeof(string));
            dataGridView2.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tiklama ++;
            if (tiklama % 2 ==1)
            {
                string[] lines = File.ReadAllLines("vars2.txt");
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
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Saticiform mn = new Saticiform();
            this.Hide();
            mn.Show();
        }
    }
}
