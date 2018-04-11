namespace WindowsFormsApplication2
{
    partial class updateAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateAvailability));
            this.aupdate = new System.Windows.Forms.Button();
            this.lblca_u = new System.Windows.Forms.Label();
            this.comboBox1_u = new System.Windows.Forms.ComboBox();
            this.rotime_u = new System.Windows.Forms.Label();
            this.lblavid_u = new System.Windows.Forms.Label();
            this.lblAdid_u = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.avid_u = new System.Windows.Forms.Label();
            this.txtrsrch = new System.Windows.Forms.TextBox();
            this.rsb1 = new System.Windows.Forms.Label();
            this.dback1 = new System.Windows.Forms.Button();
            this.txtavid_u = new System.Windows.Forms.TextBox();
            this.txtadid_u = new System.Windows.Forms.TextBox();
            this.adid_u = new System.Windows.Forms.Label();
            this.rdataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aupdate
            // 
            this.aupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.aupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aupdate.Location = new System.Drawing.Point(29, 362);
            this.aupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aupdate.Name = "aupdate";
            this.aupdate.Size = new System.Drawing.Size(117, 39);
            this.aupdate.TabIndex = 61;
            this.aupdate.Text = "Update";
            this.aupdate.UseVisualStyleBackColor = false;
            this.aupdate.Click += new System.EventHandler(this.aadd_Click);
            // 
            // lblca_u
            // 
            this.lblca_u.AutoSize = true;
            this.lblca_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblca_u.ForeColor = System.Drawing.Color.Red;
            this.lblca_u.Location = new System.Drawing.Point(171, 39);
            this.lblca_u.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblca_u.Name = "lblca_u";
            this.lblca_u.Size = new System.Drawing.Size(125, 17);
            this.lblca_u.TabIndex = 59;
            this.lblca_u.Text = "Click Availability";
            this.lblca_u.Visible = false;
            // 
            // comboBox1_u
            // 
            this.comboBox1_u.FormattingEnabled = true;
            this.comboBox1_u.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.comboBox1_u.Location = new System.Drawing.Point(160, 10);
            this.comboBox1_u.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1_u.Name = "comboBox1_u";
            this.comboBox1_u.Size = new System.Drawing.Size(225, 24);
            this.comboBox1_u.TabIndex = 7;
            // 
            // rotime_u
            // 
            this.rotime_u.AutoSize = true;
            this.rotime_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotime_u.ForeColor = System.Drawing.Color.White;
            this.rotime_u.Location = new System.Drawing.Point(13, 16);
            this.rotime_u.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotime_u.Name = "rotime_u";
            this.rotime_u.Size = new System.Drawing.Size(100, 20);
            this.rotime_u.TabIndex = 6;
            this.rotime_u.Text = "Availability";
            // 
            // lblavid_u
            // 
            this.lblavid_u.AutoSize = true;
            this.lblavid_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavid_u.ForeColor = System.Drawing.Color.Red;
            this.lblavid_u.Location = new System.Drawing.Point(189, 108);
            this.lblavid_u.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavid_u.Name = "lblavid_u";
            this.lblavid_u.Size = new System.Drawing.Size(125, 17);
            this.lblavid_u.TabIndex = 58;
            this.lblavid_u.Text = "Enter Vehicle ID";
            this.lblavid_u.Visible = false;
            // 
            // lblAdid_u
            // 
            this.lblAdid_u.AutoSize = true;
            this.lblAdid_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdid_u.ForeColor = System.Drawing.Color.Red;
            this.lblAdid_u.Location = new System.Drawing.Point(189, 60);
            this.lblAdid_u.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdid_u.Name = "lblAdid_u";
            this.lblAdid_u.Size = new System.Drawing.Size(116, 17);
            this.lblAdid_u.TabIndex = 57;
            this.lblAdid_u.Text = "Enter Driver ID";
            this.lblAdid_u.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblca_u);
            this.panel2.Controls.Add(this.comboBox1_u);
            this.panel2.Controls.Add(this.rotime_u);
            this.panel2.Location = new System.Drawing.Point(17, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 68);
            this.panel2.TabIndex = 56;
            // 
            // avid_u
            // 
            this.avid_u.AutoSize = true;
            this.avid_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avid_u.ForeColor = System.Drawing.Color.White;
            this.avid_u.Location = new System.Drawing.Point(33, 80);
            this.avid_u.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avid_u.Name = "avid_u";
            this.avid_u.Size = new System.Drawing.Size(90, 20);
            this.avid_u.TabIndex = 5;
            this.avid_u.Text = "VehicleID";
            // 
            // txtrsrch
            // 
            this.txtrsrch.Location = new System.Drawing.Point(935, 23);
            this.txtrsrch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtrsrch.Name = "txtrsrch";
            this.txtrsrch.Size = new System.Drawing.Size(245, 22);
            this.txtrsrch.TabIndex = 59;
            this.txtrsrch.TextChanged += new System.EventHandler(this.txtrsrch_TextChanged);
            // 
            // rsb1
            // 
            this.rsb1.AutoSize = true;
            this.rsb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsb1.ForeColor = System.Drawing.Color.White;
            this.rsb1.Location = new System.Drawing.Point(827, 23);
            this.rsb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rsb1.Name = "rsb1";
            this.rsb1.Size = new System.Drawing.Size(81, 25);
            this.rsb1.TabIndex = 58;
            this.rsb1.Text = "Search";
            this.rsb1.Click += new System.EventHandler(this.rsb1_Click);
            // 
            // dback1
            // 
            this.dback1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dback1.Image = ((System.Drawing.Image)(resources.GetObject("dback1.Image")));
            this.dback1.Location = new System.Drawing.Point(29, 9);
            this.dback1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dback1.Name = "dback1";
            this.dback1.Size = new System.Drawing.Size(71, 51);
            this.dback1.TabIndex = 57;
            this.dback1.UseVisualStyleBackColor = true;
            this.dback1.Click += new System.EventHandler(this.dback1_Click);
            // 
            // txtavid_u
            // 
            this.txtavid_u.Location = new System.Drawing.Point(179, 80);
            this.txtavid_u.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtavid_u.Name = "txtavid_u";
            this.txtavid_u.Size = new System.Drawing.Size(184, 22);
            this.txtavid_u.TabIndex = 10;
            // 
            // txtadid_u
            // 
            this.txtadid_u.Location = new System.Drawing.Point(179, 32);
            this.txtadid_u.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtadid_u.Name = "txtadid_u";
            this.txtadid_u.Size = new System.Drawing.Size(184, 22);
            this.txtadid_u.TabIndex = 9;
            // 
            // adid_u
            // 
            this.adid_u.AutoSize = true;
            this.adid_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adid_u.ForeColor = System.Drawing.Color.White;
            this.adid_u.Location = new System.Drawing.Point(33, 32);
            this.adid_u.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adid_u.Name = "adid_u";
            this.adid_u.Size = new System.Drawing.Size(80, 20);
            this.adid_u.TabIndex = 4;
            this.adid_u.Text = "DriverID";
            // 
            // rdataGridView1
            // 
            this.rdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rdataGridView1.Location = new System.Drawing.Point(539, 97);
            this.rdataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdataGridView1.Name = "rdataGridView1";
            this.rdataGridView1.Size = new System.Drawing.Size(655, 287);
            this.rdataGridView1.TabIndex = 62;
            this.rdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rdataGridView1_CellContentClick);
            this.rdataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.rdataGridView1_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblavid_u);
            this.panel1.Controls.Add(this.lblAdid_u);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtavid_u);
            this.panel1.Controls.Add(this.txtadid_u);
            this.panel1.Controls.Add(this.adid_u);
            this.panel1.Controls.Add(this.avid_u);
            this.panel1.Location = new System.Drawing.Point(29, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 230);
            this.panel1.TabIndex = 60;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // updateAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1229, 422);
            this.Controls.Add(this.aupdate);
            this.Controls.Add(this.txtrsrch);
            this.Controls.Add(this.rsb1);
            this.Controls.Add(this.dback1);
            this.Controls.Add(this.rdataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "updateAvailability";
            this.Text = "updateAvailability";
            this.Load += new System.EventHandler(this.updateAvailability_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aupdate;
        private System.Windows.Forms.Label lblca_u;
        private System.Windows.Forms.ComboBox comboBox1_u;
        private System.Windows.Forms.Label rotime_u;
        private System.Windows.Forms.Label lblavid_u;
        private System.Windows.Forms.Label lblAdid_u;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label avid_u;
        private System.Windows.Forms.TextBox txtrsrch;
        private System.Windows.Forms.Label rsb1;
        private System.Windows.Forms.Button dback1;
        private System.Windows.Forms.TextBox txtavid_u;
        private System.Windows.Forms.TextBox txtadid_u;
        private System.Windows.Forms.Label adid_u;
        private System.Windows.Forms.DataGridView rdataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}