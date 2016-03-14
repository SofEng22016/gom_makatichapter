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

        private void btnAccountLogIn_Click(object sender, EventArgs e)
        {
            Hide();
            Form2_FacilitatorLogin form2 = new Form2_FacilitatorLogin();
            form2.Closed += (s, args) => Close(); 
            form2.Show();
        }
    }
}
