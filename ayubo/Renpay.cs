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
    public partial class Renpay : Form
    {
        public Renpay()
        {
            InitializeComponent();
        }

        //set connection
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet dset = new DataSet();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R4FED6O\SQLEXPRESS;Initial Catalog=ayubo;Integrated Security=True");

        private void cleanme()
        {
            lblid.Text = "";
            lblvtyp.Text = "";
            lbldop.Text = "";
            lblcmil.Text = "";
            lblm.Text = "";
            lblw.Text = "";
            lbld.Text = "";
            cmbrid.SelectedIndex = 0;
            lbldcost.Text = "";
            lblvcost.Text = "";
            lblrcharg.Text = "";
            lblt.Text = "";
            txtmil.Text = "";
            lblvno.Text = "";
        }

        // ren payement form loading calculation
        private void Renpay_Load(object sender, EventArgs e)
        {
            try
            {
                String get = "SELECT rid FROM rendetail";
                conn.Open();
                sqlda = new SqlDataAdapter(get, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbrid.Items.Clear();

                cmbrid.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbrid.Items.Add(row["rid"]);
                }
                cmbrid.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Rent ID to the Combo Box...." + Environment.NewLine + msgerr);
            }

            try
            {

                string getdipdet = "SELECT * FROM renprice WHERE nam='Driver Cost'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        lblda.Text = R.GetValue(1).ToString();
                    
                    }
                    conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Lording Details of the Price Detail...." + Environment.NewLine + ex);
            }

            try
            {

                string getdipdet = "SELECT * FROM renprice WHERE nam='Rent Month'";
                conn.Open();
                cmd = new SqlCommand(getdipdet, conn);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    lblmp.Text = R.GetValue(1).ToString();

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Lording Details of the Price Detail...." + Environment.NewLine + ex);
            }

            try
            {

                string getdipdet = "SELECT * FROM renprice WHERE nam='Rent Week'";
                conn.Open();
                cmd = new SqlCommand(getdipdet, conn);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    lblwp.Text = R.GetValue(1).ToString();

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Lording Details of the Price Detail...." + Environment.NewLine + ex);
            }

            try
            {

                string getdipdet = "SELECT * FROM renprice WHERE nam='Rent Day'";
                conn.Open();
                cmd = new SqlCommand(getdipdet, conn);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    lbldp.Text = R.GetValue(1).ToString();

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Lording Details of the Price Detail...." + Environment.NewLine + ex);
            }
        }

        
        private void cmbrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblvcost.Text = "";
            lbldcost.Text = "";
            lblrcharg.Text = "";
            lblt.Text = "";
            lblrdone.Text = "";
            try
            {
                if (cmbrid.SelectedIndex == 0)
                {

                    cleanme();
              
                }
                else
                {
                    string getdipdet = "SELECT * FROM rendetail WHERE rid='" + cmbrid.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        lblid.Text = R.GetValue(2).ToString();
                        lblvtyp.Text = R.GetValue(3).ToString();
                        lbldop.Text = R.GetValue(10).ToString();
                        lblcmil.Text = R.GetValue(12).ToString();
                        lblm.Text = R.GetValue(7).ToString();
                        lblw.Text = R.GetValue(8).ToString();
                        lbld.Text = R.GetValue(9).ToString();
                        lblvno.Text = R.GetValue(4).ToString();
                       
                    }
                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Rent Detail...." + Environment.NewLine + ex);
            }

            string get = "SELECT * FROM rpay WHERE rid='" + cmbrid.Text + "'";
            conn.Open();
            cmd = new SqlCommand(get, conn);
            SqlDataReader L = cmd.ExecuteReader();

            while (L.Read())
            {
                lblrdone.Text = "Payment Done";


            }
            conn.Close();
        }

        //ren calculation button
        private void btncalculate_Click(object sender, EventArgs e)
        {
            if (cmbrid.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select the Rent Id...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {

                    string getdipdet = "SELECT * FROM vtyp WHERE typ='" + lblvtyp.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        lblvcost.Text = R.GetValue(2).ToString();


                    }
                    conn.Close();


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while Selecting vcost of the vtyp Detail...." + Environment.NewLine + ex);
                }

                try
                {
                    if (lbldop.Text == "With")
                    {
                        lbldcost.Text = (((int.Parse(lblm.Text) * 30) * Double.Parse(lblda.Text)) + ((int.Parse(lblw.Text) * 7) * Double.Parse(lblda.Text)) + (int.Parse(lbld.Text) * Double.Parse(lblda.Text))).ToString();
                    }

                    else
                    {
                        lbldcost.Text = "0";
                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while calculate cost of the driver...." + Environment.NewLine + ex);
                }

                try
                {
                    lblrcharg.Text = ((int.Parse(lblm.Text) * Double.Parse(lblmp.Text)) + (int.Parse(lblw.Text) * Double.Parse(lblwp.Text)) + (int.Parse(lbld.Text) * Double.Parse(lbldp.Text))).ToString();


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while calculate cost of the rent...." + Environment.NewLine + ex);
                }

                try
                {
                    lblt.Text = (int.Parse(lbldcost.Text) + int.Parse(lblrcharg.Text) + int.Parse(lblvcost.Text)).ToString();


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while calculate cost of the driver...." + Environment.NewLine + ex);
                }
            }
        }


        // calculation save
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cmbrid.Text == "" || lblid.Text == "" || txtmil.Text == "" || lblvcost.Text == "" || lbldcost.Text == "" || lblrcharg.Text == "" || lblt.Text == "")
            {
                MessageBox.Show("Some Fields are empty... Please Fill all to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int Pido = 0;

                    string innum = "SELECT serial FROM rpay";
                    conn.Open();
                    sqlda = new SqlDataAdapter(innum, conn);
                    conn.Close();
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        Pido = 0;
                    }
                    else
                    {
                        string maxnum = "SELECT max(serial) FROM rpay";
                        conn.Open();
                        cmd = new SqlCommand(maxnum, conn);
                        SqlDataReader R = cmd.ExecuteReader();

                        while (R.Read())
                        {
                            Pido = int.Parse(R.GetValue(0).ToString());
                        }
                        conn.Close();
                    }
                    Pido = Pido + 1;
                    string fpid = "PAY" + Pido.ToString();

                    string sav = "INSERT INTO rpay VALUES('" + fpid + "','" + Pido + "','" + cmbrid.Text + "','" + lblid.Text + "','" + txtmil.Text + "','" + lblvcost.Text + "','" + lbldcost.Text + "','" + lblrcharg.Text + "','" + lblt.Text + "')";
                    conn.Open();
                    cmd = new SqlCommand(sav, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    string upmil = "UPDATE vehdetail SET mil='" + txtmil.Text + "' WHERE vno='" + lblvno.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(upmil, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Payment ID - " + fpid + " has Registred to systeam under the Payment ID -" + fpid + " Successfully!", "Save " + fpid + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanme();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while save..." + Environment.NewLine + ex);
                }

                
            }
        }

        // search option
        private void btnsearch_Click(object sender, EventArgs e)
        {
            lblauto.Visible = false;
            cmbpayid.Visible = true;
            cmbrid.Visible = false;
            lblrid.Visible = true;

            try
            {
                String get = "SELECT pid FROM rpay";
                conn.Open();
                sqlda = new SqlDataAdapter(get, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbpayid.Items.Clear();

                cmbpayid.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbpayid.Items.Add(row["pid"]);
                }
                cmbpayid.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Pay ID to the Combo Box...." + Environment.NewLine + msgerr);
            }

        }

        private void cmbpayid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbpayid.SelectedIndex == 0)
                {

                    cleanme();

                }
                else
                {
                    string getdipdet = "SELECT * FROM rpay WHERE pid='" + cmbpayid.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        lblrid.Text = R.GetValue(2).ToString();
                        lblid.Text = R.GetValue(3).ToString();
                        txtmil.Text = R.GetValue(4).ToString();
                        lblvcost.Text = R.GetValue(5).ToString();
                        lbldcost.Text = R.GetValue(6).ToString();
                        lblrcharg.Text = R.GetValue(7).ToString();
                        lblt.Text = R.GetValue(8).ToString();


                    }
                    conn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Rent Detail...." + Environment.NewLine + ex);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
