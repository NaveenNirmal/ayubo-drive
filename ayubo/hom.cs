using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayubo
{
    public partial class hom : Form
    {
        public hom()
        {
            InitializeComponent();
        }

       
        //Customer detail form load button
        private void btncus_Click(object sender, EventArgs e)
        {
            h3.Controls.Clear();
            rencusdetails myForm = new rencusdetails();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            h3.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        //vehicle details load button
        private void btnveh_Click(object sender, EventArgs e)
        {
            h3.Controls.Clear();
            vehdetail myForm = new vehdetail();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            h3.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        // employee details loading button
        private void btnemp_Click(object sender, EventArgs e)
        {
            h3.Controls.Clear();
            driver myForm = new driver();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            h3.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

       
        //rent details loading button
        private void btnren_Click_1(object sender, EventArgs e)
        {
            h3.Controls.Clear();
            rendetail myForm = new rendetail();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            h3.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();

            
            
        }

        // hire details loading button
        private void btnhire_Click(object sender, EventArgs e)
        {
            h3.Controls.Clear();
            lhire myForm = new lhire();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            h3.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        // rent payment form loading
        private void button1_Click(object sender, EventArgs e)
        {
            h3.Controls.Clear();
            Renpay myForm = new Renpay();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            h3.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }


        // hire payment form loading button
        private void button2_Click(object sender, EventArgs e)
        {
            h3.Controls.Clear();
            mhire myForm = new mhire();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            h3.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }


        // pack detail form load
        private void button3_Click(object sender, EventArgs e)
        {
            h3.Controls.Clear();
            pack myForm = new pack();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            h3.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }


        // log out button
        private void button4_Click(object sender, EventArgs e)
        {
            log_in home = new log_in();
            this.Dispose();
            home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            h3.Controls.Clear();
            vehtyp myForm = new vehtyp();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            h3.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        


    }
}
