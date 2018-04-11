namespace WindowsFormsApplication2
{
    partial class p_process
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
            this.pp_proid = new System.Windows.Forms.TextBox();
            this.pp_in = new System.Windows.Forms.TextBox();
            this.pp_out = new System.Windows.Forms.TextBox();
            this.pp_pendquntity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ppro_id_label = new System.Windows.Forms.Label();
            this.pp_sectionid_label = new System.Windows.Forms.Label();
            this.pp_inpro_label = new System.Windows.Forms.Label();
            this.pp_outpro_label = new System.Windows.Forms.Label();
            this.pp_pendquantity_label = new System.Windows.Forms.Label();
            this.pp_quality_label = new System.Windows.Forms.Label();
            this.pp_update = new System.Windows.Forms.Button();
            this.pp_quality_com = new System.Windows.Forms.ComboBox();
            this.pp_demo_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.details_secID_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pp_proid
            // 
            this.pp_proid.Location = new System.Drawing.Point(421, 164);
            this.pp_proid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pp_proid.Name = "pp_proid";
            this.pp_proid.Size = new System.Drawing.Size(192, 22);
            this.pp_proid.TabIndex = 6;
            this.pp_proid.TextChanged += new System.EventHandler(this.pp_proid_TextChanged);
            // 
            // pp_in
            // 
            this.pp_in.Location = new System.Drawing.Point(425, 319);
            this.pp_in.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pp_in.Name = "pp_in";
            this.pp_in.Size = new System.Drawing.Size(192, 22);
            this.pp_in.TabIndex = 8;
            this.pp_in.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.pp_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pp_in_KeyPress);
            // 
            // pp_out
            // 
            this.pp_out.Location = new System.Drawing.Point(425, 383);
            this.pp_out.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pp_out.Name = "pp_out";
            this.pp_out.Size = new System.Drawing.Size(192, 22);
            this.pp_out.TabIndex = 9;
            this.pp_out.TextChanged += new System.EventHandler(this.pp_out_TextChanged);
            this.pp_out.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pp_out_KeyPress);
            // 
            // pp_pendquntity
            // 
            this.pp_pendquntity.Location = new System.Drawing.Point(425, 443);
            this.pp_pendquntity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pp_pendquntity.Name = "pp_pendquntity";
            this.pp_pendquntity.Size = new System.Drawing.Size(192, 22);
            this.pp_pendquntity.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(233, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Process ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(233, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Section ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(233, 316);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "In :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(233, 380);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Out :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(233, 439);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pending Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(233, 509);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quality Status:";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(911, 710);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(100, 41);
            this.add_button.TabIndex = 18;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Highlight;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(1147, 13);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(92, 48);
            this.back.TabIndex = 19;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(1019, 710);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 41);
            this.clear.TabIndex = 20;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 21;
            // 
            // ppro_id_label
            // 
            this.ppro_id_label.AutoSize = true;
            this.ppro_id_label.ForeColor = System.Drawing.Color.Red;
            this.ppro_id_label.Location = new System.Drawing.Point(449, 227);
            this.ppro_id_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ppro_id_label.Name = "ppro_id_label";
            this.ppro_id_label.Size = new System.Drawing.Size(134, 17);
            this.ppro_id_label.TabIndex = 22;
            this.ppro_id_label.Text = "Enter the ProcessID";
            this.ppro_id_label.Click += new System.EventHandler(this.ppro_id_label_Click);
            // 
            // pp_sectionid_label
            // 
            this.pp_sectionid_label.AutoSize = true;
            this.pp_sectionid_label.ForeColor = System.Drawing.Color.Red;
            this.pp_sectionid_label.Location = new System.Drawing.Point(444, 280);
            this.pp_sectionid_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pp_sectionid_label.Name = "pp_sectionid_label";
            this.pp_sectionid_label.Size = new System.Drawing.Size(137, 17);
            this.pp_sectionid_label.TabIndex = 23;
            this.pp_sectionid_label.Text = "Select the section ID";
            // 
            // pp_inpro_label
            // 
            this.pp_inpro_label.AutoSize = true;
            this.pp_inpro_label.ForeColor = System.Drawing.Color.Red;
            this.pp_inpro_label.Location = new System.Drawing.Point(448, 348);
            this.pp_inpro_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pp_inpro_label.Name = "pp_inpro_label";
            this.pp_inpro_label.Size = new System.Drawing.Size(128, 17);
            this.pp_inpro_label.TabIndex = 24;
            this.pp_inpro_label.Text = "Enter input amount";
            this.pp_inpro_label.Click += new System.EventHandler(this.pp_inpro_label_Click);
            // 
            // pp_outpro_label
            // 
            this.pp_outpro_label.AutoSize = true;
            this.pp_outpro_label.ForeColor = System.Drawing.Color.Red;
            this.pp_outpro_label.Location = new System.Drawing.Point(448, 412);
            this.pp_outpro_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pp_outpro_label.Name = "pp_outpro_label";
            this.pp_outpro_label.Size = new System.Drawing.Size(137, 17);
            this.pp_outpro_label.TabIndex = 25;
            this.pp_outpro_label.Text = "Enter output amount";
            this.pp_outpro_label.Click += new System.EventHandler(this.label10_Click);
            // 
            // pp_pendquantity_label
            // 
            this.pp_pendquantity_label.AutoSize = true;
            this.pp_pendquantity_label.ForeColor = System.Drawing.Color.Red;
            this.pp_pendquantity_label.Location = new System.Drawing.Point(421, 471);
            this.pp_pendquantity_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pp_pendquantity_label.Name = "pp_pendquantity_label";
            this.pp_pendquantity_label.Size = new System.Drawing.Size(194, 17);
            this.pp_pendquantity_label.TabIndex = 26;
            this.pp_pendquantity_label.Text = "Enter pending qantity amount";
            // 
            // pp_quality_label
            // 
            this.pp_quality_label.AutoSize = true;
            this.pp_quality_label.ForeColor = System.Drawing.Color.Red;
            this.pp_quality_label.Location = new System.Drawing.Point(449, 542);
            this.pp_quality_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pp_quality_label.Name = "pp_quality_label";
            this.pp_quality_label.Size = new System.Drawing.Size(134, 17);
            this.pp_quality_label.TabIndex = 27;
            this.pp_quality_label.Text = "Select quality status";
            this.pp_quality_label.Click += new System.EventHandler(this.label12_Click);
            // 
            // pp_update
            // 
            this.pp_update.BackColor = System.Drawing.SystemColors.Highlight;
            this.pp_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pp_update.ForeColor = System.Drawing.Color.White;
            this.pp_update.Location = new System.Drawing.Point(1127, 710);
            this.pp_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pp_update.Name = "pp_update";
            this.pp_update.Size = new System.Drawing.Size(100, 41);
            this.pp_update.TabIndex = 28;
            this.pp_update.Text = "Update";
            this.pp_update.UseVisualStyleBackColor = false;
            this.pp_update.Click += new System.EventHandler(this.pp_update_Click);
            // 
            // pp_quality_com
            // 
            this.pp_quality_com.FormattingEnabled = true;
            this.pp_quality_com.Items.AddRange(new object[] {
            "Grade A",
            "Grade B",
            "Grade C",
            "Grade D",
            "Grade E"});
            this.pp_quality_com.Location = new System.Drawing.Point(425, 513);
            this.pp_quality_com.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pp_quality_com.Name = "pp_quality_com";
            this.pp_quality_com.Size = new System.Drawing.Size(192, 24);
            this.pp_quality_com.TabIndex = 11;
            this.pp_quality_com.SelectedIndexChanged += new System.EventHandler(this.pp_quality_com_SelectedIndexChanged);
            // 
            // pp_demo_button
            // 
            this.pp_demo_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.pp_demo_button.Location = new System.Drawing.Point(1147, 633);
            this.pp_demo_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pp_demo_button.Name = "pp_demo_button";
            this.pp_demo_button.Size = new System.Drawing.Size(100, 28);
            this.pp_demo_button.TabIndex = 30;
            this.pp_demo_button.Text = "Demo";
            this.pp_demo_button.UseVisualStyleBackColor = false;
            this.pp_demo_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(233, 607);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Allocation:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 612);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "label9";
            // 
            // details_secID_txt
            // 
            this.details_secID_txt.Location = new System.Drawing.Point(425, 252);
            this.details_secID_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.details_secID_txt.Name = "details_secID_txt";
            this.details_secID_txt.Size = new System.Drawing.Size(188, 22);
            this.details_secID_txt.TabIndex = 33;
            this.details_secID_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // p_process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1447, 806);
            this.Controls.Add(this.details_secID_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pp_demo_button);
            this.Controls.Add(this.pp_update);
            this.Controls.Add(this.pp_quality_label);
            this.Controls.Add(this.pp_pendquantity_label);
            this.Controls.Add(this.pp_outpro_label);
            this.Controls.Add(this.pp_inpro_label);
            this.Controls.Add(this.pp_sectionid_label);
            this.Controls.Add(this.ppro_id_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.back);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pp_quality_com);
            this.Controls.Add(this.pp_pendquntity);
            this.Controls.Add(this.pp_out);
            this.Controls.Add(this.pp_in);
            this.Controls.Add(this.pp_proid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "p_process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.p_process_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ppro_id_label;
        private System.Windows.Forms.Label pp_sectionid_label;
        private System.Windows.Forms.Label pp_inpro_label;
        private System.Windows.Forms.Label pp_outpro_label;
        private System.Windows.Forms.Label pp_pendquantity_label;
        private System.Windows.Forms.Label pp_quality_label;
        public System.Windows.Forms.Button add_button;
        public System.Windows.Forms.TextBox pp_proid;
        public System.Windows.Forms.TextBox pp_in;
        public System.Windows.Forms.TextBox pp_out;
        public System.Windows.Forms.TextBox pp_pendquntity;
        private System.Windows.Forms.Button pp_update;
        public System.Windows.Forms.ComboBox pp_quality_com;
        private System.Windows.Forms.Button pp_demo_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox details_secID_txt;
    }
}