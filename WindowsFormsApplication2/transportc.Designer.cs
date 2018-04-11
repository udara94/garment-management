namespace WindowsFormsApplication2
{
    partial class transportc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transportc));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tctc = new System.Windows.Forms.Label();
            this.tcadd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txttckm = new System.Windows.Forms.TextBox();
            this.tcvid = new System.Windows.Forms.Label();
            this.tcdkm = new System.Windows.Forms.Label();
            this.tcftype = new System.Windows.Forms.Label();
            this.tcoc = new System.Windows.Forms.Label();
            this.txttcvid = new System.Windows.Forms.TextBox();
            this.tcdc = new System.Windows.Forms.Label();
            this.cmbtctype = new System.Windows.Forms.ComboBox();
            this.lbltckm = new System.Windows.Forms.Label();
            this.lbltcvid = new System.Windows.Forms.Label();
            this.lbltcftype = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOC = new System.Windows.Forms.Label();
            this.labelDC = new System.Windows.Forms.Label();
            this.txts = new System.Windows.Forms.TextBox();
            this.ds1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(583, 89);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(792, 444);
            this.dataGridView2.TabIndex = 74;
            // 
            // tctc
            // 
            this.tctc.AutoSize = true;
            this.tctc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctc.ForeColor = System.Drawing.Color.White;
            this.tctc.Location = new System.Drawing.Point(21, 28);
            this.tctc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tctc.Name = "tctc";
            this.tctc.Size = new System.Drawing.Size(163, 20);
            this.tctc.TabIndex = 65;
            this.tctc.Text = "Transpotaion Cost";
            // 
            // tcadd
            // 
            this.tcadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.tcadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tcadd.Location = new System.Drawing.Point(21, 577);
            this.tcadd.Margin = new System.Windows.Forms.Padding(4);
            this.tcadd.Name = "tcadd";
            this.tcadd.Size = new System.Drawing.Size(117, 39);
            this.tcadd.TabIndex = 73;
            this.tcadd.Text = "Add";
            this.tcadd.UseVisualStyleBackColor = false;
            this.tcadd.Click += new System.EventHandler(this.dadd_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tctc);
            this.panel2.Location = new System.Drawing.Point(21, 465);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 82);
            this.panel2.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(219, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "0";
            // 
            // txttckm
            // 
            this.txttckm.Location = new System.Drawing.Point(223, 94);
            this.txttckm.Margin = new System.Windows.Forms.Padding(4);
            this.txttckm.Name = "txttckm";
            this.txttckm.Size = new System.Drawing.Size(265, 22);
            this.txttckm.TabIndex = 71;
            this.txttckm.TextChanged += new System.EventHandler(this.txttckm_TextChanged);
            // 
            // tcvid
            // 
            this.tcvid.AutoSize = true;
            this.tcvid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcvid.ForeColor = System.Drawing.Color.White;
            this.tcvid.Location = new System.Drawing.Point(21, 37);
            this.tcvid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcvid.Name = "tcvid";
            this.tcvid.Size = new System.Drawing.Size(90, 20);
            this.tcvid.TabIndex = 64;
            this.tcvid.Text = "VehicleID";
            // 
            // tcdkm
            // 
            this.tcdkm.AutoSize = true;
            this.tcdkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcdkm.ForeColor = System.Drawing.Color.White;
            this.tcdkm.Location = new System.Drawing.Point(21, 106);
            this.tcdkm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcdkm.Name = "tcdkm";
            this.tcdkm.Size = new System.Drawing.Size(125, 20);
            this.tcdkm.TabIndex = 65;
            this.tcdkm.Text = "Distance(Km)";
            // 
            // tcftype
            // 
            this.tcftype.AutoSize = true;
            this.tcftype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcftype.ForeColor = System.Drawing.Color.White;
            this.tcftype.Location = new System.Drawing.Point(21, 313);
            this.tcftype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcftype.Name = "tcftype";
            this.tcftype.Size = new System.Drawing.Size(91, 20);
            this.tcftype.TabIndex = 66;
            this.tcftype.Text = "Fual Type";
            // 
            // tcoc
            // 
            this.tcoc.AutoSize = true;
            this.tcoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcoc.ForeColor = System.Drawing.Color.White;
            this.tcoc.Location = new System.Drawing.Point(21, 244);
            this.tcoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcoc.Name = "tcoc";
            this.tcoc.Size = new System.Drawing.Size(101, 20);
            this.tcoc.TabIndex = 74;
            this.tcoc.Text = "Other Cost";
            // 
            // txttcvid
            // 
            this.txttcvid.Location = new System.Drawing.Point(223, 33);
            this.txttcvid.Margin = new System.Windows.Forms.Padding(4);
            this.txttcvid.Name = "txttcvid";
            this.txttcvid.Size = new System.Drawing.Size(265, 22);
            this.txttcvid.TabIndex = 67;
            // 
            // tcdc
            // 
            this.tcdc.AutoSize = true;
            this.tcdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcdc.ForeColor = System.Drawing.Color.White;
            this.tcdc.Location = new System.Drawing.Point(21, 175);
            this.tcdc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcdc.Name = "tcdc";
            this.tcdc.Size = new System.Drawing.Size(106, 20);
            this.tcdc.TabIndex = 73;
            this.tcdc.Text = "Driver Cost";
            // 
            // cmbtctype
            // 
            this.cmbtctype.FormattingEnabled = true;
            this.cmbtctype.Items.AddRange(new object[] {
            "petrol",
            "diesel"});
            this.cmbtctype.Location = new System.Drawing.Point(223, 304);
            this.cmbtctype.Margin = new System.Windows.Forms.Padding(4);
            this.cmbtctype.Name = "cmbtctype";
            this.cmbtctype.Size = new System.Drawing.Size(265, 24);
            this.cmbtctype.TabIndex = 68;
            this.cmbtctype.SelectedIndexChanged += new System.EventHandler(this.cmbtctype_SelectedIndexChanged);
            // 
            // lbltckm
            // 
            this.lbltckm.AutoSize = true;
            this.lbltckm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltckm.ForeColor = System.Drawing.Color.Red;
            this.lbltckm.Location = new System.Drawing.Point(288, 122);
            this.lbltckm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltckm.Name = "lbltckm";
            this.lbltckm.Size = new System.Drawing.Size(115, 17);
            this.lbltckm.TabIndex = 72;
            this.lbltckm.Text = "Enter Distance";
            this.lbltckm.Visible = false;
            // 
            // lbltcvid
            // 
            this.lbltcvid.AutoSize = true;
            this.lbltcvid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltcvid.ForeColor = System.Drawing.Color.Red;
            this.lbltcvid.Location = new System.Drawing.Point(281, 62);
            this.lbltcvid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltcvid.Name = "lbltcvid";
            this.lbltcvid.Size = new System.Drawing.Size(125, 17);
            this.lbltcvid.TabIndex = 69;
            this.lbltcvid.Text = "Enter Vehicle ID";
            this.lbltcvid.Visible = false;
            // 
            // lbltcftype
            // 
            this.lbltcftype.AutoSize = true;
            this.lbltcftype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltcftype.ForeColor = System.Drawing.Color.Red;
            this.lbltcftype.Location = new System.Drawing.Point(284, 332);
            this.lbltcftype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltcftype.Name = "lbltcftype";
            this.lbltcftype.Size = new System.Drawing.Size(124, 17);
            this.lbltcftype.TabIndex = 70;
            this.lbltcftype.Text = "Enter Fual Type";
            this.lbltcftype.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelOC);
            this.panel1.Controls.Add(this.labelDC);
            this.panel1.Controls.Add(this.txttckm);
            this.panel1.Controls.Add(this.tcvid);
            this.panel1.Controls.Add(this.tcdkm);
            this.panel1.Controls.Add(this.tcftype);
            this.panel1.Controls.Add(this.txttcvid);
            this.panel1.Controls.Add(this.cmbtctype);
            this.panel1.Controls.Add(this.lbltckm);
            this.panel1.Controls.Add(this.lbltcvid);
            this.panel1.Controls.Add(this.lbltcftype);
            this.panel1.Controls.Add(this.tcdc);
            this.panel1.Controls.Add(this.tcoc);
            this.panel1.Location = new System.Drawing.Point(21, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 358);
            this.panel1.TabIndex = 67;
            // 
            // labelOC
            // 
            this.labelOC.AutoSize = true;
            this.labelOC.Location = new System.Drawing.Point(220, 244);
            this.labelOC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOC.Name = "labelOC";
            this.labelOC.Size = new System.Drawing.Size(16, 17);
            this.labelOC.TabIndex = 81;
            this.labelOC.Text = "0";
            // 
            // labelDC
            // 
            this.labelDC.AutoSize = true;
            this.labelDC.Location = new System.Drawing.Point(220, 178);
            this.labelDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDC.Name = "labelDC";
            this.labelDC.Size = new System.Drawing.Size(16, 17);
            this.labelDC.TabIndex = 80;
            this.labelDC.Text = "0";
            // 
            // txts
            // 
            this.txts.Location = new System.Drawing.Point(1147, 43);
            this.txts.Margin = new System.Windows.Forms.Padding(4);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(227, 22);
            this.txts.TabIndex = 71;
            this.txts.TextChanged += new System.EventHandler(this.txts_TextChanged);
            // 
            // ds1
            // 
            this.ds1.AutoSize = true;
            this.ds1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds1.ForeColor = System.Drawing.Color.White;
            this.ds1.Location = new System.Drawing.Point(1037, 43);
            this.ds1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ds1.Name = "ds1";
            this.ds1.Size = new System.Drawing.Size(81, 25);
            this.ds1.TabIndex = 70;
            this.ds1.Text = "Search";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(103, 16);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // transportc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1417, 631);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tcadd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txts);
            this.Controls.Add(this.ds1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "transportc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transportc";
            this.Load += new System.EventHandler(this.transportc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label tctc;
        private System.Windows.Forms.Button tcadd;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txttckm;
        private System.Windows.Forms.Label tcvid;
        private System.Windows.Forms.Label tcdkm;
        private System.Windows.Forms.Label tcftype;
        private System.Windows.Forms.Label tcoc;
        public System.Windows.Forms.TextBox txttcvid;
        private System.Windows.Forms.Label tcdc;
        public System.Windows.Forms.ComboBox cmbtctype;
        private System.Windows.Forms.Label lbltckm;
        private System.Windows.Forms.Label lbltcvid;
        private System.Windows.Forms.Label lbltcftype;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.Label ds1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOC;
        private System.Windows.Forms.Label labelDC;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}