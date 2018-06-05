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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GEUR785;Initial Catalog=ram;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string asa = "INSERT INTO karyawan(nama,jabatan,jenis_kelamin,tanggal_lahir) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','"+comboBox1.Text+"','" + dateTimePicker1.Text + "')";
            SqlDataAdapter ABS = new SqlDataAdapter(asa, con);
            ABS.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("berhasil menambah");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string asa = "UPDATE karyawan SET nama ='" + textBox2.Text + "',jabatan='" + textBox3.Text + "',jenis_kelamin='" + comboBox1.Text + "',tanggal_lahir='" + dateTimePicker1.Text + "'WHERE id_karyawan='" + textBox1.Text + "'";
            SqlDataAdapter ABS = new SqlDataAdapter(asa, con);
            ABS.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("update berhasil");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string asa = "DELETE FROM karyawan where id_karyawan='" + textBox1.Text + "'";
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
            con.Open();
            string asa = "SELECT *FROM karyawan";
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
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 pilih = new Form2();
            pilih.Show();
            this.Hide();
        }
    }
}
