using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2._0
{
    public partial class Form1 : Form
    {
        decimal v1 = 0; 
        decimal v2 = 0;
        string operadores = "";
        bool click = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tela.Text == "0")
            {
                tela.Text = "";
                tela.Text = "7";
            }
            else
            {
                tela.Text += "7";
            }
            if (click == true)
            {
                tela.Text = "";
                tela.Text += "7";
                click = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (tela.Text == "0")
            {
                tela.Text = "";
                tela.Text = "1";
            }
            else
            {
                tela.Text += "1";
            }

            if (click == true)
            {
                tela.Text = "";
                tela.Text += "1";
                click = false;
            }
        }

        private void bsoma_Click(object sender, EventArgs e)
        {
                v1 = decimal.Parse(tela.Text ,CultureInfo.InvariantCulture);
                operadores = "soma";
                tela.Text = "";
                labelv1.Text = Convert.ToString(v1);
                bsoma.BackColor = Color.White; 
        }

        private void bigual_Click(object sender, EventArgs e)
        {
            
            click = true;
            if (tela.Text == "")
            {
                v2 = v1;
            }
            else
            {
                v2 = decimal.Parse(tela.Text, CultureInfo.InvariantCulture);
            }
            
            if (operadores == "soma")
            {
                tela.Text = Convert.ToString(v1 + v2);
                labelv1.Text = "";
            }
            else if ( operadores == "sub")
            {
                tela.Text = Convert.ToString(v1 - v2);
                labelv1.Text = "";
            }
            else if (operadores == "mult")
            {
                tela.Text = Convert.ToString(v1 * v2);
                labelv1.Text = ""; 
            }
            else if (tela.Text == "")
            {
                tela.Text = Convert.ToString(v1); 
            } 
            else if (operadores == "div" && v2 != 0)
            {
                tela.Text = Convert.ToString(v1 / v2);
                labelv1.Text = "";
            } 
            else if (operadores == "div" && v2 == 0)
            {
                tela.Text = "Erro";
            }
            bsoma.BackColor = Color.Black;
            bdiv.BackColor = Color.Black;
            bmult.BackColor = Color.Black;
            bdiv.BackColor = Color.Black;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (tela.Text == "0")
            {
                tela.Text = "";
                tela.Text = "2";
            }
            else
            {
                tela.Text += "2";
            }
            if (click == true)
            {
                tela.Text = "";
                tela.Text += "2";
                click = false;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (tela.Text == "0")
            {
                tela.Text = "";
                tela.Text = "3";
            }
            else
            {
                tela.Text += "3";
            }
            if (click == true)
            {
                tela.Text = "";
                tela.Text += "3";
                click = false; 
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if ( tela.Text == "0")
            {
                tela.Text = "";
                tela.Text = "4";
            }
            else
            {
                tela.Text += "4";
            }
            if (click == true)
            {
                tela.Text = "";
                tela.Text += "4";
                click = false; 
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (tela.Text == "0")
            {
                tela.Text = "";
                tela.Text = "5";
            }
            else
            {
                tela.Text += "5";
            }
            if (click == true)
            {
                tela.Text = "";
                tela.Text += "5";
                click = false;
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (tela.Text == "0")
            {
                tela.Text = "";
                tela.Text = "6";
            }
            else
            {
                tela.Text += "6";
            }
            if (click == true)
            {
                tela.Text = "";
                tela.Text += "6";
                click = false;
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (tela.Text == "0")
            {
                tela.Text = "";
                tela.Text = "8";
            }
            else
            {
                tela.Text += "8";
            }
            if (click == true)
            {
                tela.Text = "";
                tela.Text += "8";
                click = false;
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (tela.Text == "0")
            {
                tela.Text = "";
                tela.Text = "9";
            }
            else
            {
                tela.Text += "9";
            }
            if (click == true)
            {
                tela.Text = "";
                tela.Text += "9";
                click = false;
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (tela.Text == "0")
            {
                tela.Text = "";
                tela.Text = "0";
            }
            else
            {
                tela.Text += "0";
            }
            if (click == true)
            {
                tela.Text = "";
                tela.Text += "0";
                click = false;
            }
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            v1 = decimal.Parse(tela.Text, CultureInfo.InvariantCulture);
            operadores = "sub";
            tela.Text = "";
            labelv1.Text = Convert.ToString(v1);
            bsoma.BackColor = Color.White;
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            v1 = decimal.Parse(tela.Text, CultureInfo.InvariantCulture);
            operadores = "mult";
            tela.Text = "";
            labelv1.Text = Convert.ToString(v1);
            bmult.BackColor = Color.White;
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            v1 = decimal.Parse(tela.Text, CultureInfo.InvariantCulture);
            operadores = "div";
            tela.Text = "";
            labelv1.Text = Convert.ToString(v1);
            bdiv.BackColor = Color.White;
        }

        private void bc_Click(object sender, EventArgs e)
        {
            tela.Text = "";
            labelv1.Text = "";
            operadores = "";
            bsoma.BackColor = Color.Black;
            bdiv.BackColor = Color.Black;
            bmult.BackColor = Color.Black;
            bdiv.BackColor = Color.Black;

        }

        private void bce_Click(object sender, EventArgs e)
        {
            tela.Text = "";
        }

        private void bponto_Click(object sender, EventArgs e)
        {
            tela.Text += ".";
        }

        private void bponto_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
 }
