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
    public partial class MultiplyTable : Form
    {
        public MultiplyTable()
        {
            InitializeComponent();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            
            int loopStart, loopEnd;
            bool isNumber1 = int.TryParse(txtBox1.Text, out loopStart);
            bool isNumber2 = int.TryParse(txtBox2.Text, out loopEnd);
            int multiplyBy = 3;
            if (!isNumber1 || !isNumber2)
            {
                MessageBox.Show("Please Enter Numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = loopStart; i <= loopEnd; i++)
            {
                int result = i * multiplyBy;
                listBox1.Items.Add(multiplyBy + " * " + i + " = " + result);
            }
        }
    }
}
