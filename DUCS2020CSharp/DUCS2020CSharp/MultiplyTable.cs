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
            int loopStart = int.Parse(txtBox1.Text);
            int loopEnd = int.Parse(txtBox2.Text);
            int multiplyBy = 3;

            for (int i = loopStart; i <= loopEnd; i++)
            {
                int result = i * multiplyBy;
                listBox1.Items.Add(multiplyBy + " * " + i + " = " + result);
            }
        }
    }
}
