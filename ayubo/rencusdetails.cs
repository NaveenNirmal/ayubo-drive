using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace ayubo
{
    public partial class rencusdetails : Form
    {
        public rencusdetails()
        {
            InitializeComponent();
        }

        // set databse connection
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet dset = new DataSet();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R4FED6O\SQLEXPRESS;Initial Catalog=ayubo;Integrated Security=True");
       
        private void cleanme()
        {
            cmbcusid.SelectedIndex = 0;
            txtcusid.Text = "";
            txtcusnam.Text = "";
            txtcusadd.Text = "";
            txtcuscon.Text = "";

        }

        private void rencusdetails_Load(object sender, EventArgs e)
        {
            txtcusid.Text = rendetail.id;      
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Search option
        private void btnsearch_Click(object sender, EventArgs e)
        {
            cmbcusid.Visible = true;
            txtcusid.Visible = false;
            btnsave.Visible = false;
            btnupdate.Visible = true;
            try
            {
                String get = "SELECT id FROM cusdetail";
                conn.Open();
                sqlda = new SqlDataAdapter(get, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbcusid.Items.Clear();

                cmbcusid.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbcusid.Items.Add(row["id"]);
                }
                cmbcusid.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Customer ID to the Combo Box...." + Environment.NewLine + msgerr);
            }

        }

        private void cmbcusid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbcusid.SelectedIndex == 0)
                {

                    txtcusnam.Text = "";
                    txtcusadd.Text = "";
                    txtcuscon.Text = "";
                    
                }
                else
                {
                    string getdipdet = "SELECT * FROM cusdetail WHERE id='" + cmbcusid.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        txtcusnam.Text = R.GetValue(1).ToString();
                        txtcusadd.Text = R.GetValue(2).ToString();
                        txtcuscon.Text = R.GetValue(3).ToString();
                        
                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Customer Detail...." + Environment.NewLine + ex);
            }
        }

        

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleanme();
        }

        //save button
        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtcusid.Text == "" || txtcusnam.Text == "" || txtcusadd.Text == "" || txtcuscon.Text == "")
            {
                MessageBox.Show("Some Fields are empty... Please Fill all to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                try
                {
                    conn.Open();
                    string sav = "INSERT INTO cusdetail VALUES('" + txtcusid.Text + "','" + txtcusnam.Text + "','" + txtcusadd.Text + "','" + txtcuscon.Text + "','" + lblrh.Text + "')";
                    cmd = new SqlCommand(sav, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Customer ID-" + txtcusid.Text + " has Registred to systeam under the Customer ID-" + txtcusid.Text + " Successfully!", "Save " + txtcusid.Text + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanme();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while save..." + Environment.NewLine + ex);
                }
            }

        }

       
        // update button
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string upcus = "UPDATE cusdetail SET name='" + txtcusnam.Text + "',caddress='" + txtcusadd.Text + "',tpno='" + txtcuscon.Text + "' WHERE id='" + cmbcusid.Text + "'";
                conn.Open();
                cmd = new SqlCommand(upcus, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Customer ID:- " + cmbcusid.Text + " is Successfuly UPDATED!!!", "UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanme();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while Update...." + Environment.NewLine + ex);
            }
        }

        private void txtcusid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcuscon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
