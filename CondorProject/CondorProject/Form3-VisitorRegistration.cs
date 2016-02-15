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
    public partial class Form3_VisitorRegistration : Form
    {
        int id;
        public Form3_VisitorRegistration(int id)
        {
            InitializeComponent();
            this.id = id;

        }

        public Form3_VisitorRegistration()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValidated() == true)
            {
                visitorTableAdapter.InsertQuery(txtBoxFirstName.Text, txtBoxLastName.Text, cmbBoxGender.Text, txtBoxRelation.Text, txtBoxPurpose.Text, pickerTimeIn.Text, id);
                this.Hide();
                Form4_VisitorResult form4 = new Form4_VisitorResult();
                form4.Closed += (s, args) => this.Close();
                form4.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_VisitorRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Visitor' table. You can move, or remove it, as needed.
            this.visitorTableAdapter.Fill(this.condorDatabaseDataSet.Visitor);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure you want to Log-out?", "Log-out Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)  // error is here
            {
                this.Hide();
                Form2_FacilitatorLogin form2 = new Form2_FacilitatorLogin();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4_VisitorResult form4 = new Form4_VisitorResult();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
