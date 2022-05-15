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
using System.Text.RegularExpressions;

namespace ayubo
{
    public partial class lhire : Form
    {
        public lhire()
        {
            InitializeComponent();
        }

        //set data connection
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet dset = new DataSet();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R4FED6O\SQLEXPRESS;Initial Catalog=ayubo;Integrated Security=True");


        //form load running iteams
        private void lhire_Load(object sender, EventArgs e)
        {
            cmbvehno.SelectedIndex = 0;
            try
            {
                String get = "SELECT hiretyp FROM hirecost";
                conn.Open();
                sqlda = new SqlDataAdapter(get, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbhtyp.Items.Clear();

                cmbhtyp.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbhtyp.Items.Add(row["hiretyp"]);
                }
                cmbhtyp.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while lord hire typ to the Combo Box...." + Environment.NewLine + msgerr);
            }

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
                MessageBox.Show("Error while lord hire typ to the Combo Box...." + Environment.NewLine + msgerr);
            }

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

        private void cmbhtyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // selecting vehicle type
        private void cmbvtyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbvtyp.SelectedIndex != 0)
                {
                    String geta = "SELECT vno FROM vehdetail WHERE vtyp='" + cmbvtyp.Text + "'";
                    conn.Open();
                    sqlda = new SqlDataAdapter(geta, conn);
                    conn.Close();
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    cmbvehno.Items.Clear();

                    cmbvehno.Items.Add("         _ _ Select _ _");
                    foreach (DataRow row in dt.Rows)
                    {
                        cmbvehno.Items.Add(row["vno"]);
                    }
                    cmbvehno.SelectedIndex = 0;
                }

            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Vehicle Number to the Combo Box...." + Environment.NewLine + msgerr);
            }

            qwer.Visible = true;
            try
            {
                dset.Reset();
                String loadinfo = "SELECT vno as Vehicle_Number,vbrand as Brand,vmodel as Model,scount as Seats,gtyp as Gear_Type FROM vehdetail WHERE vtyp='" + cmbvtyp.Text + "'";
                conn.Open();
                sqlda = new SqlDataAdapter(loadinfo, conn);
                sqlda.Fill(dset, "Vehicle");
                conn.Close();


                qwer.DataSource = dset.Tables["Vehicle"];



                this.qwer.Columns[0].Width = 100;
                this.qwer.Columns[1].Width = 100;
                this.qwer.Columns[2].Width = 100;
                this.qwer.Columns[3].Width = 100;
                this.qwer.Columns[4].Width = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while load..." + Environment.NewLine + ex);
            }
        }

        private void cmbvehno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbvehno.SelectedIndex == 0)
                {

                    lblcmil.Text = "";
                }
                else
                {
                    String geta = "SELECT mil FROM vehdetail WHERE vno='" + cmbvehno.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(geta, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        lblcmil.Text = R.GetValue(0).ToString();
                    }
                    conn.Close();
                }
            }



            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Vehicle Milage to the Combo Box...." + Environment.NewLine + msgerr);
            }
        }

        // auto customer registretion checking
        public static string id;
        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (new Regex("(^[0-9]{9}V$)|(^[0-9]{12}$)").IsMatch(txtid.Text))
            {
                id = txtid.Text;
                String cusid = "SELECT id FROM cusdetail WHERE id = '" + txtid.Text + "'";
                conn.Open();
                sqlda = new SqlDataAdapter(cusid, conn);
                conn.Close();
                DataTable cusTable = new DataTable();
                sqlda.Fill(cusTable);
                if (cusTable.Rows.Count == 0)
                {
                    rencusdetails home = new rencusdetails();
                    home.Show();
                }
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            txtid.Visible = false;
            txtautohire.Visible = false;
            cmbdid.Visible = false;
            cmbhtyp.Visible = false;
            cmbvehno.Visible = false;
            cmbvtyp.Visible = false;
            txtcusser.Visible = true;
            lbldid.Visible = true;
            lblvtyp.Visible = true;
            lblhtyp.Visible = true;
            lblvno.Visible = true;
            cmbhid.Visible = true;
            //btnupdate.Visible = true;
            //btnbook.Visible = false;
            

            try
            {
                String get = "SELECT hid FROM hirdetail";
                conn.Open();
                sqlda = new SqlDataAdapter(get, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbhid.Items.Clear();

                cmbhid.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbhid.Items.Add(row["hid"]);
                }
                cmbhid.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Hire ID to the Combo Box...." + Environment.NewLine + msgerr);
            }
        }

        //save hire details
        private void btnbook_Click(object sender, EventArgs e)
        {
            
                if (txtid.Text == "" || cmbvtyp.Text == "" || cmbvehno.Text == "" || dtpsdat.Text == "" || dtpst.Text == "" || cmbhtyp.Text == "" || cmbdid.Text == "" || lblcmil.Text == "")
                {
                    MessageBox.Show("Some Fields are empty... Please Fill all to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    try
                    {
                        int Hiro = 0;

                        string innum = "SELECT serial FROM hirdetail";
                        conn.Open();
                        sqlda = new SqlDataAdapter(innum, conn);
                        conn.Close();
                        DataTable dt = new DataTable();
                        sqlda.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            Hiro = 0;
                        }
                        else
                        {
                            string maxnum = "SELECT max(serial) FROM hirdetail";
                            conn.Open();
                            cmd = new SqlCommand(maxnum, conn);
                            SqlDataReader R = cmd.ExecuteReader();

                            while (R.Read())
                            {
                                Hiro = int.Parse(R.GetValue(0).ToString());
                            }
                            conn.Close();
                        }
                        Hiro = Hiro + 1;
                        string fHiro = "HIR" + Hiro.ToString();

                        string sav = "INSERT INTO hirdetail VALUES('" + fHiro + "','" + Hiro + "','" + txtid.Text + "','" + cmbvtyp.Text + "','" + cmbvehno.Text + "','" + dtpsdat.Text + "','" + dtpst.Text + "','" + cmbhtyp.Text + "','" + cmbdid.Text + "','" + lblcmil.Text + "')";
                        conn.Open();
                        cmd = new SqlCommand(sav, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();


                        MessageBox.Show("Hire ID - " + fHiro + " has Registred to systeam under the Hire ID -" + fHiro + " Successfully!", "Save " + fHiro + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Cleanme();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while save..." + Environment.NewLine + ex);
                    }
                }
            
        }

        private void cmbhid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbhid.SelectedIndex == 0)
                {

                    //cleanme();

                }
                else
                {
                    string getdipdet = "SELECT * FROM hirdetail WHERE hid='" + cmbhid.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        txtcusser.Text = R.GetValue(2).ToString();
                        lblvtyp.Text = R.GetValue(3).ToString();
                        lblvno.Text = R.GetValue(4).ToString();
                        dtpsdat.Text = R.GetValue(5).ToString();
                        dtpst.Text = R.GetValue(6).ToString();
                        lblhtyp.Text = R.GetValue(7).ToString();
                        lbldid.Text = R.GetValue(8).ToString();
                        lblcmil.Text = R.GetValue(9).ToString();


                    }
                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Rent Detail...." + Environment.NewLine + ex);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtid.Visible = false;
            txtautohire.Visible = false;
            cmbdid.Visible = true;
            cmbhtyp.Visible = true;
            cmbvehno.Visible = true;
            cmbvtyp.Visible = true;
            txtcusser.Visible = true;
            lbldid.Visible = false;
            lblvtyp.Visible = false;
            lblhtyp.Visible = false;
            lblvno.Visible = false;
            cmbhid.Visible = true;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbpak_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnrenserch_Click(object sender, EventArgs e)
        {

        }
    }
}
