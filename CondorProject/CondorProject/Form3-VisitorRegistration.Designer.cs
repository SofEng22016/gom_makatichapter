namespace CondorProject
{
    partial class Form3_VisitorRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_VisitorRegistration));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxIdDetails = new System.Windows.Forms.TextBox();
            this.lblIdDetails = new System.Windows.Forms.Label();
            this.cmbBoxUnitNumber = new System.Windows.Forms.ComboBox();
            this.lblDateAndTimeEntry = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBoxPurpose = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxRelation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewList = new System.Windows.Forms.Button();
            this.condorDatabaseDataSet = new CondorProject.condorDatabaseDataSet();
            this.visitor1TableAdapter = new CondorProject.condorDatabaseDataSetTableAdapters.Visitor1TableAdapter();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitorTableAdapter = new CondorProject.condorDatabaseDataSetTableAdapters.VisitorTableAdapter();
            this.ownerTableAdapter1 = new CondorProject.condorDatabaseDataSetTableAdapters.OwnerTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.condorDatabaseDataSet1 = new CondorProject.condorDatabaseDataSet();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Visitor Entry Form";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtboxIdDetails);
            this.groupBox1.Controls.Add(this.lblIdDetails);
            this.groupBox1.Controls.Add(this.cmbBoxUnitNumber);
            this.groupBox1.Controls.Add(this.lblDateAndTimeEntry);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtBoxPurpose);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBoxRelation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbBoxGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 361);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor\'s Details";
            // 
            // txtboxIdDetails
            // 
            this.txtboxIdDetails.Location = new System.Drawing.Point(119, 172);
            this.txtboxIdDetails.Name = "txtboxIdDetails";
            this.txtboxIdDetails.Size = new System.Drawing.Size(238, 20);
            this.txtboxIdDetails.TabIndex = 40;
            // 
            // lblIdDetails
            // 
            this.lblIdDetails.AutoSize = true;
            this.lblIdDetails.BackColor = System.Drawing.Color.Salmon;
            this.lblIdDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDetails.ForeColor = System.Drawing.Color.Maroon;
            this.lblIdDetails.Location = new System.Drawing.Point(19, 172);
            this.lblIdDetails.Name = "lblIdDetails";
            this.lblIdDetails.Size = new System.Drawing.Size(143, 20);
            this.lblIdDetails.TabIndex = 39;
            this.lblIdDetails.Text = "ID Details   :            ";
            // 
            // cmbBoxUnitNumber
            // 
            this.cmbBoxUnitNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUnitNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbBoxUnitNumber.FormattingEnabled = true;
            this.cmbBoxUnitNumber.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "201",
            "202",
            "203",
            "204",
            "205",
            "301",
            "302",
            "303",
            "304",
            "305",
            "401",
            "402",
            "403",
            "404",
            "405",
            "501",
            "502",
            "503",
            "504",
            "505"});
            this.cmbBoxUnitNumber.Location = new System.Drawing.Point(119, 148);
            this.cmbBoxUnitNumber.Name = "cmbBoxUnitNumber";
            this.cmbBoxUnitNumber.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUnitNumber.TabIndex = 38;
            this.cmbBoxUnitNumber.TextChanged += new System.EventHandler(this.cmbBoxUnitNumber_TextChanged);
            // 
            // lblDateAndTimeEntry
            // 
            this.lblDateAndTimeEntry.AutoSize = true;
            this.lblDateAndTimeEntry.BackColor = System.Drawing.Color.Salmon;
            this.lblDateAndTimeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTimeEntry.Location = new System.Drawing.Point(117, 27);
            this.lblDateAndTimeEntry.Name = "lblDateAndTimeEntry";
            this.lblDateAndTimeEntry.Size = new System.Drawing.Size(175, 20);
            this.lblDateAndTimeEntry.TabIndex = 37;
            this.lblDateAndTimeEntry.Text = "MM/dd/yyyy hh:mm:ss tt";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Maroon;
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(236, 306);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(204, 36);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "S U B M I T";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBoxPurpose
            // 
            this.txtBoxPurpose.Location = new System.Drawing.Point(120, 245);
            this.txtBoxPurpose.Name = "txtBoxPurpose";
            this.txtBoxPurpose.Size = new System.Drawing.Size(237, 20);
            this.txtBoxPurpose.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Salmon;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(19, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Purpose      :            ";
            // 
            // txtBoxRelation
            // 
            this.txtBoxRelation.Location = new System.Drawing.Point(120, 219);
            this.txtBoxRelation.Name = "txtBoxRelation";
            this.txtBoxRelation.Size = new System.Drawing.Size(238, 20);
            this.txtBoxRelation.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Salmon;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(19, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Relation      :            ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(19, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Unit No.       :            ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(19, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Time-In         :            ";
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBoxGender.Location = new System.Drawing.Point(119, 121);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxGender.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(19, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gender        :            ";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(121, 91);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(238, 20);
            this.txtBoxLastName.TabIndex = 14;
            this.txtBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLastName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name    :            ";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(121, 65);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(238, 20);
            this.txtBoxFirstName.TabIndex = 12;
            this.txtBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxFirstName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name   :            ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(620, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 36);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewList
            // 
            this.btnViewList.BackColor = System.Drawing.Color.Maroon;
            this.btnViewList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewList.BackgroundImage")));
            this.btnViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewList.ForeColor = System.Drawing.Color.White;
            this.btnViewList.Location = new System.Drawing.Point(501, 30);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(113, 36);
            this.btnViewList.TabIndex = 30;
            this.btnViewList.Text = "VIEW LIST";
            this.btnViewList.UseVisualStyleBackColor = false;
            this.btnViewList.Click += new System.EventHandler(this.btnViewList_Click);
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
            // bindingSource
            // 
            this.bindingSource.DataMember = "Visitor";
            this.bindingSource.DataSource = this.condorDatabaseDataSet;
            // 
            // visitorTableAdapter
            // 
            this.visitorTableAdapter.ClearBeforeFill = true;
            // 
            // ownerTableAdapter1
            // 
            this.ownerTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Owner";
            this.bindingSource1.DataSource = this.condorDatabaseDataSet1;
            // 
            // condorDatabaseDataSet1
            // 
            this.condorDatabaseDataSet1.DataSetName = "condorDatabaseDataSet";
            this.condorDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form3_VisitorRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 533);
            this.Controls.Add(this.btnViewList);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3_VisitorRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_VisitorRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxPurpose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxRelation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.Label lblDateAndTimeEntry;
        private condorDatabaseDataSet condorDatabaseDataSet;
        private condorDatabaseDataSetTableAdapters.Visitor1TableAdapter visitor1TableAdapter;
        private System.Windows.Forms.BindingSource bindingSource;
        private condorDatabaseDataSetTableAdapters.VisitorTableAdapter visitorTableAdapter;
        private System.Windows.Forms.ComboBox cmbBoxUnitNumber;
        private condorDatabaseDataSetTableAdapters.OwnerTableAdapter ownerTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private condorDatabaseDataSet condorDatabaseDataSet1;
        private System.Windows.Forms.Label lblIdDetails;
        private System.Windows.Forms.TextBox txtboxIdDetails;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}