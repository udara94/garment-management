namespace WindowsFormsApplication2
{
    partial class cost
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
            this.lbl_cost = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.lbl_month = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_annual = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ann = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.Location = new System.Drawing.Point(207, 26);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(103, 38);
            this.lbl_cost.TabIndex = 0;
            this.lbl_cost.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(553, 599);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_back.Location = new System.Drawing.Point(183, 536);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(151, 59);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_label
            // 
            this.lbl_label.AutoSize = true;
            this.lbl_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.lbl_label.Location = new System.Drawing.Point(3, 37);
            this.lbl_label.Name = "lbl_label";
            this.lbl_label.Size = new System.Drawing.Size(198, 25);
            this.lbl_label.TabIndex = 5;
            this.lbl_label.Text = "Total Maintance Cost";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_label);
            this.panel1.Controls.Add(this.lbl_cost);
            this.panel1.Location = new System.Drawing.Point(70, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 87);
            this.panel1.TabIndex = 6;
            // 
            // cmb_month
            // 
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_month.Location = new System.Drawing.Point(61, 15);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(121, 24);
            this.cmb_month.TabIndex = 7;
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.lbl_month.Location = new System.Drawing.Point(3, 18);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(47, 17);
            this.lbl_month.TabIndex = 8;
            this.lbl_month.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 9;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.lbl_year.Location = new System.Drawing.Point(199, 22);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(38, 17);
            this.lbl_year.TabIndex = 10;
            this.lbl_year.Text = "Year";
            // 
            // cmb_year
            // 
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Items.AddRange(new object[] {
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cmb_year.Location = new System.Drawing.Point(247, 15);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(137, 24);
            this.cmb_year.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(61, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Maintanace Cost";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_annual
            // 
            this.cmb_annual.FormattingEnabled = true;
            this.cmb_annual.Items.AddRange(new object[] {
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cmb_annual.Location = new System.Drawing.Point(61, 37);
            this.cmb_annual.Name = "cmb_annual";
            this.cmb_annual.Size = new System.Drawing.Size(121, 24);
            this.cmb_annual.TabIndex = 13;
            this.cmb_annual.SelectedIndexChanged += new System.EventHandler(this.cmb_annual_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Year";
            // 
            // lbl_ann
            // 
            this.lbl_ann.AutoSize = true;
            this.lbl_ann.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ann.Location = new System.Drawing.Point(219, 29);
            this.lbl_ann.Name = "lbl_ann";
            this.lbl_ann.Size = new System.Drawing.Size(0, 32);
            this.lbl_ann.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_ann);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb_annual);
            this.panel2.Location = new System.Drawing.Point(70, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 100);
            this.panel2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.label3.Location = new System.Drawing.Point(67, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Maintance cost for selected year";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbl_year);
            this.panel3.Controls.Add(this.cmb_month);
            this.panel3.Controls.Add(this.cmb_year);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lbl_month);
            this.panel3.Location = new System.Drawing.Point(70, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 124);
            this.panel3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(67, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Maintanance cost for selected month";
            // 
            // cost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 608);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cost";
            this.Load += new System.EventHandler(this.cost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.Label lbl_label;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_annual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ann;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}