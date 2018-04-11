namespace WindowsFormsApplication2
{
    partial class updateVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateVehicle));
            this.vdateTimePicker1_u = new System.Windows.Forms.DateTimePicker();
            this.vlin_lable_uv = new System.Windows.Forms.Label();
            this.vmw_lable_uv = new System.Windows.Forms.Label();
            this.vtype_lable_uv = new System.Windows.Forms.Label();
            this.vnu_lable_uv = new System.Windows.Forms.Label();
            this.cmbtype_uv = new System.Windows.Forms.ComboBox();
            this.txtvlin_uv = new System.Windows.Forms.TextBox();
            this.txtvmaxw_uv = new System.Windows.Forms.TextBox();
            this.txtvnu_uv = new System.Windows.Forms.TextBox();
            this.vlied_uv = new System.Windows.Forms.Label();
            this.vlnu_uv = new System.Windows.Forms.Label();
            this.vmaxw_uv = new System.Windows.Forms.Label();
            this.vtype_uv = new System.Windows.Forms.Label();
            this.vnu_uv = new System.Windows.Forms.Label();
            this.vdataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtvs1 = new System.Windows.Forms.TextBox();
            this.vupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dback1 = new System.Windows.Forms.Button();
            this.vid_uv = new System.Windows.Forms.Label();
            this.txtvid_uv = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.vdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vdateTimePicker1_u
            // 
            this.vdateTimePicker1_u.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vdateTimePicker1_u.Location = new System.Drawing.Point(324, 364);
            this.vdateTimePicker1_u.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vdateTimePicker1_u.Name = "vdateTimePicker1_u";
            this.vdateTimePicker1_u.Size = new System.Drawing.Size(292, 22);
            this.vdateTimePicker1_u.TabIndex = 68;
            // 
            // vlin_lable_uv
            // 
            this.vlin_lable_uv.AutoSize = true;
            this.vlin_lable_uv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlin_lable_uv.ForeColor = System.Drawing.Color.Red;
            this.vlin_lable_uv.Location = new System.Drawing.Point(349, 324);
            this.vlin_lable_uv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vlin_lable_uv.Name = "vlin_lable_uv";
            this.vlin_lable_uv.Size = new System.Drawing.Size(245, 17);
            this.vlin_lable_uv.TabIndex = 67;
            this.vlin_lable_uv.Text = "Enter Licence insurance Number";
            this.vlin_lable_uv.Visible = false;
            // 
            // vmw_lable_uv
            // 
            this.vmw_lable_uv.AutoSize = true;
            this.vmw_lable_uv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vmw_lable_uv.ForeColor = System.Drawing.Color.Red;
            this.vmw_lable_uv.Location = new System.Drawing.Point(377, 255);
            this.vmw_lable_uv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vmw_lable_uv.Name = "vmw_lable_uv";
            this.vmw_lable_uv.Size = new System.Drawing.Size(135, 17);
            this.vmw_lable_uv.TabIndex = 66;
            this.vmw_lable_uv.Text = "Enter Max Weight";
            this.vmw_lable_uv.Visible = false;
            // 
            // vtype_lable_uv
            // 
            this.vtype_lable_uv.AutoSize = true;
            this.vtype_lable_uv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtype_lable_uv.ForeColor = System.Drawing.Color.Red;
            this.vtype_lable_uv.Location = new System.Drawing.Point(377, 186);
            this.vtype_lable_uv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vtype_lable_uv.Name = "vtype_lable_uv";
            this.vtype_lable_uv.Size = new System.Drawing.Size(146, 17);
            this.vtype_lable_uv.TabIndex = 65;
            this.vtype_lable_uv.Text = "Enter Vehicle Type";
            this.vtype_lable_uv.Visible = false;
            // 
            // vnu_lable_uv
            // 
            this.vnu_lable_uv.AutoSize = true;
            this.vnu_lable_uv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vnu_lable_uv.ForeColor = System.Drawing.Color.Red;
            this.vnu_lable_uv.Location = new System.Drawing.Point(377, 116);
            this.vnu_lable_uv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vnu_lable_uv.Name = "vnu_lable_uv";
            this.vnu_lable_uv.Size = new System.Drawing.Size(166, 17);
            this.vnu_lable_uv.TabIndex = 64;
            this.vnu_lable_uv.Text = "Enter Vehicle Number";
            this.vnu_lable_uv.Visible = false;
            // 
            // cmbtype_uv
            // 
            this.cmbtype_uv.FormattingEnabled = true;
            this.cmbtype_uv.Items.AddRange(new object[] {
            "Van",
            "Lorry",
            "Container"});
            this.cmbtype_uv.Location = new System.Drawing.Point(324, 156);
            this.cmbtype_uv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbtype_uv.Name = "cmbtype_uv";
            this.cmbtype_uv.Size = new System.Drawing.Size(292, 24);
            this.cmbtype_uv.TabIndex = 63;
            // 
            // txtvlin_uv
            // 
            this.txtvlin_uv.Location = new System.Drawing.Point(324, 295);
            this.txtvlin_uv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvlin_uv.Name = "txtvlin_uv";
            this.txtvlin_uv.Size = new System.Drawing.Size(292, 22);
            this.txtvlin_uv.TabIndex = 62;
            // 
            // txtvmaxw_uv
            // 
            this.txtvmaxw_uv.Location = new System.Drawing.Point(324, 226);
            this.txtvmaxw_uv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvmaxw_uv.Name = "txtvmaxw_uv";
            this.txtvmaxw_uv.Size = new System.Drawing.Size(292, 22);
            this.txtvmaxw_uv.TabIndex = 61;
            // 
            // txtvnu_uv
            // 
            this.txtvnu_uv.Location = new System.Drawing.Point(324, 87);
            this.txtvnu_uv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvnu_uv.Name = "txtvnu_uv";
            this.txtvnu_uv.Size = new System.Drawing.Size(292, 22);
            this.txtvnu_uv.TabIndex = 60;
            // 
            // vlied_uv
            // 
            this.vlied_uv.AutoSize = true;
            this.vlied_uv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlied_uv.ForeColor = System.Drawing.Color.White;
            this.vlied_uv.Location = new System.Drawing.Point(13, 368);
            this.vlied_uv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vlied_uv.Name = "vlied_uv";
            this.vlied_uv.Size = new System.Drawing.Size(246, 20);
            this.vlied_uv.TabIndex = 59;
            this.vlied_uv.Text = "License Insuranse Exp Date";
            // 
            // vlnu_uv
            // 
            this.vlnu_uv.AutoSize = true;
            this.vlnu_uv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlnu_uv.ForeColor = System.Drawing.Color.White;
            this.vlnu_uv.Location = new System.Drawing.Point(13, 299);
            this.vlnu_uv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vlnu_uv.Name = "vlnu_uv";
            this.vlnu_uv.Size = new System.Drawing.Size(234, 20);
            this.vlnu_uv.TabIndex = 58;
            this.vlnu_uv.Text = "License Insurance Number";
            // 
            // vmaxw_uv
            // 
            this.vmaxw_uv.AutoSize = true;
            this.vmaxw_uv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vmaxw_uv.ForeColor = System.Drawing.Color.White;
            this.vmaxw_uv.Location = new System.Drawing.Point(13, 230);
            this.vmaxw_uv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vmaxw_uv.Name = "vmaxw_uv";
            this.vmaxw_uv.Size = new System.Drawing.Size(107, 20);
            this.vmaxw_uv.TabIndex = 57;
            this.vmaxw_uv.Text = "Max Weight";
            // 
            // vtype_uv
            // 
            this.vtype_uv.AutoSize = true;
            this.vtype_uv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtype_uv.ForeColor = System.Drawing.Color.White;
            this.vtype_uv.Location = new System.Drawing.Point(13, 161);
            this.vtype_uv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vtype_uv.Name = "vtype_uv";
            this.vtype_uv.Size = new System.Drawing.Size(117, 20);
            this.vtype_uv.TabIndex = 56;
            this.vtype_uv.Text = "Vehicle Type";
            // 
            // vnu_uv
            // 
            this.vnu_uv.AutoSize = true;
            this.vnu_uv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vnu_uv.ForeColor = System.Drawing.Color.White;
            this.vnu_uv.Location = new System.Drawing.Point(13, 92);
            this.vnu_uv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vnu_uv.Name = "vnu_uv";
            this.vnu_uv.Size = new System.Drawing.Size(142, 20);
            this.vnu_uv.TabIndex = 55;
            this.vnu_uv.Text = "Vehicle Number";
            // 
            // vdataGridView1
            // 
            this.vdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vdataGridView1.Location = new System.Drawing.Point(708, 95);
            this.vdataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vdataGridView1.Name = "vdataGridView1";
            this.vdataGridView1.Size = new System.Drawing.Size(681, 417);
            this.vdataGridView1.TabIndex = 69;
            this.vdataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.vdataGridView1_RowHeaderMouseClick);
            // 
            // txtvs1
            // 
            this.txtvs1.Location = new System.Drawing.Point(1148, 33);
            this.txtvs1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvs1.Name = "txtvs1";
            this.txtvs1.Size = new System.Drawing.Size(240, 22);
            this.txtvs1.TabIndex = 71;
            this.txtvs1.TextChanged += new System.EventHandler(this.txtvs1_TextChanged);
            // 
            // vupdate
            // 
            this.vupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.vupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vupdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.vupdate.Location = new System.Drawing.Point(32, 534);
            this.vupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vupdate.Name = "vupdate";
            this.vupdate.Size = new System.Drawing.Size(113, 37);
            this.vupdate.TabIndex = 72;
            this.vupdate.Text = "Update";
            this.vupdate.UseVisualStyleBackColor = false;
            this.vupdate.Click += new System.EventHandler(this.vupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(1052, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Search";
            // 
            // dback1
            // 
            this.dback1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dback1.Image = ((System.Drawing.Image)(resources.GetObject("dback1.Image")));
            this.dback1.Location = new System.Drawing.Point(32, 13);
            this.dback1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dback1.Name = "dback1";
            this.dback1.Size = new System.Drawing.Size(68, 56);
            this.dback1.TabIndex = 74;
            this.dback1.UseVisualStyleBackColor = true;
            this.dback1.Click += new System.EventHandler(this.dback1_Click_1);
            // 
            // vid_uv
            // 
            this.vid_uv.AutoSize = true;
            this.vid_uv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vid_uv.ForeColor = System.Drawing.Color.White;
            this.vid_uv.Location = new System.Drawing.Point(13, 23);
            this.vid_uv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vid_uv.Name = "vid_uv";
            this.vid_uv.Size = new System.Drawing.Size(96, 20);
            this.vid_uv.TabIndex = 75;
            this.vid_uv.Text = "Vehicle ID";
            // 
            // txtvid_uv
            // 
            this.txtvid_uv.Location = new System.Drawing.Point(324, 18);
            this.txtvid_uv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvid_uv.Name = "txtvid_uv";
            this.txtvid_uv.Size = new System.Drawing.Size(292, 22);
            this.txtvid_uv.TabIndex = 76;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbtype_uv);
            this.panel1.Controls.Add(this.txtvid_uv);
            this.panel1.Controls.Add(this.vnu_uv);
            this.panel1.Controls.Add(this.vid_uv);
            this.panel1.Controls.Add(this.vtype_uv);
            this.panel1.Controls.Add(this.vmaxw_uv);
            this.panel1.Controls.Add(this.vlnu_uv);
            this.panel1.Controls.Add(this.vlied_uv);
            this.panel1.Controls.Add(this.txtvnu_uv);
            this.panel1.Controls.Add(this.txtvmaxw_uv);
            this.panel1.Controls.Add(this.vdateTimePicker1_u);
            this.panel1.Controls.Add(this.txtvlin_uv);
            this.panel1.Controls.Add(this.vlin_lable_uv);
            this.panel1.Controls.Add(this.vnu_lable_uv);
            this.panel1.Controls.Add(this.vmw_lable_uv);
            this.panel1.Controls.Add(this.vtype_lable_uv);
            this.panel1.Location = new System.Drawing.Point(32, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 417);
            this.panel1.TabIndex = 77;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // updateVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1415, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dback1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vupdate);
            this.Controls.Add(this.txtvs1);
            this.Controls.Add(this.vdataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "updateVehicle";
            this.Text = "updateVehicle";
            this.Load += new System.EventHandler(this.updateVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker vdateTimePicker1_u;
        private System.Windows.Forms.Label vlin_lable_uv;
        private System.Windows.Forms.Label vmw_lable_uv;
        private System.Windows.Forms.Label vtype_lable_uv;
        private System.Windows.Forms.Label vnu_lable_uv;
        private System.Windows.Forms.ComboBox cmbtype_uv;
        private System.Windows.Forms.TextBox txtvlin_uv;
        private System.Windows.Forms.TextBox txtvmaxw_uv;
        private System.Windows.Forms.TextBox txtvnu_uv;
        private System.Windows.Forms.Label vlied_uv;
        private System.Windows.Forms.Label vlnu_uv;
        private System.Windows.Forms.Label vmaxw_uv;
        private System.Windows.Forms.Label vtype_uv;
        private System.Windows.Forms.Label vnu_uv;
        private System.Windows.Forms.DataGridView vdataGridView1;
        private System.Windows.Forms.TextBox txtvs1;
        private System.Windows.Forms.Button vupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dback1;
        private System.Windows.Forms.Label vid_uv;
        private System.Windows.Forms.TextBox txtvid_uv;
        private System.Windows.Forms.Panel panel1;
    }
}