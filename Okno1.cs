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
    public partial class Okno1 : Form
    {
        public double s1, s2, s3, s4, s5, s6;

        private void Button2_Click(object sender, EventArgs e)
        {
            string y;
            double s3 = double.Parse(textBox3.Text);
            double s4 = double.Parse(textBox4.Text);
            double s6 = (s3*s4)/(s3+s4);
            y = Convert.ToString(s6);
            textBox6.Text = y;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string x;
            double s1 = double.Parse(textBox1.Text);
            double s2 = double.Parse(textBox2.Text);
            double s5 = s1 + s2;
            x = Convert.ToString(s5);
            textBox5.Text = x;
        }

       

        Form1 f1;
        public Okno1()
        {
            InitializeComponent();
        }
        public Okno1(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void Okno1_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Visible = true;
        }
    }
}
