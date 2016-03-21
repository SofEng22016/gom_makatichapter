namespace CondorProject
{
    partial class Form9_GeneratePDF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9_GeneratePDF));
            this.condorDatabaseDataSet = new CondorProject.condorDatabaseDataSet();
            this.visitor1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitor1TableAdapter = new CondorProject.condorDatabaseDataSetTableAdapters.Visitor1TableAdapter();
            this.tableAdapterManager = new CondorProject.condorDatabaseDataSetTableAdapters.TableAdapterManager();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreatePDF = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // condorDatabaseDataSet
            // 
            this.condorDatabaseDataSet.DataSetName = "condorDatabaseDataSet";
            this.condorDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitor1BindingSource
            // 
            this.visitor1BindingSource.DataMember = "Visitor1";
            this.visitor1BindingSource.DataSource = this.condorDatabaseDataSet;
            // 
            // visitor1TableAdapter
            // 
            this.visitor1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FacilitatorTableAdapter = null;
            this.tableAdapterManager.OwnerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CondorProject.condorDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorTableAdapter = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(604, 337);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // datePicker1
            // 
            this.datePicker1.CustomFormat = "MM/dd/yyyy";
            this.datePicker1.Enabled = false;
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(131, 125);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(183, 22);
            this.datePicker1.TabIndex = 22;
            this.datePicker1.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // datePicker2
            // 
            this.datePicker2.CustomFormat = "MM/dd/yyyy";
            this.datePicker2.Enabled = false;
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker2.Location = new System.Drawing.Point(372, 125);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(183, 22);
            this.datePicker2.TabIndex = 23;
            this.datePicker2.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "to";
            // 
            // btnCreatePDF
            // 
            this.btnCreatePDF.BackColor = System.Drawing.Color.Maroon;
            this.btnCreatePDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreatePDF.BackgroundImage")));
            this.btnCreatePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePDF.ForeColor = System.Drawing.Color.White;
            this.btnCreatePDF.Location = new System.Drawing.Point(131, 253);
            this.btnCreatePDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatePDF.Name = "btnCreatePDF";
            this.btnCreatePDF.Size = new System.Drawing.Size(158, 44);
            this.btnCreatePDF.TabIndex = 39;
            this.btnCreatePDF.Text = "Generate PDF";
            this.btnCreatePDF.UseVisualStyleBackColor = false;
            this.btnCreatePDF.Click += new System.EventHandler(this.btnCreatePDF_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month"});
            this.comboBox1.Location = new System.Drawing.Point(131, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Type: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Range: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Save in:";
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(134, 195);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.ReadOnly = true;
            this.txtBoxPath.Size = new System.Drawing.Size(397, 22);
            this.txtBoxPath.TabIndex = 44;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Maroon;
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(538, 193);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 28);
            this.btnBrowse.TabIndex = 45;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(335, 253);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 44);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form9_GeneratePDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 326);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCreatePDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker2);
            this.Controls.Add(this.datePicker1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form9_GeneratePDF";
            this.Text = "Generate PDF";
            this.Load += new System.EventHandler(this.Form9_GeneratePDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private condorDatabaseDataSet condorDatabaseDataSet;
        private System.Windows.Forms.BindingSource visitor1BindingSource;
        private condorDatabaseDataSetTableAdapters.Visitor1TableAdapter visitor1TableAdapter;
        private condorDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreatePDF;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnBack;

    }
}