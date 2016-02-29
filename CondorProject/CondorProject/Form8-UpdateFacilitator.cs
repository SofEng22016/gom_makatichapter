using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CondorProject
{
    public partial class Form8_UpdateFacilitator : Form
    {
        int param;

        public Form8_UpdateFacilitator()
        {
            InitializeComponent();
        }

        public Form8_UpdateFacilitator(string facilitatorID)
        {
            InitializeComponent();

            param = Convert.ToInt32(facilitatorID);
            this.facilitatorTableAdapter.Fill(this.condorDatabaseDataSet.Facilitator);
            lblFacilitatorID.Text = condorDatabaseDataSet.Facilitator[param - 1].idFacilitator.ToString();
            txtBoxFirstName.Text = condorDatabaseDataSet.Facilitator[param - 1].firstName;
            txtBoxLastName.Text = condorDatabaseDataSet.Facilitator[param - 1].lastName;
            txtBoxUserName.Text = condorDatabaseDataSet.Facilitator[param - 1].userName;
            txtBoxPassword.Text = condorDatabaseDataSet.Facilitator[param - 1].password;
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                //query for update
                facilitatorTableAdapter.UpdateQuery(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxPassword.Text, txtBoxUserName.Text, param);
                MessageBox.Show("Facilitator record has been updated.");
                this.Hide();
                Form6_FacilitatorList form6 = new Form6_FacilitatorList();
                form6.Closed += (s, args) => this.Close();
                form6.Show();
            }
        }

        private void Form8_UpdateFacilitator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Facilitator' table. You can move, or remove it, as needed.
            this.facilitatorTableAdapter.Fill(this.condorDatabaseDataSet.Facilitator);

        }

        private void facilitatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facilitatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.condorDatabaseDataSet);

        }

        public bool isValidated()
        {
            // Check the if there's an empty field/s.
            errorProvider1.Clear();
            bool check = true;

            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text))
            {
                errorProvider1.SetError(txtBoxFirstName, "Please fill in the required fields.");
                check = false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxLastName.Text))
            {
                errorProvider1.SetError(txtBoxLastName, "Please fill in the required fields.");
                check = false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxUserName.Text))
            {
                errorProvider1.SetError(txtBoxUserName, "Please fill in the required fields.");
                check = false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                errorProvider1.SetError(txtBoxPassword, "Please fill in the required fields.");
                check = false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text))
            {
                errorProvider1.SetError(txtBoxConfirmPassword, "Please fill in the required fields.");
                check = false;
            }

            if (txtBoxPassword.Text != txtBoxConfirmPassword.Text)
            {
                errorProvider1.SetError(txtBoxConfirmPassword, "The password entered does not match.");
                check = false;
            }

            return check;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6_FacilitatorList form6 = new Form6_FacilitatorList();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
        }
    }
}
