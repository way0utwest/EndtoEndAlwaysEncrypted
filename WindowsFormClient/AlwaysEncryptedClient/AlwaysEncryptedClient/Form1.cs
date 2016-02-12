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

                    using (SqlCommand cmd = new SqlCommand("dbo.Customers_SelectAll", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
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
                catch
                {
                    //A simple catch.
                    MessageBox.Show("The requested order could not be loaded into the form.");
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
                    SqlParameter cAuth = new SqlParameter("@CreditAuthorizedUser", SqlDbType.VarChar, 200);
                    cAuth.Value = txtCreditAuth.Text;
                    cmd.Parameters.Add(cAuth);
                    SqlParameter cLimit = new SqlParameter("@CreditLimit", SqlDbType.Float);
                    cLimit.Value = Convert.ToDecimal(txtCreditLimit.Text);
                    cmd.Parameters.Add(cLimit);
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
                    txtCreditAuth.Text = "";
                    txtCreditLimit.Text = "0.0";
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
    }
}
