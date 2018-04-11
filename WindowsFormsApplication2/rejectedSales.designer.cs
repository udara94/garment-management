namespace WindowsFormsApplication2
{
    partial class rejectedSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.R_sales_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.R_sales_allocation = new System.Windows.Forms.Label();
            this.R_sales_unitPrice = new System.Windows.Forms.Label();
            this.R_sales_quality = new System.Windows.Forms.Label();
            this.R_sales_reason = new System.Windows.Forms.RichTextBox();
            this.R_sales_date = new System.Windows.Forms.Label();
            this.R_sales_month = new System.Windows.Forms.Label();
            this.addRejectSales_button = new System.Windows.Forms.Button();
            this.r_sales_bakButton = new System.Windows.Forms.Button();
            this.dataGridViewR = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.search_sales_reject = new System.Windows.Forms.TextBox();
            this.R_sales_cat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(102, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(102, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(102, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Allocation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(102, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(102, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reason";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(102, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quality";
            // 
            // R_sales_id
            // 
            this.R_sales_id.Location = new System.Drawing.Point(228, 177);
            this.R_sales_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R_sales_id.Name = "R_sales_id";
            this.R_sales_id.Size = new System.Drawing.Size(171, 22);
            this.R_sales_id.TabIndex = 6;
            this.R_sales_id.TextChanged += new System.EventHandler(this.R_sales_id_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(102, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(102, 574);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Month";
            // 
            // R_sales_allocation
            // 
            this.R_sales_allocation.AutoSize = true;
            this.R_sales_allocation.Location = new System.Drawing.Point(226, 274);
            this.R_sales_allocation.Name = "R_sales_allocation";
            this.R_sales_allocation.Size = new System.Drawing.Size(54, 17);
            this.R_sales_allocation.TabIndex = 10;
            this.R_sales_allocation.Text = "label10";
            // 
            // R_sales_unitPrice
            // 
            this.R_sales_unitPrice.AutoSize = true;
            this.R_sales_unitPrice.Location = new System.Drawing.Point(226, 328);
            this.R_sales_unitPrice.Name = "R_sales_unitPrice";
            this.R_sales_unitPrice.Size = new System.Drawing.Size(54, 17);
            this.R_sales_unitPrice.TabIndex = 11;
            this.R_sales_unitPrice.Text = "label11";
            // 
            // R_sales_quality
            // 
            this.R_sales_quality.AutoSize = true;
            this.R_sales_quality.Location = new System.Drawing.Point(226, 365);
            this.R_sales_quality.Name = "R_sales_quality";
            this.R_sales_quality.Size = new System.Drawing.Size(54, 17);
            this.R_sales_quality.TabIndex = 12;
            this.R_sales_quality.Text = "label12";
            // 
            // R_sales_reason
            // 
            this.R_sales_reason.Location = new System.Drawing.Point(228, 408);
            this.R_sales_reason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.R_sales_reason.Name = "R_sales_reason";
            this.R_sales_reason.Size = new System.Drawing.Size(199, 90);
            this.R_sales_reason.TabIndex = 13;
            this.R_sales_reason.Text = "";
            this.R_sales_reason.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // R_sales_date
            // 
            this.R_sales_date.AutoSize = true;
            this.R_sales_date.Location = new System.Drawing.Point(226, 522);
            this.R_sales_date.Name = "R_sales_date";
            this.R_sales_date.Size = new System.Drawing.Size(54, 17);
            this.R_sales_date.TabIndex = 14;
            this.R_sales_date.Text = "label13";
            // 
            // R_sales_month
            // 
            this.R_sales_month.AutoSize = true;
            this.R_sales_month.Location = new System.Drawing.Point(226, 581);
            this.R_sales_month.Name = "R_sales_month";
            this.R_sales_month.Size = new System.Drawing.Size(54, 17);
            this.R_sales_month.TabIndex = 15;
            this.R_sales_month.Text = "label14";
            // 
            // addRejectSales_button
            // 
            this.addRejectSales_button.Location = new System.Drawing.Point(1107, 722);
            this.addRejectSales_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRejectSales_button.Name = "addRejectSales_button";
            this.addRejectSales_button.Size = new System.Drawing.Size(99, 30);
            this.addRejectSales_button.TabIndex = 16;
            this.addRejectSales_button.Text = "Add";
            this.addRejectSales_button.UseVisualStyleBackColor = true;
            this.addRejectSales_button.Click += new System.EventHandler(this.addRejectSales_button_Click);
            // 
            // r_sales_bakButton
            // 
            this.r_sales_bakButton.Location = new System.Drawing.Point(1094, 130);
            this.r_sales_bakButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.r_sales_bakButton.Name = "r_sales_bakButton";
            this.r_sales_bakButton.Size = new System.Drawing.Size(99, 30);
            this.r_sales_bakButton.TabIndex = 17;
            this.r_sales_bakButton.Text = "Back";
            this.r_sales_bakButton.UseVisualStyleBackColor = true;
            this.r_sales_bakButton.Click += new System.EventHandler(this.r_sales_bakButton_Click);
            // 
            // dataGridViewR
            // 
            this.dataGridViewR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewR.Location = new System.Drawing.Point(532, 180);
            this.dataGridViewR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewR.Name = "dataGridViewR";
            this.dataGridViewR.Size = new System.Drawing.Size(708, 446);
            this.dataGridViewR.TabIndex = 18;
            this.dataGridViewR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewR_CellContentClick);
            this.dataGridViewR.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewR_RowHeaderMouseClick_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(829, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Search :";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // search_sales_reject
            // 
            this.search_sales_reject.Location = new System.Drawing.Point(919, 130);
            this.search_sales_reject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_sales_reject.Name = "search_sales_reject";
            this.search_sales_reject.Size = new System.Drawing.Size(132, 22);
            this.search_sales_reject.TabIndex = 34;
            this.search_sales_reject.TextChanged += new System.EventHandler(this.search_sales_reject_TextChanged);
            // 
            // R_sales_cat
            // 
            this.R_sales_cat.AutoSize = true;
            this.R_sales_cat.Location = new System.Drawing.Point(226, 226);
            this.R_sales_cat.Name = "R_sales_cat";
            this.R_sales_cat.Size = new System.Drawing.Size(54, 17);
            this.R_sales_cat.TabIndex = 36;
            this.R_sales_cat.Text = "label10";
            this.R_sales_cat.Click += new System.EventHandler(this.label10_Click);
            // 
            // rejectedSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(202)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1447, 806);
            this.Controls.Add(this.R_sales_cat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.search_sales_reject);
            this.Controls.Add(this.dataGridViewR);
            this.Controls.Add(this.r_sales_bakButton);
            this.Controls.Add(this.addRejectSales_button);
            this.Controls.Add(this.R_sales_month);
            this.Controls.Add(this.R_sales_date);
            this.Controls.Add(this.R_sales_reason);
            this.Controls.Add(this.R_sales_quality);
            this.Controls.Add(this.R_sales_unitPrice);
            this.Controls.Add(this.R_sales_allocation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.R_sales_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "rejectedSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rejectedSales";
            this.Load += new System.EventHandler(this.rejectedSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewR)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox R_sales_id;
        public System.Windows.Forms.Label R_sales_allocation;
        public System.Windows.Forms.Label R_sales_unitPrice;
        public System.Windows.Forms.Label R_sales_quality;
        public System.Windows.Forms.RichTextBox R_sales_reason;
        public System.Windows.Forms.Label R_sales_date;
        public System.Windows.Forms.Label R_sales_month;
        public System.Windows.Forms.Button addRejectSales_button;
        public System.Windows.Forms.Button r_sales_bakButton;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox search_sales_reject;
        public System.Windows.Forms.DataGridView dataGridViewR;
        private System.Windows.Forms.Label R_sales_cat;
    }
}