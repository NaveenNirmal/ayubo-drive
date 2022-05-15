namespace ayubo
{
    partial class rencusdetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rencusdetails));
            this.txtcusnam = new System.Windows.Forms.TextBox();
            this.txtcusadd = new System.Windows.Forms.TextBox();
            this.txtcuscon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblrh = new System.Windows.Forms.Label();
            this.cmbcusid = new System.Windows.Forms.ComboBox();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtcusnam
            // 
            this.txtcusnam.BackColor = System.Drawing.Color.White;
            this.txtcusnam.Location = new System.Drawing.Point(235, 78);
            this.txtcusnam.Name = "txtcusnam";
            this.txtcusnam.Size = new System.Drawing.Size(221, 33);
            this.txtcusnam.TabIndex = 2;
            // 
            // txtcusadd
            // 
            this.txtcusadd.BackColor = System.Drawing.Color.White;
            this.txtcusadd.Location = new System.Drawing.Point(235, 133);
            this.txtcusadd.Name = "txtcusadd";
            this.txtcusadd.Size = new System.Drawing.Size(221, 33);
            this.txtcusadd.TabIndex = 3;
            // 
            // txtcuscon
            // 
            this.txtcuscon.BackColor = System.Drawing.Color.White;
            this.txtcuscon.Location = new System.Drawing.Point(235, 191);
            this.txtcuscon.MaxLength = 10;
            this.txtcuscon.Name = "txtcuscon";
            this.txtcuscon.Size = new System.Drawing.Size(221, 33);
            this.txtcuscon.TabIndex = 6;
            this.txtcuscon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcuscon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Customer Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customer Contact No";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(113, 243);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(82, 35);
            this.btnsearch.TabIndex = 15;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(217, 243);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 35);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnback.Location = new System.Drawing.Point(413, 243);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 35);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(323, 243);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 35);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(323, 243);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 35);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblrh
            // 
            this.lblrh.AutoSize = true;
            this.lblrh.BackColor = System.Drawing.Color.Transparent;
            this.lblrh.ForeColor = System.Drawing.Color.Transparent;
            this.lblrh.Location = new System.Drawing.Point(243, 81);
            this.lblrh.Name = "lblrh";
            this.lblrh.Size = new System.Drawing.Size(49, 25);
            this.lblrh.TabIndex = 49;
            this.lblrh.Text = "Rent";
            this.lblrh.Visible = false;
            // 
            // cmbcusid
            // 
            this.cmbcusid.BackColor = System.Drawing.Color.White;
            this.cmbcusid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcusid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbcusid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcusid.FormattingEnabled = true;
            this.cmbcusid.Items.AddRange(new object[] {
            "select"});
            this.cmbcusid.Location = new System.Drawing.Point(235, 18);
            this.cmbcusid.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.cmbcusid.Name = "cmbcusid";
            this.cmbcusid.Size = new System.Drawing.Size(221, 33);
            this.cmbcusid.TabIndex = 20;
            this.cmbcusid.Visible = false;
            this.cmbcusid.SelectedIndexChanged += new System.EventHandler(this.cmbcusid_SelectedIndexChanged);
            // 
            // txtcusid
            // 
            this.txtcusid.BackColor = System.Drawing.Color.White;
            this.txtcusid.Location = new System.Drawing.Point(235, 18);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(221, 33);
            this.txtcusid.TabIndex = 50;
            this.txtcusid.TextChanged += new System.EventHandler(this.txtcusid_TextChanged);
            // 
            // rencusdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 306);
            this.ControlBox = false;
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.cmbcusid);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcuscon);
            this.Controls.Add(this.txtcusadd);
            this.Controls.Add(this.txtcusnam);
            this.Controls.Add(this.lblrh);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "rencusdetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rencusdetails";
            this.Load += new System.EventHandler(this.rencusdetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcusnam;
        private System.Windows.Forms.TextBox txtcusadd;
        private System.Windows.Forms.TextBox txtcuscon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblrh;
        private System.Windows.Forms.ComboBox cmbcusid;
        private System.Windows.Forms.TextBox txtcusid;
    }
}