namespace CondorProject
{
    partial class Form5_UpdateEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5_UpdateEntry));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPurpose = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVisitorID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtboxIdDetails = new System.Windows.Forms.TextBox();
            this.lblIdDetails = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxRelation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxUnitNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.visitorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.condorDatabaseDataSet = new CondorProject.condorDatabaseDataSet();
            this.visitorTableAdapter = new CondorProject.condorDatabaseDataSetTableAdapters.VisitorTableAdapter();
            this.tableAdapterManager = new CondorProject.condorDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.visitorBindingSource, "idVisitor", true));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 677);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("dark forest", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(491, 64);
            this.label3.TabIndex = 19;
            this.label3.Text = "Update Visitor Details";
            // 
            // txtBoxPurpose
            // 
            this.txtBoxPurpose.Location = new System.Drawing.Point(160, 284);
            this.txtBoxPurpose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPurpose.Name = "txtBoxPurpose";
            this.txtBoxPurpose.Size = new System.Drawing.Size(315, 22);
            this.txtBoxPurpose.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblVisitorID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtboxIdDetails);
            this.groupBox1.Controls.Add(this.lblIdDetails);
            this.groupBox1.Controls.Add(this.txtBoxPurpose);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBoxRelation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBoxUnitNumber);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbBoxGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(55, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(913, 405);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor\'s Details";
            // 
            // lblVisitorID
            // 
            this.lblVisitorID.AutoSize = true;
            this.lblVisitorID.BackColor = System.Drawing.Color.Salmon;
            this.lblVisitorID.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitorID.Location = new System.Drawing.Point(156, 25);
            this.lblVisitorID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisitorID.Name = "lblVisitorID";
            this.lblVisitorID.Size = new System.Drawing.Size(62, 26);
            this.lblVisitorID.TabIndex = 39;
            this.lblVisitorID.Text = "00000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(25, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "Visitor ID     :            ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(328, 353);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 44);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(487, 353);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 44);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtboxIdDetails
            // 
            this.txtboxIdDetails.Location = new System.Drawing.Point(159, 197);
            this.txtboxIdDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxIdDetails.Name = "txtboxIdDetails";
            this.txtboxIdDetails.Size = new System.Drawing.Size(316, 22);
            this.txtboxIdDetails.TabIndex = 30;
            // 
            // lblIdDetails
            // 
            this.lblIdDetails.AutoSize = true;
            this.lblIdDetails.BackColor = System.Drawing.Color.Salmon;
            this.lblIdDetails.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDetails.ForeColor = System.Drawing.Color.Maroon;
            this.lblIdDetails.Location = new System.Drawing.Point(28, 193);
            this.lblIdDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdDetails.Name = "lblIdDetails";
            this.lblIdDetails.Size = new System.Drawing.Size(188, 26);
            this.lblIdDetails.TabIndex = 29;
            this.lblIdDetails.Text = "ID Details   :            ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Salmon;
            this.label9.Font = new System.Drawing.Font("dark forest", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(25, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 26);
            this.label9.TabIndex = 28;
            this.label9.Text = "Purpose      :            ";
            // 
            // txtBoxRelation
            // 
            this.txtBoxRelation.Location = new System.Drawing.Point(160, 252);
            this.txtBoxRelation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label8.Location = new System.Drawing.Point(25, 249);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "Relation      :            ";
            // 
            // txtBoxUnitNumber
            // 
            this.txtBoxUnitNumber.Location = new System.Drawing.Point(159, 165);
            this.txtBoxUnitNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label7.Location = new System.Drawing.Point(25, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "Unit No.       :            ";
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBoxGender.Location = new System.Drawing.Point(159, 132);
            this.cmbBoxGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label4.Location = new System.Drawing.Point(25, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gender        :            ";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(161, 95);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name    :            ";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(161, 63);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label1.Location = new System.Drawing.Point(25, 60);
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
            // Form5_UpdateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 644);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5_UpdateEntry";
            this.Text = "Form5_UpdateEntry";
            this.Load += new System.EventHandler(this.Form5_UpdateEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.condorDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxPurpose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxRelation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxUnitNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBoxGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxIdDetails;
        private System.Windows.Forms.Label lblIdDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private condorDatabaseDataSet condorDatabaseDataSet;
        private System.Windows.Forms.BindingSource visitorBindingSource;
        private condorDatabaseDataSetTableAdapters.VisitorTableAdapter visitorTableAdapter;
        private condorDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblVisitorID;
        private System.Windows.Forms.Label label5;
    }
}