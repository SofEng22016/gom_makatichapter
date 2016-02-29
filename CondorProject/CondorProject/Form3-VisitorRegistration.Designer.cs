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
            this.lblDateAndTimeEntry = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBoxPurpose = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxRelation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxUnitNumber = new System.Windows.Forms.TextBox();
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
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condorDatabaseDataSet = new CondorProject.condorDatabaseDataSet();
            this.visitorTableAdapter = new CondorProject.condorDatabaseDataSetTableAdapters.VisitorTableAdapter();
            this.tableAdapterManager = new CondorProject.condorDatabaseDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("dark forest", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(72, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 64);
            this.label3.TabIndex = 14;
            this.label3.Text = "Visitor Entry Form";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblDateAndTimeEntry);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtBoxPurpose);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBoxRelation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBoxUnitNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbBoxGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(64, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(913, 444);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor\'s Details";
            // 
            // lblDateAndTimeEntry
            // 
            this.lblDateAndTimeEntry.AutoSize = true;
            this.lblDateAndTimeEntry.BackColor = System.Drawing.Color.Salmon;
            this.lblDateAndTimeEntry.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTimeEntry.Location = new System.Drawing.Point(156, 33);
            this.lblDateAndTimeEntry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateAndTimeEntry.Name = "lblDateAndTimeEntry";
            this.lblDateAndTimeEntry.Size = new System.Drawing.Size(204, 26);
            this.lblDateAndTimeEntry.TabIndex = 37;
            this.lblDateAndTimeEntry.Text = "MM/dd/yyyy hh:mm:ss tt";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Maroon;
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(315, 377);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(272, 44);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "S U B M I T";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBoxPurpose
            // 
            this.txtBoxPurpose.Location = new System.Drawing.Point(160, 302);
            this.txtBoxPurpose.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPurpose.Name = "txtBoxPurpose";
            this.txtBoxPurpose.Size = new System.Drawing.Size(315, 22);
            this.txtBoxPurpose.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Salmon;
            this.label9.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(25, 298);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = "Purpose      :            ";
            // 
            // txtBoxRelation
            // 
            this.txtBoxRelation.Location = new System.Drawing.Point(160, 270);
            this.txtBoxRelation.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRelation.Name = "txtBoxRelation";
            this.txtBoxRelation.Size = new System.Drawing.Size(316, 22);
            this.txtBoxRelation.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Salmon;
            this.label8.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(25, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "Relation      :            ";
            // 
            // txtBoxUnitNumber
            // 
            this.txtBoxUnitNumber.Location = new System.Drawing.Point(159, 182);
            this.txtBoxUnitNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxUnitNumber.Name = "txtBoxUnitNumber";
            this.txtBoxUnitNumber.Size = new System.Drawing.Size(160, 22);
            this.txtBoxUnitNumber.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(25, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Unit No.       :            ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(25, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 26);
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
            this.cmbBoxGender.Location = new System.Drawing.Point(159, 149);
            this.cmbBoxGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(160, 24);
            this.cmbBoxGender.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(25, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gender        :            ";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(161, 112);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(316, 22);
            this.txtBoxLastName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name    :            ";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(161, 80);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(316, 22);
            this.txtBoxFirstName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
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
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 677);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(827, 37);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(151, 44);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "LOG-OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewList
            // 
            this.btnViewList.BackColor = System.Drawing.Color.Maroon;
            this.btnViewList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewList.BackgroundImage")));
            this.btnViewList.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewList.ForeColor = System.Drawing.Color.White;
            this.btnViewList.Location = new System.Drawing.Point(668, 37);
            this.btnViewList.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(151, 44);
            this.btnViewList.TabIndex = 30;
            this.btnViewList.Text = "VIEW LIST";
            this.btnViewList.UseVisualStyleBackColor = false;
            this.btnViewList.Click += new System.EventHandler(this.btnViewList_Click);
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
            // visitorTableAdapter
            // 
            this.visitorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FacilitatorTableAdapter = null;
            this.tableAdapterManager.OwnerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CondorProject.condorDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitorTableAdapter = this.visitorTableAdapter;
            // 
            // Form3_VisitorRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 656);
            this.Controls.Add(this.btnViewList);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3_VisitorRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_VisitorRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox txtBoxUnitNumber;
        private System.Windows.Forms.Button btnSubmit;
        private condorDatabaseDataSet condorDatabaseDataSet;
        private System.Windows.Forms.BindingSource visitorBindingSource;
        private condorDatabaseDataSetTableAdapters.VisitorTableAdapter visitorTableAdapter;
        private condorDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.Label lblDateAndTimeEntry;

    }
}