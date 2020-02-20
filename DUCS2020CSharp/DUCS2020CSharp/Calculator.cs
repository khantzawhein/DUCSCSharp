using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DUCS2020CSharp
{
    public partial class Calculator : Form
    {
        double total1, total2 = 0;
        char Operator = '+';
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnOne.Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (Operator == '+')
            {
                total1 += Double.Parse(txtDisplay.Text);
            }
            else if (Operator == '/')
            {
                total1 /= Double.Parse(txtDisplay.Text);
            }
            txtDisplay.Clear();
            Operator = '/';

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Operator == '+')
            {
                total1 += Double.Parse(txtDisplay.Text);
            }
            else if (Operator == '-')
            {
                total1 -= Double.Parse(txtDisplay.Text);
            }
            txtDisplay.Clear();
            Operator = '-';

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (Operator == '+')
            {
                total1 += Double.Parse(txtDisplay.Text);
            }
            else if (Operator == '*')
            {
                total1 *= Double.Parse(txtDisplay.Text);
            }
            txtDisplay.Clear();
            Operator = '*';

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Operator == '+')
            {
                total1 += Double.Parse(txtDisplay.Text);
            }
            else if (Operator == '-')
            {
                total1 -= Double.Parse(txtDisplay.Text);
            }
            txtDisplay.Clear();
            Operator = '+';
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnZero.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnDot.Text;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (Operator)
            {
                case '+':
                    {
                        total2 = total1 + double.Parse(txtDisplay.Text);
                        break;
                    }
                case '*':
                    {
                        total2 = total1 * double.Parse(txtDisplay.Text);
                        break;
                    }
                case '-':
                    {
                        total2 = total1 - double.Parse(txtDisplay.Text);
                        break;
                    }
                case '/':
                    {
                        total2 = total1 / double.Parse(txtDisplay.Text);
                        break;
                    }
            }
            txtDisplay.Text = total2.ToString();
            Operator = '+';
            total1 = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Operator = '+';
            total1 = total2 = 0;
            txtDisplay.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
