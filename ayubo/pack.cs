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
    public partial class pack : Form
    {
        public pack()
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
            txthtyp.Text = "";
            cmbht.SelectedIndex=0;
            txtp.Text = "";
            txtkl.Text = "";
            txtkp.Text = "";
            txttl.Text = "";
            txttp.Text = "";
            txtn.Text = "";
            txtc.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleanme();

        }
        // save details
        private void button1_Click(object sender, EventArgs e)
        {
            if (txthtyp.Text == "" || txtp.Text == "" || txtkl.Text == "" || txtkp.Text == "" || txttl.Text == "" || txttp.Text == "" )
            {
                MessageBox.Show("Some Fields are empty... Please Fill all to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                try
                {
                    conn.Open();
                    string sav = "INSERT INTO hirecost VALUES('" + txthtyp.Text + "','" + cmbpak.Text + "','" + txtp.Text + "','" + txtkl.Text + "','" + txtkp.Text + "','" + txttl.Text + "','" + txttp.Text + "','" + txtn.Text + "','" + txtc.Text + "')";
                    cmd = new SqlCommand(sav, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Package -" + txthtyp.Text + " has Registred to systeam under the Package-" + txthtyp.Text + " Successfully!", "Save " + txthtyp.Text + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleanme();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while save..." + Environment.NewLine + ex);
                }
            }

        }
        //search option
        private void button2_Click(object sender, EventArgs e)
        {
            txthtyp.Visible=false;
            cmbht.Visible=true;

             try
            {
                String get = "SELECT hiretyp FROM hirecost";
                conn.Open();
                sqlda = new SqlDataAdapter(get, conn);
                conn.Close();
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                cmbht.Items.Clear();

                cmbht.Items.Add("         _ _ Select _ _");
                foreach (DataRow row in dt.Rows)
                {
                    cmbht.Items.Add(row["hiretyp"]);
                }
                cmbht.SelectedIndex = 0;
            }

            catch (Exception msgerr)
            {
                MessageBox.Show("Error while Load package to the Combo Box...." + Environment.NewLine + msgerr);
            }



        }

        private void txthtyp_TextChanged(object sender, EventArgs e)
        {
            txtn.Text = "";
            txtc.Text = "";
        }

        private void cmbht_SelectedIndexChanged(object sender, EventArgs e)
        {
        try
            {
                if (cmbht.SelectedIndex == 0)
                {
                    txtp.Text="";
                    txtkl.Text="";
                    txtkp.Text="";
                    txttl.Text="";
                    txttp.Text="";
                    txtn.Text="";
                    txtp.Text="";
                    
                    
                }
                else
                {
                    string getdipdet = "SELECT * FROM hirecost WHERE hiretyp='" + cmbht.Text + "'";
                    conn.Open();
                    cmd = new SqlCommand(getdipdet, conn);
                    SqlDataReader R = cmd.ExecuteReader();

                    while (R.Read())
                    {
                        txtp.Text = R.GetValue(2).ToString();
                        cmbpak.Text = R.GetValue(1).ToString();
                        txtkl.Text = R.GetValue(3).ToString();
                        txtkp.Text = R.GetValue(4).ToString();
                        txttl.Text = R.GetValue(5).ToString();
                        txttp.Text = R.GetValue(6).ToString();
                        txtn.Text = R.GetValue(7).ToString();
                        txtc.Text = R.GetValue(8).ToString();
                        
                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Selecting Details of the Customer Detail...." + Environment.NewLine + ex);
            }
        }
        //update option
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string upcus = "UPDATE hirecost SET hpak='"+cmbpak.Text+"',price='" + txtp.Text + "',kmlim='" + txtkl.Text + "',okmpri='" + txtkp.Text + "',timelim='" + txttl.Text + "',otimpri='" + txttp.Text + "',overnig='" + txtn.Text + "',parking='" + txtc.Text + "' WHERE hiretyp='" + cmbht.Text + "'";
                conn.Open();
                cmd = new SqlCommand(upcus, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Package type:- " + cmbht.Text + " is Successfuly UPDATED!!!", "UPDATE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleanme();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while Update...." + Environment.NewLine + ex);
            }
        }

        private void cmbpak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbpak.SelectedIndex == 2)
            {
                label2.Visible = true;
                label8.Visible = true;
                txtn.Visible = true;
                txtc.Visible = true;
            }
            else
            {
                label2.Visible = false;
                label8.Visible = false;
                txtn.Visible = false;
                txtc.Visible = false;
                txtn.Text = "0";
                txtc.Text = "0";
            }
        }
    }
}
