namespace LINQ2SQLClassDesignerCRUD
{
    partial class Form1
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
            this.gridSuppliers = new System.Windows.Forms.DataGridView();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.txtUpdateCompanyName = new System.Windows.Forms.TextBox();
            this.txtUpdateContactName = new System.Windows.Forms.TextBox();
            this.txtUpdateContactTitle = new System.Windows.Forms.TextBox();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateCity = new System.Windows.Forms.TextBox();
            this.txtUpdateRegion = new System.Windows.Forms.TextBox();
            this.txtUpdatePostalCode = new System.Windows.Forms.TextBox();
            this.txtUpdateCountry = new System.Windows.Forms.TextBox();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtUpdateFax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDeleteSupplierId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSuppliers
            // 
            this.gridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSuppliers.Location = new System.Drawing.Point(12, 64);
            this.gridSuppliers.Name = "gridSuppliers";
            this.gridSuppliers.Size = new System.Drawing.Size(546, 448);
            this.gridSuppliers.TabIndex = 0;
            this.gridSuppliers.SelectionChanged += new System.EventHandler(this.gridSuppliers_SelectionChanged);
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Enabled = false;
            this.txtUpdateId.Location = new System.Drawing.Point(603, 25);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateId.TabIndex = 1;
            // 
            // txtUpdateCompanyName
            // 
            this.txtUpdateCompanyName.Location = new System.Drawing.Point(603, 73);
            this.txtUpdateCompanyName.MaxLength = 40;
            this.txtUpdateCompanyName.Name = "txtUpdateCompanyName";
            this.txtUpdateCompanyName.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateCompanyName.TabIndex = 2;
            // 
            // txtUpdateContactName
            // 
            this.txtUpdateContactName.Location = new System.Drawing.Point(603, 125);
            this.txtUpdateContactName.MaxLength = 30;
            this.txtUpdateContactName.Name = "txtUpdateContactName";
            this.txtUpdateContactName.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateContactName.TabIndex = 3;
            // 
            // txtUpdateContactTitle
            // 
            this.txtUpdateContactTitle.Location = new System.Drawing.Point(603, 174);
            this.txtUpdateContactTitle.MaxLength = 30;
            this.txtUpdateContactTitle.Name = "txtUpdateContactTitle";
            this.txtUpdateContactTitle.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateContactTitle.TabIndex = 4;
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(603, 229);
            this.txtUpdateAddress.MaxLength = 60;
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateAddress.TabIndex = 5;
            // 
            // txtUpdateCity
            // 
            this.txtUpdateCity.Location = new System.Drawing.Point(603, 278);
            this.txtUpdateCity.MaxLength = 15;
            this.txtUpdateCity.Name = "txtUpdateCity";
            this.txtUpdateCity.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateCity.TabIndex = 6;
            // 
            // txtUpdateRegion
            // 
            this.txtUpdateRegion.Location = new System.Drawing.Point(603, 331);
            this.txtUpdateRegion.MaxLength = 15;
            this.txtUpdateRegion.Name = "txtUpdateRegion";
            this.txtUpdateRegion.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateRegion.TabIndex = 7;
            // 
            // txtUpdatePostalCode
            // 
            this.txtUpdatePostalCode.Location = new System.Drawing.Point(603, 387);
            this.txtUpdatePostalCode.MaxLength = 10;
            this.txtUpdatePostalCode.Name = "txtUpdatePostalCode";
            this.txtUpdatePostalCode.Size = new System.Drawing.Size(185, 20);
            this.txtUpdatePostalCode.TabIndex = 8;
            // 
            // txtUpdateCountry
            // 
            this.txtUpdateCountry.Location = new System.Drawing.Point(603, 439);
            this.txtUpdateCountry.MaxLength = 15;
            this.txtUpdateCountry.Name = "txtUpdateCountry";
            this.txtUpdateCountry.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateCountry.TabIndex = 9;
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Location = new System.Drawing.Point(603, 492);
            this.txtUpdatePhone.MaxLength = 24;
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(185, 20);
            this.txtUpdatePhone.TabIndex = 10;
            // 
            // txtUpdateFax
            // 
            this.txtUpdateFax.Location = new System.Drawing.Point(603, 540);
            this.txtUpdateFax.MaxLength = 24;
            this.txtUpdateFax.Name = "txtUpdateFax";
            this.txtUpdateFax.Size = new System.Drawing.Size(185, 20);
            this.txtUpdateFax.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Supplier ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Company name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contact name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contact title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Region";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Postal code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(600, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(603, 524);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fax";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(649, 567);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(13, 13);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(98, 45);
            this.btnAddNew.TabIndex = 24;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Supplier ID";
            // 
            // txtDeleteSupplierId
            // 
            this.txtDeleteSupplierId.Enabled = false;
            this.txtDeleteSupplierId.Location = new System.Drawing.Point(12, 540);
            this.txtDeleteSupplierId.Name = "txtDeleteSupplierId";
            this.txtDeleteSupplierId.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteSupplierId.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 567);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 34);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDeleteSupplierId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdateFax);
            this.Controls.Add(this.txtUpdatePhone);
            this.Controls.Add(this.txtUpdateCountry);
            this.Controls.Add(this.txtUpdatePostalCode);
            this.Controls.Add(this.txtUpdateRegion);
            this.Controls.Add(this.txtUpdateCity);
            this.Controls.Add(this.txtUpdateAddress);
            this.Controls.Add(this.txtUpdateContactTitle);
            this.Controls.Add(this.txtUpdateContactName);
            this.Controls.Add(this.txtUpdateCompanyName);
            this.Controls.Add(this.txtUpdateId);
            this.Controls.Add(this.gridSuppliers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSuppliers;
        private System.Windows.Forms.TextBox txtUpdateId;
        private System.Windows.Forms.TextBox txtUpdateCompanyName;
        private System.Windows.Forms.TextBox txtUpdateContactName;
        private System.Windows.Forms.TextBox txtUpdateContactTitle;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtUpdateCity;
        private System.Windows.Forms.TextBox txtUpdateRegion;
        private System.Windows.Forms.TextBox txtUpdatePostalCode;
        private System.Windows.Forms.TextBox txtUpdateCountry;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.TextBox txtUpdateFax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDeleteSupplierId;
        private System.Windows.Forms.Button btnDelete;
    }
}

