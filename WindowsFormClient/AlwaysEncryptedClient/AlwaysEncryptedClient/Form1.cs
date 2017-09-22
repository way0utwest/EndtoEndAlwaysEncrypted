using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlwaysEncryptedClient
{
    public partial class frmAlwaysEncrypted : Form
    {
        public string strProcedureName = "dbo.Customers_SelectAll";

        public frmAlwaysEncrypted()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strConnstring = "Data Source=" + this.txtInstance.Text + ";Initial Catalog=" + this.txtDB.Text + "; Integrated Security = False; User ID=" + txtUser.Text + ";Password=" + txtPwd.Text;
            if ( chkEncrypt.Checked)
            {
                strConnstring += "; Column Encryption Setting = Enabled";
            }
             
            //string strConnstring = "Data Source=" + this.txtInstance.Text + ";Initial Catalog=" + this.txtDB.Text + "; Integrated Security = True; Column Encryption Setting = Enabled";
            SqlConnection con = new SqlConnection(strConnstring);
                   
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(strProcedureName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (strProcedureName == "dbo.Customers_SelectOne")
                    {
                        SqlParameter cCustEmail = new SqlParameter("@CustomerEmail", SqlDbType.VarChar, 200);
                        cCustEmail.Value = txtFilter.Text;
                        cmd.Parameters.Add(cCustEmail);

                    }
                    //SqlParameter ln = new SqlParameter("@CustomerID", SqlDbType.Int, 32);
                    //ln.Value = txtCustID.Text;
                    //cmd.Parameters.Add(ln);
                    SqlDataReader rdr = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();

                        //Load the data from SqlDataReader into the data table.
                        dataTable.Load(rdr);
                        dgvCustomers.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
            {
                string strError = "An error occurred getting the data table: " + ex.Message;

                //A simple catch.
                MessageBox.Show(strError);
                }
                finally
                {
                    //Close the connection.
                    con.Close();
                }
    }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string strConnstring = "Data Source=" + this.txtInstance.Text + ";Initial Catalog=" + this.txtDB.Text + "; Integrated Security = False; User ID=" + txtUser.Text + ";Password=" + txtPwd.Text;
            if (chkEncrypt.Checked)
            {
                strConnstring += "; Column Encryption Setting = Enabled";
            }

            //string strConnstring = "Data Source=" + this.txtInstance.Text + ";Initial Catalog=" + this.txtDB.Text + "; Integrated Security = True; Column Encryption Setting = Enabled";
            SqlConnection con = new SqlConnection(strConnstring);

            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("dbo.Customers_Insert", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter cID = new SqlParameter("@CustomerID", SqlDbType.Int, 32);
                    cID.Value = txtCustID.Text;
                    cmd.Parameters.Add(cID);
                    SqlParameter cName = new SqlParameter("@CustomerName", SqlDbType.VarChar, 200);
                    cName.Value = txtCustomerName.Text;
                    cmd.Parameters.Add(cName);
                    SqlParameter cTaxID = new SqlParameter("@TaxID", SqlDbType.VarChar, 20);
                    cTaxID.Value = txtTaxID.Text;
                    cmd.Parameters.Add(cTaxID);
                    SqlParameter cCustomerEmail = new SqlParameter("@CustomerEmail", SqlDbType.VarChar, 200);
                    cCustomerEmail.Value = txtCustomerEmail.Text;
                    cmd.Parameters.Add(cCustomerEmail);
                    SqlParameter cLimit = new SqlParameter("@CreditLimit", SqlDbType.Int);
                    cLimit.Value = Convert.ToDecimal(txtCreditLimit.Text);
                    cmd.Parameters.Add(cLimit);
                    SqlParameter cSecureLimit = new SqlParameter("@SecureCreditLimit", SqlDbType.Int);
                    cSecureLimit.Value = Convert.ToDecimal(txtSecureCreditLimit.Text);
                    // Add the parameter and set the precision and scale or Always Encrypted will complain.
                    cmd.Parameters.Add(cSecureLimit);


                    SqlParameter bActive = new SqlParameter("@Active", SqlDbType.Bit);
                    bActive.Value = chkActive.Checked;
                    //bool b = chkActive.Checked;
                    /*
                    if (chkActive.Checked)
                         { cActive = i; }
                    else { cActive = 0; }
                    
                    */
                    cmd.Parameters.Add(bActive);

                    cmd.ExecuteNonQuery();

                    txtCustID.Text = "";
                    txtCustomerName.Text = "";
                    txtCustomerEmail.Text = "";
                    txtTaxID.Text = "";
                    txtCreditLimit.Text = "0";
                    txtSecureCreditLimit.Text = "0";
                    chkActive.Checked = true;

                }
            }
            catch
            {
                //A simple catch.
                MessageBox.Show("The customer could not be inserted.");
            }
            finally
            {
                //Close the connection.
                con.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (strProcedureName== "dbo.Customers_SelectAll")
            {
                strProcedureName = "dbo.Customers_SelectOne";
                lblProcedure.Text = "dbo.Customers_SelectOne";
                txtFilter.Enabled = true;
            }
            else
            {
                strProcedureName = "dbo.Customers_SelectAll";
                lblProcedure.Text = "dbo.Customers_SelectAll";
                txtFilter.Enabled = false;
                txtFilter.Text = "";
            }
        }
    }
}
