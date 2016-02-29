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
    public partial class Form7_CreateFacilitator : Form
    {
        public Form7_CreateFacilitator()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure you want to Log-out?", "Log-out Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form2_FacilitatorLogin form2 = new Form2_FacilitatorLogin();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                facilitatorTableAdapter.InsertQuery(txtBoxFirstName.Text,txtBoxLastName.Text,txtBoxPassword.Text,txtBoxUserName.Text);
                this.Hide();
                Form6_FacilitatorList form6 = new Form6_FacilitatorList();
                form6.Closed += (s, args) => this.Close();
                form6.Show();
            }
        }

        private void facilitatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facilitatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.condorDatabaseDataSet);

        }

        private void facilitatorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.facilitatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.condorDatabaseDataSet);

        }

        private void Form7_CreateFacilitator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Facilitator' table. You can move, or remove it, as needed.
            this.facilitatorTableAdapter.Fill(this.condorDatabaseDataSet.Facilitator);

            Timer tmr = new Timer();
            tmr.Interval = 1000;//ticks every 1 second
            tmr.Tick += new EventHandler(displayTime);
            tmr.Start();

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

        private void btnViewList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6_FacilitatorList form6 = new Form6_FacilitatorList();
            form6.Closed += (s, args) => this.Close();
            form6.Show();
        }

        private void displayTime(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("MM/dd/yyyy" + " " + "hh:mm:ss tt");
        }
    }
}
