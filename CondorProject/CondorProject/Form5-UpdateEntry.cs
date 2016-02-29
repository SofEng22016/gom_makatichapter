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
    public partial class Form5_UpdateEntry : Form
    {
        int param;
        public Form5_UpdateEntry()
        {
            InitializeComponent();
        }
        public Form5_UpdateEntry(int visitorID)
        {
            InitializeComponent();

            param = visitorID;
            this.visitorTableAdapter.Fill(this.condorDatabaseDataSet.Visitor);
            lblVisitorID.Text = condorDatabaseDataSet.Visitor[param - 1].idVisitor.ToString();
            txtBoxFirstName.Text = condorDatabaseDataSet.Visitor[param - 1].firstName;
            txtBoxLastName.Text = condorDatabaseDataSet.Visitor[param - 1].lastName;
            cmbBoxGender.Text = condorDatabaseDataSet.Visitor[param - 1].gender;
            txtBoxUnitNumber.Text = condorDatabaseDataSet.Visitor[param - 1].unitNumber;
            txtboxIdDetails.Text = condorDatabaseDataSet.Visitor[param - 1].idDetails;
            txtBoxRelation.Text = condorDatabaseDataSet.Visitor[param - 1].visitorRelation;
            txtBoxPurpose.Text = condorDatabaseDataSet.Visitor[param - 1].purposeOfVisit;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4_VisitorListResult form4 = new Form4_VisitorListResult();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                visitorTableAdapter.UpdateQuery(txtBoxFirstName.Text, txtBoxLastName.Text, cmbBoxGender.Text, txtBoxUnitNumber.Text, txtboxIdDetails.Text, txtBoxRelation.Text, txtBoxPurpose.Text, param);
                MessageBox.Show("Visitor record has been updated.");
                this.Hide();
                Form4_VisitorListResult form4 = new Form4_VisitorListResult();
                form4.Closed += (s, args) => this.Close();
                form4.Show();
            }
        }

        private void Form5_UpdateEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Visitor' table. You can move, or remove it, as needed.
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

            if (string.IsNullOrWhiteSpace(cmbBoxGender.Text))
            {
                errorProvider1.SetError(cmbBoxGender, "Please fill in the required fields.");
                check = false;
            }

            if (string.IsNullOrWhiteSpace(txtBoxUnitNumber.Text))
            {
                errorProvider1.SetError(txtBoxUnitNumber, "Please fill in the required fields.");
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

        
    }
}
