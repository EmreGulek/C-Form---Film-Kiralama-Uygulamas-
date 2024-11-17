using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FilmKiralamaUygulaması
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string telno = maskedTextBox1.Text;
            string id = maskedTextBox2.Text;
            decimal kiraGünü = numericUpDown2.Value;
            decimal gunlukUcret = numericUpDown1.Value; // Kullanıcının girdiği günlük kira ücreti

            string path = @"\\Mac\Home\Downloads\müşteri.txt";
            string message = $"{name},{surname},{telno},{id},{kiraGünü},{gunlukUcret}";

            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            tablo.Rows.Add(maskedTextBox2.Text, textBox1.Text, textBox2.Text, numericUpDown2.Value*numericUpDown1.Value, maskedTextBox1.Text, numericUpDown2.Value);
            dataGridView1.DataSource = tablo;
        }
        DataTable tablo=new DataTable();
        private void Form3_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("Film ID", typeof(string));
            tablo.Columns.Add("Müşteri İsim", typeof(string));
            tablo.Columns.Add("Müşteri Soyad", typeof(string));
            tablo.Columns.Add("Ücret", typeof(string));
            tablo.Columns.Add("Telefon No", typeof(string));
            tablo.Columns.Add("Gün Sayısı", typeof(string));
            dataGridView1.DataSource = tablo;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
            private void liste_Click(object sender, EventArgs e)
            {
            
                // Film listesini al
                List<Film> filmler = Film.FilmleriListele();

                // ListView kontrolüne filmleri ekle
                foreach (Film film in filmler)
                {
                    ListViewItem item = new ListViewItem(new[] { film.ID, film.AD, film.UCRET });
                    listView1.Items.Add(item);
                }
            }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
    }
