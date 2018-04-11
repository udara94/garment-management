namespace WindowsFormsApplication2
{
    partial class Availability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Availability));
            this.txtrsrch = new System.Windows.Forms.TextBox();
            this.rsb1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblavid = new System.Windows.Forms.Label();
            this.lblAdid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblca = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rotime = new System.Windows.Forms.Label();
            this.txtavid = new System.Windows.Forms.TextBox();
            this.txtadid = new System.Windows.Forms.TextBox();
            this.adid = new System.Windows.Forms.Label();
            this.avid = new System.Windows.Forms.Label();
            this.aadd = new System.Windows.Forms.Button();
            this.rdataGridView1 = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtrsrch
            // 
            this.txtrsrch.Location = new System.Drawing.Point(288, 104);
            this.txtrsrch.Margin = new System.Windows.Forms.Padding(4);
            this.txtrsrch.Name = "txtrsrch";
            this.txtrsrch.Size = new System.Drawing.Size(245, 22);
            this.txtrsrch.TabIndex = 52;
            this.txtrsrch.TextChanged += new System.EventHandler(this.txtrsrch_TextChanged);
            // 
            // rsb1
            // 
            this.rsb1.AutoSize = true;
            this.rsb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsb1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rsb1.Location = new System.Drawing.Point(180, 104);
            this.rsb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rsb1.Name = "rsb1";
            this.rsb1.Size = new System.Drawing.Size(81, 25);
            this.rsb1.TabIndex = 51;
            this.rsb1.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblavid);
            this.panel1.Controls.Add(this.lblAdid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtavid);
            this.panel1.Controls.Add(this.txtadid);
            this.panel1.Controls.Add(this.adid);
            this.panel1.Controls.Add(this.avid);
            this.panel1.Location = new System.Drawing.Point(355, 339);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 230);
            this.panel1.TabIndex = 53;
            // 
            // lblavid
            // 
            this.lblavid.AutoSize = true;
            this.lblavid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblavid.Location = new System.Drawing.Point(189, 108);
            this.lblavid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavid.Name = "lblavid";
            this.lblavid.Size = new System.Drawing.Size(125, 17);
            this.lblavid.TabIndex = 58;
            this.lblavid.Text = "Enter Vehicle ID";
            this.lblavid.Visible = false;
            // 
            // lblAdid
            // 
            this.lblAdid.AutoSize = true;
            this.lblAdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdid.Location = new System.Drawing.Point(189, 60);
            this.lblAdid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdid.Name = "lblAdid";
            this.lblAdid.Size = new System.Drawing.Size(116, 17);
            this.lblAdid.TabIndex = 57;
            this.lblAdid.Text = "Enter Driver ID";
            this.lblAdid.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblca);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.rotime);
            this.panel2.Location = new System.Drawing.Point(17, 140);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 68);
            this.panel2.TabIndex = 56;
            // 
            // lblca
            // 
            this.lblca.AutoSize = true;
            this.lblca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblca.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblca.Location = new System.Drawing.Point(171, 39);
            this.lblca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblca.Name = "lblca";
            this.lblca.Size = new System.Drawing.Size(125, 17);
            this.lblca.TabIndex = 59;
            this.lblca.Text = "Click Availability";
            this.lblca.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.comboBox1.Location = new System.Drawing.Point(160, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // rotime
            // 
            this.rotime.AutoSize = true;
            this.rotime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rotime.Location = new System.Drawing.Point(13, 16);
            this.rotime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotime.Name = "rotime";
            this.rotime.Size = new System.Drawing.Size(100, 20);
            this.rotime.TabIndex = 6;
            this.rotime.Text = "Availability";
            // 
            // txtavid
            // 
            this.txtavid.Location = new System.Drawing.Point(179, 80);
            this.txtavid.Margin = new System.Windows.Forms.Padding(4);
            this.txtavid.Name = "txtavid";
            this.txtavid.Size = new System.Drawing.Size(184, 22);
            this.txtavid.TabIndex = 10;
            // 
            // txtadid
            // 
            this.txtadid.Location = new System.Drawing.Point(179, 32);
            this.txtadid.Margin = new System.Windows.Forms.Padding(4);
            this.txtadid.Name = "txtadid";
            this.txtadid.Size = new System.Drawing.Size(184, 22);
            this.txtadid.TabIndex = 9;
            // 
            // adid
            // 
            this.adid.AutoSize = true;
            this.adid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.adid.Location = new System.Drawing.Point(33, 32);
            this.adid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adid.Name = "adid";
            this.adid.Size = new System.Drawing.Size(80, 20);
            this.adid.TabIndex = 4;
            this.adid.Text = "DriverID";
            // 
            // avid
            // 
            this.avid.AutoSize = true;
            this.avid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.avid.Location = new System.Drawing.Point(33, 80);
            this.avid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avid.Name = "avid";
            this.avid.Size = new System.Drawing.Size(90, 20);
            this.avid.TabIndex = 5;
            this.avid.Text = "VehicleID";
            // 
            // aadd
            // 
            this.aadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.aadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aadd.Location = new System.Drawing.Point(504, 603);
            this.aadd.Margin = new System.Windows.Forms.Padding(4);
            this.aadd.Name = "aadd";
            this.aadd.Size = new System.Drawing.Size(117, 39);
            this.aadd.TabIndex = 54;
            this.aadd.Text = "Add";
            this.aadd.UseVisualStyleBackColor = false;
            this.aadd.Click += new System.EventHandler(this.radd_Click);
            // 
            // rdataGridView1
            // 
            this.rdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rdataGridView1.Location = new System.Drawing.Point(551, 103);
            this.rdataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.rdataGridView1.Name = "rdataGridView1";
            this.rdataGridView1.Size = new System.Drawing.Size(632, 228);
            this.rdataGridView1.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label21.Location = new System.Drawing.Point(434, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(302, 39);
            this.label21.TabIndex = 73;
            this.label21.Text = "Vehicle Availability";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(68, 2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 72;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1156, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // Availability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1203, 655);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdataGridView1);
            this.Controls.Add(this.aadd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtrsrch);
            this.Controls.Add(this.rsb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Availability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Availability";
            this.Load += new System.EventHandler(this.Availability_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrsrch;
        private System.Windows.Forms.Label rsb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label adid;
        private System.Windows.Forms.Label avid;
        private System.Windows.Forms.Label rotime;
        private System.Windows.Forms.TextBox txtavid;
        private System.Windows.Forms.TextBox txtadid;
        private System.Windows.Forms.Button aadd;
        private System.Windows.Forms.DataGridView rdataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblavid;
        private System.Windows.Forms.Label lblAdid;
        private System.Windows.Forms.Label lblca;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}