using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace putra_batara
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 pilih = new Form1();
            pilih.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 pilih = new Form3();
            pilih.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 pilih = new Form4();
            pilih.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 pilih = new Form5();
            pilih.Show();
            this.Hide();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 pilih = new Form6();
            pilih.Show();
            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("ss/MM/yyyy");
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
