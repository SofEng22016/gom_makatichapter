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
    public partial class Form6_FacilitatorList : Form
    {
        public Form6_FacilitatorList()
        {
            InitializeComponent();
        }

        private void facilitatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facilitatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.condorDatabaseDataSet);

        }

        private void Form6_FacilitatorList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Facilitator' table. You can move, or remove it, as needed.
            this.facilitatorTableAdapter.Fill(this.condorDatabaseDataSet.Facilitator);

            Timer tmr = new Timer();
            tmr.Interval = 1000;//ticks every 1 second
            tmr.Tick += new EventHandler(displayTime);
            tmr.Start();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8_UpdateFacilitator form8 = new Form8_UpdateFacilitator(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
            form8.Closed += (s, args) => this.Close();
            form8.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7_CreateFacilitator form7 = new Form7_CreateFacilitator();
            form7.Closed += (s, args) => this.Close();
            form7.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure you want to Delete?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int facilitatorID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                facilitatorTableAdapter.DeleteQuery(facilitatorID);
                this.facilitatorTableAdapter.Fill(this.condorDatabaseDataSet.Facilitator);
            }
        }
            

        private void displayTime(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("MM/dd/yyyy" + " " + "hh:mm:ss tt");
        }
    }
}
