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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String Gender;
            String SelectedLang = "";
            if (rdMale.Checked)
            {
                Gender = rdMale.Text;
            }
            else
            {
                Gender = rdFemale.Text;
            }
            if (checkCS.Checked)
            {
                SelectedLang += checkCS.Text + "\n";
            }
            if (checkASP.Checked)
            {
                SelectedLang += checkASP.Text + "\n";
            }
            if (checkVB.Checked)
            {
                SelectedLang += checkVB.Text + "\n";
            }
            string StudentLocation = listCity.Text;

            MessageBox.Show("Name: " + txtName.Text + "\nAddress: " + txtAddress.Text + "\nCity: " + StudentLocation + "\nGender: " + Gender + "\nStudy Language: " + SelectedLang + "\n", "Student Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);       }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
