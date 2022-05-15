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
    public partial class rencusid : Form
    {
        public rencusid()
        {
            InitializeComponent();
        }

        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataSet dset = new DataSet();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-R4FED6O\SQLEXPRESS;Initial Catalog=ayubo;Integrated Security=True");
       

        private void btnback_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvcusfin.Visible = true;
            try
            {
                dset.Reset();
                String loadinfo = "SELECT id as Customer_ID,rid as Rent_ID,rendat as Rent_Date,retdat as Return_Date FROM rendetail WHERE id='" + txtcusfin.Text + "'";
                conn.Open();
                sqlda = new SqlDataAdapter(loadinfo, conn);
                sqlda.Fill(dset, "Rent Finder");
                conn.Close();


                dgvcusfin.DataSource = dset.Tables["Rent Finder"];

                

                this.dgvcusfin.Columns[0].Width = 110;
                this.dgvcusfin.Columns[1].Width = 100;
                this.dgvcusfin.Columns[2].Width = 120;
                this.dgvcusfin.Columns[3].Width = 120;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while load..." + Environment.NewLine + ex);
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btncus_Click(object sender, EventArgs e)
        {
            rencusdetails home=new rencusdetails();
            this.Hide();
            home.Show();
        }
    }
}
