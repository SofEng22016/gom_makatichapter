using System;
using System.Windows.Forms;

namespace CondorProject
{
    public partial class Form7_CreateFacilitator : Form
    {
        public Form7_CreateFacilitator()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "CONDOR Visitor Management System", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                facilitatorTableAdapter.InsertQuery(txtBoxFirstName.Text,txtBoxLastName.Text,txtBoxPassword.Text,txtBoxUserName.Text);
                Hide();
                Form6_FacilitatorList form6 = new Form6_FacilitatorList();
                form6.Closed += (s, args) => Close();
                form6.Show();
            }
        }

        private void facilitatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            facilitatorBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(condorDatabaseDataSet);
        }

        private void facilitatorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            facilitatorBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(condorDatabaseDataSet);
        }

        private void Form7_CreateFacilitator_Load(object sender, EventArgs e)
        {
            facilitatorTableAdapter.Fill(condorDatabaseDataSet.Facilitator);
                Timer tmr = new Timer();
                tmr.Interval = 1000;
                tmr.Tick += new EventHandler(displayTime);
                tmr.Start();
            
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

        private void btnViewList_Click(object sender, EventArgs e)
        {
            Hide();
            Form6_FacilitatorList form6 = new Form6_FacilitatorList();
            form6.Closed += (s, args) => Close();
            form6.Show();
        }

        private void displayTime(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("MM/dd/yyyy" + " " + "hh:mm:ss tt");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblDateAndTime_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
