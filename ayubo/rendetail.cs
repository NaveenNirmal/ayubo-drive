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
    public partial class rendetail : Form
    {
        public rendetail()
        {
            InitializeComponent();
        }

        
        private void Cleanme()
        {

            txtcusid.Text = "";
            cmbvtype.SelectedIndex = 0;
            cmbvehno.SelectedIndex = 0;
            dtprend.Text = "";
            dtpretd.Text = "";
            m.Text = "";
            w.Text = "";
            d.Text = "";
            cmbdop.SelectedIndex = 0;
            cmbdid.SelectedIndex = 0;
            lblmil.Text = "";
            txtcusid.Focus();

        }

        //set connection
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet dset = new DataSet();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R4FED6O\SQLEXPRESS;Initial Catalog=ayubo;Integrated Security=True");


        //check customer id and auto save unreg custommers
        public static string id;
        private void txtcusid_TextChanged(object sender, EventArgs e)
        {
            if (new Regex("(^[0-9]{9}V$)|(^[0-9]{12}$)").IsMatch(txtcusid.Text))
            {
                id = txtcusid.Text;
                String cusid = "SELECT id FROM cusdetail WHERE id = '" + txtcusid.Text + "'";
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
      
        //Search button
        private void btnsearch_Click(object sender, EventArgs e)
        {
            txtautoren.Visible=false;
            cmbrid.Visible = true;
            txtcusid.Visible = false;
            txtcusser.Visible = true;
            cmbvehno.Visible = false;
            lblvno.Visible = true;
            cmbdop.Visible = false;
            lbldopt.Visible = true;
            cmbdid.Visible=false;
            lbldid.Visible = true;
            cmbvtype.Visible = false;
            lblvtyp.Visible = true;
            lblcid.Visible = false;
            cid.Visible = false;
            btnbook.Visible = false;
            btnsearch.Visible = true;
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


            
           
        }
    
        //rent id selection and load data
        private void cmbrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbrid.SelectedIndex == 0)
                {

                    txtcusser.Text = "";
                    lblvtyp.Text = "";
                    lblvno.Text = "";
                    dtprend.Text = "";
                    dtpretd.Text = "";
                    m.Text = "";
                    w.Text = "";
                    d.Text = "";
                    lbldopt.Text = "";
                    lbldid.Text= "";
                    lblmil.Text = "";

                }
                else
                {
                    string getdipdet = "SELECT * FROM rendetail WHERE rid='" + cmbrid.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        txtcusser.Text = R.GetValue(2).ToString();
                        cid.Text = R.GetValue(2).ToString();
                        lblvtyp.Text = R.GetValue(3).ToString();
                        lblvno.Text = R.GetValue(4).ToString();
                        dtprend.Text = R.GetValue(5).ToString();
                        dtpretd.Text = R.GetValue(6).ToString();
                        m.Text = R.GetValue(7).ToString();
                        w.Text = R.GetValue(8).ToString();
                        d.Text = R.GetValue(9).ToString();
                        lbldopt.Text = R.GetValue(10).ToString();
                        lbldid.Text = R.GetValue(11).ToString();
                        lblmil.Text = R.GetValue(12).ToString();
                    }
                    conn.Close();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Rent Detail...." + Environment.NewLine + ex);
            }

           
        }
        // loading rent details to form
        private void rendetail_Load(object sender, EventArgs e)
        {
             
            try
            {
                string geta = "SELECT serial, typ FROM vtyp";
                conn.Open();
                sqlda = new SqlDataAdapter(geta, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbvtype.Items.Clear();

                cmbvtype.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbvtype.Items.Add(row["typ"]);
                }
                cmbvtype.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Vehicle Type to the Combo Box...." + Environment.NewLine + msgerr);
            }

            


            cmbdop.SelectedIndex = 0;
            cmbvehno.SelectedIndex = 0;

            
        }
        
        // loading vehicle type
        private void cmbvtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbvtype.SelectedIndex != 0)
                {
                    String geta = "SELECT vno FROM vehdetail WHERE vtyp='" + cmbvtype.Text + "'";
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
            dgvvdet.Visible = true;
            try
            {
                dset.Reset();
                String loadinfo = "SELECT vno as Vehicle_Number,vbrand as Brand,vmodel as Model,scount as Seats,gtyp as Gear_Type FROM vehdetail WHERE vtyp='" + cmbvtype.Text + "'";
                conn.Open();
                sqlda = new SqlDataAdapter(loadinfo, conn);
                sqlda.Fill(dset, "Vehicle");
                conn.Close();


                dgvvdet.DataSource = dset.Tables["Vehicle"];



                this.dgvvdet.Columns[0].Width = 100;
                this.dgvvdet.Columns[1].Width = 100;
                this.dgvvdet.Columns[2].Width = 100;
                this.dgvvdet.Columns[3].Width = 100;
                this.dgvvdet.Columns[4].Width = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while load..." + Environment.NewLine + ex);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtcusser.Visible = false;
            txtcusid.Visible = true;
            cmbvehno.Visible = true;
            lbldopt.Visible = false;
            lbldid.Visible = false;
            cmbdop.Visible = true;
            cmbdid.Visible = true;
            cmbvtype.Visible = true;
            lblvtyp.Visible = false;
            lblvno.Visible = false;
            cid.Visible = true;
            lblcid.Visible = true;
        }

        // selecting vehicles
        private void cmbvehno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbvehno.SelectedIndex == 0)
                {

                    lblmil.Text = "";
                }
                else
                {
                    String geta = "SELECT mil FROM vehdetail WHERE vno='" + cmbvehno.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(geta, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        lblmil.Text = R.GetValue(0).ToString();
                    }
                    conn.Close();
                }
            }



            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load Vehicle Milage to the Combo Box...." + Environment.NewLine + msgerr);
            }
        }

       

        // save option
        private void btnbook_Click(object sender, EventArgs e)
        {
            if (cmbdop.SelectedIndex == 1)
            {
                if (txtcusid.Text == "" || cmbvtype.Text == "" || cmbvehno.Text == "" || dtprend.Text == "" || dtpretd.Text == "" || cmbdop.Text == "" || cmbdid.Text == "" || lblmil.Text == "")
                {
                    MessageBox.Show("Some Fields are empty... Please Fill all to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    try
                    {
                        int Reno = 0;

                        string innum = "SELECT serial FROM rendetail";
                        conn.Open();
                        sqlda = new SqlDataAdapter(innum, conn);
                        conn.Close();
                        DataTable dt = new DataTable();
                        sqlda.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            Reno = 0;
                        }
                        else
                        {
                            string maxnum = "SELECT max(serial) FROM rendetail";
                            conn.Open();
                            cmd = new SqlCommand(maxnum, conn);
                            SqlDataReader R = cmd.ExecuteReader();

                            while (R.Read())
                            {
                                Reno = int.Parse(R.GetValue(0).ToString());
                            }
                            conn.Close();
                        }
                        Reno = Reno + 1;
                        string fren = "REN" + Reno.ToString();

                        string sav = "INSERT INTO rendetail VALUES('" + fren + "','" + Reno + "','" + txtcusid.Text + "','" + cmbvtype.Text + "','" + cmbvehno.Text + "','" + dtprend.Text + "','" + dtpretd.Text + "','" + m.Text + "','" + w.Text + "','" + d.Text + "','" + cmbdop.Text + "','" + cmbdid.Text + "','" + lblmil.Text + "')";
                        conn.Open();
                        cmd = new SqlCommand(sav, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();


                        MessageBox.Show("Rent ID - " + fren + " has Registred to systeam under the Rent ID -" + fren + " Successfully!", "Save " + fren + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cleanme();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while save..." + Environment.NewLine + ex);
                    }
                }
            }
            else if (cmbdop.SelectedIndex == 2)
            {
                if (txtcusid.Text == "" || cmbvtype.Text == "" || cmbvehno.Text == "" || dtprend.Text == "" || dtpretd.Text == "" || cmbdop.Text == "" || lblmil.Text == "")
                {
                    MessageBox.Show("Some Fields are empty... Please Fill all to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    try
                    {
                        int Reno = 0;

                        string innum = "SELECT serial FROM rendetail";
                        conn.Open();
                        sqlda = new SqlDataAdapter(innum, conn);
                        conn.Close();
                        DataTable dt = new DataTable();
                        sqlda.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            Reno = 0;
                        }
                        else
                        {
                            string maxnum = "SELECT max(serial) FROM rendetail";
                            conn.Open();
                            cmd = new SqlCommand(maxnum, conn);
                            SqlDataReader R = cmd.ExecuteReader();

                            while (R.Read())
                            {
                                Reno = int.Parse(R.GetValue(0).ToString());
                            }
                            conn.Close();
                        }
                        Reno = Reno + 1;
                        string fren = "REN" + Reno.ToString();

                        string sav1 = "INSERT INTO rendetail VALUES('" + fren + "','" + Reno + "','" + txtcusid.Text + "','" + cmbvtype.Text + "','" + cmbvehno.Text + "','" + dtprend.Text + "','" + dtpretd.Text + "','" + m.Text + "','" + w.Text + "','" + d.Text + "','" + cmbdop.Text + "','NULL','" + lblmil.Text + "')";
                        conn.Open();
                        cmd = new SqlCommand(sav1, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();


                        MessageBox.Show("Rent ID - " + fren + " has Registred to systeam under the Rent ID -" + fren + " Successfully!", "Save " + fren + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cleanme();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while save..." + Environment.NewLine + ex);
                    }
                }
            }
            
        }

        

        private void cmbdop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                try
                {

                    string geta = "SELECT did FROM ddetail";
                    conn.Open();
                    sqlda = new SqlDataAdapter(geta, conn);
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

        private void btnrenserch_Click(object sender, EventArgs e)
        {
            rencusid home= new rencusid();
            home.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                string upcus = "UPDATE rendetail SET id='" + txtcusid.Text + "',vtyp='" + cmbvtype.Text + "',vno='" + cmbvehno.Text + "',rendat='" + dtprend.Text + "',retdat='" + dtpretd.Text + "',m='" + m.Text + "',w='" + w.Text + "',d='" + d.Text + "',doption='" + cmbdop.Text + "',did='" + cmbdid.Text + "' WHERE rid='" + cmbrid.Text + "'";
                conn.Open();
                cmd = new SqlCommand(upcus, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Rent ID:- " + cmbrid.Text + " is Successfuly UPDATED!!!", "UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cleanme();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while Update...." + Environment.NewLine + ex);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Cleanme();
        }

       

        private void txtcusser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else { e.Handled = false; }

        }

       

       

        private void dtpretd_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime ren = dtprend.Value;
            DateTime ret = dtpretd.Value;
            TimeSpan difer = ret.Subtract(ren);
            int day = int.Parse(difer.ToString("dd")) + 1;
            int mon = day / 30;
            day = day % 30;
            int week = day / 7;
            day = day % 7;
            m.Text = mon.ToString();
            w.Text = week.ToString();
            d.Text = day.ToString();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
