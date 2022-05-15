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
    public partial class hirpay : Form
    {
        public hirpay()
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

            txtmil.Text = "";

            dtpstd.Text = "";
            dtpt1.Text = "";
            lblvcost.Text = "";
            lblstd.Text = "";
            lblstt.Text = "";
            lblt.Text = "";
            lblvno.Text = "";
            lblvtyp.Text = "";
            lblcmil.Text = "";
            lbldcost.Text = "";
            lbldprice.Text = "";
            lblemc.Text = "";
            lblhcharg.Text = "";
            
            waitchar.Text = "";
                


            //hire pay load
        }
        private void hirpay_Load(object sender, EventArgs e)
        {
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
                    lbldprice.Text = R.GetValue(1).ToString();

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Lording Details of the Price Detail...." + Environment.NewLine + ex);
            }

        }

        private void cmbpayid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbhid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

           

            try
            {
                if (cmbhid.SelectedIndex == 0)
                {

                    cleanme();

                }
                else
                {
                    
                    string getdipdet = "SELECT * FROM hirdetail WHERE hid='" + cmbhid.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        lblid.Text = R.GetValue(2).ToString();
                        lblvtyp.Text = R.GetValue(3).ToString();
                        dtpstd.Text = R.GetValue(5).ToString();
                        lblcmil.Text = R.GetValue(9).ToString();
                        dtpt1.Text = R.GetValue(6).ToString();
                        lblhtyp.Text = R.GetValue(7).ToString();   
                        lblvno.Text = R.GetValue(4).ToString();
                      

                    }
                    conn.Close();

                  

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Hire Detail...." + Environment.NewLine + ex);
            }

            try
            {

                string getdipdet = "SELECT * FROM vtyp WHERE typ='" + lblvtyp.Text + "'";
                conn.Open();
                cmd = new SqlCommand(getdipdet, conn);
                SqlDataReader R = cmd.ExecuteReader();

                while (R.Read())
                {
                    lblvcost.Text = R.GetValue(1).ToString();


                }
                conn.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting vcost of the vtyp Detail...." + Environment.NewLine + ex);
            }


            try
            {
                if (lblhtyp.Text == "")
                {

                    //cleanme();

                }
                else
                {

                    string getdipdet1 = "SELECT * FROM hirecost WHERE hiretyp='" + lblhtyp.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet1, conn);
                    SqlDataReader M = cmd.ExecuteReader();

                    while (M.Read())
                    {
                        lblhcharg.Text = M.GetValue(1).ToString();
                        kmlim.Text = M.GetValue(2).ToString();
                        okmpri.Text = M.GetValue(3).ToString();
                        timelim.Text = M.GetValue(4).ToString();
                        otimpri.Text = M.GetValue(5).ToString();
                        onight.Text = M.GetValue(6).ToString();
                        park.Text = M.GetValue(7).ToString();

                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Hire Detail...." + Environment.NewLine + ex);
            }

            
        }

        private void lblhtyp_TextChanged(object sender, EventArgs e)
        {
         
        
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void btncal_Click(object sender, EventArgs e)
        {
            Double endKM = Double.Parse(txtmil.Text);
            Double startKM = Double.Parse(lblcmil.Text);
            lblkms.Text = ((endKM - startKM) - Double.Parse(kmlim.Text)).ToString();



            if (Double.Parse(lblkms.Text) <= 0)
            {
                lblkms.Text = "0";
            }

            Double dCost = 0;
            Double Extrakm = 0;
            Double overnight = 0;
            Double Basecost = 0;
            Double vehTypecost = 0;
            Double parkcost = 0;


            Basecost = Double.Parse(lblonight.Text);
            overnight = Double.Parse(lblovernight.Text);
            dCost = Double.Parse(lbldcost.Text);
            Extrakm = Double.Parse(lblkms.Text) * Double.Parse(exkmp.Text);
            parkcost = Double.Parse(lblprkcost.Text);
            vehTypecost = Double.Parse(lblvcost.Text);




            lblt.Text = ((Basecost + overnight + dCost + Extrakm + parkcost + vehTypecost)).ToString();
        }

        private void dtped_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void dtpstd_ValueChanged(object sender, EventArgs e)
        {
           
            

        }

        private void txtmil_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void dtpt1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        Double extraHours, waitingcost;
        private void dtpet_ValueChanged(object sender, EventArgs e)
        {
            DateTime stime = dtpt1.Value;
            DateTime etime = dtpet.Value;

            TimeSpan hirehours = etime - stime;

            if (hirehours.Hours < 0)
            {
                lblstt.Text = "0";
            }
            else
            {
                lblstt.Text = hirehours.Hours.ToString();
            }

            extraHours = (hirehours.Hours) - Double.Parse(timelim.Text);
            waitingcost = Double.Parse(otimpri.Text);
            if (extraHours <= 0)
            {
                waitchar.Text = "0";
            }
            else
            {
                waitchar.Text = (extraHours * waitingcost).ToString();
            }
        }

        private void lbldcost_Click(object sender, EventArgs e)
        {

        }

        private void btncl_Click(object sender, EventArgs e)
        {
            cleanme();
            
            dtpet.Text = "";
        }
        //SAve
        private void btnsav_Click(object sender, EventArgs e)
        {
            if (cmbhid.Text == "" || lblid.Text == "" || txtmil.Text == "" ||  dtpet.Text == "" || lblvcost.Text == "" || lbldcost.Text == "" || lblhcharg.Text == "" || lblemc.Text == "" || waitchar.Text == "" ||  lblt.Text == "")
            {
                MessageBox.Show("Some Fields are empty... Please Fill all to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    int Dri = 0;

                    string innum = "SELECT serial FROM hirepay";
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
                        string maxnum = "SELECT max(serial) FROM hirepay";
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
                    string fDri = "HPAY" + Dri.ToString();

                    string sav = "INSERT INTO hirepay VALUES('" + fDri + "','" + Dri + "','" + cmbhid.Text + "','" + lblid.Text + "','" + txtmil.Text + "','" + dtpet.Text + "','" + lblvcost.Text + "','" + lbldcost.Text + "','" + lblhcharg.Text + "','" + lblemc.Text + "','" + waitchar.Text + "','" + lblt.Text + "')";
                    conn.Open();
                    cmd = new SqlCommand(sav, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    MessageBox.Show("Payment ID - " + fDri + " has Registred to systeam under the Payment ID -" + fDri + " Successfully!", "Save " + fDri + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanme();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while save..." + Environment.NewLine + ex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
