using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ayubo
{
    public partial class driver : Form
    {
        public driver()
        {
            InitializeComponent();
        }

        //setconnection
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet dset = new DataSet();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R4FED6O\SQLEXPRESS;Initial Catalog=ayubo;Integrated Security=True");


        private void cleanme()
        {
            cmbdid.SelectedIndex = 0;
            txtdid.Text = "";
            txtdnam.Text = "";
            txtdadd.Text = "";
            txtdcon.Text = "";
            txtli.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // clear code
        private void btnclear_Click(object sender, EventArgs e)
        {
            cleanme();
            txtdid.Visible = true;
            cmbdid.Visible = false;
            btnupdate.Visible = false;
            btnsave.Visible = true;

            
        }

        // search that data
        private void btnsearch_Click(object sender, EventArgs e)
        {
            txtdid.Visible = false;
            cmbdid.Visible = true;
            btnsave.Visible = false;
            btnupdate.Visible = true;

            try
            {
                String get = "SELECT did FROM ddetail";
                conn.Open();
                sqlda = new SqlDataAdapter(get, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbdid.Items.Clear();

                cmbdid.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbdid.Items.Add(row["did"]);
                }
                cmbdid.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Driver ID to the Combo Box...." + Environment.NewLine + msgerr);
            }
        }

        private void cmbdid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbdid.SelectedIndex == 0)
                {

                    cleanme();

                }
                else
                {
                    string getdipdet = "SELECT * FROM ddetail WHERE did='" + cmbdid.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        txtdnam.Text = R.GetValue(2).ToString();
                        txtdadd.Text = R.GetValue(3).ToString();
                        txtdcon.Text = R.GetValue(4).ToString();
                        txtli.Text = R.GetValue(5).ToString();
                    
                    }
                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Driver Detail...." + Environment.NewLine + ex);
            }
        }

        //save process
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtdid.Text == "" || txtdnam.Text == "" || txtdadd.Text == "" || txtdcon.Text == "" || txtli.Text == "")
            {
                MessageBox.Show("Some Fields are empty... Please Fill all to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int Dri = 0;

                    string innum = "SELECT serial FROM ddetail";
                    conn.Open();
                    sqlda = new SqlDataAdapter(innum, conn);
                    conn.Close();
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        Dri = 0;
                    }
                    else
                    {
                        string maxnum = "SELECT max(serial) FROM ddetail";
                        conn.Open();
                        cmd = new SqlCommand(maxnum, conn);
                        SqlDataReader R = cmd.ExecuteReader();

                        while (R.Read())
                        {
                            Dri = int.Parse(R.GetValue(0).ToString());
                        }
                        conn.Close();
                    }
                    Dri = Dri + 1;
                    string fDri = "EMP" + Dri.ToString();

                    string sav = "INSERT INTO ddetail VALUES('" + fDri + "','" + Dri + "','" + txtdnam.Text + "','" + txtdadd.Text + "','" + txtdcon.Text + "','" + txtli.Text + "')";
                    conn.Open();
                    cmd = new SqlCommand(sav, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    MessageBox.Show("Driver ID - " + fDri + " has Registred to systeam under the Driver ID -" + fDri + " Successfully!", "Save " + fDri + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanme();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while save..." + Environment.NewLine + ex);
                }
            }
        }

        //update process
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string upcus = "UPDATE ddetail SET name='" + txtdnam.Text + "',daddress='" + txtdadd.Text + "',tpno='" + txtdcon.Text + "',licenceno='" + txtli.Text + "' WHERE did='" + cmbdid.Text + "'";
                conn.Open();
                cmd = new SqlCommand(upcus, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Driver ID:- " + cmbdid.Text + " is Successfuly UPDATED!!!", "UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanme();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while Update...." + Environment.NewLine + ex);
            }
        }

        private void txtdcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
