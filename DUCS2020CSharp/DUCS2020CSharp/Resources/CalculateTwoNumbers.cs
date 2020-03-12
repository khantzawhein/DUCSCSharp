using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DUCS2020CSharp.Resources
{
    public partial class CalculateTwoNumbers : Form
    {
        public CalculateTwoNumbers()
        {
            InitializeComponent();
        }

        private void CalculateTwoNumbers_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int answer = int.Parse(txtFirstNum.Text) - int.Parse(txtSecondNum.Text);
            txtAns.Text = answer.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int answer = int.Parse(txtFirstNum.Text) / int.Parse(txtSecondNum.Text);
            txtAns.Text = answer.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int answer = int.Parse(txtFirstNum.Text) * int.Parse(txtSecondNum.Text);
            txtAns.Text = answer.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtFirstNum.Text = txtSecondNum.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int answer = int.Parse(txtFirstNum.Text) + int.Parse(txtSecondNum.Text);
            txtAns.Text = answer.ToString();
        }
    }
}
