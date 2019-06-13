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
    public partial class Okno3 : Form
    {
        Form1 f1;
        public Okno3()
        {
            InitializeComponent();
        }
        public Okno3(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void Okno3_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string y = "";
            int res = int.Parse(textBox1.Text);
            if (res < 100 || res > 999)
            {
                y = "Kod nie 3 cyfrowy";
            }
            else
            {
                switch (res % 10)
                {
                    case 0:
                        y = Convert.ToString( res / 10 );
                        break;
                    case 1:
                    case 2:
                        y = Convert.ToString( res / 10 * (int)Math.Pow( 10, res % 10 ) );
                        break;
                    case 3:
                        y = Convert.ToString( res / 10 ) + "k ";
                        break;
                    case 4:
                    case 5:
                        y = Convert.ToString( res / 10 * (int)Math.Pow( 10, ( res - 3 ) % 10 ) ) + "k ";
                        break;
                    case 6:
                        y = Convert.ToString( res / 10 ) + "M ";
                        break;
                    case 7:
                    case 8:
                        y = Convert.ToString( res / 10 * (int)Math.Pow( 10, ( res - 6 ) % 10 ) ) + "M ";
                        break;
                    case 9:
                        y = Convert.ToString( res / 10 ) + "G ";
                        break;
                    default:
                        y = "Błąd";
                        break;
                }
                if (checkBox1.Checked)
                {
                    y = y + " 1%";
                }
                else
                {
                    y = y + " 5%";
                }
            }
            textBox9.Text = y;
        }
    }
}

