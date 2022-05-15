namespace ayubo
{
    partial class lhire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lhire));
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnrenserch = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.txtcusser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbdid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbhtyp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbvehno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbvtyp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbhid = new System.Windows.Forms.ComboBox();
            this.lblcmil = new System.Windows.Forms.Label();
            this.dtpsdat = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpst = new System.Windows.Forms.DateTimePicker();
            this.lblvtyp = new System.Windows.Forms.Label();
            this.lblvno = new System.Windows.Forms.Label();
            this.lblhtyp = new System.Windows.Forms.Label();
            this.lbldid = new System.Windows.Forms.Label();
            this.txtautohire = new System.Windows.Forms.TextBox();
            this.qwer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbpak = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qwer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(762, 523);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(102, 35);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(762, 423);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(102, 41);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Visible = false;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(762, 476);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(102, 41);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsearch.Location = new System.Drawing.Point(762, 377);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(102, 40);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnrenserch
            // 
            this.btnrenserch.BackColor = System.Drawing.Color.AliceBlue;
            this.btnrenserch.Image = ((System.Drawing.Image)(resources.GetObject("btnrenserch.Image")));
            this.btnrenserch.Location = new System.Drawing.Point(687, 277);
            this.btnrenserch.Name = "btnrenserch";
            this.btnrenserch.Size = new System.Drawing.Size(194, 95);
            this.btnrenserch.TabIndex = 5;
            this.btnrenserch.UseVisualStyleBackColor = false;
            this.btnrenserch.Click += new System.EventHandler(this.btnrenserch_Click);
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.Color.LightGray;
            this.btnbook.ForeColor = System.Drawing.Color.Black;
            this.btnbook.Location = new System.Drawing.Point(762, 423);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(102, 41);
            this.btnbook.TabIndex = 4;
            this.btnbook.Text = "Save";
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // txtcusser
            // 
            this.txtcusser.Location = new System.Drawing.Point(146, 76);
            this.txtcusser.Name = "txtcusser";
            this.txtcusser.Size = new System.Drawing.Size(220, 33);
            this.txtcusser.TabIndex = 52;
            this.txtcusser.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(11, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Start Milage";
            // 
            // cmbdid
            // 
            this.cmbdid.FormattingEnabled = true;
            this.cmbdid.Location = new System.Drawing.Point(149, 301);
            this.cmbdid.Name = "cmbdid";
            this.cmbdid.Size = new System.Drawing.Size(220, 33);
            this.cmbdid.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(11, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Driver ID";
            // 
            // cmbhtyp
            // 
            this.cmbhtyp.FormattingEnabled = true;
            this.cmbhtyp.Location = new System.Drawing.Point(149, 246);
            this.cmbhtyp.Name = "cmbhtyp";
            this.cmbhtyp.Size = new System.Drawing.Size(220, 33);
            this.cmbhtyp.TabIndex = 47;
            this.cmbhtyp.SelectedIndexChanged += new System.EventHandler(this.cmbhtyp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(11, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Hire type";
            // 
            // cmbvehno
            // 
            this.cmbvehno.BackColor = System.Drawing.Color.White;
            this.cmbvehno.FormattingEnabled = true;
            this.cmbvehno.Items.AddRange(new object[] {
            "Select Vehicle Type"});
            this.cmbvehno.Location = new System.Drawing.Point(147, 185);
            this.cmbvehno.Name = "cmbvehno";
            this.cmbvehno.Size = new System.Drawing.Size(220, 33);
            this.cmbvehno.TabIndex = 45;
            this.cmbvehno.SelectedIndexChanged += new System.EventHandler(this.cmbvehno_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(9, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Vehicle No";
            // 
            // cmbvtyp
            // 
            this.cmbvtyp.BackColor = System.Drawing.Color.White;
            this.cmbvtyp.FormattingEnabled = true;
            this.cmbvtyp.Location = new System.Drawing.Point(145, 129);
            this.cmbvtyp.Name = "cmbvtyp";
            this.cmbvtyp.Size = new System.Drawing.Size(220, 33);
            this.cmbvtyp.TabIndex = 43;
            this.cmbvtyp.SelectedIndexChanged += new System.EventHandler(this.cmbvtyp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(7, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Vehicle Type";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(146, 76);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(220, 33);
            this.txtid.TabIndex = 41;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Hire ID";
            // 
            // cmbhid
            // 
            this.cmbhid.FormattingEnabled = true;
            this.cmbhid.Location = new System.Drawing.Point(146, 22);
            this.cmbhid.Name = "cmbhid";
            this.cmbhid.Size = new System.Drawing.Size(220, 33);
            this.cmbhid.TabIndex = 38;
            this.cmbhid.Visible = false;
            this.cmbhid.SelectedIndexChanged += new System.EventHandler(this.cmbhid_SelectedIndexChanged);
            // 
            // lblcmil
            // 
            this.lblcmil.AutoSize = true;
            this.lblcmil.BackColor = System.Drawing.Color.White;
            this.lblcmil.Location = new System.Drawing.Point(150, 359);
            this.lblcmil.MinimumSize = new System.Drawing.Size(220, 33);
            this.lblcmil.Name = "lblcmil";
            this.lblcmil.Size = new System.Drawing.Size(220, 33);
            this.lblcmil.TabIndex = 54;
            // 
            // dtpsdat
            // 
            this.dtpsdat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpsdat.Location = new System.Drawing.Point(146, 465);
            this.dtpsdat.MinDate = new System.DateTime(2020, 9, 16, 10, 16, 45, 0);
            this.dtpsdat.Name = "dtpsdat";
            this.dtpsdat.Size = new System.Drawing.Size(220, 33);
            this.dtpsdat.TabIndex = 55;
            this.dtpsdat.Value = new System.DateTime(2020, 9, 16, 10, 16, 45, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(8, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Start Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(7, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 60;
            this.label10.Text = "Start Time";
            // 
            // dtpst
            // 
            this.dtpst.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpst.Location = new System.Drawing.Point(145, 518);
            this.dtpst.Name = "dtpst";
            this.dtpst.Size = new System.Drawing.Size(220, 33);
            this.dtpst.TabIndex = 61;
            // 
            // lblvtyp
            // 
            this.lblvtyp.AutoSize = true;
            this.lblvtyp.BackColor = System.Drawing.Color.White;
            this.lblvtyp.Location = new System.Drawing.Point(147, 129);
            this.lblvtyp.MinimumSize = new System.Drawing.Size(219, 33);
            this.lblvtyp.Name = "lblvtyp";
            this.lblvtyp.Size = new System.Drawing.Size(219, 33);
            this.lblvtyp.TabIndex = 62;
            this.lblvtyp.Visible = false;
            // 
            // lblvno
            // 
            this.lblvno.AutoSize = true;
            this.lblvno.BackColor = System.Drawing.Color.White;
            this.lblvno.Location = new System.Drawing.Point(146, 185);
            this.lblvno.MinimumSize = new System.Drawing.Size(219, 33);
            this.lblvno.Name = "lblvno";
            this.lblvno.Size = new System.Drawing.Size(219, 33);
            this.lblvno.TabIndex = 63;
            this.lblvno.Visible = false;
            // 
            // lblhtyp
            // 
            this.lblhtyp.AutoSize = true;
            this.lblhtyp.BackColor = System.Drawing.Color.White;
            this.lblhtyp.Location = new System.Drawing.Point(150, 246);
            this.lblhtyp.MinimumSize = new System.Drawing.Size(219, 33);
            this.lblhtyp.Name = "lblhtyp";
            this.lblhtyp.Size = new System.Drawing.Size(219, 33);
            this.lblhtyp.TabIndex = 64;
            this.lblhtyp.Visible = false;
            // 
            // lbldid
            // 
            this.lbldid.AutoSize = true;
            this.lbldid.BackColor = System.Drawing.Color.White;
            this.lbldid.Location = new System.Drawing.Point(149, 301);
            this.lbldid.MinimumSize = new System.Drawing.Size(219, 33);
            this.lbldid.Name = "lbldid";
            this.lbldid.Size = new System.Drawing.Size(219, 33);
            this.lbldid.TabIndex = 65;
            this.lbldid.Visible = false;
            // 
            // txtautohire
            // 
            this.txtautohire.BackColor = System.Drawing.Color.White;
            this.txtautohire.Location = new System.Drawing.Point(147, 22);
            this.txtautohire.Name = "txtautohire";
            this.txtautohire.Size = new System.Drawing.Size(219, 33);
            this.txtautohire.TabIndex = 66;
            this.txtautohire.Text = "Auto Genareted Id";
            this.txtautohire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qwer
            // 
            this.qwer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qwer.Location = new System.Drawing.Point(399, 22);
            this.qwer.Name = "qwer";
            this.qwer.Size = new System.Drawing.Size(465, 232);
            this.qwer.TabIndex = 67;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(624, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 68;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(437, 326);
            this.label9.MinimumSize = new System.Drawing.Size(219, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 33);
            this.label9.TabIndex = 69;
            this.label9.Visible = false;
            // 
            // cmbpak
            // 
            this.cmbpak.FormattingEnabled = true;
            this.cmbpak.Items.AddRange(new object[] {
            "_ _ Select _ _",
            "Day Hire",
            "Long Hire"});
            this.cmbpak.Location = new System.Drawing.Point(147, 415);
            this.cmbpak.Name = "cmbpak";
            this.cmbpak.Size = new System.Drawing.Size(220, 33);
            this.cmbpak.TabIndex = 71;
            this.cmbpak.SelectedIndexChanged += new System.EventHandler(this.cmbpak_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(7, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 25);
            this.label11.TabIndex = 70;
            this.label11.Text = "Package Type";
            // 
            // lhire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 569);
            this.Controls.Add(this.cmbpak);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnrenserch);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.qwer);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtautohire);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.lbldid);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblhtyp);
            this.Controls.Add(this.lblvno);
            this.Controls.Add(this.lblvtyp);
            this.Controls.Add(this.dtpst);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpsdat);
            this.Controls.Add(this.lblcmil);
            this.Controls.Add(this.txtcusser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbdid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbhtyp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbvehno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbvtyp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbhid);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "lhire";
            this.Text = "lhire";
            this.Load += new System.EventHandler(this.lhire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qwer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnrenserch;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.TextBox txtcusser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbdid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbhtyp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbvehno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbvtyp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbhid;
        private System.Windows.Forms.Label lblcmil;
        private System.Windows.Forms.DateTimePicker dtpsdat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpst;
        private System.Windows.Forms.Label lblvtyp;
        private System.Windows.Forms.Label lblvno;
        private System.Windows.Forms.Label lblhtyp;
        private System.Windows.Forms.Label lbldid;
        private System.Windows.Forms.TextBox txtautohire;
        private System.Windows.Forms.DataGridView qwer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbpak;
        private System.Windows.Forms.Label label11;

    }
}