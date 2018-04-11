namespace WindowsFormsApplication2
{
    partial class parts
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
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.lbl_pur_pri = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_part_id = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txtpur_price = new System.Windows.Forms.TextBox();
            this.lblpurch_price = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_validate = new System.Windows.Forms.Label();
            this.cmbpurcom = new System.Windows.Forms.ComboBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_pur_com = new System.Windows.Forms.Label();
            this.txt_pur_date = new System.Windows.Forms.DateTimePicker();
            this.txtins_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_pur_date = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblquty = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblintall_date = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblpur_comp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnpart_add = new System.Windows.Forms.Button();
            this.btnpart_update = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.cmbtype);
            this.panel1.Controls.Add(this.lbl_pur_pri);
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Controls.Add(this.lbl_part_id);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.txtpur_price);
            this.panel1.Controls.Add(this.lblpurch_price);
            this.panel1.Controls.Add(this.lbltype);
            this.panel1.Location = new System.Drawing.Point(33, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 505);
            this.panel1.TabIndex = 0;
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Motor",
            "Wheel",
            "Wire",
            "Needle",
            "Paddle",
            "Shuttle"});
            this.cmbtype.Location = new System.Drawing.Point(203, 233);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(159, 24);
            this.cmbtype.TabIndex = 13;
            this.cmbtype.SelectedIndexChanged += new System.EventHandler(this.cmbtype_SelectedIndexChanged);
            // 
            // lbl_pur_pri
            // 
            this.lbl_pur_pri.AutoSize = true;
            this.lbl_pur_pri.ForeColor = System.Drawing.Color.Red;
            this.lbl_pur_pri.Location = new System.Drawing.Point(200, 391);
            this.lbl_pur_pri.Name = "lbl_pur_pri";
            this.lbl_pur_pri.Size = new System.Drawing.Size(0, 17);
            this.lbl_pur_pri.TabIndex = 12;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.ForeColor = System.Drawing.Color.Red;
            this.lbl_type.Location = new System.Drawing.Point(200, 260);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(0, 17);
            this.lbl_type.TabIndex = 11;
            // 
            // lbl_part_id
            // 
            this.lbl_part_id.AutoSize = true;
            this.lbl_part_id.Location = new System.Drawing.Point(200, 81);
            this.lbl_part_id.Name = "lbl_part_id";
            this.lbl_part_id.Size = new System.Drawing.Size(0, 17);
            this.lbl_part_id.TabIndex = 9;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_id.Location = new System.Drawing.Point(37, 81);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(75, 25);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "Part Id";
            // 
            // txtpur_price
            // 
            this.txtpur_price.Location = new System.Drawing.Point(203, 366);
            this.txtpur_price.Name = "txtpur_price";
            this.txtpur_price.Size = new System.Drawing.Size(159, 22);
            this.txtpur_price.TabIndex = 6;
            this.txtpur_price.TextChanged += new System.EventHandler(this.txtpur_price_TextChanged_1);
            // 
            // lblpurch_price
            // 
            this.lblpurch_price.AutoSize = true;
            this.lblpurch_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpurch_price.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblpurch_price.Location = new System.Drawing.Point(37, 368);
            this.lblpurch_price.Name = "lblpurch_price";
            this.lblpurch_price.Size = new System.Drawing.Size(158, 25);
            this.lblpurch_price.TabIndex = 3;
            this.lblpurch_price.Text = "Purchase Price";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbltype.Location = new System.Drawing.Point(37, 233);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(61, 25);
            this.lbltype.TabIndex = 2;
            this.lbltype.Text = "Type";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_validate);
            this.panel2.Controls.Add(this.cmbpurcom);
            this.panel2.Controls.Add(this.lbl_qty);
            this.panel2.Controls.Add(this.lbl_pur_com);
            this.panel2.Controls.Add(this.txt_pur_date);
            this.panel2.Controls.Add(this.txtins_date);
            this.panel2.Controls.Add(this.lbl_pur_date);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblquty);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblintall_date);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblpur_comp);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(583, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 505);
            this.panel2.TabIndex = 1;
            // 
            // lbl_validate
            // 
            this.lbl_validate.AutoSize = true;
            this.lbl_validate.ForeColor = System.Drawing.Color.Red;
            this.lbl_validate.Location = new System.Drawing.Point(219, 462);
            this.lbl_validate.Name = "lbl_validate";
            this.lbl_validate.Size = new System.Drawing.Size(0, 17);
            this.lbl_validate.TabIndex = 16;
            // 
            // cmbpurcom
            // 
            this.cmbpurcom.FormattingEnabled = true;
            this.cmbpurcom.Items.AddRange(new object[] {
            "LG",
            "Singer",
            "Abans",
            "USHA"});
            this.cmbpurcom.Location = new System.Drawing.Point(222, 314);
            this.cmbpurcom.Name = "cmbpurcom";
            this.cmbpurcom.Size = new System.Drawing.Size(159, 24);
            this.cmbpurcom.TabIndex = 15;
            this.cmbpurcom.SelectedIndexChanged += new System.EventHandler(this.cmbpurcom_SelectedIndexChanged);
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.ForeColor = System.Drawing.Color.Red;
            this.lbl_qty.Location = new System.Drawing.Point(219, 81);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(0, 17);
            this.lbl_qty.TabIndex = 13;
            // 
            // lbl_pur_com
            // 
            this.lbl_pur_com.AutoSize = true;
            this.lbl_pur_com.ForeColor = System.Drawing.Color.Red;
            this.lbl_pur_com.Location = new System.Drawing.Point(219, 341);
            this.lbl_pur_com.Name = "lbl_pur_com";
            this.lbl_pur_com.Size = new System.Drawing.Size(0, 17);
            this.lbl_pur_com.TabIndex = 14;
            // 
            // txt_pur_date
            // 
            this.txt_pur_date.Location = new System.Drawing.Point(222, 437);
            this.txt_pur_date.Name = "txt_pur_date";
            this.txt_pur_date.Size = new System.Drawing.Size(159, 22);
            this.txt_pur_date.TabIndex = 13;
            this.txt_pur_date.ValueChanged += new System.EventHandler(this.txt_pur_date_ValueChanged);
            // 
            // txtins_date
            // 
            this.txtins_date.Location = new System.Drawing.Point(222, 187);
            this.txtins_date.Name = "txtins_date";
            this.txtins_date.Size = new System.Drawing.Size(159, 22);
            this.txtins_date.TabIndex = 12;
            // 
            // lbl_pur_date
            // 
            this.lbl_pur_date.AutoSize = true;
            this.lbl_pur_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pur_date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_pur_date.Location = new System.Drawing.Point(1, 439);
            this.lbl_pur_date.Name = "lbl_pur_date";
            this.lbl_pur_date.Size = new System.Drawing.Size(154, 25);
            this.lbl_pur_date.TabIndex = 10;
            this.lbl_pur_date.Text = "Purchase Date";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(222, 55);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(159, 22);
            this.txtqty.TabIndex = 7;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-488, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Purchase Price";
            // 
            // lblquty
            // 
            this.lblquty.AutoSize = true;
            this.lblquty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquty.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblquty.Location = new System.Drawing.Point(2, 57);
            this.lblquty.Name = "lblquty";
            this.lblquty.Size = new System.Drawing.Size(93, 25);
            this.lblquty.TabIndex = 4;
            this.lblquty.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-488, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Type";
            // 
            // lblintall_date
            // 
            this.lblintall_date.AutoSize = true;
            this.lblintall_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintall_date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblintall_date.Location = new System.Drawing.Point(2, 189);
            this.lblintall_date.Name = "lblintall_date";
            this.lblintall_date.Size = new System.Drawing.Size(120, 25);
            this.lblintall_date.TabIndex = 5;
            this.lblintall_date.Text = "Install Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-488, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Part Number";
            // 
            // lblpur_comp
            // 
            this.lblpur_comp.AutoSize = true;
            this.lblpur_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpur_comp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblpur_comp.Location = new System.Drawing.Point(1, 318);
            this.lblpur_comp.Name = "lblpur_comp";
            this.lblpur_comp.Size = new System.Drawing.Size(201, 25);
            this.lblpur_comp.TabIndex = 6;
            this.lblpur_comp.Text = "Purchase Company";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-488, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Part ID";
            // 
            // btnpart_add
            // 
            this.btnpart_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnpart_add.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.add;
            this.btnpart_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnpart_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpart_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnpart_add.Location = new System.Drawing.Point(356, 537);
            this.btnpart_add.Name = "btnpart_add";
            this.btnpart_add.Size = new System.Drawing.Size(151, 59);
            this.btnpart_add.TabIndex = 2;
            this.btnpart_add.Text = "ADD";
            this.btnpart_add.UseVisualStyleBackColor = false;
            this.btnpart_add.Click += new System.EventHandler(this.btnpart_add_Click);
            // 
            // btnpart_update
            // 
            this.btnpart_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnpart_update.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.refresh;
            this.btnpart_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnpart_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpart_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnpart_update.Location = new System.Drawing.Point(356, 537);
            this.btnpart_update.Name = "btnpart_update";
            this.btnpart_update.Size = new System.Drawing.Size(151, 59);
            this.btnpart_update.TabIndex = 3;
            this.btnpart_update.Text = "UPDATE";
            this.btnpart_update.UseVisualStyleBackColor = false;
            this.btnpart_update.Click += new System.EventHandler(this.btnpart_update_Click);
            // 
            // btn_demo
            // 
            this.btn_demo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_demo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_demo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_demo.Location = new System.Drawing.Point(582, 537);
            this.btn_demo.Name = "btn_demo";
            this.btn_demo.Size = new System.Drawing.Size(151, 59);
            this.btn_demo.TabIndex = 4;
            this.btn_demo.Text = "DEMO";
            this.btn_demo.UseVisualStyleBackColor = false;
            this.btn_demo.Click += new System.EventHandler(this.btn_demo_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnback.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.left_arrow_icon;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnback.Location = new System.Drawing.Point(171, 537);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(151, 59);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1067, 608);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btn_demo);
            this.Controls.Add(this.btnpart_add);
            this.Controls.Add(this.btnpart_update);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "parts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parts";
            this.Load += new System.EventHandler(this.parts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblpurch_price;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblquty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblintall_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblpur_comp;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtpur_price;
        public System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lbl_pur_date;
        public System.Windows.Forms.DateTimePicker txtins_date;
        public System.Windows.Forms.DateTimePicker txt_pur_date;
        public System.Windows.Forms.Button btnpart_add;
        public System.Windows.Forms.Button btnpart_update;
        public System.Windows.Forms.Label lbl_part_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_pur_pri;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_pur_com;
        private System.Windows.Forms.Button btn_demo;
        public System.Windows.Forms.ComboBox cmbpurcom;
        public System.Windows.Forms.Button btnback;
        public System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Label lbl_validate;
    }
}