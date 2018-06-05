using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace putra_batara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(this, "tolong isi data", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show(this, "tolong isi data", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox1.Text == "ahlun" && textBox2.Text == "12344")
                {
                    Form2 pilihan = new Form2();
                    pilihan.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show(this, "nama atau password anda salah\nsilahkan ulang", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
