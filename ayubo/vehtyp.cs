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
    public partial class vehtyp : Form
    {
        public vehtyp()
        {
            InitializeComponent();
        }

        //Set connection
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet dset = new DataSet();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R4FED6O\SQLEXPRESS;Initial Catalog=ayubo;Integrated Security=True");

        private void cleanme()
        {
            txtpri.Text = "";
            txtvehtype.Text = "";
            cmbvehtyp.SelectedIndex = 0;
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleanme();
        }

        //Type searching part
        private void btnsearch_Click(object sender, EventArgs e)
        {
            cmbvehtyp.Visible = true;
            txtvehtype.Visible = false;
            btnupdate.Visible = true;
            btnsave.Visible = false;

            try
            {
                String get = "SELECT typ FROM vtyp";
                conn.Open();
                sqlda = new SqlDataAdapter(get, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbvehtyp.Items.Clear();

                cmbvehtyp.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbvehtyp.Items.Add(row["typ"]);
                }
                cmbvehtyp.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Vehicle typ to the Combo Box...." + Environment.NewLine + msgerr);
            }
        }

        //type saving part
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtvehtype.Text == "" || txtpri.Text == "" )
            {
                MessageBox.Show("Some Fields are empty... Please Fill all to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {

                    string sav = "INSERT INTO vtyp VALUES('" + txtvehtype.Text + "','" + txtpri.Text + "')";
                    conn.Open();
                    cmd = new SqlCommand(sav, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    MessageBox.Show("Vehicle type -" + txtvehtype.Text + " has Registred to systeam under the Vehicle type-" + txtvehtype.Text + " Successfully!", "Save " + txtvehtype.Text + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanme();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while save..." + Environment.NewLine + ex);
                }



            }
        }


        private void cmbvehtyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbvehtyp.SelectedIndex == 0)
                {

                    cleanme();

                }
                else
                {
                    string getdipdet = "SELECT * FROM vehdetail WHERE typ='" + cmbvehtyp.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        txtpri.Text = R.GetValue(1).ToString();
                        

                    }
                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Vehicle type Detail...." + Environment.NewLine + ex);
            }
        }

        //type update
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string upcus = "UPDATE vtyp SET price='" + txtpri.Text + "' WHERE vno='" + cmbvehtyp.Text + "'";
                conn.Open();
                cmd = new SqlCommand(upcus, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("vehicle type:- " + cmbvehtyp.Text + " is Successfuly UPDATED!!!", "UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanme();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while Update...." + Environment.NewLine + ex);
            }
        }
    }
}
