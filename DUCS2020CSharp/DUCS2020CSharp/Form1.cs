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
            MenuBarEx menu1 = new MenuBarEx();
            menu1.Show();
        }
    }
}
