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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (StreamReader sr = new StreamReader(@"D:/anak.txt"))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Text = line;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 pilih = new Form2();
            pilih.Show();
            this.Hide();
        }
    }
}
