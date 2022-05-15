namespace ayubo
{
    partial class driver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(driver));
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdcon = new System.Windows.Forms.TextBox();
            this.txtdadd = new System.Windows.Forms.TextBox();
            this.txtdnam = new System.Windows.Forms.TextBox();
            this.txtdid = new System.Windows.Forms.TextBox();
            this.cmbdid = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtli = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Driver Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(37, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Driver Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Driver Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Driver ID";
            // 
            // txtdcon
            // 
            this.txtdcon.BackColor = System.Drawing.Color.White;
            this.txtdcon.Location = new System.Drawing.Point(230, 247);
            this.txtdcon.MaxLength = 10;
            this.txtdcon.Name = "txtdcon";
            this.txtdcon.Size = new System.Drawing.Size(221, 33);
            this.txtdcon.TabIndex = 18;
            this.txtdcon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdcon_KeyPress);
            // 
            // txtdadd
            // 
            this.txtdadd.BackColor = System.Drawing.Color.White;
            this.txtdadd.Location = new System.Drawing.Point(230, 162);
            this.txtdadd.Multiline = true;
            this.txtdadd.Name = "txtdadd";
            this.txtdadd.Size = new System.Drawing.Size(221, 63);
            this.txtdadd.TabIndex = 17;
            // 
            // txtdnam
            // 
            this.txtdnam.BackColor = System.Drawing.Color.White;
            this.txtdnam.Location = new System.Drawing.Point(230, 99);
            this.txtdnam.Name = "txtdnam";
            this.txtdnam.Size = new System.Drawing.Size(221, 33);
            this.txtdnam.TabIndex = 16;
            // 
            // txtdid
            // 
            this.txtdid.BackColor = System.Drawing.Color.White;
            this.txtdid.Enabled = false;
            this.txtdid.Location = new System.Drawing.Point(230, 33);
            this.txtdid.Name = "txtdid";
            this.txtdid.Size = new System.Drawing.Size(221, 33);
            this.txtdid.TabIndex = 15;
            this.txtdid.Text = "Auto Genareted Id";
            this.txtdid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbdid
            // 
            this.cmbdid.BackColor = System.Drawing.Color.White;
            this.cmbdid.FormattingEnabled = true;
            this.cmbdid.Items.AddRange(new object[] {
            "--SELECT--"});
            this.cmbdid.Location = new System.Drawing.Point(230, 33);
            this.cmbdid.Name = "cmbdid";
            this.cmbdid.Size = new System.Drawing.Size(221, 33);
            this.cmbdid.TabIndex = 14;
            this.cmbdid.Visible = false;
            this.cmbdid.SelectedIndexChanged += new System.EventHandler(this.cmbdid_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "License No";
            // 
            // txtli
            // 
            this.txtli.BackColor = System.Drawing.Color.White;
            this.txtli.Location = new System.Drawing.Point(230, 307);
            this.txtli.MaxLength = 8;
            this.txtli.Name = "txtli";
            this.txtli.Size = new System.Drawing.Size(221, 33);
            this.txtli.TabIndex = 23;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(288, 355);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(84, 35);
            this.btnupdate.TabIndex = 29;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Visible = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(288, 355);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(84, 35);
            this.btnsave.TabIndex = 28;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnback.Location = new System.Drawing.Point(401, 355);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 35);
            this.btnback.TabIndex = 27;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(168, 355);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(79, 35);
            this.btnclear.TabIndex = 26;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(36, 355);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(87, 35);
            this.btnsearch.TabIndex = 25;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 402);
            this.ControlBox = false;
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdcon);
            this.Controls.Add(this.txtdadd);
            this.Controls.Add(this.txtdnam);
            this.Controls.Add(this.txtdid);
            this.Controls.Add(this.cmbdid);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdcon;
        private System.Windows.Forms.TextBox txtdadd;
        private System.Windows.Forms.TextBox txtdnam;
        private System.Windows.Forms.TextBox txtdid;
        private System.Windows.Forms.ComboBox cmbdid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtli;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsearch;

    }
}