namespace WindowsFormsApplication2
{
    partial class cal_productDetails
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
            this.cal_month_com = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cal_add_button = new System.Windows.Forms.Button();
            this.rejected_sum_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unitPrice_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back_cal_button = new System.Windows.Forms.Button();
            this.name_com = new System.Windows.Forms.ComboBox();
            this.dataGridcal = new System.Windows.Forms.DataGridView();
            this.tableName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product_profit = new System.Windows.Forms.Label();
            this.add_sales_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcal)).BeginInit();
            this.SuspendLayout();
            // 
            // cal_month_com
            // 
            this.cal_month_com.FormattingEnabled = true;
            this.cal_month_com.Items.AddRange(new object[] {
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
            "12"});
            this.cal_month_com.Location = new System.Drawing.Point(116, 149);
            this.cal_month_com.Name = "cal_month_com";
            this.cal_month_com.Size = new System.Drawing.Size(137, 21);
            this.cal_month_com.TabIndex = 24;
            this.cal_month_com.SelectedIndexChanged += new System.EventHandler(this.cal_month_com_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Month :";
            // 
            // cal_add_button
            // 
            this.cal_add_button.Location = new System.Drawing.Point(204, 510);
            this.cal_add_button.Name = "cal_add_button";
            this.cal_add_button.Size = new System.Drawing.Size(75, 23);
            this.cal_add_button.TabIndex = 22;
            this.cal_add_button.Text = "Add";
            this.cal_add_button.UseVisualStyleBackColor = true;
            this.cal_add_button.Click += new System.EventHandler(this.cal_add_button_Click);
            // 
            // rejected_sum_label
            // 
            this.rejected_sum_label.AutoSize = true;
            this.rejected_sum_label.Location = new System.Drawing.Point(194, 266);
            this.rejected_sum_label.Name = "rejected_sum_label";
            this.rejected_sum_label.Size = new System.Drawing.Size(13, 13);
            this.rejected_sum_label.TabIndex = 21;
            this.rejected_sum_label.Text = "0";
            this.rejected_sum_label.Click += new System.EventHandler(this.rejected_sum_label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Total Unit prices of Rejected Items: ";
            // 
            // unitPrice_label
            // 
            this.unitPrice_label.AutoSize = true;
            this.unitPrice_label.Location = new System.Drawing.Point(170, 239);
            this.unitPrice_label.Name = "unitPrice_label";
            this.unitPrice_label.Size = new System.Drawing.Size(13, 13);
            this.unitPrice_label.TabIndex = 19;
            this.unitPrice_label.Text = "0";
            this.unitPrice_label.Click += new System.EventHandler(this.unitPrice_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total Unit prices  of  products: ";
            // 
            // back_cal_button
            // 
            this.back_cal_button.Location = new System.Drawing.Point(204, 448);
            this.back_cal_button.Name = "back_cal_button";
            this.back_cal_button.Size = new System.Drawing.Size(75, 23);
            this.back_cal_button.TabIndex = 17;
            this.back_cal_button.Text = "Back";
            this.back_cal_button.UseVisualStyleBackColor = true;
            this.back_cal_button.Click += new System.EventHandler(this.back_cal_button_Click);
            // 
            // name_com
            // 
            this.name_com.FormattingEnabled = true;
            this.name_com.Items.AddRange(new object[] {
            "Product Details",
            "Rejected Items"});
            this.name_com.Location = new System.Drawing.Point(116, 187);
            this.name_com.Name = "name_com";
            this.name_com.Size = new System.Drawing.Size(137, 21);
            this.name_com.TabIndex = 16;
            this.name_com.SelectedIndexChanged += new System.EventHandler(this.name_com_SelectedIndexChanged);
            // 
            // dataGridcal
            // 
            this.dataGridcal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcal.Location = new System.Drawing.Point(357, 149);
            this.dataGridcal.Name = "dataGridcal";
            this.dataGridcal.Size = new System.Drawing.Size(427, 347);
            this.dataGridcal.TabIndex = 15;
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tableName.Location = new System.Drawing.Point(12, 188);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(98, 20);
            this.tableName.TabIndex = 14;
            this.tableName.Text = "Table Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total profits of product Items:";
            // 
            // product_profit
            // 
            this.product_profit.AutoSize = true;
            this.product_profit.Location = new System.Drawing.Point(162, 292);
            this.product_profit.Name = "product_profit";
            this.product_profit.Size = new System.Drawing.Size(13, 13);
            this.product_profit.TabIndex = 29;
            this.product_profit.Text = "0";
            this.product_profit.Click += new System.EventHandler(this.product_profit_Click);
            // 
            // add_sales_button
            // 
            this.add_sales_button.Location = new System.Drawing.Point(22, 510);
            this.add_sales_button.Name = "add_sales_button";
            this.add_sales_button.Size = new System.Drawing.Size(116, 23);
            this.add_sales_button.TabIndex = 30;
            this.add_sales_button.Text = "Add Rejected Sales";
            this.add_sales_button.UseVisualStyleBackColor = true;
            this.add_sales_button.Click += new System.EventHandler(this.add_sales_button_Click);
            // 
            // cal_productDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1069, 616);
            this.Controls.Add(this.add_sales_button);
            this.Controls.Add(this.product_profit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cal_month_com);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cal_add_button);
            this.Controls.Add(this.rejected_sum_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitPrice_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_cal_button);
            this.Controls.Add(this.name_com);
            this.Controls.Add(this.dataGridcal);
            this.Controls.Add(this.tableName);
            this.Name = "cal_productDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cal_productDetails";
            this.Load += new System.EventHandler(this.cal_productDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cal_month_com;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button cal_add_button;
        private System.Windows.Forms.Label rejected_sum_label;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label unitPrice_label;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button back_cal_button;
        public System.Windows.Forms.ComboBox name_com;
        private System.Windows.Forms.Label tableName;
        public System.Windows.Forms.DataGridView dataGridcal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label product_profit;
        public System.Windows.Forms.Button add_sales_button;
    }
}