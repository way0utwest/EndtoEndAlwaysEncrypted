namespace AlwaysEncryptedClient
{
    partial class frmAlwaysEncrypted
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
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEncrypt = new System.Windows.Forms.CheckBox();
            this.lblConnect = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSecureCreditLimit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.txtCreditAuth = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProcedure = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaxID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInstance
            // 
            this.txtInstance.Location = new System.Drawing.Point(75, 19);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(132, 20);
            this.txtInstance.TabIndex = 80;
            this.txtInstance.Text = ".\\SQL2016";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Instance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 200;
            this.label2.Text = "Database";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(75, 46);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(132, 20);
            this.txtDB.TabIndex = 300;
            this.txtDB.Text = "AlwaysEncryptedDemo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 400;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 500;
            this.label4.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(75, 83);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(132, 20);
            this.txtUser.TabIndex = 600;
            this.txtUser.Text = "AEUser";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(75, 112);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(132, 20);
            this.txtPwd.TabIndex = 700;
            this.txtPwd.Text = "Blu3Corn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEncrypt);
            this.groupBox1.Controls.Add(this.lblConnect);
            this.groupBox1.Controls.Add(this.txtInstance);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(382, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 166);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
            // 
            // chkEncrypt
            // 
            this.chkEncrypt.AutoSize = true;
            this.chkEncrypt.Location = new System.Drawing.Point(75, 140);
            this.chkEncrypt.Name = "chkEncrypt";
            this.chkEncrypt.Size = new System.Drawing.Size(74, 17);
            this.chkEncrypt.TabIndex = 1000;
            this.chkEncrypt.Text = "Encrypted";
            this.chkEncrypt.UseVisualStyleBackColor = true;
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Location = new System.Drawing.Point(11, 140);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(0, 13);
            this.lblConnect.TabIndex = 9;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(110, 19);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(206, 20);
            this.txtCustID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "CustomerID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(44, 273);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 23);
            this.btnSearch.TabIndex = 110;
            this.btnSearch.Text = "Get Customers";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(24, 302);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(578, 213);
            this.dgvCustomers.TabIndex = 12;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(463, 521);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(119, 23);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTaxID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSecureCreditLimit);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnAddCustomer);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.chkActive);
            this.groupBox2.Controls.Add(this.txtCreditLimit);
            this.groupBox2.Controls.Add(this.txtCreditAuth);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCustID);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 238);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Customer";
            // 
            // txtSecureCreditLimit
            // 
            this.txtSecureCreditLimit.Location = new System.Drawing.Point(110, 166);
            this.txtSecureCreditLimit.Name = "txtSecureCreditLimit";
            this.txtSecureCreditLimit.Size = new System.Drawing.Size(206, 20);
            this.txtSecureCreditLimit.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 190;
            this.label10.Text = "Secure Credit Limit";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(128, 202);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(122, 29);
            this.btnAddCustomer.TabIndex = 30;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 440;
            this.label8.Text = "Credit Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 160;
            this.label7.Text = "Authorizer";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(48, 209);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 28;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(110, 137);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(206, 20);
            this.txtCreditLimit.TabIndex = 20;
            // 
            // txtCreditAuth
            // 
            this.txtCreditAuth.Location = new System.Drawing.Point(110, 75);
            this.txtCreditAuth.Name = "txtCreditAuth";
            this.txtCreditAuth.Size = new System.Drawing.Size(206, 20);
            this.txtCreditAuth.TabIndex = 15;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(110, 47);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(206, 20);
            this.txtCustomerName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Name";
            // 
            // lblProcedure
            // 
            this.lblProcedure.Location = new System.Drawing.Point(169, 273);
            this.lblProcedure.Name = "lblProcedure";
            this.lblProcedure.Size = new System.Drawing.Size(240, 24);
            this.lblProcedure.TabIndex = 150;
            this.lblProcedure.Text = "dbo.Customers_SelectAll";
            this.lblProcedure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProcedure.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Enabled = false;
            this.txtFilter.Location = new System.Drawing.Point(396, 277);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 20);
            this.txtFilter.TabIndex = 160;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 210;
            this.label9.Text = "TaxID";
            // 
            // txtTaxID
            // 
            this.txtTaxID.Location = new System.Drawing.Point(110, 107);
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Size = new System.Drawing.Size(206, 20);
            this.txtTaxID.TabIndex = 18;
            // 
            // frmAlwaysEncrypted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 556);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblProcedure);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAlwaysEncrypted";
            this.Text = "AlwaysEncryptedClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox chkEncrypt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.TextBox txtCreditAuth;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProcedure;
        private System.Windows.Forms.TextBox txtSecureCreditLimit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtTaxID;
        private System.Windows.Forms.Label label9;
    }
}

