namespace ayubo
{
    partial class rencusid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rencusid));
            this.txtcusfin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvcusfin = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btncus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcusfin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcusfin
            // 
            this.txtcusfin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtcusfin.Location = new System.Drawing.Point(160, 18);
            this.txtcusfin.Name = "txtcusfin";
            this.txtcusfin.Size = new System.Drawing.Size(147, 33);
            this.txtcusfin.TabIndex = 0;
            this.txtcusfin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // dgvcusfin
            // 
            this.dgvcusfin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcusfin.Location = new System.Drawing.Point(12, 69);
            this.dgvcusfin.Name = "dgvcusfin";
            this.dgvcusfin.Size = new System.Drawing.Size(494, 235);
            this.dgvcusfin.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(431, 311);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 34);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // btncus
            // 
            this.btncus.Location = new System.Drawing.Point(346, 17);
            this.btncus.Name = "btncus";
            this.btncus.Size = new System.Drawing.Size(160, 34);
            this.btncus.TabIndex = 4;
            this.btncus.Text = "Customer Detail";
            this.btncus.UseVisualStyleBackColor = true;
            this.btncus.Click += new System.EventHandler(this.btncus_Click);
            // 
            // rencusid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 351);
            this.ControlBox = false;
            this.Controls.Add(this.btncus);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dgvcusfin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcusfin);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "rencusid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent ID Finder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcusfin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcusfin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcusfin;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btncus;
    }
}