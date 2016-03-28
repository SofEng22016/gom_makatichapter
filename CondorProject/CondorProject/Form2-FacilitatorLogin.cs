using System;
using System.Windows.Forms;

namespace CondorProject
{
    public partial class Form2_FacilitatorLogin : Form
    {
        int id;
        public Form2_FacilitatorLogin()
        {
            InitializeComponent();
        }

        private void Form2_FacilitatorLogin_Load(object sender, EventArgs e)
        {
            facilitatorTableAdapter.Fill(condorDatabaseDataSet.Facilitator);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (facilitatorTableAdapter.LoginQuery(txtBoxUserName.Text, txtBoxPassword.Text) == 1)
            {
                if (txtBoxUserName.Text.Equals(facilitatorTableAdapter.AdminUsernameQuery()) && txtBoxPassword.Text.Equals(facilitatorTableAdapter.AdminPasswordQuery()))
                {
                    Hide();
                    Form6_FacilitatorList form6 = new Form6_FacilitatorList();
                    form6.Closed += (s, args) => Close();
                    form6.Show();
                }
                else
                {
                    id = (int)facilitatorTableAdapter.GetIdQuery(txtBoxUserName.Text, txtBoxPassword.Text);
                    Hide();
                    Form3_VisitorRegistration form3 = new Form3_VisitorRegistration(id);
                    form3.Closed += (s, args) => Close();
                    form3.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Login Details!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => Close();
            form1.Show();
        }
    }
}
