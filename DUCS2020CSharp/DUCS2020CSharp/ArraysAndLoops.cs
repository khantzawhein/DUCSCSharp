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
    public partial class ArraysAndLoops : Form
    {
        public ArraysAndLoops()
        {
            InitializeComponent();
        }

        private void btnTwoDimen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int arrayRows = 5;
            int arrayCols = 3;
            int[,] arrayTimes = new int[arrayRows, arrayCols];
            int mult = 0;

            for (int i = 0; i < arrayRows; i++)
            {
                mult += 10;
                for (int j = 0; j < arrayCols; j++)
                {
                    arrayTimes[i, j] = mult;

                    listBox1.Items.Add("arrayPosition= " + i + "," + j + " val = " + mult);

                    mult *= 10;
                }
                mult /= 1000;
            }
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] lottery_number = new int[100];
            
            for (int i = 0; i < lottery_number.Length; i++)
            {
                lottery_number[i] = i + 1;
                listBox1.Items.Add(lottery_number[i]);
            }
        }

        private void btnTimesTable_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] aryTimes = new int[10];

            int times = int.Parse(textBox1.Text);
            for (int i = 1; i < aryTimes.Length; i++)
            {
                aryTimes[i] = i * times;
                listBox1.Items.Add(times + " * " + i + " = " + aryTimes[i]);
            }
        }

        private void btnArrOne_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] lottery_numbers = {1,2,3,4};
            for (int i = 0; i < lottery_numbers.Length; i++)
            {
                listBox1.Items.Add(lottery_numbers[i]);
            }
        }

        private void btnStringArr_Click(object sender, EventArgs e)
        {
            string[] arrayStrings = { "These", "are", " ", "string", "array" };
            listBox1.Items.Clear();
            for (int i = 0; i < arrayStrings.Length; i++)
            {
                listBox1.Items.Add(arrayStrings[i]);
            }
        }
    }
}
