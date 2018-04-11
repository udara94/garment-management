namespace WindowsFormsApplication2
{
    partial class vdetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vdetails));
            this.txtvs1 = new System.Windows.Forms.TextBox();
            this.vnu = new System.Windows.Forms.Label();
            this.vtype = new System.Windows.Forms.Label();
            this.vmaxw = new System.Windows.Forms.Label();
            this.vlnu = new System.Windows.Forms.Label();
            this.vlied = new System.Windows.Forms.Label();
            this.txtvnu = new System.Windows.Forms.TextBox();
            this.txtvlin = new System.Windows.Forms.TextBox();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.vnu_lable = new System.Windows.Forms.Label();
            this.vtype_lable = new System.Windows.Forms.Label();
            this.vmw_lable = new System.Windows.Forms.Label();
            this.vlin_lable = new System.Windows.Forms.Label();
            this.vadd = new System.Windows.Forms.Button();
            this.vdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.vdataGridView1 = new System.Windows.Forms.DataGridView();
            this.demov = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbmW = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtvs1
            // 
            this.txtvs1.Location = new System.Drawing.Point(1147, 33);
            this.txtvs1.Margin = new System.Windows.Forms.Padding(4);
            this.txtvs1.Name = "txtvs1";
            this.txtvs1.Size = new System.Drawing.Size(240, 22);
            this.txtvs1.TabIndex = 24;
            this.txtvs1.TextChanged += new System.EventHandler(this.txtvs1_TextChanged);
            // 
            // vnu
            // 
            this.vnu.AutoSize = true;
            this.vnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vnu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vnu.Location = new System.Drawing.Point(13, 28);
            this.vnu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vnu.Name = "vnu";
            this.vnu.Size = new System.Drawing.Size(142, 20);
            this.vnu.TabIndex = 25;
            this.vnu.Text = "Vehicle Number";
            // 
            // vtype
            // 
            this.vtype.AutoSize = true;
            this.vtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtype.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vtype.Location = new System.Drawing.Point(13, 102);
            this.vtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vtype.Name = "vtype";
            this.vtype.Size = new System.Drawing.Size(117, 20);
            this.vtype.TabIndex = 26;
            this.vtype.Text = "Vehicle Type";
            // 
            // vmaxw
            // 
            this.vmaxw.AutoSize = true;
            this.vmaxw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vmaxw.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vmaxw.Location = new System.Drawing.Point(13, 176);
            this.vmaxw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vmaxw.Name = "vmaxw";
            this.vmaxw.Size = new System.Drawing.Size(107, 20);
            this.vmaxw.TabIndex = 27;
            this.vmaxw.Text = "Max Weight";
            // 
            // vlnu
            // 
            this.vlnu.AutoSize = true;
            this.vlnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlnu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vlnu.Location = new System.Drawing.Point(13, 250);
            this.vlnu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vlnu.Name = "vlnu";
            this.vlnu.Size = new System.Drawing.Size(234, 20);
            this.vlnu.TabIndex = 28;
            this.vlnu.Text = "License Insurance Number";
            // 
            // vlied
            // 
            this.vlied.AutoSize = true;
            this.vlied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlied.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vlied.Location = new System.Drawing.Point(13, 324);
            this.vlied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vlied.Name = "vlied";
            this.vlied.Size = new System.Drawing.Size(246, 20);
            this.vlied.TabIndex = 29;
            this.vlied.Text = "License Insuranse Exp Date";
            // 
            // txtvnu
            // 
            this.txtvnu.Location = new System.Drawing.Point(324, 23);
            this.txtvnu.Margin = new System.Windows.Forms.Padding(4);
            this.txtvnu.Name = "txtvnu";
            this.txtvnu.Size = new System.Drawing.Size(292, 22);
            this.txtvnu.TabIndex = 31;
            // 
            // txtvlin
            // 
            this.txtvlin.Location = new System.Drawing.Point(324, 245);
            this.txtvlin.Margin = new System.Windows.Forms.Padding(4);
            this.txtvlin.Name = "txtvlin";
            this.txtvlin.Size = new System.Drawing.Size(292, 22);
            this.txtvlin.TabIndex = 33;
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Van",
            "Lorry",
            "Container"});
            this.cmbtype.Location = new System.Drawing.Point(324, 96);
            this.cmbtype.Margin = new System.Windows.Forms.Padding(4);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(292, 24);
            this.cmbtype.TabIndex = 35;
            // 
            // vnu_lable
            // 
            this.vnu_lable.AutoSize = true;
            this.vnu_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vnu_lable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vnu_lable.Location = new System.Drawing.Point(377, 52);
            this.vnu_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vnu_lable.Name = "vnu_lable";
            this.vnu_lable.Size = new System.Drawing.Size(166, 17);
            this.vnu_lable.TabIndex = 38;
            this.vnu_lable.Text = "Enter Vehicle Number";
            this.vnu_lable.Visible = false;
            this.vnu_lable.Click += new System.EventHandler(this.vnu_lable_Click);
            // 
            // vtype_lable
            // 
            this.vtype_lable.AutoSize = true;
            this.vtype_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtype_lable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vtype_lable.Location = new System.Drawing.Point(377, 126);
            this.vtype_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vtype_lable.Name = "vtype_lable";
            this.vtype_lable.Size = new System.Drawing.Size(146, 17);
            this.vtype_lable.TabIndex = 39;
            this.vtype_lable.Text = "Enter Vehicle Type";
            this.vtype_lable.Visible = false;
            this.vtype_lable.Click += new System.EventHandler(this.vtype_lable_Click);
            // 
            // vmw_lable
            // 
            this.vmw_lable.AutoSize = true;
            this.vmw_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vmw_lable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vmw_lable.Location = new System.Drawing.Point(377, 199);
            this.vmw_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vmw_lable.Name = "vmw_lable";
            this.vmw_lable.Size = new System.Drawing.Size(135, 17);
            this.vmw_lable.TabIndex = 40;
            this.vmw_lable.Text = "Enter Max Weight";
            this.vmw_lable.Visible = false;
            this.vmw_lable.Click += new System.EventHandler(this.vmw_lable_Click);
            // 
            // vlin_lable
            // 
            this.vlin_lable.AutoSize = true;
            this.vlin_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlin_lable.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vlin_lable.Location = new System.Drawing.Point(349, 273);
            this.vlin_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vlin_lable.Name = "vlin_lable";
            this.vlin_lable.Size = new System.Drawing.Size(245, 17);
            this.vlin_lable.TabIndex = 41;
            this.vlin_lable.Text = "Enter Licence insurance Number";
            this.vlin_lable.Visible = false;
            this.vlin_lable.Click += new System.EventHandler(this.vlin_lable_Click);
            // 
            // vadd
            // 
            this.vadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.vadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vadd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.vadd.Location = new System.Drawing.Point(31, 514);
            this.vadd.Margin = new System.Windows.Forms.Padding(4);
            this.vadd.Name = "vadd";
            this.vadd.Size = new System.Drawing.Size(113, 43);
            this.vadd.TabIndex = 43;
            this.vadd.Text = "Add";
            this.vadd.UseVisualStyleBackColor = false;
            this.vadd.Click += new System.EventHandler(this.vadd_Click);
            // 
            // vdateTimePicker1
            // 
            this.vdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vdateTimePicker1.Location = new System.Drawing.Point(324, 319);
            this.vdateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.vdateTimePicker1.Name = "vdateTimePicker1";
            this.vdateTimePicker1.Size = new System.Drawing.Size(292, 22);
            this.vdateTimePicker1.TabIndex = 44;
            // 
            // vdataGridView1
            // 
            this.vdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vdataGridView1.Location = new System.Drawing.Point(712, 107);
            this.vdataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.vdataGridView1.Name = "vdataGridView1";
            this.vdataGridView1.Size = new System.Drawing.Size(676, 372);
            this.vdataGridView1.TabIndex = 45;
            // 
            // demov
            // 
            this.demov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.demov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demov.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.demov.Location = new System.Drawing.Point(168, 514);
            this.demov.Margin = new System.Windows.Forms.Padding(4);
            this.demov.Name = "demov";
            this.demov.Size = new System.Drawing.Size(113, 43);
            this.demov.TabIndex = 78;
            this.demov.Text = "DEMO";
            this.demov.UseVisualStyleBackColor = false;
            this.demov.Click += new System.EventHandler(this.demov_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(1051, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbmW);
            this.panel1.Controls.Add(this.vnu);
            this.panel1.Controls.Add(this.vtype);
            this.panel1.Controls.Add(this.vmaxw);
            this.panel1.Controls.Add(this.vlnu);
            this.panel1.Controls.Add(this.vdateTimePicker1);
            this.panel1.Controls.Add(this.vlied);
            this.panel1.Controls.Add(this.txtvnu);
            this.panel1.Controls.Add(this.vlin_lable);
            this.panel1.Controls.Add(this.txtvlin);
            this.panel1.Controls.Add(this.vmw_lable);
            this.panel1.Controls.Add(this.cmbtype);
            this.panel1.Controls.Add(this.vtype_lable);
            this.panel1.Controls.Add(this.vnu_lable);
            this.panel1.Location = new System.Drawing.Point(28, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 371);
            this.panel1.TabIndex = 80;
            // 
            // cmbmW
            // 
            this.cmbmW.FormattingEnabled = true;
            this.cmbmW.Items.AddRange(new object[] {
            "600kg",
            "1000kg",
            "2000kg",
            "3000kg",
            "1T",
            "2T",
            "3T"});
            this.cmbmW.Location = new System.Drawing.Point(324, 171);
            this.cmbmW.Margin = new System.Windows.Forms.Padding(4);
            this.cmbmW.Name = "cmbmW";
            this.cmbmW.Size = new System.Drawing.Size(292, 24);
            this.cmbmW.TabIndex = 46;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(96, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // vdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1419, 580);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.demov);
            this.Controls.Add(this.vdataGridView1);
            this.Controls.Add(this.vadd);
            this.Controls.Add(this.txtvs1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vdetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vdetails";
            this.Load += new System.EventHandler(this.vdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtvs1;
        private System.Windows.Forms.Label vnu;
        private System.Windows.Forms.Label vtype;
        private System.Windows.Forms.Label vmaxw;
        private System.Windows.Forms.Label vlnu;
        private System.Windows.Forms.Label vlied;
        private System.Windows.Forms.TextBox txtvnu;
        private System.Windows.Forms.TextBox txtvlin;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Label vnu_lable;
        private System.Windows.Forms.Label vtype_lable;
        private System.Windows.Forms.Label vmw_lable;
        private System.Windows.Forms.Label vlin_lable;
        private System.Windows.Forms.Button vadd;
        private System.Windows.Forms.DateTimePicker vdateTimePicker1;
        private System.Windows.Forms.DataGridView vdataGridView1;
        private System.Windows.Forms.Button demov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbmW;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}