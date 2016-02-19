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
    public partial class Form4_VisitorResult : Form
    {
        public Form4_VisitorResult()
        {
            InitializeComponent();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form3_VisitorRegistration form3 = new Form3_VisitorRegistration();
                form3.Closed += (s, args) => this.Close();
                form3.Show();
        }

        private void Form4_VisitorResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Visitor' table. You can move, or remove it, as needed.

            Timer tmr = new Timer();
            tmr.Interval = 1000;//ticks every 1 second
            tmr.Tick += new EventHandler(displayTime);
            tmr.Start();
            
            this.visitorTableAdapter.Fill(this.condorDatabaseDataSet.Visitor);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.visitorTableAdapter.GetDataBy(txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text);
            this.visitorTableAdapter.FillBy(this.condorDatabaseDataSet.Visitor, txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text);
            txtboxSearch.Text = "";
        }


        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
       
        }

        private void displayTime(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("MM/dd/yyyy" + " " + "hh:mm:ss tt");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    this.Hide();
                    Form5_UpdateEntry form5 = new Form5_UpdateEntry(row.Cells[0].Value.ToString());
                    form5.Closed += (s, args) => this.Close();
                    form5.Show();
                }
            }
            else if (selectedRowCount == 0)
            {
                MessageBox.Show("Please select a row to update.");
            }
            else
            {
                MessageBox.Show("Please select only one row to update.");
            }
        }

        private void Form4_VisitorResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                //TODO Facilitator credential validation for closing. (Another form for closing the program)
                //do not hide the previous form. just overlap with logout and disable.
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            //will update timeout and also move row from datagridview1 to datagridview2
        }

    }
}
