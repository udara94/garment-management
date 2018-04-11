namespace WindowsFormsApplication2
{
    partial class crystal
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_part = new System.Windows.Forms.Button();
            this.btn_machine = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_parameter = new System.Windows.Forms.Button();
            this.btn_service = new System.Windows.Forms.Button();
            this.btn_repaire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(546, 553);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // btn_part
            // 
            this.btn_part.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_part.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_part.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_part.Location = new System.Drawing.Point(24, 352);
            this.btn_part.Margin = new System.Windows.Forms.Padding(4);
            this.btn_part.Name = "btn_part";
            this.btn_part.Size = new System.Drawing.Size(151, 59);
            this.btn_part.TabIndex = 3;
            this.btn_part.Text = "Parts";
            this.btn_part.UseVisualStyleBackColor = false;
            this.btn_part.Click += new System.EventHandler(this.btn_part_Click);
            // 
            // btn_machine
            // 
            this.btn_machine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_machine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_machine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_machine.Location = new System.Drawing.Point(24, 295);
            this.btn_machine.Margin = new System.Windows.Forms.Padding(4);
            this.btn_machine.Name = "btn_machine";
            this.btn_machine.Size = new System.Drawing.Size(151, 59);
            this.btn_machine.TabIndex = 4;
            this.btn_machine.Text = "Machines";
            this.btn_machine.UseVisualStyleBackColor = false;
            this.btn_machine.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 5;
            // 
            // btn_parameter
            // 
            this.btn_parameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_parameter.Location = new System.Drawing.Point(24, 109);
            this.btn_parameter.Name = "btn_parameter";
            this.btn_parameter.Size = new System.Drawing.Size(111, 36);
            this.btn_parameter.TabIndex = 6;
            this.btn_parameter.Text = "Search";
            this.btn_parameter.UseVisualStyleBackColor = false;
            this.btn_parameter.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_service
            // 
            this.btn_service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_service.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_service.Location = new System.Drawing.Point(24, 409);
            this.btn_service.Margin = new System.Windows.Forms.Padding(4);
            this.btn_service.Name = "btn_service";
            this.btn_service.Size = new System.Drawing.Size(151, 59);
            this.btn_service.TabIndex = 7;
            this.btn_service.Text = "Service ";
            this.btn_service.UseVisualStyleBackColor = false;
            this.btn_service.Click += new System.EventHandler(this.btn_service_Click);
            // 
            // btn_repaire
            // 
            this.btn_repaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_repaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repaire.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_repaire.Location = new System.Drawing.Point(24, 466);
            this.btn_repaire.Margin = new System.Windows.Forms.Padding(4);
            this.btn_repaire.Name = "btn_repaire";
            this.btn_repaire.Size = new System.Drawing.Size(151, 59);
            this.btn_repaire.TabIndex = 8;
            this.btn_repaire.Text = "Repaire";
            this.btn_repaire.UseVisualStyleBackColor = false;
            this.btn_repaire.Click += new System.EventHandler(this.btn_repaire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "PartID";
            // 
            // crystal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 553);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_repaire);
            this.Controls.Add(this.btn_parameter);
            this.Controls.Add(this.btn_service);
            this.Controls.Add(this.btn_machine);
            this.Controls.Add(this.btn_part);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "crystal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crystal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        public System.Windows.Forms.Button btn_part;
        public System.Windows.Forms.Button btn_machine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_parameter;
        public System.Windows.Forms.Button btn_service;
        public System.Windows.Forms.Button btn_repaire;
        private System.Windows.Forms.Label label1;
    }
}