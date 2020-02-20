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
    public partial class MenuBarEx : Form
    {
        public MenuBarEx()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you really sure to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                Application.Exit();
            }
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
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
            mnuViewTextBoxes.Checked = !mnuViewTextBoxes.Checked;
            if (mnuViewTextBoxes.Checked)
            {
                textBox1.Visible = textBox2.Visible = true;
            }
            else
            {
                textBox1.Visible = textBox2.Visible = false;
            }
        }

        private void MenuBarEx_Load(object sender, EventArgs e)
        {
            mnuViewTextBoxes.Checked = mnuViewLabels.Checked = true;
        }

        private void mnuViewImages_Click(object sender, EventArgs e)
        {
            openFD.Title = "Insert an image";
            openFD.Filter = "JPEG Images|*.jpg|GIF Files|*.gif|All Files|*.*";
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

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openFD.Title = "Open a text file";
            openFD.Filter = "Text File|*.txt";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFD.FileName = "";
            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled");
                return;
            }
            string Chosen_file = openFD.FileName;
            richTextBox1.LoadFile(Chosen_file, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFD.Title = "Save a text file";
            saveFD.InitialDirectory = "C:";
            saveFD.FileName = "";
            if (saveFD.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled");
                return;
            }
            string Saved_file = saveFD.FileName;
            richTextBox1.SaveFile(Saved_file, RichTextBoxStreamType.PlainText);
        }

        private void viewFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
