namespace WindowsFormsApplication2
{
    partial class runningChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(runningChart));
            this.rdid = new System.Windows.Forms.Label();
            this.rvid = new System.Windows.Forms.Label();
            this.rotime = new System.Windows.Forms.Label();
            this.ritime = new System.Windows.Forms.Label();
            this.rdate = new System.Windows.Forms.Label();
            this.rkm = new System.Windows.Forms.Label();
            this.rfrom = new System.Windows.Forms.Label();
            this.rto = new System.Windows.Forms.Label();
            this.txtrdid = new System.Windows.Forms.TextBox();
            this.txtrvid = new System.Windows.Forms.TextBox();
            this.txtrkm = new System.Windows.Forms.TextBox();
            this.txtrfrom = new System.Windows.Forms.TextBox();
            this.txtrto = new System.Windows.Forms.TextBox();
            this.radd = new System.Windows.Forms.Button();
            this.rdataGridView1 = new System.Windows.Forms.DataGridView();
            this.rsb1 = new System.Windows.Forms.Label();
            this.txtrsrch = new System.Windows.Forms.TextBox();
            this.lblkm = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblrdid = new System.Windows.Forms.Label();
            this.lblrvid = new System.Windows.Forms.Label();
            this.rdateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.rdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.rdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rdataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rdid
            // 
            this.rdid.AutoSize = true;
            this.rdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdid.Location = new System.Drawing.Point(25, 33);
            this.rdid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rdid.Name = "rdid";
            this.rdid.Size = new System.Drawing.Size(80, 20);
            this.rdid.TabIndex = 1;
            this.rdid.Text = "DriverID";
            this.rdid.Click += new System.EventHandler(this.rdid_Click);
            // 
            // rvid
            // 
            this.rvid.AutoSize = true;
            this.rvid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rvid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rvid.Location = new System.Drawing.Point(25, 79);
            this.rvid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rvid.Name = "rvid";
            this.rvid.Size = new System.Drawing.Size(90, 20);
            this.rvid.TabIndex = 2;
            this.rvid.Text = "VehicleID";
            this.rvid.Click += new System.EventHandler(this.rvid_Click);
            // 
            // rotime
            // 
            this.rotime.AutoSize = true;
            this.rotime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rotime.Location = new System.Drawing.Point(25, 128);
            this.rotime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotime.Name = "rotime";
            this.rotime.Size = new System.Drawing.Size(86, 20);
            this.rotime.TabIndex = 3;
            this.rotime.Text = "Out Time";
            this.rotime.Click += new System.EventHandler(this.rotime_Click);
            // 
            // ritime
            // 
            this.ritime.AutoSize = true;
            this.ritime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ritime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ritime.Location = new System.Drawing.Point(25, 176);
            this.ritime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ritime.Name = "ritime";
            this.ritime.Size = new System.Drawing.Size(71, 20);
            this.ritime.TabIndex = 4;
            this.ritime.Text = "In Time";
            this.ritime.Click += new System.EventHandler(this.ritime_Click);
            // 
            // rdate
            // 
            this.rdate.AutoSize = true;
            this.rdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdate.Location = new System.Drawing.Point(25, 224);
            this.rdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rdate.Name = "rdate";
            this.rdate.Size = new System.Drawing.Size(49, 20);
            this.rdate.TabIndex = 5;
            this.rdate.Text = "Date";
            this.rdate.Click += new System.EventHandler(this.rdate_Click);
            // 
            // rkm
            // 
            this.rkm.AutoSize = true;
            this.rkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rkm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rkm.Location = new System.Drawing.Point(25, 274);
            this.rkm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rkm.Name = "rkm";
            this.rkm.Size = new System.Drawing.Size(90, 20);
            this.rkm.TabIndex = 6;
            this.rkm.Text = "Distance ";
            this.rkm.Click += new System.EventHandler(this.rkm_Click);
            // 
            // rfrom
            // 
            this.rfrom.AutoSize = true;
            this.rfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rfrom.Location = new System.Drawing.Point(25, 324);
            this.rfrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rfrom.Name = "rfrom";
            this.rfrom.Size = new System.Drawing.Size(52, 20);
            this.rfrom.TabIndex = 7;
            this.rfrom.Text = "From";
            this.rfrom.Click += new System.EventHandler(this.rfrom_Click);
            // 
            // rto
            // 
            this.rto.AutoSize = true;
            this.rto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rto.Location = new System.Drawing.Point(25, 372);
            this.rto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rto.Name = "rto";
            this.rto.Size = new System.Drawing.Size(30, 20);
            this.rto.TabIndex = 8;
            this.rto.Text = "To";
            this.rto.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtrdid
            // 
            this.txtrdid.Location = new System.Drawing.Point(204, 28);
            this.txtrdid.Margin = new System.Windows.Forms.Padding(4);
            this.txtrdid.Name = "txtrdid";
            this.txtrdid.Size = new System.Drawing.Size(245, 22);
            this.txtrdid.TabIndex = 24;
            this.txtrdid.TextChanged += new System.EventHandler(this.txtrdid_TextChanged);
            // 
            // txtrvid
            // 
            this.txtrvid.Location = new System.Drawing.Point(204, 74);
            this.txtrvid.Margin = new System.Windows.Forms.Padding(4);
            this.txtrvid.Name = "txtrvid";
            this.txtrvid.Size = new System.Drawing.Size(245, 22);
            this.txtrvid.TabIndex = 25;
            this.txtrvid.TextChanged += new System.EventHandler(this.txtrvid_TextChanged);
            // 
            // txtrkm
            // 
            this.txtrkm.Location = new System.Drawing.Point(204, 267);
            this.txtrkm.Margin = new System.Windows.Forms.Padding(4);
            this.txtrkm.Name = "txtrkm";
            this.txtrkm.Size = new System.Drawing.Size(245, 22);
            this.txtrkm.TabIndex = 29;
            this.txtrkm.TextChanged += new System.EventHandler(this.txtrkm_TextChanged);
            // 
            // txtrfrom
            // 
            this.txtrfrom.Location = new System.Drawing.Point(204, 315);
            this.txtrfrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtrfrom.Name = "txtrfrom";
            this.txtrfrom.Size = new System.Drawing.Size(245, 22);
            this.txtrfrom.TabIndex = 30;
            this.txtrfrom.TextChanged += new System.EventHandler(this.txtrfrom_TextChanged);
            // 
            // txtrto
            // 
            this.txtrto.Location = new System.Drawing.Point(204, 363);
            this.txtrto.Margin = new System.Windows.Forms.Padding(4);
            this.txtrto.Name = "txtrto";
            this.txtrto.Size = new System.Drawing.Size(245, 22);
            this.txtrto.TabIndex = 31;
            this.txtrto.TextChanged += new System.EventHandler(this.txtrto_TextChanged);
            // 
            // radd
            // 
            this.radd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.radd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radd.Location = new System.Drawing.Point(19, 553);
            this.radd.Margin = new System.Windows.Forms.Padding(4);
            this.radd.Name = "radd";
            this.radd.Size = new System.Drawing.Size(117, 39);
            this.radd.TabIndex = 32;
            this.radd.Text = "Add";
            this.radd.UseVisualStyleBackColor = false;
            this.radd.Click += new System.EventHandler(this.radd_Click);
            // 
            // rdataGridView1
            // 
            this.rdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rdataGridView1.Location = new System.Drawing.Point(561, 95);
            this.rdataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.rdataGridView1.Name = "rdataGridView1";
            this.rdataGridView1.Size = new System.Drawing.Size(723, 436);
            this.rdataGridView1.TabIndex = 46;
            // 
            // rsb1
            // 
            this.rsb1.AutoSize = true;
            this.rsb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsb1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rsb1.Location = new System.Drawing.Point(929, 37);
            this.rsb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rsb1.Name = "rsb1";
            this.rsb1.Size = new System.Drawing.Size(81, 25);
            this.rsb1.TabIndex = 47;
            this.rsb1.Text = "Search";
            // 
            // txtrsrch
            // 
            this.txtrsrch.Location = new System.Drawing.Point(1037, 37);
            this.txtrsrch.Margin = new System.Windows.Forms.Padding(4);
            this.txtrsrch.Name = "txtrsrch";
            this.txtrsrch.Size = new System.Drawing.Size(245, 22);
            this.txtrsrch.TabIndex = 48;
            this.txtrsrch.TextChanged += new System.EventHandler(this.txtrsrch_TextChanged);
            // 
            // lblkm
            // 
            this.lblkm.AutoSize = true;
            this.lblkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblkm.Location = new System.Drawing.Point(260, 295);
            this.lblkm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblkm.Name = "lblkm";
            this.lblkm.Size = new System.Drawing.Size(115, 17);
            this.lblkm.TabIndex = 53;
            this.lblkm.Text = "Enter Distance";
            this.lblkm.Visible = false;
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblfrom.Location = new System.Drawing.Point(251, 343);
            this.lblfrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(132, 17);
            this.lblfrom.TabIndex = 54;
            this.lblfrom.Text = "Enter Start Place";
            this.lblfrom.Visible = false;
            // 
            // lblto
            // 
            this.lblto.AutoSize = true;
            this.lblto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblto.Location = new System.Drawing.Point(251, 391);
            this.lblto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblto.Name = "lblto";
            this.lblto.Size = new System.Drawing.Size(134, 17);
            this.lblto.TabIndex = 55;
            this.lblto.Text = "Enter Destination";
            this.lblto.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblrdid);
            this.panel2.Controls.Add(this.lblrvid);
            this.panel2.Controls.Add(this.rdid);
            this.panel2.Controls.Add(this.rdateTimePicker3);
            this.panel2.Controls.Add(this.rdateTimePicker2);
            this.panel2.Controls.Add(this.txtrdid);
            this.panel2.Controls.Add(this.rvid);
            this.panel2.Controls.Add(this.rdateTimePicker1);
            this.panel2.Controls.Add(this.txtrvid);
            this.panel2.Controls.Add(this.lblto);
            this.panel2.Controls.Add(this.rotime);
            this.panel2.Controls.Add(this.lblfrom);
            this.panel2.Controls.Add(this.ritime);
            this.panel2.Controls.Add(this.lblkm);
            this.panel2.Controls.Add(this.rdate);
            this.panel2.Controls.Add(this.rkm);
            this.panel2.Controls.Add(this.rfrom);
            this.panel2.Controls.Add(this.rto);
            this.panel2.Controls.Add(this.txtrkm);
            this.panel2.Controls.Add(this.txtrfrom);
            this.panel2.Controls.Add(this.txtrto);
            this.panel2.Location = new System.Drawing.Point(16, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 435);
            this.panel2.TabIndex = 56;
            // 
            // lblrdid
            // 
            this.lblrdid.AutoSize = true;
            this.lblrdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrdid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblrdid.Location = new System.Drawing.Point(261, 54);
            this.lblrdid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrdid.Name = "lblrdid";
            this.lblrdid.Size = new System.Drawing.Size(111, 17);
            this.lblrdid.TabIndex = 61;
            this.lblrdid.Text = "Enter DriverID";
            this.lblrdid.Visible = false;
            this.lblrdid.Click += new System.EventHandler(this.lblrdid_Click);
            // 
            // lblrvid
            // 
            this.lblrvid.AutoSize = true;
            this.lblrvid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrvid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblrvid.Location = new System.Drawing.Point(256, 102);
            this.lblrvid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrvid.Name = "lblrvid";
            this.lblrvid.Size = new System.Drawing.Size(120, 17);
            this.lblrvid.TabIndex = 60;
            this.lblrvid.Text = "Enter VehicleID";
            this.lblrvid.Visible = false;
            // 
            // rdateTimePicker3
            // 
            this.rdateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdateTimePicker3.Location = new System.Drawing.Point(204, 219);
            this.rdateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.rdateTimePicker3.Name = "rdateTimePicker3";
            this.rdateTimePicker3.Size = new System.Drawing.Size(245, 22);
            this.rdateTimePicker3.TabIndex = 59;
            // 
            // rdateTimePicker2
            // 
            this.rdateTimePicker2.CustomFormat = "hh.mm.ss";
            this.rdateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.rdateTimePicker2.Location = new System.Drawing.Point(204, 171);
            this.rdateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.rdateTimePicker2.Name = "rdateTimePicker2";
            this.rdateTimePicker2.ShowUpDown = true;
            this.rdateTimePicker2.Size = new System.Drawing.Size(245, 22);
            this.rdateTimePicker2.TabIndex = 58;
            this.rdateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // rdateTimePicker1
            // 
            this.rdateTimePicker1.CustomFormat = "hh.mm.ss";
            this.rdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.rdateTimePicker1.Location = new System.Drawing.Point(204, 123);
            this.rdateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.rdateTimePicker1.Name = "rdateTimePicker1";
            this.rdateTimePicker1.ShowUpDown = true;
            this.rdateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.rdateTimePicker1.TabIndex = 57;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(80, 3);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 74;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // runningChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1355, 607);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtrsrch);
            this.Controls.Add(this.rsb1);
            this.Controls.Add(this.rdataGridView1);
            this.Controls.Add(this.radd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "runningChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "runningChart";
            this.Load += new System.EventHandler(this.runningChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label rdid;
        private System.Windows.Forms.Label rvid;
        private System.Windows.Forms.Label rotime;
        private System.Windows.Forms.Label ritime;
        private System.Windows.Forms.Label rdate;
        private System.Windows.Forms.Label rkm;
        private System.Windows.Forms.Label rfrom;
        private System.Windows.Forms.Label rto;
        private System.Windows.Forms.TextBox txtrdid;
        private System.Windows.Forms.TextBox txtrvid;
        private System.Windows.Forms.TextBox txtrkm;
        private System.Windows.Forms.TextBox txtrfrom;
        private System.Windows.Forms.TextBox txtrto;
        private System.Windows.Forms.Button radd;
        private System.Windows.Forms.DataGridView rdataGridView1;
        private System.Windows.Forms.Label rsb1;
        private System.Windows.Forms.TextBox txtrsrch;
        private System.Windows.Forms.Label lblkm;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker rdateTimePicker1;
        private System.Windows.Forms.DateTimePicker rdateTimePicker3;
        private System.Windows.Forms.DateTimePicker rdateTimePicker2;
        private System.Windows.Forms.Label lblrdid;
        private System.Windows.Forms.Label lblrvid;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}