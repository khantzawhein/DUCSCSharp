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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void BtnMultiplyTable_Click(object sender, EventArgs e)
        {
            MultiplyTable m1 = new MultiplyTable();
            m1.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Calculator c1 = new Calculator();
            c1.Show();
        }

        private void btnMenuBarEx_Click(object sender, EventArgs e)
        {
            Adding_Menus menu1 = new Adding_Menus();
            menu1.Show();
        }

        private void btnCalculateTwoNum_Click(object sender, EventArgs e)
        {
            CalculateTwoNumbers cal1 = new CalculateTwoNumbers();
            cal1.Show();
        }

        private void btnArrandLoops_Click(object sender, EventArgs e)
        {
            ArraysAndLoops arr1 = new ArraysAndLoops();
            arr1.Show();
        }

        private void btnUserForm_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }
    }
}
