using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int vize, final, perf, ort;
                vize = Convert.ToInt16(textBox1.Text);
                final = Convert.ToInt16(textBox2.Text);
                perf = Convert.ToInt16(textBox3.Text);
                ort = (vize * 30 / 100) + (final * 60 / 100) + (perf * 10 / 100);
                textBox4.Text = "Ortalamanız: " + ort.ToString();
            }
            catch
            {
                MessageBox.Show("Sadece sayı karakteri girin!");
            }

        }
    }
}
