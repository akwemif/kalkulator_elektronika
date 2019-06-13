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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Okno3 o3 = new Okno3(this);
            this.Visible = false;
            o3.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Okno1 o1 = new Okno1(this);
            this.Visible = false;
            o1.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Okno2 o2 = new Okno2(this);
            this.Visible = false;
            o2.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Okno4 o4 = new Okno4(this);
            this.Visible = false;
            o4.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Okno5 o5 = new Okno5(this);
            this.Visible = false;
            o5.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Okno6 o6 = new Okno6(this);
            this.Visible = false;
            o6.ShowDialog();
        }
    }
}
