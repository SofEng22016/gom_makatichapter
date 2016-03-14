using System;
using System.Windows.Forms;

namespace CondorProject
{
    public partial class Form3_VisitorRegistration : Form
    {
        int id;
        int idOwner;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                visitor1TableAdapter.InsertQuery(txtBoxFirstName.Text, txtBoxLastName.Text, cmbBoxGender.Text, cmbBoxUnitNumber.Text,txtboxIdDetails.Text, txtBoxRelation.Text, txtBoxPurpose.Text, lblDateAndTimeEntry.Text, this.id, idOwner);
              //visitorTableAdapter.Update(condorDatabaseDataSet.Visitor);
                Hide();
                Form4_VisitorListResult form4 = new Form4_VisitorListResult(this.id);
                form4.Closed += (s, args) => Close();
                form4.Show();
            }
        }

        private void Form3_VisitorRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Visitor' table. You can move, or remove it, as needed.
            this.visitorTableAdapter.Fill(this.condorDatabaseDataSet.Visitor);
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Visitor' table. You can move, or remove it, as needed.
            this.visitorTableAdapter.Fill(this.condorDatabaseDataSet.Visitor);
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Visitor1' table. You can move, or remove it, as needed.



            //visitorTableAdapter.Fill(condorDatabaseDataSet.Visitor);
                Timer tmr = new Timer();
                tmr.Interval = 1000;
                tmr.Tick += new EventHandler(displayTime);
                tmr.Start();

               
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Log-out?", "Log-out Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Hide();
                Form2_FacilitatorLogin form2 = new Form2_FacilitatorLogin();
                form2.Closed += (s, args) => Close();
                form2.Show();
            }
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            Hide();
            Form4_VisitorListResult form4 = new Form4_VisitorListResult(this.id);
            form4.Closed += (s, args) => Close();
            form4.Show();
        }

        private void displayTime(object sender, EventArgs e)
        {
            lblDateAndTimeEntry.Text = DateTime.Now.ToString("MM/dd/yyyy" + " " + "hh:mm:ss tt");
        }

        
        private void txtBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '-')
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

       

        private void cmbBoxUnitNumber_TextChanged(object sender, EventArgs e)
        {
            idOwner = (int)ownerTableAdapter1.GetIDQuery(cmbBoxUnitNumber.Text);
        }
    }
}
