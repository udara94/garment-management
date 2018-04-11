namespace WindowsFormsApplication2
{
    partial class btn_demo
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
            this.lbltype = new System.Windows.Forms.Label();
            this.lblinstall_date = new System.Windows.Forms.Label();
            this.lblservice_dte = new System.Windows.Forms.Label();
            this.lblpur_price = new System.Windows.Forms.Label();
            this.lblpur_comp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_validate = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_mach_id = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtinstall_date = new System.Windows.Forms.DateTimePicker();
            this.txtser_date = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_com = new System.Windows.Forms.Label();
            this.lbl_pur = new System.Windows.Forms.Label();
            this.txt_estlife = new System.Windows.Forms.TextBox();
            this.lbl_estlife = new System.Windows.Forms.Label();
            this.cmbpurcom = new System.Windows.Forms.ComboBox();
            this.lbl_est_life = new System.Windows.Forms.Label();
            this.lbl_rep_cost = new System.Windows.Forms.Label();
            this.txtpur_price = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltype.Location = new System.Drawing.Point(3, 150);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(61, 25);
            this.lbltype.TabIndex = 1;
            this.lbltype.Text = "Type";
            // 
            // lblinstall_date
            // 
            this.lblinstall_date.AutoSize = true;
            this.lblinstall_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstall_date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblinstall_date.Location = new System.Drawing.Point(1, 267);
            this.lblinstall_date.Name = "lblinstall_date";
            this.lblinstall_date.Size = new System.Drawing.Size(120, 25);
            this.lblinstall_date.TabIndex = 3;
            this.lblinstall_date.Text = "Install Date";
            // 
            // lblservice_dte
            // 
            this.lblservice_dte.AutoSize = true;
            this.lblservice_dte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservice_dte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblservice_dte.Location = new System.Drawing.Point(3, 380);
            this.lblservice_dte.Name = "lblservice_dte";
            this.lblservice_dte.Size = new System.Drawing.Size(136, 25);
            this.lblservice_dte.TabIndex = 6;
            this.lblservice_dte.Text = "Service Date";
            // 
            // lblpur_price
            // 
            this.lblpur_price.AutoSize = true;
            this.lblpur_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpur_price.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblpur_price.Location = new System.Drawing.Point(25, 34);
            this.lblpur_price.Name = "lblpur_price";
            this.lblpur_price.Size = new System.Drawing.Size(158, 25);
            this.lblpur_price.TabIndex = 7;
            this.lblpur_price.Text = "Purchase Price";
            // 
            // lblpur_comp
            // 
            this.lblpur_comp.AutoSize = true;
            this.lblpur_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpur_comp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblpur_comp.Location = new System.Drawing.Point(25, 140);
            this.lblpur_comp.Name = "lblpur_comp";
            this.lblpur_comp.Size = new System.Drawing.Size(201, 25);
            this.lblpur_comp.TabIndex = 8;
            this.lblpur_comp.Text = "Purchase Company";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_validate);
            this.panel1.Controls.Add(this.cmbtype);
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Controls.Add(this.lbl_mach_id);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.txtinstall_date);
            this.panel1.Controls.Add(this.txtser_date);
            this.panel1.Controls.Add(this.lbltype);
            this.panel1.Controls.Add(this.lblinstall_date);
            this.panel1.Controls.Add(this.lblservice_dte);
            this.panel1.Location = new System.Drawing.Point(70, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 438);
            this.panel1.TabIndex = 9;
            // 
            // lbl_validate
            // 
            this.lbl_validate.AutoSize = true;
            this.lbl_validate.ForeColor = System.Drawing.Color.Red;
            this.lbl_validate.Location = new System.Drawing.Point(188, 405);
            this.lbl_validate.Name = "lbl_validate";
            this.lbl_validate.Size = new System.Drawing.Size(0, 17);
            this.lbl_validate.TabIndex = 15;
            // 
            // cmbtype
            // 
            this.cmbtype.DisplayMember = "bvbbv";
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Swing Machine",
            "Washine Machine",
            "Cutting Machine",
            "Iron"});
            this.cmbtype.Location = new System.Drawing.Point(182, 144);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(175, 24);
            this.cmbtype.TabIndex = 14;
            this.cmbtype.SelectedIndexChanged += new System.EventHandler(this.cmbtype_SelectedIndexChanged);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.ForeColor = System.Drawing.Color.Red;
            this.lbl_type.Location = new System.Drawing.Point(223, 171);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(0, 17);
            this.lbl_type.TabIndex = 13;
            // 
            // lbl_mach_id
            // 
            this.lbl_mach_id.AutoSize = true;
            this.lbl_mach_id.Location = new System.Drawing.Point(158, 44);
            this.lbl_mach_id.Name = "lbl_mach_id";
            this.lbl_mach_id.Size = new System.Drawing.Size(0, 17);
            this.lbl_mach_id.TabIndex = 12;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_id.Location = new System.Drawing.Point(3, 40);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(121, 25);
            this.lbl_id.TabIndex = 11;
            this.lbl_id.Text = "Machine ID";
            // 
            // txtinstall_date
            // 
            this.txtinstall_date.Location = new System.Drawing.Point(182, 267);
            this.txtinstall_date.Name = "txtinstall_date";
            this.txtinstall_date.Size = new System.Drawing.Size(173, 22);
            this.txtinstall_date.TabIndex = 10;
            // 
            // txtser_date
            // 
            this.txtser_date.Location = new System.Drawing.Point(182, 380);
            this.txtser_date.Name = "txtser_date";
            this.txtser_date.Size = new System.Drawing.Size(170, 22);
            this.txtser_date.TabIndex = 13;
            this.txtser_date.ValueChanged += new System.EventHandler(this.txtser_date_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_com);
            this.panel2.Controls.Add(this.lbl_pur);
            this.panel2.Controls.Add(this.txt_estlife);
            this.panel2.Controls.Add(this.lbl_estlife);
            this.panel2.Controls.Add(this.cmbpurcom);
            this.panel2.Controls.Add(this.lbl_est_life);
            this.panel2.Controls.Add(this.lbl_rep_cost);
            this.panel2.Controls.Add(this.txtpur_price);
            this.panel2.Controls.Add(this.lblpur_comp);
            this.panel2.Controls.Add(this.lblpur_price);
            this.panel2.Location = new System.Drawing.Point(543, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 432);
            this.panel2.TabIndex = 10;
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.ForeColor = System.Drawing.Color.Red;
            this.lbl_com.Location = new System.Drawing.Point(216, 165);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(0, 17);
            this.lbl_com.TabIndex = 24;
            // 
            // lbl_pur
            // 
            this.lbl_pur.AutoSize = true;
            this.lbl_pur.ForeColor = System.Drawing.Color.Red;
            this.lbl_pur.Location = new System.Drawing.Point(216, 57);
            this.lbl_pur.Name = "lbl_pur";
            this.lbl_pur.Size = new System.Drawing.Size(0, 17);
            this.lbl_pur.TabIndex = 23;
            // 
            // txt_estlife
            // 
            this.txt_estlife.Location = new System.Drawing.Point(247, 261);
            this.txt_estlife.Name = "txt_estlife";
            this.txt_estlife.Size = new System.Drawing.Size(168, 22);
            this.txt_estlife.TabIndex = 22;
            this.txt_estlife.TextChanged += new System.EventHandler(this.txt_estlife_TextChanged);
            // 
            // lbl_estlife
            // 
            this.lbl_estlife.AutoSize = true;
            this.lbl_estlife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estlife.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_estlife.Location = new System.Drawing.Point(25, 261);
            this.lbl_estlife.Name = "lbl_estlife";
            this.lbl_estlife.Size = new System.Drawing.Size(148, 25);
            this.lbl_estlife.TabIndex = 15;
            this.lbl_estlife.Text = "Estimated Life";
            // 
            // cmbpurcom
            // 
            this.cmbpurcom.FormattingEnabled = true;
            this.cmbpurcom.Items.AddRange(new object[] {
            "Abans",
            "Singer",
            "LG",
            "USHA"});
            this.cmbpurcom.Location = new System.Drawing.Point(247, 138);
            this.cmbpurcom.Name = "cmbpurcom";
            this.cmbpurcom.Size = new System.Drawing.Size(172, 24);
            this.cmbpurcom.TabIndex = 21;
            this.cmbpurcom.SelectedIndexChanged += new System.EventHandler(this.cmbpurcom_SelectedIndexChanged);
            // 
            // lbl_est_life
            // 
            this.lbl_est_life.AutoSize = true;
            this.lbl_est_life.ForeColor = System.Drawing.Color.Red;
            this.lbl_est_life.Location = new System.Drawing.Point(216, 286);
            this.lbl_est_life.Name = "lbl_est_life";
            this.lbl_est_life.Size = new System.Drawing.Size(0, 17);
            this.lbl_est_life.TabIndex = 18;
            // 
            // lbl_rep_cost
            // 
            this.lbl_rep_cost.AutoSize = true;
            this.lbl_rep_cost.ForeColor = System.Drawing.Color.Red;
            this.lbl_rep_cost.Location = new System.Drawing.Point(226, 502);
            this.lbl_rep_cost.Name = "lbl_rep_cost";
            this.lbl_rep_cost.Size = new System.Drawing.Size(0, 17);
            this.lbl_rep_cost.TabIndex = 20;
            // 
            // txtpur_price
            // 
            this.txtpur_price.Location = new System.Drawing.Point(245, 32);
            this.txtpur_price.Name = "txtpur_price";
            this.txtpur_price.Size = new System.Drawing.Size(170, 22);
            this.txtpur_price.TabIndex = 11;
            this.txtpur_price.TextChanged += new System.EventHandler(this.txtpur_price_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnadd.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.add;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnadd.Location = new System.Drawing.Point(312, 537);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(151, 59);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnupdate.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.refresh;
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnupdate.Location = new System.Drawing.Point(312, 537);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(151, 59);
            this.btnupdate.TabIndex = 12;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(543, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "DEMO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnback.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.left_arrow_icon;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnback.Location = new System.Drawing.Point(70, 537);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(151, 59);
            this.btnback.TabIndex = 14;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btn_demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1067, 608);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.Name = "btn_demo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine_Details";
            this.Load += new System.EventHandler(this.Machine_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblinstall_date;
        private System.Windows.Forms.Label lblservice_dte;
        private System.Windows.Forms.Label lblpur_price;
        private System.Windows.Forms.Label lblpur_comp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtpur_price;
        public System.Windows.Forms.DateTimePicker txtinstall_date;
        public System.Windows.Forms.DateTimePicker txtser_date;
        public System.Windows.Forms.Button btnadd;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Label lbl_mach_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_est_life;
        private System.Windows.Forms.Label lbl_rep_cost;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cmbtype;
        public System.Windows.Forms.ComboBox cmbpurcom;
        public System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lbl_estlife;
        public System.Windows.Forms.TextBox txt_estlife;
        private System.Windows.Forms.Label lbl_validate;
        private System.Windows.Forms.Label lbl_pur;
        private System.Windows.Forms.Label lbl_com;
    }
}