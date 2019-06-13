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
    public partial class Okno5 : Form
    {
        public double s1, s2, s3, s9;
        Form1 f1;
        public Okno5()
        {
            InitializeComponent();
        }
        public Okno5(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void Okno5_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string y;
            double s1 = double.Parse(textBox1.Text);
            double s2 = double.Parse(textBox2.Text);
            double s3 = double.Parse(textBox3.Text);
            double s9 = (s3/(s1+s2))*s2;
            y = Convert.ToString(s9);
            textBox9.Text = y;
        }
    }
}
