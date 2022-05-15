namespace ayubo
{
    partial class vehdetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehdetail));
            this.txtvno = new System.Windows.Forms.TextBox();
            this.cmbvno = new System.Windows.Forms.ComboBox();
            this.cmbvtyp = new System.Windows.Forms.ComboBox();
            this.txtscoun = new System.Windows.Forms.TextBox();
            this.cmbgtyp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcmil = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtvmod = new System.Windows.Forms.TextBox();
            this.txtvbrand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtvno
            // 
            this.txtvno.BackColor = System.Drawing.Color.White;
            this.txtvno.Location = new System.Drawing.Point(263, 19);
            this.txtvno.Name = "txtvno";
            this.txtvno.Size = new System.Drawing.Size(249, 33);
            this.txtvno.TabIndex = 0;
            // 
            // cmbvno
            // 
            this.cmbvno.BackColor = System.Drawing.Color.White;
            this.cmbvno.FormattingEnabled = true;
            this.cmbvno.Location = new System.Drawing.Point(263, 19);
            this.cmbvno.Name = "cmbvno";
            this.cmbvno.Size = new System.Drawing.Size(249, 33);
            this.cmbvno.TabIndex = 1;
            this.cmbvno.Visible = false;
            this.cmbvno.SelectedIndexChanged += new System.EventHandler(this.cmbvno_SelectedIndexChanged);
            // 
            // cmbvtyp
            // 
            this.cmbvtyp.BackColor = System.Drawing.Color.White;
            this.cmbvtyp.FormattingEnabled = true;
            this.cmbvtyp.Location = new System.Drawing.Point(263, 85);
            this.cmbvtyp.Name = "cmbvtyp";
            this.cmbvtyp.Size = new System.Drawing.Size(249, 33);
            this.cmbvtyp.TabIndex = 2;
            // 
            // txtscoun
            // 
            this.txtscoun.BackColor = System.Drawing.Color.White;
            this.txtscoun.Location = new System.Drawing.Point(263, 282);
            this.txtscoun.Name = "txtscoun";
            this.txtscoun.Size = new System.Drawing.Size(249, 33);
            this.txtscoun.TabIndex = 5;
            // 
            // cmbgtyp
            // 
            this.cmbgtyp.BackColor = System.Drawing.Color.White;
            this.cmbgtyp.FormattingEnabled = true;
            this.cmbgtyp.Items.AddRange(new object[] {
            "      _ _ Select _ _",
            "AUTO",
            "Manual"});
            this.cmbgtyp.Location = new System.Drawing.Point(263, 353);
            this.cmbgtyp.Name = "cmbgtyp";
            this.cmbgtyp.Size = new System.Drawing.Size(249, 33);
            this.cmbgtyp.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vehicle No     ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vehicle Type  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(39, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Vehicle Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vehicle Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(39, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Seat Count     ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(39, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gear Type      ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Current Milage";
            // 
            // txtcmil
            // 
            this.txtcmil.BackColor = System.Drawing.Color.White;
            this.txtcmil.Location = new System.Drawing.Point(263, 416);
            this.txtcmil.Name = "txtcmil";
            this.txtcmil.Size = new System.Drawing.Size(249, 33);
            this.txtcmil.TabIndex = 19;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(323, 490);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 35);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(323, 490);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 35);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnback.Location = new System.Drawing.Point(413, 490);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 35);
            this.btnback.TabIndex = 22;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(226, 490);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 35);
            this.btnclear.TabIndex = 21;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(129, 490);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 35);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtvmod
            // 
            this.txtvmod.BackColor = System.Drawing.Color.White;
            this.txtvmod.Location = new System.Drawing.Point(263, 217);
            this.txtvmod.Name = "txtvmod";
            this.txtvmod.Size = new System.Drawing.Size(249, 33);
            this.txtvmod.TabIndex = 25;
            // 
            // txtvbrand
            // 
            this.txtvbrand.BackColor = System.Drawing.Color.White;
            this.txtvbrand.Location = new System.Drawing.Point(263, 151);
            this.txtvbrand.Name = "txtvbrand";
            this.txtvbrand.Size = new System.Drawing.Size(249, 33);
            this.txtvbrand.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(297, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Offroad";
            // 
            // vehdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(563, 551);
            this.ControlBox = false;
            this.Controls.Add(this.txtvbrand);
            this.Controls.Add(this.txtvmod);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtscoun);
            this.Controls.Add(this.cmbvtyp);
            this.Controls.Add(this.cmbvno);
            this.Controls.Add(this.txtvno);
            this.Controls.Add(this.cmbgtyp);
            this.Controls.Add(this.txtcmil);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "vehdetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vehdetail ";
            this.Load += new System.EventHandler(this.vehdetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvno;
        private System.Windows.Forms.ComboBox cmbvno;
        private System.Windows.Forms.ComboBox cmbvtyp;
        private System.Windows.Forms.TextBox txtscoun;
        private System.Windows.Forms.ComboBox cmbgtyp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcmil;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtvmod;
        private System.Windows.Forms.TextBox txtvbrand;
        private System.Windows.Forms.Label label8;
    }
}