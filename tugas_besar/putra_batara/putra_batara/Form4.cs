using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace putra_batara
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GEUR785;Initial Catalog=ram;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string asa = "INSERT INTO penjualan_sawit(no_plat,nama,jenis_mobil,berat_masuk,berat_keluar,berat_bersih,tanggal) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Text + "')";
            SqlDataAdapter ABS = new SqlDataAdapter(asa, con);
            ABS.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("berhasil menambah");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string asa = "UPDATE penjualan_sawit SET no_plat ='" + textBox2.Text + "',nama='" + textBox3.Text + "',jenis_mobil='" + textBox4.Text + "',berat_masuk='" + textBox5.Text + "',berat_keluar='" + textBox6.Text + "',berat_bersih='" + textBox7.Text + "',tanggal='" + dateTimePicker1.Text + "'WHERE id_keluar='" + textBox1.Text + "'";
            SqlDataAdapter ABS = new SqlDataAdapter(asa, con);
            ABS.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("update berhasil");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string asa = "DELETE FROM penjualan_sawit where id_keluar='" + textBox1.Text + "'";
            SqlDataAdapter ABS = new SqlDataAdapter(asa, con);
            ABS.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("berhasil dihapus");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            con.Open();
            string asa = "SELECT *FROM penjualan_sawit";
            SqlDataAdapter ABS = new SqlDataAdapter(asa, con);
            DataTable dt = new DataTable();
            ABS.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 pilih = new Form2();
            pilih.Show();
            this.Hide();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            double berat = double.Parse(textBox5.Text);
            double kosong = double.Parse(textBox6.Text);
            textBox7.Text = (berat - kosong).ToString();
        }
    }
}
