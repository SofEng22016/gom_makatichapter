namespace CondorProject
{
    partial class Form4_VisitorListResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_VisitorListResult));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.btnCreatePDF = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idVisitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorRelationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeOfVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilitatorLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitor1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condorDatabaseDataSet = new CondorProject.condorDatabaseDataSet();
            this.visitor1TableAdapter = new CondorProject.condorDatabaseDataSetTableAdapters.Visitor1TableAdapter();
            this.visitorTableAdapter = new CondorProject.condorDatabaseDataSetTableAdapters.VisitorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 46);
            this.label3.TabIndex = 19;
            this.label3.Text = "Visitor List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-13, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(959, 561);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(790, 523);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 36);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(670, 523);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 36);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxSearch.Location = new System.Drawing.Point(444, 67);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(327, 20);
            this.txtboxSearch.TabIndex = 32;
            this.txtboxSearch.Text = "ie. First Name, Last Name, Gender, Unit Number";
            this.txtboxSearch.Click += new System.EventHandler(this.txtboxSearch_Click);
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Maroon;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(814, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 36);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(46, 523);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 36);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.BackColor = System.Drawing.Color.Maroon;
            this.btnTimeOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimeOut.BackgroundImage")));
            this.btnTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeOut.ForeColor = System.Drawing.Color.White;
            this.btnTimeOut.Location = new System.Drawing.Point(166, 523);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(113, 36);
            this.btnTimeOut.TabIndex = 35;
            this.btnTimeOut.Text = "TIME OUT";
            this.btnTimeOut.UseVisualStyleBackColor = false;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.BackColor = System.Drawing.Color.Salmon;
            this.lblDateAndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.Location = new System.Drawing.Point(54, 7);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(175, 20);
            this.lblDateAndTime.TabIndex = 36;
            this.lblDateAndTime.Text = "MM/dd/yyyy hh:mm:ss tt";
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.BackColor = System.Drawing.Color.Maroon;
            this.btnSearchClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchClear.BackgroundImage")));
            this.btnSearchClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClear.ForeColor = System.Drawing.Color.White;
            this.btnSearchClear.Location = new System.Drawing.Point(777, 57);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(31, 36);
            this.btnSearchClear.TabIndex = 37;
            this.btnSearchClear.Text = "X";
            this.btnSearchClear.UseVisualStyleBackColor = false;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // btnCreatePDF
            // 
            this.btnCreatePDF.BackColor = System.Drawing.Color.Maroon;
            this.btnCreatePDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreatePDF.BackgroundImage")));
            this.btnCreatePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePDF.ForeColor = System.Drawing.Color.White;
            this.btnCreatePDF.Location = new System.Drawing.Point(285, 523);
            this.btnCreatePDF.Name = "btnCreatePDF";
            this.btnCreatePDF.Size = new System.Drawing.Size(113, 36);
            this.btnCreatePDF.TabIndex = 38;
            this.btnCreatePDF.Text = "Create PDF";
            this.btnCreatePDF.UseVisualStyleBackColor = false;
            this.btnCreatePDF.Click += new System.EventHandler(this.btnCreatePDF_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVisitor,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.unitNumberDataGridViewTextBoxColumn,
            this.idDetailsDataGridViewTextBoxColumn,
            this.visitorRelationDataGridViewTextBoxColumn,
            this.purposeOfVisitDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.ownerLastName,
            this.ownerFirstName,
            this.facilitatorLastName});
            this.dataGridView1.DataSource = this.visitor1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(880, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idVisitor
            // 
            this.idVisitor.DataPropertyName = "idVisitor";
            this.idVisitor.HeaderText = "idVisitor";
            this.idVisitor.Name = "idVisitor";
            this.idVisitor.ReadOnly = true;
            this.idVisitor.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitNumberDataGridViewTextBoxColumn
            // 
            this.unitNumberDataGridViewTextBoxColumn.DataPropertyName = "unitNumber";
            this.unitNumberDataGridViewTextBoxColumn.HeaderText = "Unit Number";
            this.unitNumberDataGridViewTextBoxColumn.Name = "unitNumberDataGridViewTextBoxColumn";
            this.unitNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDetailsDataGridViewTextBoxColumn
            // 
            this.idDetailsDataGridViewTextBoxColumn.DataPropertyName = "idDetails";
            this.idDetailsDataGridViewTextBoxColumn.HeaderText = "ID Detail";
            this.idDetailsDataGridViewTextBoxColumn.Name = "idDetailsDataGridViewTextBoxColumn";
            this.idDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitorRelationDataGridViewTextBoxColumn
            // 
            this.visitorRelationDataGridViewTextBoxColumn.DataPropertyName = "visitorRelation";
            this.visitorRelationDataGridViewTextBoxColumn.HeaderText = "Relation to Owner";
            this.visitorRelationDataGridViewTextBoxColumn.Name = "visitorRelationDataGridViewTextBoxColumn";
            this.visitorRelationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purposeOfVisitDataGridViewTextBoxColumn
            // 
            this.purposeOfVisitDataGridViewTextBoxColumn.DataPropertyName = "purposeOfVisit";
            this.purposeOfVisitDataGridViewTextBoxColumn.HeaderText = "Purpose of Visit";
            this.purposeOfVisitDataGridViewTextBoxColumn.Name = "purposeOfVisitDataGridViewTextBoxColumn";
            this.purposeOfVisitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "timeIn";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "Time In";
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            this.timeInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "timeOut";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "Time Out";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerLastName
            // 
            this.ownerLastName.DataPropertyName = "ownerLastName";
            this.ownerLastName.HeaderText = "Unit Owner(Last Name)";
            this.ownerLastName.Name = "ownerLastName";
            this.ownerLastName.ReadOnly = true;
            // 
            // ownerFirstName
            // 
            this.ownerFirstName.DataPropertyName = "ownerFirstName";
            this.ownerFirstName.HeaderText = "Unit Owner(First Name)";
            this.ownerFirstName.Name = "ownerFirstName";
            this.ownerFirstName.ReadOnly = true;
            // 
            // facilitatorLastName
            // 
            this.facilitatorLastName.DataPropertyName = "facilitatorLastName";
            this.facilitatorLastName.HeaderText = "Facilitator(Last Name)";
            this.facilitatorLastName.Name = "facilitatorLastName";
            this.facilitatorLastName.ReadOnly = true;
            // 
            // visitor1BindingSource
            // 
            this.visitor1BindingSource.DataMember = "Visitor1";
            this.visitor1BindingSource.DataSource = this.condorDatabaseDataSet;
            // 
            // condorDatabaseDataSet
            // 
            this.condorDatabaseDataSet.DataSetName = "condorDatabaseDataSet";
            this.condorDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitor1TableAdapter
            // 
            this.visitor1TableAdapter.ClearBeforeFill = true;
            // 
            // visitorTableAdapter
            // 
            this.visitorTableAdapter.ClearBeforeFill = true;
            // 
            // Form4_VisitorListResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 610);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreatePDF);
            this.Controls.Add(this.btnSearchClear);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.btnTimeOut);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4_VisitorListResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_VisitorResult_FormClosing);
            this.Load += new System.EventHandler(this.Form4_VisitorResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitor1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Button btnCreatePDF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private condorDatabaseDataSet condorDatabaseDataSet;
        private System.Windows.Forms.BindingSource visitor1BindingSource;
        private condorDatabaseDataSetTableAdapters.Visitor1TableAdapter visitor1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorRelationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeOfVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitatorLastName;
        private condorDatabaseDataSetTableAdapters.VisitorTableAdapter visitorTableAdapter;
    }
}