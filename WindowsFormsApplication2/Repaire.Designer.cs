namespace WindowsFormsApplication2
{
    partial class Repaire
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
            this.components = new System.ComponentModel.Container();
            this.lbl_rpid = new System.Windows.Forms.Label();
            this.lbl_mchid = new System.Windows.Forms.Label();
            this.lbl_rptype = new System.Windows.Forms.Label();
            this.lbl_rpcost = new System.Windows.Forms.Label();
            this.lbl_repid = new System.Windows.Forms.Label();
            this.txt_machid = new System.Windows.Forms.TextBox();
            this.cmbreptype = new System.Windows.Forms.ComboBox();
            this.txtrepcost = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.mainDataSet1 = new WindowsFormsApplication2.mainDataSet1();
            this.repaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repaireTableAdapter = new WindowsFormsApplication2.mainDataSet1TableAdapters.RepaireTableAdapter();
            this.lbl_rpdate = new System.Windows.Forms.Label();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.cmb_date = new System.Windows.Forms.ComboBox();
            this.btn_demo = new System.Windows.Forms.Button();
            this.lbl_mach_ID = new System.Windows.Forms.Label();
            this.lbl_repaire = new System.Windows.Forms.Label();
            this.lbl_rep_cost = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_rpid
            // 
            this.lbl_rpid.AutoSize = true;
            this.lbl_rpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rpid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_rpid.Location = new System.Drawing.Point(41, 104);
            this.lbl_rpid.Name = "lbl_rpid";
            this.lbl_rpid.Size = new System.Drawing.Size(103, 25);
            this.lbl_rpid.TabIndex = 0;
            this.lbl_rpid.Text = "Repaire ID";
            // 
            // lbl_mchid
            // 
            this.lbl_mchid.AutoSize = true;
            this.lbl_mchid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mchid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_mchid.Location = new System.Drawing.Point(41, 191);
            this.lbl_mchid.Name = "lbl_mchid";
            this.lbl_mchid.Size = new System.Drawing.Size(111, 25);
            this.lbl_mchid.TabIndex = 1;
            this.lbl_mchid.Text = "Machine ID";
            // 
            // lbl_rptype
            // 
            this.lbl_rptype.AutoSize = true;
            this.lbl_rptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rptype.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_rptype.Location = new System.Drawing.Point(41, 278);
            this.lbl_rptype.Name = "lbl_rptype";
            this.lbl_rptype.Size = new System.Drawing.Size(129, 25);
            this.lbl_rptype.TabIndex = 2;
            this.lbl_rptype.Text = "Repaire Type";
            // 
            // lbl_rpcost
            // 
            this.lbl_rpcost.AutoSize = true;
            this.lbl_rpcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rpcost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_rpcost.Location = new System.Drawing.Point(41, 365);
            this.lbl_rpcost.Name = "lbl_rpcost";
            this.lbl_rpcost.Size = new System.Drawing.Size(125, 25);
            this.lbl_rpcost.TabIndex = 3;
            this.lbl_rpcost.Text = "Repaire Cost";
            // 
            // lbl_repid
            // 
            this.lbl_repid.AutoSize = true;
            this.lbl_repid.Location = new System.Drawing.Point(251, 104);
            this.lbl_repid.Name = "lbl_repid";
            this.lbl_repid.Size = new System.Drawing.Size(0, 17);
            this.lbl_repid.TabIndex = 5;
            // 
            // txt_machid
            // 
            this.txt_machid.Location = new System.Drawing.Point(254, 185);
            this.txt_machid.Name = "txt_machid";
            this.txt_machid.Size = new System.Drawing.Size(200, 22);
            this.txt_machid.TabIndex = 6;
            this.txt_machid.TextChanged += new System.EventHandler(this.txt_machid_TextChanged);
            // 
            // cmbreptype
            // 
            this.cmbreptype.FormattingEnabled = true;
            this.cmbreptype.Items.AddRange(new object[] {
            "oil change ",
            "lubrication",
            "wire change ",
            "motor change"});
            this.cmbreptype.Location = new System.Drawing.Point(254, 271);
            this.cmbreptype.Name = "cmbreptype";
            this.cmbreptype.Size = new System.Drawing.Size(200, 24);
            this.cmbreptype.TabIndex = 7;
            this.cmbreptype.SelectedIndexChanged += new System.EventHandler(this.cmbreptype_SelectedIndexChanged);
            // 
            // txtrepcost
            // 
            this.txtrepcost.Location = new System.Drawing.Point(254, 359);
            this.txtrepcost.Name = "txtrepcost";
            this.txtrepcost.Size = new System.Drawing.Size(200, 22);
            this.txtrepcost.TabIndex = 8;
            this.txtrepcost.TextChanged += new System.EventHandler(this.txtrepcost_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_add.Location = new System.Drawing.Point(203, 518);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(151, 59);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_back.Location = new System.Drawing.Point(44, 518);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(151, 59);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // mainDataSet1
            // 
            this.mainDataSet1.DataSetName = "mainDataSet1";
            this.mainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repaireBindingSource
            // 
            this.repaireBindingSource.DataMember = "Repaire";
            this.repaireBindingSource.DataSource = this.mainDataSet1;
            // 
            // repaireTableAdapter
            // 
            this.repaireTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_rpdate
            // 
            this.lbl_rpdate.AutoSize = true;
            this.lbl_rpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_rpdate.Location = new System.Drawing.Point(41, 452);
            this.lbl_rpdate.Name = "lbl_rpdate";
            this.lbl_rpdate.Size = new System.Drawing.Size(125, 25);
            this.lbl_rpdate.TabIndex = 4;
            this.lbl_rpdate.Text = "Repaire Date";
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
            "2015",
            "2016"});
            this.cmb_year.Location = new System.Drawing.Point(233, 445);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(81, 24);
            this.cmb_year.TabIndex = 12;
            this.cmb_year.SelectedIndexChanged += new System.EventHandler(this.cmb_year_SelectedIndexChanged);
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
            this.cmb_month.Location = new System.Drawing.Point(320, 445);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(87, 24);
            this.cmb_month.TabIndex = 13;
            this.cmb_month.SelectedIndexChanged += new System.EventHandler(this.cmb_year_SelectedIndexChanged);
            // 
            // cmb_date
            // 
            this.cmb_date.FormattingEnabled = true;
            this.cmb_date.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmb_date.Location = new System.Drawing.Point(413, 445);
            this.cmb_date.MaxDropDownItems = 5;
            this.cmb_date.Name = "cmb_date";
            this.cmb_date.Size = new System.Drawing.Size(71, 24);
            this.cmb_date.TabIndex = 10;
            this.cmb_date.SelectedIndexChanged += new System.EventHandler(this.cmb_year_SelectedIndexChanged);
            // 
            // btn_demo
            // 
            this.btn_demo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_demo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_demo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_demo.Location = new System.Drawing.Point(362, 518);
            this.btn_demo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_demo.Name = "btn_demo";
            this.btn_demo.Size = new System.Drawing.Size(151, 59);
            this.btn_demo.TabIndex = 15;
            this.btn_demo.Text = "DEMO";
            this.btn_demo.UseVisualStyleBackColor = false;
            this.btn_demo.Click += new System.EventHandler(this.btn_demo_Click);
            // 
            // lbl_mach_ID
            // 
            this.lbl_mach_ID.AutoSize = true;
            this.lbl_mach_ID.ForeColor = System.Drawing.Color.Red;
            this.lbl_mach_ID.Location = new System.Drawing.Point(251, 210);
            this.lbl_mach_ID.Name = "lbl_mach_ID";
            this.lbl_mach_ID.Size = new System.Drawing.Size(0, 17);
            this.lbl_mach_ID.TabIndex = 16;
            // 
            // lbl_repaire
            // 
            this.lbl_repaire.AutoSize = true;
            this.lbl_repaire.ForeColor = System.Drawing.Color.Red;
            this.lbl_repaire.Location = new System.Drawing.Point(251, 298);
            this.lbl_repaire.Name = "lbl_repaire";
            this.lbl_repaire.Size = new System.Drawing.Size(0, 17);
            this.lbl_repaire.TabIndex = 17;
            // 
            // lbl_rep_cost
            // 
            this.lbl_rep_cost.AutoSize = true;
            this.lbl_rep_cost.ForeColor = System.Drawing.Color.Red;
            this.lbl_rep_cost.Location = new System.Drawing.Point(251, 384);
            this.lbl_rep_cost.Name = "lbl_rep_cost";
            this.lbl_rep_cost.Size = new System.Drawing.Size(0, 17);
            this.lbl_rep_cost.TabIndex = 18;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.ForeColor = System.Drawing.Color.Red;
            this.lbl_date.Location = new System.Drawing.Point(230, 472);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 17);
            this.lbl_date.TabIndex = 19;
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.ForeColor = System.Drawing.Color.Red;
            this.lbl_month.Location = new System.Drawing.Point(317, 472);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(0, 17);
            this.lbl_month.TabIndex = 20;
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.ForeColor = System.Drawing.Color.Red;
            this.lbl_year.Location = new System.Drawing.Point(410, 472);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(0, 17);
            this.lbl_year.TabIndex = 21;
            // 
            // Repaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(564, 608);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_rep_cost);
            this.Controls.Add(this.lbl_repaire);
            this.Controls.Add(this.lbl_mach_ID);
            this.Controls.Add(this.btn_demo);
            this.Controls.Add(this.cmb_date);
            this.Controls.Add(this.cmb_month);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtrepcost);
            this.Controls.Add(this.cmbreptype);
            this.Controls.Add(this.txt_machid);
            this.Controls.Add(this.lbl_repid);
            this.Controls.Add(this.lbl_rpdate);
            this.Controls.Add(this.lbl_rpcost);
            this.Controls.Add(this.lbl_rptype);
            this.Controls.Add(this.lbl_mchid);
            this.Controls.Add(this.lbl_rpid);
            this.Name = "Repaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaire";
            this.Load += new System.EventHandler(this.Repaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repaireBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rpid;
        private System.Windows.Forms.Label lbl_mchid;
        private System.Windows.Forms.Label lbl_rptype;
        private System.Windows.Forms.Label lbl_rpcost;
        private System.Windows.Forms.Label lbl_repid;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox txt_machid;
        public System.Windows.Forms.TextBox txtrepcost;
        public System.Windows.Forms.ComboBox cmbreptype;
        public System.Windows.Forms.Button btn_back;
        private mainDataSet1 mainDataSet1;
        private System.Windows.Forms.BindingSource repaireBindingSource;
        private mainDataSet1TableAdapters.RepaireTableAdapter repaireTableAdapter;
        private System.Windows.Forms.Label lbl_rpdate;
        public System.Windows.Forms.ComboBox cmb_year;
        public System.Windows.Forms.ComboBox cmb_month;
        public System.Windows.Forms.ComboBox cmb_date;
        public System.Windows.Forms.Button btn_demo;
        private System.Windows.Forms.Label lbl_mach_ID;
        private System.Windows.Forms.Label lbl_repaire;
        private System.Windows.Forms.Label lbl_rep_cost;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.Label lbl_year;
    }
}