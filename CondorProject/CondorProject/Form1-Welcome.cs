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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccountLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_FacilitatorLogin form2 = new Form2_FacilitatorLogin();
            form2.Closed += (s, args) => this.Close(); 
            form2.Show();
        }
    }
}
