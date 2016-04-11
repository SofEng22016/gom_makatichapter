using System;
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
            facilitatorTableAdapter.Fill(condorDatabaseDataSet.Facilitator);
            lblFacilitatorID.Text = condorDatabaseDataSet.Facilitator[param - 1].idFacilitator.ToString();
            txtBoxFirstName.Text = condorDatabaseDataSet.Facilitator[param - 1].firstName;
            txtBoxLastName.Text = condorDatabaseDataSet.Facilitator[param - 1].lastName;
            txtBoxUserName.Text = condorDatabaseDataSet.Facilitator[param - 1].userName;
            //txtBoxOldPassword.Text = condorDatabaseDataSet.Facilitator[param - 1].password;
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValidated() && !string.IsNullOrWhiteSpace(txtBoxOldPassword.Text))
            {
                facilitatorTableAdapter.UpdateQuery(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxNewPassword.Text, txtBoxUserName.Text, param);
                MessageBox.Show("Facilitator record has been updated.");
                Hide();
                Form6_FacilitatorList form6 = new Form6_FacilitatorList();
                form6.Closed += (s, args) => Close();
                form6.Show();
            }
            else if (isValidated() && string.IsNullOrWhiteSpace(txtBoxOldPassword.Text))
            {
                facilitatorTableAdapter.UpdateQuery1(txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxUserName.Text, param);
                MessageBox.Show("Facilitator record has been updated.");
                Hide();
                Form6_FacilitatorList form6 = new Form6_FacilitatorList();
                form6.Closed += (s, args) => Close();
                form6.Show();
            }

        }

        private void Form8_UpdateFacilitator_Load(object sender, EventArgs e)
        {
            facilitatorTableAdapter.Fill(condorDatabaseDataSet.Facilitator);
        }

        private void facilitatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            facilitatorBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(condorDatabaseDataSet);
        }

        public bool isValidated()
        {
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
            if (!string.IsNullOrWhiteSpace(txtBoxOldPassword.Text))
            {
                if (txtBoxOldPassword.Text != condorDatabaseDataSet.Facilitator[param - 1].password)
                {
                    errorProvider1.SetError(txtBoxOldPassword, "Your old password does not match the one entered.");
                    check = false;
                }
                if (string.IsNullOrWhiteSpace(txtBoxNewPassword.Text))
                {
                    errorProvider1.SetError(txtBoxNewPassword, "Please fill in the required fields.");
                    check = false;
                }
                if (string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text))
                {
                    errorProvider1.SetError(txtBoxConfirmPassword, "Please fill in the required fields.");
                    check = false;
                }
                if (txtBoxNewPassword.Text != txtBoxConfirmPassword.Text)
                {
                    errorProvider1.SetError(txtBoxConfirmPassword, "The password entered does not match.");
                    check = false;
                }
            }
            
            /*
             if (txtBoxPassword.Text != txtBoxConfirmPassword.Text && txtBoxNewPassword.Text != txtBoxConfirmPassword.Text)
            {
                errorProvider1.SetError(txtBoxConfirmPassword, "The password entered does not match.");
                check = false;
            }
             */
            return check;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Form6_FacilitatorList form6 = new Form6_FacilitatorList();
            form6.Closed += (s, args) => Close();
            form6.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "CONDOR Visitor Management System", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
