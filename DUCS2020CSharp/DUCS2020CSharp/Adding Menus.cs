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
    public partial class Adding_Menus : Form
    {
        public Adding_Menus()
        {
            InitializeComponent();
        }

        private void mnuShowCV_Click(object sender, EventArgs e)
        {
            CVForm CV = new CVForm();
            CV.Show();
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                textBox1.Copy();
            }
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                textBox1.Paste();
            }
        }

        private void mnuViewTextBoxes_Click(object sender, EventArgs e)
        {

        }

        private void mnuViewLabels_Click(object sender, EventArgs e)
        {

        }

        private void mnuViewImages_Click(object sender, EventArgs e)
        {
            openFD.Title = "Insert an image";
            openFD.Filter = "JPEG Images|*.jpg|GIF Files|*.gif";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFD.FileName = "";
            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled");
                return;
            }
            string Chosen_file = openFD.FileName;
            picBox.Image = Image.FromFile(Chosen_file);
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you really sure to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
