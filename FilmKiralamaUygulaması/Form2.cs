using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmKiralamaUygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string dosyaYolu = @"\\Mac\Home\Downloads\Filmler.txt";
            Console.ReadLine();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Film adı",typeof(string));
            table.Columns.Add("Film Türü", typeof(string));
            table.Columns.Add("Film ID", typeof(string));
            dataGridView1.DataSource= table;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"\\Mac\Home\Downloads\Filmler.txt");
            string[] values;
            for(int i = 0;i< lines.Length; i++)
            {
                values = lines[i].ToString().Split('-');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                } 
                table.Rows.Add(row);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            
        }
    }
}
