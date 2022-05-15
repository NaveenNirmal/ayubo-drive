namespace ayubo
{
    partial class rendetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rendetail));
            this.cmbrid = new System.Windows.Forms.ComboBox();
            this.cmbvehno = new System.Windows.Forms.ComboBox();
            this.cmbdop = new System.Windows.Forms.ComboBox();
            this.cmbdid = new System.Windows.Forms.ComboBox();
            this.Rent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbvtype = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnrenserch = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.d = new System.Windows.Forms.Label();
            this.w = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.wdhdfg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtautoren = new System.Windows.Forms.TextBox();
            this.txtcusser = new System.Windows.Forms.TextBox();
            this.lblvtyp = new System.Windows.Forms.Label();
            this.lblmil = new System.Windows.Forms.Label();
            this.ayuboDataSet = new ayubo.ayuboDataSet();
            this.vehdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehdetailTableAdapter = new ayubo.ayuboDataSetTableAdapters.vehdetailTableAdapter();
            this.dgvvdet = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.Label();
            this.lblcid = new System.Windows.Forms.Label();
            this.lblnd = new System.Windows.Forms.Label();
            this.dtprend = new System.Windows.Forms.DateTimePicker();
            this.dtpretd = new System.Windows.Forms.DateTimePicker();
            this.lblvno = new System.Windows.Forms.Label();
            this.lbldid = new System.Windows.Forms.Label();
            this.lbldopt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvdet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbrid
            // 
            this.cmbrid.BackColor = System.Drawing.Color.White;
            this.cmbrid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbrid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrid.FormattingEnabled = true;
            this.cmbrid.Location = new System.Drawing.Point(165, 15);
            this.cmbrid.Margin = new System.Windows.Forms.Padding(6);
            this.cmbrid.Name = "cmbrid";
            this.cmbrid.Size = new System.Drawing.Size(219, 33);
            this.cmbrid.TabIndex = 0;
            this.cmbrid.Visible = false;
            this.cmbrid.SelectedIndexChanged += new System.EventHandler(this.cmbrid_SelectedIndexChanged);
            // 
            // cmbvehno
            // 
            this.cmbvehno.BackColor = System.Drawing.Color.White;
            this.cmbvehno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvehno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbvehno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbvehno.FormattingEnabled = true;
            this.cmbvehno.Items.AddRange(new object[] {
            "Select Vehicle Type"});
            this.cmbvehno.Location = new System.Drawing.Point(165, 214);
            this.cmbvehno.Margin = new System.Windows.Forms.Padding(6);
            this.cmbvehno.Name = "cmbvehno";
            this.cmbvehno.Size = new System.Drawing.Size(219, 33);
            this.cmbvehno.TabIndex = 7;
            this.cmbvehno.SelectedIndexChanged += new System.EventHandler(this.cmbvehno_SelectedIndexChanged);
            // 
            // cmbdop
            // 
            this.cmbdop.BackColor = System.Drawing.Color.White;
            this.cmbdop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbdop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdop.FormattingEnabled = true;
            this.cmbdop.Items.AddRange(new object[] {
            "         _ _ select _ _ ",
            "With",
            "With Out"});
            this.cmbdop.Location = new System.Drawing.Point(165, 428);
            this.cmbdop.Margin = new System.Windows.Forms.Padding(6);
            this.cmbdop.Name = "cmbdop";
            this.cmbdop.Size = new System.Drawing.Size(219, 33);
            this.cmbdop.TabIndex = 8;
            this.cmbdop.SelectedIndexChanged += new System.EventHandler(this.cmbdop_SelectedIndexChanged);
            // 
            // cmbdid
            // 
            this.cmbdid.BackColor = System.Drawing.Color.White;
            this.cmbdid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbdid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdid.FormattingEnabled = true;
            this.cmbdid.Items.AddRange(new object[] {
            "_ _ _ select _ _ _"});
            this.cmbdid.Location = new System.Drawing.Point(165, 504);
            this.cmbdid.Margin = new System.Windows.Forms.Padding(6);
            this.cmbdid.Name = "cmbdid";
            this.cmbdid.Size = new System.Drawing.Size(219, 33);
            this.cmbdid.TabIndex = 9;
            // 
            // Rent
            // 
            this.Rent.AutoSize = true;
            this.Rent.BackColor = System.Drawing.Color.Transparent;
            this.Rent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.ForeColor = System.Drawing.Color.Black;
            this.Rent.Location = new System.Drawing.Point(6, 15);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(112, 25);
            this.Rent.TabIndex = 10;
            this.Rent.Text = "Rent ID        ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rented Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Return Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(2, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Vehicle No   ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(-1, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Driver option";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(2, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Driver ID      ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-2, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Start Milage  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Vehicle Type";
            // 
            // cmbvtype
            // 
            this.cmbvtype.BackColor = System.Drawing.Color.White;
            this.cmbvtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbvtype.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbvtype.FormattingEnabled = true;
            this.cmbvtype.Location = new System.Drawing.Point(165, 150);
            this.cmbvtype.Margin = new System.Windows.Forms.Padding(6);
            this.cmbvtype.Name = "cmbvtype";
            this.cmbvtype.Size = new System.Drawing.Size(219, 33);
            this.cmbvtype.TabIndex = 29;
            this.cmbvtype.TabStop = false;
            this.cmbvtype.SelectedIndexChanged += new System.EventHandler(this.cmbvtype_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Customer ID";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(771, 542);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(113, 35);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(770, 428);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(114, 41);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(771, 481);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(113, 41);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsearch.Location = new System.Drawing.Point(771, 371);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(114, 45);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnrenserch
            // 
            this.btnrenserch.BackColor = System.Drawing.Color.AliceBlue;
            this.btnrenserch.Image = ((System.Drawing.Image)(resources.GetObject("btnrenserch.Image")));
            this.btnrenserch.Location = new System.Drawing.Point(700, 258);
            this.btnrenserch.Name = "btnrenserch";
            this.btnrenserch.Size = new System.Drawing.Size(194, 95);
            this.btnrenserch.TabIndex = 5;
            this.btnrenserch.UseVisualStyleBackColor = false;
            this.btnrenserch.Click += new System.EventHandler(this.btnrenserch_Click);
            // 
            // btnbook
            // 
            this.btnbook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnbook.Location = new System.Drawing.Point(770, 428);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(115, 40);
            this.btnbook.TabIndex = 4;
            this.btnbook.Text = "Save";
            this.btnbook.UseVisualStyleBackColor = false;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // txtcusid
            // 
            this.txtcusid.BackColor = System.Drawing.Color.White;
            this.txtcusid.Location = new System.Drawing.Point(165, 79);
            this.txtcusid.MaxLength = 12;
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(219, 33);
            this.txtcusid.TabIndex = 38;
            this.txtcusid.TextChanged += new System.EventHandler(this.txtcusid_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.d);
            this.groupBox1.Controls.Add(this.w);
            this.groupBox1.Controls.Add(this.m);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.wdhdfg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(428, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 288);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rent Period";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.BackColor = System.Drawing.Color.White;
            this.d.ForeColor = System.Drawing.Color.Black;
            this.d.Location = new System.Drawing.Point(59, 237);
            this.d.MinimumSize = new System.Drawing.Size(70, 33);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(70, 33);
            this.d.TabIndex = 51;
            this.d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.BackColor = System.Drawing.Color.White;
            this.w.ForeColor = System.Drawing.Color.Black;
            this.w.Location = new System.Drawing.Point(59, 152);
            this.w.MinimumSize = new System.Drawing.Size(70, 33);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(70, 33);
            this.w.TabIndex = 50;
            this.w.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.BackColor = System.Drawing.Color.White;
            this.m.ForeColor = System.Drawing.Color.Black;
            this.m.Location = new System.Drawing.Point(59, 64);
            this.m.MinimumSize = new System.Drawing.Size(70, 33);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(70, 33);
            this.m.TabIndex = 49;
            this.m.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Days";
            // 
            // wdhdfg
            // 
            this.wdhdfg.AutoSize = true;
            this.wdhdfg.BackColor = System.Drawing.Color.Transparent;
            this.wdhdfg.ForeColor = System.Drawing.Color.Black;
            this.wdhdfg.Location = new System.Drawing.Point(20, 110);
            this.wdhdfg.Name = "wdhdfg";
            this.wdhdfg.Size = new System.Drawing.Size(66, 25);
            this.wdhdfg.TabIndex = 30;
            this.wdhdfg.Text = "Weeks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Months";
            // 
            // txtautoren
            // 
            this.txtautoren.BackColor = System.Drawing.Color.White;
            this.txtautoren.Location = new System.Drawing.Point(165, 15);
            this.txtautoren.Name = "txtautoren";
            this.txtautoren.Size = new System.Drawing.Size(219, 33);
            this.txtautoren.TabIndex = 41;
            this.txtautoren.Text = "Auto Genareted Id";
            this.txtautoren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcusser
            // 
            this.txtcusser.BackColor = System.Drawing.Color.White;
            this.txtcusser.Location = new System.Drawing.Point(165, 80);
            this.txtcusser.MaxLength = 12;
            this.txtcusser.Name = "txtcusser";
            this.txtcusser.Size = new System.Drawing.Size(219, 33);
            this.txtcusser.TabIndex = 44;
            this.txtcusser.Visible = false;
            this.txtcusser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcusser_KeyPress);
            // 
            // lblvtyp
            // 
            this.lblvtyp.AutoSize = true;
            this.lblvtyp.BackColor = System.Drawing.Color.White;
            this.lblvtyp.Location = new System.Drawing.Point(165, 153);
            this.lblvtyp.MinimumSize = new System.Drawing.Size(219, 33);
            this.lblvtyp.Name = "lblvtyp";
            this.lblvtyp.Size = new System.Drawing.Size(219, 33);
            this.lblvtyp.TabIndex = 47;
            this.lblvtyp.Visible = false;
            // 
            // lblmil
            // 
            this.lblmil.AutoSize = true;
            this.lblmil.BackColor = System.Drawing.Color.White;
            this.lblmil.Location = new System.Drawing.Point(165, 562);
            this.lblmil.MinimumSize = new System.Drawing.Size(219, 33);
            this.lblmil.Name = "lblmil";
            this.lblmil.Size = new System.Drawing.Size(219, 33);
            this.lblmil.TabIndex = 49;
            // 
            // ayuboDataSet
            // 
            this.ayuboDataSet.DataSetName = "ayuboDataSet";
            this.ayuboDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehdetailBindingSource
            // 
            this.vehdetailBindingSource.DataMember = "vehdetail";
            this.vehdetailBindingSource.DataSource = this.ayuboDataSet;
            // 
            // vehdetailTableAdapter
            // 
            this.vehdetailTableAdapter.ClearBeforeFill = true;
            // 
            // dgvvdet
            // 
            this.dgvvdet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvdet.Location = new System.Drawing.Point(393, 15);
            this.dgvvdet.Name = "dgvvdet";
            this.dgvvdet.Size = new System.Drawing.Size(475, 232);
            this.dgvvdet.TabIndex = 50;
            // 
            // cid
            // 
            this.cid.AutoSize = true;
            this.cid.BackColor = System.Drawing.Color.Transparent;
            this.cid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid.Location = new System.Drawing.Point(168, 58);
            this.cid.MinimumSize = new System.Drawing.Size(219, 20);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(219, 20);
            this.cid.TabIndex = 51;
            this.cid.Visible = false;
            // 
            // lblcid
            // 
            this.lblcid.AutoSize = true;
            this.lblcid.BackColor = System.Drawing.Color.Transparent;
            this.lblcid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcid.ForeColor = System.Drawing.Color.Black;
            this.lblcid.Location = new System.Drawing.Point(6, 58);
            this.lblcid.Name = "lblcid";
            this.lblcid.Size = new System.Drawing.Size(145, 20);
            this.lblcid.TabIndex = 52;
            this.lblcid.Text = "Current Cuatomer ID";
            this.lblcid.Visible = false;
            // 
            // lblnd
            // 
            this.lblnd.AutoSize = true;
            this.lblnd.BackColor = System.Drawing.Color.White;
            this.lblnd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnd.ForeColor = System.Drawing.Color.Transparent;
            this.lblnd.Location = new System.Drawing.Point(220, 507);
            this.lblnd.Name = "lblnd";
            this.lblnd.Size = new System.Drawing.Size(93, 25);
            this.lblnd.TabIndex = 53;
            this.lblnd.Text = "No Driver";
            // 
            // dtprend
            // 
            this.dtprend.Enabled = false;
            this.dtprend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtprend.Location = new System.Drawing.Point(165, 287);
            this.dtprend.MinDate = new System.DateTime(2020, 9, 16, 0, 0, 0, 0);
            this.dtprend.Name = "dtprend";
            this.dtprend.Size = new System.Drawing.Size(200, 33);
            this.dtprend.TabIndex = 54;
            // 
            // dtpretd
            // 
            this.dtpretd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpretd.Location = new System.Drawing.Point(165, 350);
            this.dtpretd.MinDate = new System.DateTime(2020, 9, 16, 0, 0, 0, 0);
            this.dtpretd.Name = "dtpretd";
            this.dtpretd.Size = new System.Drawing.Size(200, 33);
            this.dtpretd.TabIndex = 55;
            this.dtpretd.ValueChanged += new System.EventHandler(this.dtpretd_ValueChanged_1);
            // 
            // lblvno
            // 
            this.lblvno.AutoSize = true;
            this.lblvno.BackColor = System.Drawing.Color.White;
            this.lblvno.Location = new System.Drawing.Point(165, 214);
            this.lblvno.MinimumSize = new System.Drawing.Size(219, 33);
            this.lblvno.Name = "lblvno";
            this.lblvno.Size = new System.Drawing.Size(219, 33);
            this.lblvno.TabIndex = 56;
            this.lblvno.Visible = false;
            // 
            // lbldid
            // 
            this.lbldid.AutoSize = true;
            this.lbldid.BackColor = System.Drawing.Color.White;
            this.lbldid.Location = new System.Drawing.Point(165, 507);
            this.lbldid.MinimumSize = new System.Drawing.Size(219, 33);
            this.lbldid.Name = "lbldid";
            this.lbldid.Size = new System.Drawing.Size(219, 33);
            this.lbldid.TabIndex = 57;
            this.lbldid.Visible = false;
            // 
            // lbldopt
            // 
            this.lbldopt.AutoSize = true;
            this.lbldopt.BackColor = System.Drawing.Color.White;
            this.lbldopt.Location = new System.Drawing.Point(165, 428);
            this.lbldopt.MinimumSize = new System.Drawing.Size(219, 33);
            this.lbldopt.Name = "lbldopt";
            this.lbldopt.Size = new System.Drawing.Size(219, 33);
            this.lbldopt.TabIndex = 58;
            this.lbldopt.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(646, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 59;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rendetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 608);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbldopt);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lbldid);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.lblvno);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dtpretd);
            this.Controls.Add(this.btnrenserch);
            this.Controls.Add(this.dtprend);
            this.Controls.Add(this.lblcid);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.dgvvdet);
            this.Controls.Add(this.lblmil);
            this.Controls.Add(this.lblvtyp);
            this.Controls.Add(this.txtcusser);
            this.Controls.Add(this.txtautoren);
            this.Controls.Add(this.cmbvtype);
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rent);
            this.Controls.Add(this.cmbdid);
            this.Controls.Add(this.cmbdop);
            this.Controls.Add(this.cmbvehno);
            this.Controls.Add(this.cmbrid);
            this.Controls.Add(this.lblnd);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(897, 608);
            this.MinimumSize = new System.Drawing.Size(897, 608);
            this.Name = "rendetail";
            this.Text = "rendetail";
            this.Load += new System.EventHandler(this.rendetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ayuboDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbrid;
        private System.Windows.Forms.ComboBox cmbvehno;
        private System.Windows.Forms.ComboBox cmbdop;
        private System.Windows.Forms.ComboBox cmbdid;
        private System.Windows.Forms.Label Rent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbvtype;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnrenserch;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label wdhdfg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtautoren;
        private System.Windows.Forms.TextBox txtcusser;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label lblvtyp;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.Label lblmil;
        private ayuboDataSet ayuboDataSet;
        private System.Windows.Forms.BindingSource vehdetailBindingSource;
        private ayuboDataSetTableAdapters.vehdetailTableAdapter vehdetailTableAdapter;
        private System.Windows.Forms.DataGridView dgvvdet;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label cid;
        private System.Windows.Forms.Label lblcid;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblnd;
        private System.Windows.Forms.DateTimePicker dtprend;
        private System.Windows.Forms.DateTimePicker dtpretd;
        private System.Windows.Forms.Label lblvno;
        private System.Windows.Forms.Label lbldid;
        private System.Windows.Forms.Label lbldopt;
        private System.Windows.Forms.Button button1;
    }
}