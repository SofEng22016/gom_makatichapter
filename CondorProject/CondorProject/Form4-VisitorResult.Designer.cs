﻿namespace CondorProject
{
    partial class Form4_VisitorResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_VisitorResult));
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idVisitorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorRelationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeOfVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFacilitatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condorDatabaseDataSet = new CondorProject.condorDatabaseDataSet();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTimeOut = new System.Windows.Forms.Button();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.visitorTableAdapter = new CondorProject.condorDatabaseDataSetTableAdapters.VisitorTableAdapter();
            this.condorDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new CondorProject.condorDatabaseDataSetTableAdapters.TableAdapterManager();
            this.unitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilitatorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("dark forest", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(66, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 64);
            this.label3.TabIndex = 19;
            this.label3.Text = "Visitor List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1279, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-17, -7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1279, 690);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1053, 644);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(151, 44);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(894, 644);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 44);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(610, 83);
            this.txtboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(435, 22);
            this.txtboxSearch.TabIndex = 32;
            this.txtboxSearch.TextChanged += new System.EventHandler(this.txtboxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Maroon;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1053, 70);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 44);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVisitorDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.unitNumber,
            this.idDetailsDataGridViewTextBoxColumn,
            this.visitorRelationDataGridViewTextBoxColumn,
            this.purposeOfVisitDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn,
            this.idFacilitatorDataGridViewTextBoxColumn,
            this.idOwner});
            this.dataGridView1.DataSource = this.visitorBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Salmon;
            this.dataGridView1.Location = new System.Drawing.Point(64, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 256);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idVisitorDataGridViewTextBoxColumn
            // 
            this.idVisitorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idVisitorDataGridViewTextBoxColumn.DataPropertyName = "idVisitor";
            this.idVisitorDataGridViewTextBoxColumn.HeaderText = "Visitor ID";
            this.idVisitorDataGridViewTextBoxColumn.Name = "idVisitorDataGridViewTextBoxColumn";
            this.idVisitorDataGridViewTextBoxColumn.Width = 82;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 93;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 93;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 81;
            // 
            // unitNumber
            // 
            this.unitNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unitNumber.DataPropertyName = "unitNumber";
            this.unitNumber.HeaderText = "Unit";
            this.unitNumber.Name = "unitNumber";
            this.unitNumber.Width = 58;
            // 
            // idDetailsDataGridViewTextBoxColumn
            // 
            this.idDetailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDetailsDataGridViewTextBoxColumn.DataPropertyName = "idDetails";
            this.idDetailsDataGridViewTextBoxColumn.HeaderText = "ID Details";
            this.idDetailsDataGridViewTextBoxColumn.Name = "idDetailsDataGridViewTextBoxColumn";
            this.idDetailsDataGridViewTextBoxColumn.Width = 86;
            // 
            // visitorRelationDataGridViewTextBoxColumn
            // 
            this.visitorRelationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.visitorRelationDataGridViewTextBoxColumn.DataPropertyName = "visitorRelation";
            this.visitorRelationDataGridViewTextBoxColumn.HeaderText = "Visitor Relation";
            this.visitorRelationDataGridViewTextBoxColumn.Name = "visitorRelationDataGridViewTextBoxColumn";
            this.visitorRelationDataGridViewTextBoxColumn.Width = 117;
            // 
            // purposeOfVisitDataGridViewTextBoxColumn
            // 
            this.purposeOfVisitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.purposeOfVisitDataGridViewTextBoxColumn.DataPropertyName = "purposeOfVisit";
            this.purposeOfVisitDataGridViewTextBoxColumn.HeaderText = "Purpose Of Visit";
            this.purposeOfVisitDataGridViewTextBoxColumn.Name = "purposeOfVisitDataGridViewTextBoxColumn";
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "timeIn";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "Time In";
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            this.timeInDataGridViewTextBoxColumn.Width = 73;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "timeOut";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "Time Out";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.Width = 84;
            // 
            // idFacilitatorDataGridViewTextBoxColumn
            // 
            this.idFacilitatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idFacilitatorDataGridViewTextBoxColumn.DataPropertyName = "idFacilitator";
            this.idFacilitatorDataGridViewTextBoxColumn.HeaderText = "Facilitator ID";
            this.idFacilitatorDataGridViewTextBoxColumn.Name = "idFacilitatorDataGridViewTextBoxColumn";
            this.idFacilitatorDataGridViewTextBoxColumn.Width = 102;
            // 
            // idOwner
            // 
            this.idOwner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idOwner.DataPropertyName = "idOwner";
            this.idOwner.HeaderText = "Unit ID";
            this.idOwner.Name = "idOwner";
            this.idOwner.Width = 58;
            // 
            // visitorBindingSource
            // 
            this.visitorBindingSource.DataMember = "Visitor";
            this.visitorBindingSource.DataSource = this.condorDatabaseDataSet;
            // 
            // condorDatabaseDataSet
            // 
            this.condorDatabaseDataSet.DataSetName = "condorDatabaseDataSet";
            this.condorDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(62, 644);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 44);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTimeOut
            // 
            this.btnTimeOut.BackColor = System.Drawing.Color.Maroon;
            this.btnTimeOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimeOut.BackgroundImage")));
            this.btnTimeOut.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeOut.ForeColor = System.Drawing.Color.White;
            this.btnTimeOut.Location = new System.Drawing.Point(221, 644);
            this.btnTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimeOut.Name = "btnTimeOut";
            this.btnTimeOut.Size = new System.Drawing.Size(151, 44);
            this.btnTimeOut.TabIndex = 35;
            this.btnTimeOut.Text = "TIME OUT";
            this.btnTimeOut.UseVisualStyleBackColor = false;
            this.btnTimeOut.Click += new System.EventHandler(this.btnTimeOut_Click);
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.BackColor = System.Drawing.Color.Salmon;
            this.lblDateAndTime.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.Location = new System.Drawing.Point(72, 9);
            this.lblDateAndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(204, 26);
            this.lblDateAndTime.TabIndex = 36;
            this.lblDateAndTime.Text = "MM/dd/yyyy hh:mm:ss tt";
            this.lblDateAndTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // visitorTableAdapter
            // 
            this.visitorTableAdapter.ClearBeforeFill = true;
            // 
            // condorDatabaseDataSetBindingSource
            // 
            this.condorDatabaseDataSetBindingSource.DataSource = this.condorDatabaseDataSet;
            this.condorDatabaseDataSetBindingSource.Position = 0;
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
            // unitID
            // 
            this.unitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unitID.HeaderText = "Unit ID";
            this.unitID.Name = "unitID";
            this.unitID.Width = 58;
            // 
            // facilitatorID
            // 
            this.facilitatorID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.facilitatorID.HeaderText = "Facilitator ID";
            this.facilitatorID.Name = "facilitatorID";
            this.facilitatorID.Width = 102;
            // 
            // timeOut
            // 
            this.timeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeOut.HeaderText = "Time Out";
            this.timeOut.Name = "timeOut";
            this.timeOut.Width = 84;
            // 
            // timeIn
            // 
            this.timeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.timeIn.HeaderText = "Time In";
            this.timeIn.Name = "timeIn";
            this.timeIn.Width = 73;
            // 
            // purpose
            // 
            this.purpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.purpose.HeaderText = "Purpose of Visit";
            this.purpose.Name = "purpose";
            this.purpose.Width = 97;
            // 
            // relation
            // 
            this.relation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.relation.HeaderText = "Visitor Relation";
            this.relation.Name = "relation";
            this.relation.Width = 117;
            // 
            // idDetails
            // 
            this.idDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDetails.HeaderText = "ID Details";
            this.idDetails.Name = "idDetails";
            this.idDetails.Width = 86;
            // 
            // unitNum
            // 
            this.unitNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unitNum.HeaderText = "Unit";
            this.unitNum.Name = "unitNum";
            this.unitNum.Width = 58;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.Width = 81;
            // 
            // lastName
            // 
            this.lastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.Width = 93;
            // 
            // firstName
            // 
            this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.Width = 93;
            // 
            // visitorId
            // 
            this.visitorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.visitorId.HeaderText = "Visitor ID";
            this.visitorId.Name = "visitorId";
            this.visitorId.Width = 82;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitorId,
            this.firstName,
            this.lastName,
            this.gender,
            this.unitNum,
            this.idDetails,
            this.relation,
            this.purpose,
            this.timeIn,
            this.timeOut,
            this.facilitatorID,
            this.unitID});
            this.dataGridView2.GridColor = System.Drawing.Color.Salmon;
            this.dataGridView2.Location = new System.Drawing.Point(64, 384);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1140, 256);
            this.dataGridView2.TabIndex = 37;
            // 
            // Form4_VisitorResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 853);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.btnTimeOut);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4_VisitorResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_VisitorResult_FormClosing);
            this.Load += new System.EventHandler(this.Form4_VisitorResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource condorDatabaseDataSetBindingSource;
        private condorDatabaseDataSet condorDatabaseDataSet;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource visitorBindingSource;
        private condorDatabaseDataSetTableAdapters.VisitorTableAdapter visitorTableAdapter;
        private condorDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTimeOut;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisitorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorRelationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeOfVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacilitatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitatorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn relation;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitorId;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}