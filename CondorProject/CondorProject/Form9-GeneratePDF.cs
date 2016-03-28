using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CondorProject
{
    public partial class Form9_GeneratePDF : Form
    {
        public Form9_GeneratePDF()
        {
            InitializeComponent();
        }

        private void Form9_GeneratePDF_Load(object sender, EventArgs e)
        {
           

            // TODO: This line of code loads data into the 'condorDatabaseDataSet.Visitor1' table. You can move, or remove it, as needed.
            this.visitor1TableAdapter.Fill(this.condorDatabaseDataSet.Visitor1);

        }

        /*private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("---Daily---"))
            {
                datePicker1.Enabled = true;
                datePicker2.Enabled = false;
                
            }
            else if (comboBox1.Text.Equals("---Monthly---") || comboBox1.Text.Equals("---Custom Range---"))
            {
                datePicker1.Enabled = true;
                datePicker1.Enabled = false;
            }  
        }*/

        private void btnCreatePDF_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBoxPath.Text))
            {
                MessageBox.Show("Please enter a path!");
            }
            else
            {
                if (comboBox1.SelectedIndex == 0) //Daily
                {
                    exportToPDF(visitor1TableAdapter.GetDay(datePicker1.Text));
                    System.Diagnostics.Process.Start(@txtBoxPath.Text);
                }
                else if (comboBox1.SelectedIndex == 1) //Weekly
                {
                    exportToPDF(visitor1TableAdapter.GetWeek(datePicker1.Text,datePicker2.Text));
                    System.Diagnostics.Process.Start(@txtBoxPath.Text);
                }
                else if (comboBox1.SelectedIndex == 2) //Monthly
                {
                    string[] myMonth = datePicker1.Text.Split('/');
                    exportToPDF(visitor1TableAdapter.GetMonth(myMonth[0], myMonth[1]));
                    System.Diagnostics.Process.Start(@txtBoxPath.Text);
                }
            }
           // MessageBox.Show(datePicker1.Text);
        }

        private void exportToPDF(DataTable dt)
        {

            iTextSharp.text.Document document = new iTextSharp.text.Document(PageSize.LEDGER, 10, 10, 42, 35);
            //using (Document document = new Document(PageSize.LEDGER, 10, 10, 42, 35))
            
                //string title = "System Report (Visitor)_" + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".pdf";
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(txtBoxPath.Text, FileMode.Create));

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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBoxPath.Text = saveFileDialog1.FileName + ".pdf";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                datePicker1.CustomFormat = "MM/dd/yyyy";
                datePicker1.Visible = true;
                datePicker1.Enabled = true;
                label1.Visible = false;
                datePicker2.Visible = false;
            
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                datePicker1.CustomFormat = "MM/dd/yyyy";
                datePicker1.Enabled = true;
                datePicker2.Enabled = false;
                label1.Visible = true;
                datePicker2.Visible = true;
              
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            datePicker2.Value = datePicker1.Value.AddDays(7);
        }

        private void datePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        
    }

    class HeaderFooter : PdfPageEventHelper
    {
        /** Current page number */
        int pagenumber;
        Phrase header;


        /**
         * Initialize one of the headers.
         * @see com.itextpdf.text.pdf.PdfPageEventHelper#onOpenDocument(
         *      com.itextpdf.text.pdf.PdfWriter, com.itextpdf.text.Document)
         */
        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            header = new Phrase("Generated on: " + DateTime.Now.ToString("MM/dd/yyyy" + " " + "hh:mm:ss tt"));

        }

        /**
         * Increase the page number.
         * @see com.itextpdf.text.pdf.PdfPageEventHelper#onStartPage(
         *      com.itextpdf.text.pdf.PdfWriter, com.itextpdf.text.Document)
         */
        public override void OnStartPage(PdfWriter writer, Document document)
        {
            pagenumber++;
        }

        /**
         * Adds the header and the footer.
         * @see com.itextpdf.text.pdf.PdfPageEventHelper#onEndPage(
         *      com.itextpdf.text.pdf.PdfWriter, com.itextpdf.text.Document)
         */
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            Rectangle rect = writer.GetBoxSize("art");
            ColumnText.ShowTextAligned(writer.DirectContent,
                     Element.ALIGN_LEFT,
                     header,
                     rect.Left, rect.Bottom, 0);

            ColumnText.ShowTextAligned(
               writer.DirectContent,
               Element.ALIGN_LEFT,
               new Phrase(String.Format("|  page {0}", pagenumber)),
               (rect.Left + rect.Right),
               rect.Bottom, 0
            );
        }
    }
}
