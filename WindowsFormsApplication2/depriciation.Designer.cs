namespace WindowsFormsApplication2
{
    partial class depriciation
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
            this.dgvdep = new System.Windows.Forms.DataGridView();
            this.lblmachine_ID = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_machine_id = new System.Windows.Forms.TextBox();
            this.txt_pur_cost = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.lblpur_cost = new System.Windows.Forms.Label();
            this.lbl_pur_date = new System.Windows.Forms.Label();
            this.txt_pur_date = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblperiod = new System.Windows.Forms.Label();
            this.txt_period = new System.Windows.Forms.TextBox();
            this.lbl_ann_dep = new System.Windows.Forms.Label();
            this.lbl_mon_dep = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_period = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.lbl_anual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdep)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdep
            // 
            this.dgvdep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdep.Location = new System.Drawing.Point(12, 12);
            this.dgvdep.Name = "dgvdep";
            this.dgvdep.RowTemplate.Height = 24;
            this.dgvdep.Size = new System.Drawing.Size(622, 299);
            this.dgvdep.TabIndex = 0;
            this.dgvdep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdep_CellClick);
            // 
            // lblmachine_ID
            // 
            this.lblmachine_ID.AutoSize = true;
            this.lblmachine_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmachine_ID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblmachine_ID.Location = new System.Drawing.Point(3, 53);
            this.lblmachine_ID.Name = "lblmachine_ID";
            this.lblmachine_ID.Size = new System.Drawing.Size(104, 20);
            this.lblmachine_ID.TabIndex = 1;
            this.lblmachine_ID.Text = "Machine ID";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_type.Location = new System.Drawing.Point(3, 152);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(49, 20);
            this.lbl_type.TabIndex = 3;
            this.lbl_type.Text = "Type";
            // 
            // txt_machine_id
            // 
            this.txt_machine_id.Location = new System.Drawing.Point(184, 51);
            this.txt_machine_id.Name = "txt_machine_id";
            this.txt_machine_id.Size = new System.Drawing.Size(172, 22);
            this.txt_machine_id.TabIndex = 4;
            // 
            // txt_pur_cost
            // 
            this.txt_pur_cost.Location = new System.Drawing.Point(184, 249);
            this.txt_pur_cost.Name = "txt_pur_cost";
            this.txt_pur_cost.Size = new System.Drawing.Size(172, 22);
            this.txt_pur_cost.TabIndex = 5;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(184, 150);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(172, 22);
            this.txt_type.TabIndex = 6;
            // 
            // lblpur_cost
            // 
            this.lblpur_cost.AutoSize = true;
            this.lblpur_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpur_cost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblpur_cost.Location = new System.Drawing.Point(3, 251);
            this.lblpur_cost.Name = "lblpur_cost";
            this.lblpur_cost.Size = new System.Drawing.Size(133, 20);
            this.lblpur_cost.TabIndex = 8;
            this.lblpur_cost.Text = "Purchase Cost";
            // 
            // lbl_pur_date
            // 
            this.lbl_pur_date.AutoSize = true;
            this.lbl_pur_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pur_date.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_pur_date.Location = new System.Drawing.Point(3, 350);
            this.lbl_pur_date.Name = "lbl_pur_date";
            this.lbl_pur_date.Size = new System.Drawing.Size(106, 20);
            this.lbl_pur_date.TabIndex = 9;
            this.lbl_pur_date.Text = "Install Date";
            // 
            // txt_pur_date
            // 
            this.txt_pur_date.Location = new System.Drawing.Point(184, 348);
            this.txt_pur_date.Name = "txt_pur_date";
            this.txt_pur_date.Size = new System.Drawing.Size(172, 22);
            this.txt_pur_date.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_pur_date);
            this.panel1.Controls.Add(this.lbl_pur_date);
            this.panel1.Controls.Add(this.lblpur_cost);
            this.panel1.Controls.Add(this.lblperiod);
            this.panel1.Controls.Add(this.txt_type);
            this.panel1.Controls.Add(this.txt_pur_cost);
            this.panel1.Controls.Add(this.txt_machine_id);
            this.panel1.Controls.Add(this.txt_period);
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Controls.Add(this.lblmachine_ID);
            this.panel1.Location = new System.Drawing.Point(679, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 519);
            this.panel1.TabIndex = 11;
            // 
            // lblperiod
            // 
            this.lblperiod.AutoSize = true;
            this.lblperiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperiod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblperiod.Location = new System.Drawing.Point(3, 449);
            this.lblperiod.Name = "lblperiod";
            this.lblperiod.Size = new System.Drawing.Size(215, 20);
            this.lblperiod.TabIndex = 15;
            this.lblperiod.Text = "Years to depreciate over";
            // 
            // txt_period
            // 
            this.txt_period.Location = new System.Drawing.Point(256, 447);
            this.txt_period.Name = "txt_period";
            this.txt_period.Size = new System.Drawing.Size(100, 22);
            this.txt_period.TabIndex = 12;
            this.txt_period.TextChanged += new System.EventHandler(this.txt_period_TextChanged);
            // 
            // lbl_ann_dep
            // 
            this.lbl_ann_dep.AutoSize = true;
            this.lbl_ann_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ann_dep.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ann_dep.Location = new System.Drawing.Point(31, 40);
            this.lbl_ann_dep.Name = "lbl_ann_dep";
            this.lbl_ann_dep.Size = new System.Drawing.Size(248, 20);
            this.lbl_ann_dep.TabIndex = 16;
            this.lbl_ann_dep.Text = "Annual Depreciation Amount";
            // 
            // lbl_mon_dep
            // 
            this.lbl_mon_dep.AutoSize = true;
            this.lbl_mon_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mon_dep.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_mon_dep.Location = new System.Drawing.Point(31, 89);
            this.lbl_mon_dep.Name = "lbl_mon_dep";
            this.lbl_mon_dep.Size = new System.Drawing.Size(251, 20);
            this.lbl_mon_dep.TabIndex = 17;
            this.lbl_mon_dep.Text = "Monthly Depriciation Amount";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_period);
            this.panel2.Controls.Add(this.lbl_month);
            this.panel2.Controls.Add(this.lbl_anual);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_mon_dep);
            this.panel2.Controls.Add(this.lbl_ann_dep);
            this.panel2.Location = new System.Drawing.Point(12, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 211);
            this.panel2.TabIndex = 20;
            // 
            // lbl_period
            // 
            this.lbl_period.AutoSize = true;
            this.lbl_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_period.Location = new System.Drawing.Point(316, 139);
            this.lbl_period.Name = "lbl_period";
            this.lbl_period.Size = new System.Drawing.Size(0, 20);
            this.lbl_period.TabIndex = 21;
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_month.Location = new System.Drawing.Point(316, 87);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(0, 20);
            this.lbl_month.TabIndex = 20;
            // 
            // lbl_anual
            // 
            this.lbl_anual.AutoSize = true;
            this.lbl_anual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anual.Location = new System.Drawing.Point(316, 40);
            this.lbl_anual.Name = "lbl_anual";
            this.lbl_anual.Size = new System.Drawing.Size(0, 20);
            this.lbl_anual.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(31, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Depreciation Period";
            // 
            // btn_clean
            // 
            this.btn_clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clean.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clean.Location = new System.Drawing.Point(169, 537);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(151, 59);
            this.btn_clean.TabIndex = 20;
            this.btn_clean.Text = "Clean";
            this.btn_clean.UseVisualStyleBackColor = false;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_back.Location = new System.Drawing.Point(12, 537);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(151, 59);
            this.btn_back.TabIndex = 22;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // depriciation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1067, 608);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvdep);
            this.Name = "depriciation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "depriciation";
            this.Load += new System.EventHandler(this.depriciation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblmachine_ID;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lblpur_cost;
        public System.Windows.Forms.TextBox txt_machine_id;
        public System.Windows.Forms.TextBox txt_pur_cost;
        public System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label lbl_pur_date;
        public System.Windows.Forms.TextBox txt_pur_date;
        public System.Windows.Forms.DataGridView dgvdep;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_period;
        private System.Windows.Forms.Label lblperiod;
        private System.Windows.Forms.Label lbl_ann_dep;
        private System.Windows.Forms.Label lbl_mon_dep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_period;
        public System.Windows.Forms.Label lbl_month;
        public System.Windows.Forms.Label lbl_anual;
    }
}