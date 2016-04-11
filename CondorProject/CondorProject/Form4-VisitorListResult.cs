using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CondorProject
{
    public partial class Form4_VisitorListResult : Form
    {
       
        int id;
        public Form4_VisitorListResult()
        {
            InitializeComponent();
        }

        public Form4_VisitorListResult(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form3_VisitorRegistration form3 = new Form3_VisitorRegistration(this.id);
            form3.Closed += (s, args) => Close();
            form3.Show();
        }

        private void Form4_VisitorResult_Load(object sender, EventArgs e)
        {
            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(displayTime);
            
            tmr.Start();

            txtFacilitator.Text = "Welcome " + facilitatorTableAdapter1.GetFacilitatorFirstNameQuery(id).ToString();
            comboBox1.SelectedIndex = 0;
            //this.visitor1TableAdapter.Fill(this.condorDatabaseDataSet.Visitor1);
            //visitor1TableAdapter.GetDay(time);
            visitor1TableAdapter.FillDay(condorDatabaseDataSet.Visitor1,DateTime.Now.ToString("MM/dd/yyyy"));
            disableTimeOutBtnChecker();
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            visitor1TableAdapter.GetDataBy(txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text);
            visitor1TableAdapter.FillBy(condorDatabaseDataSet.Visitor1, txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text);
            txtboxSearch.Text = "";
        }

        private void displayTime(object sender, EventArgs e)
        {
            lblDateAndTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
           
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 0)
            {
                MessageBox.Show("Please select a row to update.");
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to change details of Visitor ID No. " + dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString() + " ?", "Update Visitor Entry", MessageBoxButtons.YesNo);

                    int visitorID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());

                    if (dialogResult == DialogResult.Yes)  // error is here
                    {
                        Hide();
                        Form5_UpdateEntry form5 = new Form5_UpdateEntry(visitorID, this.id);
                        form5.Closed += (s, args) => Close();
                        form5.ShowDialog();
                    }
                }
            }
        }

        private void Form4_VisitorResult_FormClosing(object sender, FormClosingEventArgs e)
        {
             //TODO Facilitator credential validation for closing. (Another form for closing the program)
             //do not hide the previous form. just overlap with logout and disable.
        }

        private void btnTimeOut_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Time-out? ", "Time-out Visitor Entry", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)  // error is here
            {
                int visitorID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                visitor1TableAdapter.UpdateTimeOutQuery1(lblDateAndTime.Text, visitorID);
                //visitor1TableAdapter.Fill(condorDatabaseDataSet.Visitor1);
                //visitor1TableAdapter.FillDay(condorDatabaseDataSet.Visitor1, DateTime.Now.ToString("MM/dd/yyyy"));
                btnGenerate_Click(sender, e);
                MessageBox.Show("Successfully timed out visitor.");
            }

            

        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {

            if (txtboxSearch.Text != "")
            {
                //Form4_VisitorResult_Load(sender, e);
                visitor1TableAdapter.GetDataBy(txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text);
                visitor1TableAdapter.FillBy(condorDatabaseDataSet.Visitor1, txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text, txtboxSearch.Text);
                ///visitor1TableAdapter.Fill(this.condorDatabaseDataSet.Visitor1);
            }
            else
            {
                visitor1TableAdapter.FillDay(condorDatabaseDataSet.Visitor1, DateTime.Now.ToString("MM/dd/yyyy"));
            }
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtboxSearch.Text = "";
            Form4_VisitorResult_Load(sender, e);
        }

        private void txtboxSearch_Click(object sender, EventArgs e)
        {
            txtboxSearch.ForeColor = System.Drawing.Color.Black;
            txtboxSearch.Text = "";
        }

        private void btnCreatePDF_Click_1(object sender, EventArgs e)
        {
           
            Form9_GeneratePDF form9 = new Form9_GeneratePDF();
            form9.Closed += (s, args) => Close();
            form9.ShowDialog();

            //exportToPDF(visitor1TableAdapter.GetData());
            //MessageBox.Show("Print Success.");
        }

        private void exportToPDF(DataTable dt)
        {
            Document document = new Document(PageSize.LEDGER, 10, 10, 42, 35);
            
                string title = "System Report (Visitor)_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pdf";
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(title, FileMode.Create));
                
                    HeaderFooter hf = new HeaderFooter();
                    writer.SetBoxSize("art", new Rectangle(36, 54, 220, 760));
                    writer.PageEvent = hf;

                    document.Open();

                    var logo = CondorProject.Properties.Resources.textCondor;
                    var logoCondor = iTextSharp.text.Image.GetInstance(logo, BaseColor.WHITE);
                    logoCondor.Alignment = Image.ALIGN_CENTER;
                    document.Add(logoCondor);

                    Font font5 = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                    Font font6 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                    Font headerFont = FontFactory.GetFont(FontFactory.COURIER_BOLD, 18);

                    Paragraph labelHeader = new Paragraph("VISITOR LIST", headerFont);
                    labelHeader.Alignment = Element.ALIGN_CENTER;
                    labelHeader.SpacingAfter = 20;
                    document.Add(labelHeader);


                    PdfPTable table = new PdfPTable(dt.Columns.Count);
                    float[] widths = new float[] { 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f, 4f };
                    table.SetWidths(widths);
                    table.WidthPercentage = 100;

                    PdfPCell cell = new PdfPCell(new Phrase("Visitors"));

                    cell.Colspan = dt.Columns.Count;

                    foreach (DataColumn c in dt.Columns)
                    {

                        String NewName = c.ColumnName;
                        String revisedName = "";
                        switch (NewName)
                        {
                            case "idVisitor":
                                revisedName = "Visitor's ID";
                                break;
                            case "firstName":
                                revisedName = "First Name";
                                break;
                            case "lastName":
                                revisedName = "Last Name";
                                break;
                            case "gender":
                                revisedName = "Gender";
                                break;
                            case "unitNumber":
                                revisedName = "Unit Number";
                                break;
                            case "idDetails":
                                revisedName = "ID Detail";
                                break;
                            case "visitorRelation":
                                revisedName = "Relation to Owner";
                                break;
                            case "purposeOfVisit":
                                revisedName = "Purpose Of Visit";
                                break;
                            case "timeIn":
                                revisedName = "Time In";
                                break;
                            case "timeOut":
                                revisedName = "Time Out";
                                break;
                            case "idOwner":
                                revisedName = "Owner's ID";
                                break;
                            case "idFacilitator":
                                revisedName = "Facilitator's ID";
                                break;
                            case "ownerLastName":
                                revisedName = "Unit Owner(Last Name)";
                                break;
                            case "ownerFirstName":
                                revisedName = "Unit Owner(First Name)";
                                break;
                            case "facilitatorLastName":
                                revisedName = "Facilitator(Last Name)";
                                break;
                            default:
                                break;

                        }
                        PdfPCell labeledCell = new PdfPCell(new Phrase(revisedName, font6));
                        labeledCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        labeledCell.BackgroundColor = new BaseColor(35, 197, 227);
                        labeledCell.Padding = 4;

                        table.AddCell(labeledCell);

                        //table.AddCell(new Phrase(c.ColumnName, font5));
                    }

                    foreach (DataRow r in dt.Rows)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            table.AddCell(new Phrase(r[0].ToString(), font5));
                            table.AddCell(new Phrase(r[1].ToString(), font5));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            table.AddCell(new Phrase(r[2].ToString(), font5));
                            table.AddCell(new Phrase(r[3].ToString(), font5));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            table.AddCell(new Phrase(r[4].ToString(), font5));
                            table.AddCell(new Phrase(r[5].ToString(), font5));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            table.AddCell(new Phrase(r[6].ToString(), font5));
                            table.AddCell(new Phrase(r[7].ToString(), font5));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            table.AddCell(new Phrase(r[8].ToString(), font5));
                            table.AddCell(new Phrase(r[9].ToString(), font5));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            table.AddCell(new Phrase(r[10].ToString(), font5));
                            table.AddCell(new Phrase(r[11].ToString(), font5));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            table.AddCell(new Phrase(r[12].ToString(), font5));
                            table.AddCell(new Phrase(r[13].ToString(), font5));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            table.AddCell(new Phrase(r[14].ToString(), font5));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                        }
                    }
                    document.Add(table);
                    document.Close();
                
            }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disableTimeOutBtnChecker();
        }

        private void disableTimeOutBtnChecker()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int visitorID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                string timeOut = (String)visitor1TableAdapter.GetTimeOutQuery(visitorID);
                if (string.IsNullOrEmpty(timeOut))
                {
                    btnTimeOut.Enabled = true;
                }
                else
                {
                    btnTimeOut.Enabled = false;
                }
            }
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                datePicker1.CustomFormat = "MM/dd/yyyy";
                datePicker1.Visible = false;
                datePicker1.Enabled = false;
                label1.Visible = false;
                datePicker2.Visible = false;
                label4.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                datePicker1.CustomFormat = "MM/dd/yyyy";
                datePicker1.Visible = true;
                datePicker1.Enabled = true;
                datePicker2.Enabled = false;
                label1.Visible = true;
                datePicker2.Visible = true;
                label4.Visible = true;

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                datePicker1.Enabled = true;
                datePicker1.Visible = true;
                datePicker1.CustomFormat = "MM/yyyy";
                label1.Visible = false;
                datePicker2.Visible = false;
            }
        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            datePicker2.Value = datePicker1.Value.AddDays(7);
        }


        private void lblDateAndTime_Click(object sender, EventArgs e)
        {

        }

        private void datePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) //Daily
            {
                visitor1TableAdapter.FillDay(condorDatabaseDataSet.Visitor1, DateTime.Now.ToString("MM/dd/yyyy"));
            }
            else if (comboBox1.SelectedIndex == 1) //Weekly
            {
                //exportToPDF(visitor1TableAdapter.GetWeek(datePicker1.Text, datePicker2.Text));
                visitor1TableAdapter.FillWeek(condorDatabaseDataSet.Visitor1, datePicker1.Text, datePicker2.Text);
               
            }
            else if (comboBox1.SelectedIndex == 2) //Monthly
            {
                string[] myMonth = datePicker1.Text.Split('/');
                //exportToPDF(visitor1TableAdapter.GetMonth(myMonth[0], myMonth[1]));
                visitor1TableAdapter.FillMonth(condorDatabaseDataSet.Visitor1, myMonth[0], myMonth[1]);
                
            }
        }

      

        
    }

    
}
