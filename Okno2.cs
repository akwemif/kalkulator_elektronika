using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apka
{
    public partial class Okno2 : Form
    {
        public double s1, s2, s3, s4, s5, s6, s7, s8, s9;
        Form1 f1;
        public Okno2()
        {
            InitializeComponent();
        }
        public Okno2(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void Okno2_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string y;
            double s1 = double.Parse(textBox1.Text);
            double s3 = double.Parse(textBox3.Text);
            double s7 = s1/s3;
            y = Convert.ToString(s7);
            textBox7.Text = y;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string y;
            double s2 = double.Parse(textBox2.Text);
            double s4 = double.Parse(textBox4.Text);
            double s8 = s2/s4;
            y = Convert.ToString(s8);
            textBox8.Text = y;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string y;
            double s5 = double.Parse(textBox5.Text);
            double s6 = double.Parse(textBox6.Text);
            double s9 = s5*s6;
            y = Convert.ToString(s9);
            textBox9.Text = y;
        }
    }
}
