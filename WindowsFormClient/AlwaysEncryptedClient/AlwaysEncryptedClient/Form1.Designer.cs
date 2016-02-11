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
            this.lblConnect = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnQuit = new System.Windows.Forms.Button();
            this.chkEncrypt = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInstance
            // 
            this.txtInstance.Location = new System.Drawing.Point(75, 19);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(132, 20);
            this.txtInstance.TabIndex = 0;
            this.txtInstance.Text = ".\\SQL2014";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instance";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Database";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(75, 46);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(132, 20);
            this.txtDB.TabIndex = 3;
            this.txtDB.Text = "AlwaysEncryptedDemo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(75, 83);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(132, 20);
            this.txtUser.TabIndex = 6;
            this.txtUser.Text = "AEUser";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(75, 112);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(132, 20);
            this.txtPwd.TabIndex = 7;
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
            this.groupBox1.Location = new System.Drawing.Point(226, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 166);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentication";
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
            this.txtCustID.Location = new System.Drawing.Point(99, 31);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(100, 20);
            this.txtCustID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CustomerID";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(166, 303);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Get Customers";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 332);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(434, 156);
            this.dgvCustomers.TabIndex = 12;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(166, 496);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(119, 23);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // chkEncrypt
            // 
            this.chkEncrypt.AutoSize = true;
            this.chkEncrypt.Location = new System.Drawing.Point(75, 140);
            this.chkEncrypt.Name = "chkEncrypt";
            this.chkEncrypt.Size = new System.Drawing.Size(74, 17);
            this.chkEncrypt.TabIndex = 10;
            this.chkEncrypt.Text = "Encrypted";
            this.chkEncrypt.UseVisualStyleBackColor = true;
            // 
            // frmAlwaysEncrypted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 531);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAlwaysEncrypted";
            this.Text = "AlwaysEncryptedClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
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
    }
}

