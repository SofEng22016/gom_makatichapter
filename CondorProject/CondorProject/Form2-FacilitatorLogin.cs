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
    public partial class Form2_FacilitatorLogin : Form
    {
        int id;
        public Form2_FacilitatorLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((int)facilitatorTableAdapter.LoginQuery(txtBoxUserName.Text, txtBoxPassword.Text) == 1)
            {
                id=(int)facilitatorTableAdapter.GetIdQuery(txtBoxUserName.Text,txtBoxPassword.Text);
                this.Hide();
                Form3_VisitorRegistration form3 = new Form3_VisitorRegistration(id);
                form3.Closed += (s, args) => this.Close();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Details!");
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FacilitatorLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Facilitator' table. You can move, or remove it, as needed.
            this.facilitatorTableAdapter.Fill(this.condorDatabaseDataSet.Facilitator);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
