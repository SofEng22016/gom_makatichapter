using System;
using System.Windows.Forms;

namespace CondorProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "CONDOR Visitor Management System", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void btnAccountLogIn_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form2_FacilitatorLogin form2 = new Form2_FacilitatorLogin();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
    }
}
