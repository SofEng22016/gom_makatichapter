using System;
using System.Windows.Forms;

namespace CondorProject
{
    public partial class Form5_UpdateEntry : Form
    {
        int param;
        int id;
        public Form5_UpdateEntry()
        {
            InitializeComponent();
        }
        public Form5_UpdateEntry(int visitorID,int id)
        {
            InitializeComponent();

            param = visitorID;
            visitorTableAdapter.Fill(condorDatabaseDataSet.Visitor);
            lblVisitorID.Text = condorDatabaseDataSet.Visitor[param - 1].idVisitor.ToString();
            txtBoxFirstName.Text = condorDatabaseDataSet.Visitor[param - 1].firstName;
            txtBoxLastName.Text = condorDatabaseDataSet.Visitor[param - 1].lastName;
            cmbBoxGender.Text = condorDatabaseDataSet.Visitor[param - 1].gender;
            cmbBoxUnitNumber.Text = condorDatabaseDataSet.Visitor[param - 1].unitNumber;
            txtboxIdDetails.Text = condorDatabaseDataSet.Visitor[param - 1].idDetails;
            txtBoxRelation.Text = condorDatabaseDataSet.Visitor[param - 1].visitorRelation;
            txtBoxPurpose.Text = condorDatabaseDataSet.Visitor[param - 1].purposeOfVisit;
            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Form4_VisitorListResult form4 = new Form4_VisitorListResult(this.id);
            form4.Closed += (s, args) => Close();
            form4.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                visitorTableAdapter.UpdateQuery(txtBoxFirstName.Text, txtBoxLastName.Text, cmbBoxGender.Text, cmbBoxUnitNumber.Text, txtboxIdDetails.Text, txtBoxRelation.Text, txtBoxPurpose.Text, param);
                MessageBox.Show("Visitor record has been updated.");
                Hide();
                Form4_VisitorListResult form4 = new Form4_VisitorListResult(this.id);
                form4.Closed += (s, args) => Close();
                form4.Show();
            }
        }

        private void Form5_UpdateEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Visitor' table. You can move, or remove it, as needed.
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

            if (string.IsNullOrWhiteSpace(cmbBoxGender.Text))
            {
                errorProvider1.SetError(cmbBoxGender, "Please fill in the required fields.");
                check = false;
            }

            if (string.IsNullOrWhiteSpace(cmbBoxUnitNumber.Text))
            {
                errorProvider1.SetError(cmbBoxUnitNumber, "Please fill in the required fields.");
                check = false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxPurpose.Text))
            {
                errorProvider1.SetError(txtBoxPurpose, "Please fill in the required fields.");
                check = false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxRelation.Text))
            {
                errorProvider1.SetError(txtBoxRelation, "Please fill in the required fields.");
                check = false;
            }
            return check;
        }

        private void txtBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar!='-')
            {
                e.Handled = true;
            }
               
        }

        private void txtBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            Form3_VisitorRegistration form3 = new Form3_VisitorRegistration();
            form3.Closed += (s, args) => Close();
            form3.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "CONDOR Visitor Management System", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
