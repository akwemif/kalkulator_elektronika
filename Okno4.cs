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
    public partial class Okno4 : Form
    {
        Form1 f1;
        public Okno4()
        {
            InitializeComponent();
        }
        public Okno4(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void Okno4_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string y = "";
            int k1, k2, k3, k4, entire;
            k1 = comboBox1.SelectedIndex;
            k2 = comboBox2.SelectedIndex;
            k3 = comboBox3.SelectedIndex;
            k4 = comboBox4.SelectedIndex;
            if ( k1 == -1 || k2 == -1 || k3 == -1 || k4 == -1 )
            {
                y = "Błąd";
            }
            else
            {
                entire = ( k1 + 1 ) * 10 + k2;
                switch(k3)
                {
                    case 0:
                        y = Convert.ToString( entire) + " ";
                        break;
                    case 1:
                        y = Convert.ToString( entire * 10);
                        break;
                    case 2:
                        y = Convert.ToString( entire * 100 );
                        break;
                    case 3:
                        y = Convert.ToString( entire ) + "k";
                        break;
                    case 4:
                        y = Convert.ToString( entire * 10 ) + "k";
                        break;
                    case 5:
                        y = Convert.ToString( entire * 100 ) + "k";
                        break;
                    case 6:
                        y = Convert.ToString( entire ) + "M";
                        break;
                    case 7:
                        y = Convert.ToString( entire * 10 ) + "M";
                        break;
                    case 8:
                        y = Convert.ToString( entire * 0.1 );
                        break;
                    case 9:
                        y = Convert.ToString( entire * 0.01 );
                        break;
                    default:
                        y = "Błąd";
                        break;
                }
                switch (k4)
                {
                    case 0:
                        y = y + " 1%";
                        break;
                    case 1:
                        y = y + " 2%";
                        break;
                    case 2:
                        y = y + " 0,5%";
                        break;
                    case 3:
                        y = y + " 0,25%";
                        break;
                    case 4:
                        y = y + " 0,1%";
                        break;
                    case 5:
                        y = y + " 0,05%";
                        break;
                    case 6:
                        y = y + " 5%";
                        break;
                    case 7:
                        y = y + " 10%";
                        break;
                    default:
                        y = "Błąd";
                        break;
                }
            }
            textBox9.Text = y;
        }
    }
}
