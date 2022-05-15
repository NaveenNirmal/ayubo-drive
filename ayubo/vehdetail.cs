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
    public partial class vehdetail : Form
    {
        public vehdetail()
        {
            InitializeComponent();
        }

        //Set Connection
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet dset = new DataSet();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R4FED6O\SQLEXPRESS;Initial Catalog=ayubo;Integrated Security=True");
       
        private void cleanme()
        {
            cmbvno.SelectedIndex=0;
            txtvno.Text="";
            txtvno.Text = "";
            cmbvtyp.SelectedIndex = 0;
            txtvbrand.Text = "";
            txtvmod.Text = "";
            txtscoun.Text = "";
            cmbgtyp.SelectedIndex = 0;
            txtcmil.Text = "";

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleanme();
        }

        //search code
        private void btnsearch_Click(object sender, EventArgs e)
        {
            cmbvno.Visible = true;
            txtvno.Visible = false;
            btnupdate.Visible = true;
            btnsave.Visible = false;
            
            try
            {
                String get = "SELECT vno FROM vehdetail";
                conn.Open();
                sqlda = new SqlDataAdapter(get, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbvno.Items.Clear();

                cmbvno.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbvno.Items.Add(row["vno"]);
                }
                cmbvno.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Vehicle NO to the Combo Box...." + Environment.NewLine + msgerr);
            }
        }

        // Load vehicle details
        private void vehdetail_Load(object sender, EventArgs e)
        {
            try
            {
                string geta = "SELECT typ FROM vtyp";
                conn.Open();
                sqlda = new SqlDataAdapter(geta, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbvtyp.Items.Clear();

                cmbvtyp.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbvtyp.Items.Add(row["typ"]);
                }
                cmbvtyp.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Vehicle Type to the Combo Box...." + Environment.NewLine + msgerr);
            }

        }

        //select vehicle no
        private void cmbvno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbvno.SelectedIndex == 0)
                {

                    cleanme();

                }
                else
                {
                    string getdipdet = "SELECT * FROM vehdetail WHERE vno='" + cmbvno.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        cmbvtyp.Text = R.GetValue(1).ToString();
                        txtvbrand.Text = R.GetValue(2).ToString();
                        txtvmod.Text = R.GetValue(3).ToString();
                        txtscoun.Text = R.GetValue(4).ToString();
                        cmbgtyp.Text = R.GetValue(5).ToString();
                        txtcmil.Text = R.GetValue(7).ToString();
                        
                    }
                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Vehicle Detail...." + Environment.NewLine + ex);
            }

        }
        //save option
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtvno.Text == "" || cmbvtyp.Text == "" || txtvbrand.Text == "" || txtvmod.Text == "" || txtscoun.Text == "" || cmbgtyp.Text == "" || txtcmil.Text == "")
            {
                MessageBox.Show("Some Fields are empty... Please Fill all to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else

            {
                try
                {
                    
                    string sav = "INSERT INTO vehdetail VALUES('" + txtvno.Text + "','" + cmbvtyp.Text + "','" + txtvbrand.Text + "','" + txtvmod.Text + "','" + txtscoun.Text + "','" + cmbgtyp.Text + "','" + label8.Text + "','"+ txtcmil.Text+"')";
                    conn.Open();
                    cmd = new SqlCommand(sav, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    MessageBox.Show("Vehicle NO -" + txtvno.Text + " has Registred to systeam under the Vehicle NO-" + txtvno.Text + " Successfully!", "Save " + txtvno.Text + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanme();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while save..." + Environment.NewLine + ex);
                }

               
                
            }

        }
        // update process
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string upcus = "UPDATE vehdetail SET vtyp='" + cmbvtyp.Text + "',vbrand='" + txtvbrand.Text + "',vmodel='" + txtvmod.Text + "',scount='" + txtscoun.Text + "',gtyp='" + cmbgtyp.Text + "',mil='" + txtcmil.Text + "' WHERE vno='" + cmbvno.Text + "'";
                conn.Open();
                cmd = new SqlCommand(upcus, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("vehicle No:- " + cmbvno.Text + " is Successfuly UPDATED!!!", "UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanme();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while Update...." + Environment.NewLine + ex);
            }
        }
    }
}
