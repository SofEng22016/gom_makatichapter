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
        public Form2_FacilitatorLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_VisitorRegistration form3 = new Form3_VisitorRegistration();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FacilitatorLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
