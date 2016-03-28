using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            Validate();
            facilitatorBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(condorDatabaseDataSet);

        }

        private void Form6_FacilitatorList_Load(object sender, EventArgs e)
        {
            facilitatorTableAdapter.Fill(condorDatabaseDataSet.Facilitator);

            Timer tmr = new Timer();
         
                tmr.Interval = 1000;
                tmr.Tick += new EventHandler(displayTime);
                tmr.Start();
       
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Hide();
            Form8_UpdateFacilitator form8 = new Form8_UpdateFacilitator(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
            form8.Closed += (s, args) => Close();
            form8.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Hide();
            Form7_CreateFacilitator form7 = new Form7_CreateFacilitator();
            form7.Closed += (s, args) => Close();
            form7.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Delete?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int facilitatorID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                facilitatorTableAdapter.DeleteQuery(facilitatorID);
                facilitatorTableAdapter.Fill(condorDatabaseDataSet.Facilitator);
            }
        }

        private void displayTime(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("MM/dd/yyyy" + " " + "hh:mm:ss tt");
        }
        /*
        private void btnCreatePDF_Click(object sender, EventArgs e)
        {
            exportToPDF(facilitatorTableAdapter.GetData());
            MessageBox.Show("Print Success.");
        }

        private void exportToPDF(DataTable dt)
        {
            using (Document document = new Document())
            {
                string title = "System Report (Facilitator)_" + DateTime.Now.ToString("MM-dd-yyyy") + ".pdf";
                using (PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(title, FileMode.Create)))
                {
                    HeaderFooter hf = new HeaderFooter();
                    writer.SetBoxSize("art", new Rectangle(36, 54, 220, 820));
                    writer.PageEvent = hf;
                    document.Open();
                    Font font5 = FontFactory.GetFont(FontFactory.HELVETICA, 5);
                    PdfPTable table = new PdfPTable(dt.Columns.Count);
                    float[] widths = new float[] { 4f, 4f, 4f, 4f, 4f };
                    table.SetWidths(widths);
                    table.WidthPercentage = 100;
                    PdfPCell cell = new PdfPCell(new Phrase("Facilitators"));
                    cell.Colspan = dt.Columns.Count;
                    foreach (DataColumn c in dt.Columns)
                    {
                        table.AddCell(new Phrase(c.ColumnName, font5));
                    }
                    foreach (DataRow r in dt.Rows)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            table.AddCell(new Phrase(r[0].ToString(), font5));
                            table.AddCell(new Phrase(r[1].ToString(), font5));
                            table.AddCell(new Phrase(r[2].ToString(), font5));
                            table.AddCell(new Phrase(r[3].ToString(), font5));
                            table.AddCell(new Phrase(r[4].ToString(), font5));
                        }
                    }
                    document.Add(table);
                    document.Close();
                }
            }
        }
        */
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Log-out?", "Confirm Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)  // error is here
            {
                Hide();
                Form2_FacilitatorLogin form2 = new Form2_FacilitatorLogin();
                form2.Closed += (s, args) => Close();
                form2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "CONDOR Visitor Management System", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void lblDateAndTime_Click(object sender, EventArgs e)
        {

        }
    }
}
