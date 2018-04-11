namespace WindowsFormsApplication2
{
    partial class service
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_mach_no = new System.Windows.Forms.Label();
            this.lbl_service_no = new System.Windows.Forms.Label();
            this.txtser_date = new System.Windows.Forms.DateTimePicker();
            this.txtmach_no = new System.Windows.Forms.TextBox();
            this.lblmachine_no = new System.Windows.Forms.Label();
            this.lblservice_date = new System.Windows.Forms.Label();
            this.lblservice_no = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ser_stat = new System.Windows.Forms.Label();
            this.cmbstation = new System.Windows.Forms.ComboBox();
            this.lbl_ser_cost = new System.Windows.Forms.Label();
            this.lbl_ser_per = new System.Windows.Forms.Label();
            this.txtser_per = new System.Windows.Forms.TextBox();
            this.txtser_cost = new System.Windows.Forms.TextBox();
            this.lblser_period = new System.Windows.Forms.Label();
            this.lblser_cost = new System.Windows.Forms.Label();
            this.lblser_sta = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btn_demo = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_mach_no);
            this.panel1.Controls.Add(this.lbl_service_no);
            this.panel1.Controls.Add(this.txtser_date);
            this.panel1.Controls.Add(this.txtmach_no);
            this.panel1.Controls.Add(this.lblmachine_no);
            this.panel1.Controls.Add(this.lblservice_date);
            this.panel1.Controls.Add(this.lblservice_no);
            this.panel1.Location = new System.Drawing.Point(46, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 353);
            this.panel1.TabIndex = 0;
            // 
            // lbl_mach_no
            // 
            this.lbl_mach_no.AutoSize = true;
            this.lbl_mach_no.ForeColor = System.Drawing.Color.Red;
            this.lbl_mach_no.Location = new System.Drawing.Point(237, 210);
            this.lbl_mach_no.Name = "lbl_mach_no";
            this.lbl_mach_no.Size = new System.Drawing.Size(0, 17);
            this.lbl_mach_no.TabIndex = 8;
            // 
            // lbl_service_no
            // 
            this.lbl_service_no.AutoSize = true;
            this.lbl_service_no.Location = new System.Drawing.Point(204, 47);
            this.lbl_service_no.Name = "lbl_service_no";
            this.lbl_service_no.Size = new System.Drawing.Size(0, 17);
            this.lbl_service_no.TabIndex = 7;
            // 
            // txtser_date
            // 
            this.txtser_date.Location = new System.Drawing.Point(240, 289);
            this.txtser_date.Name = "txtser_date";
            this.txtser_date.Size = new System.Drawing.Size(167, 22);
            this.txtser_date.TabIndex = 6;
            this.txtser_date.ValueChanged += new System.EventHandler(this.txtser_date_ValueChanged);
            // 
            // txtmach_no
            // 
            this.txtmach_no.Location = new System.Drawing.Point(233, 183);
            this.txtmach_no.Name = "txtmach_no";
            this.txtmach_no.Size = new System.Drawing.Size(167, 22);
            this.txtmach_no.TabIndex = 4;
            this.txtmach_no.TextChanged += new System.EventHandler(this.txtmach_no_TextChanged);
            // 
            // lblmachine_no
            // 
            this.lblmachine_no.AutoSize = true;
            this.lblmachine_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmachine_no.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblmachine_no.Location = new System.Drawing.Point(35, 185);
            this.lblmachine_no.Name = "lblmachine_no";
            this.lblmachine_no.Size = new System.Drawing.Size(175, 25);
            this.lblmachine_no.TabIndex = 2;
            this.lblmachine_no.Text = "Machine Number";
            // 
            // lblservice_date
            // 
            this.lblservice_date.AutoSize = true;
            this.lblservice_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservice_date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblservice_date.Location = new System.Drawing.Point(42, 288);
            this.lblservice_date.Name = "lblservice_date";
            this.lblservice_date.Size = new System.Drawing.Size(136, 25);
            this.lblservice_date.TabIndex = 1;
            this.lblservice_date.Text = "Service Date";
            // 
            // lblservice_no
            // 
            this.lblservice_no.AutoSize = true;
            this.lblservice_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservice_no.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblservice_no.Location = new System.Drawing.Point(42, 47);
            this.lblservice_no.Name = "lblservice_no";
            this.lblservice_no.Size = new System.Drawing.Size(166, 25);
            this.lblservice_no.TabIndex = 0;
            this.lblservice_no.Text = "Service Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_ser_stat);
            this.panel2.Controls.Add(this.cmbstation);
            this.panel2.Controls.Add(this.lbl_ser_cost);
            this.panel2.Controls.Add(this.lbl_ser_per);
            this.panel2.Controls.Add(this.txtser_per);
            this.panel2.Controls.Add(this.txtser_cost);
            this.panel2.Controls.Add(this.lblser_period);
            this.panel2.Controls.Add(this.lblser_cost);
            this.panel2.Controls.Add(this.lblser_sta);
            this.panel2.Location = new System.Drawing.Point(575, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 353);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_ser_stat
            // 
            this.lbl_ser_stat.AutoSize = true;
            this.lbl_ser_stat.ForeColor = System.Drawing.Color.Red;
            this.lbl_ser_stat.Location = new System.Drawing.Point(250, 332);
            this.lbl_ser_stat.Name = "lbl_ser_stat";
            this.lbl_ser_stat.Size = new System.Drawing.Size(0, 17);
            this.lbl_ser_stat.TabIndex = 12;
            // 
            // cmbstation
            // 
            this.cmbstation.FormattingEnabled = true;
            this.cmbstation.Items.AddRange(new object[] {
            "Abans",
            "LG",
            "Singer",
            "USHA"});
            this.cmbstation.Location = new System.Drawing.Point(244, 300);
            this.cmbstation.Name = "cmbstation";
            this.cmbstation.Size = new System.Drawing.Size(176, 24);
            this.cmbstation.TabIndex = 11;
            this.cmbstation.SelectedIndexChanged += new System.EventHandler(this.cmbstation_SelectedIndexChanged);
            // 
            // lbl_ser_cost
            // 
            this.lbl_ser_cost.AutoSize = true;
            this.lbl_ser_cost.ForeColor = System.Drawing.Color.Red;
            this.lbl_ser_cost.Location = new System.Drawing.Point(250, 195);
            this.lbl_ser_cost.Name = "lbl_ser_cost";
            this.lbl_ser_cost.Size = new System.Drawing.Size(0, 17);
            this.lbl_ser_cost.TabIndex = 10;
            // 
            // lbl_ser_per
            // 
            this.lbl_ser_per.AutoSize = true;
            this.lbl_ser_per.ForeColor = System.Drawing.Color.Red;
            this.lbl_ser_per.Location = new System.Drawing.Point(250, 77);
            this.lbl_ser_per.Name = "lbl_ser_per";
            this.lbl_ser_per.Size = new System.Drawing.Size(0, 17);
            this.lbl_ser_per.TabIndex = 9;
            // 
            // txtser_per
            // 
            this.txtser_per.Location = new System.Drawing.Point(253, 49);
            this.txtser_per.Name = "txtser_per";
            this.txtser_per.Size = new System.Drawing.Size(167, 22);
            this.txtser_per.TabIndex = 6;
            this.txtser_per.TextChanged += new System.EventHandler(this.txtser_per_TextChanged);
            // 
            // txtser_cost
            // 
            this.txtser_cost.Location = new System.Drawing.Point(253, 170);
            this.txtser_cost.Name = "txtser_cost";
            this.txtser_cost.Size = new System.Drawing.Size(167, 22);
            this.txtser_cost.TabIndex = 7;
            this.txtser_cost.TextChanged += new System.EventHandler(this.txtser_cost_TextChanged);
            // 
            // lblser_period
            // 
            this.lblser_period.AutoSize = true;
            this.lblser_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblser_period.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblser_period.Location = new System.Drawing.Point(52, 47);
            this.lblser_period.Name = "lblser_period";
            this.lblser_period.Size = new System.Drawing.Size(153, 25);
            this.lblser_period.TabIndex = 3;
            this.lblser_period.Text = "Service Period";
            // 
            // lblser_cost
            // 
            this.lblser_cost.AutoSize = true;
            this.lblser_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblser_cost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblser_cost.Location = new System.Drawing.Point(52, 170);
            this.lblser_cost.Name = "lblser_cost";
            this.lblser_cost.Size = new System.Drawing.Size(136, 25);
            this.lblser_cost.TabIndex = 4;
            this.lblser_cost.Text = "Service Cost";
            // 
            // lblser_sta
            // 
            this.lblser_sta.AutoSize = true;
            this.lblser_sta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblser_sta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblser_sta.Location = new System.Drawing.Point(52, 293);
            this.lblser_sta.Name = "lblser_sta";
            this.lblser_sta.Size = new System.Drawing.Size(159, 25);
            this.lblser_sta.TabIndex = 5;
            this.lblser_sta.Text = "Service Station";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnupdate.Location = new System.Drawing.Point(354, 450);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(151, 59);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnADD.Location = new System.Drawing.Point(354, 450);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(151, 59);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btn_demo
            // 
            this.btn_demo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_demo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_demo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_demo.Location = new System.Drawing.Point(575, 450);
            this.btn_demo.Name = "btn_demo";
            this.btn_demo.Size = new System.Drawing.Size(151, 59);
            this.btn_demo.TabIndex = 2;
            this.btn_demo.Text = "DEMO";
            this.btn_demo.UseVisualStyleBackColor = false;
            this.btn_demo.Click += new System.EventHandler(this.btn_demo_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnback.Location = new System.Drawing.Point(141, 450);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(151, 59);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1067, 608);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btn_demo);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "service";
            this.Load += new System.EventHandler(this.service_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblmachine_no;
        private System.Windows.Forms.Label lblservice_date;
        private System.Windows.Forms.Label lblservice_no;
        private System.Windows.Forms.Label lblser_period;
        private System.Windows.Forms.Label lblser_cost;
        private System.Windows.Forms.Label lblser_sta;
        public System.Windows.Forms.TextBox txtmach_no;
        public System.Windows.Forms.TextBox txtser_per;
        public System.Windows.Forms.TextBox txtser_cost;
        public System.Windows.Forms.DateTimePicker txtser_date;
        public System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.Button btnADD;
        public System.Windows.Forms.Label lbl_service_no;
        private System.Windows.Forms.Label lbl_mach_no;
        private System.Windows.Forms.Label lbl_ser_cost;
        private System.Windows.Forms.Label lbl_ser_per;
        private System.Windows.Forms.Button btn_demo;
        public System.Windows.Forms.Button btnback;
        public System.Windows.Forms.ComboBox cmbstation;
        private System.Windows.Forms.Label lbl_ser_stat;
    }
}