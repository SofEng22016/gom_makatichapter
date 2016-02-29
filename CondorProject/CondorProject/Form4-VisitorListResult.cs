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
    public partial class Form4_VisitorListResult : Form
    {
        public Form4_VisitorListResult()
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
            this.visitorTableAdapter.GetDataBy1(txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text);
            this.visitorTableAdapter.FillBy(this.condorDatabaseDataSet.Visitor, txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text);
            txtboxSearch.Text = "";
        }

        private void displayTime(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("MM/dd/yyyy" + " " + "hh:mm:ss tt");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 0)
            {
                MessageBox.Show("Please select a row to update.");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int visitorID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                    this.Hide();
                    Form5_UpdateEntry form5 = new Form5_UpdateEntry(visitorID);
                    form5.Closed += (s, args) => this.Close();
                    form5.Show();
                }
            }
        }

        private void Form4_VisitorResult_FormClosing(object sender, FormClosingEventArgs e)
        {
             //TODO Facilitator credential validation for closing. (Another form for closing the program)
             //do not hide the previous form. just overlap with logout and disable.
        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            int visitorID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
            string timeOut = this.visitorTableAdapter.GetTimeOutQuery(visitorID);
            if (string.IsNullOrEmpty(timeOut))
            {
                this.visitorTableAdapter.UpdateTimeOutQuery(lblDateAndTime.Text, visitorID);
                this.visitorTableAdapter.Fill(this.condorDatabaseDataSet.Visitor);
                
            }
            else
            {
                MessageBox.Show("The visitor you selected has already timed out.");
            }
        }

    }
}
