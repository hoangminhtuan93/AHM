namespace AnhHuyMobile
{
    partial class frmRevenue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Sum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DAT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_CUS_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Sum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_to);
            this.groupBox1.Controls.Add(this.dtp_from);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu";
            // 
            // lbl_Sum
            // 
            this.lbl_Sum.AutoSize = true;
            this.lbl_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sum.Location = new System.Drawing.Point(412, 52);
            this.lbl_Sum.Name = "lbl_Sum";
            this.lbl_Sum.Size = new System.Drawing.Size(0, 20);
            this.lbl_Sum.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tổng doanh thu:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DAT_DATE,
            this.CHR_NAME,
            this.CHR_MONEY,
            this.CHR_CUSTOMER,
            this.CHR_CUS_PHONE,
            this.CHR_TYPE});
            this.dataGridView1.Location = new System.Drawing.Point(4, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 419);
            this.dataGridView1.TabIndex = 4;
            // 
            // DAT_DATE
            // 
            this.DAT_DATE.DataPropertyName = "DAT_DATE";
            this.DAT_DATE.HeaderText = "Ngày";
            this.DAT_DATE.Name = "DAT_DATE";
            this.DAT_DATE.Width = 57;
            // 
            // CHR_NAME
            // 
            this.CHR_NAME.DataPropertyName = "CHR_NAME";
            this.CHR_NAME.HeaderText = "Tên hàng (dịch vụ)";
            this.CHR_NAME.Name = "CHR_NAME";
            this.CHR_NAME.Width = 98;
            // 
            // CHR_MONEY
            // 
            this.CHR_MONEY.DataPropertyName = "CHR_MONEY";
            dataGridViewCellStyle1.Format = "C0";
            this.CHR_MONEY.DefaultCellStyle = dataGridViewCellStyle1;
            this.CHR_MONEY.HeaderText = "Giá tiền";
            this.CHR_MONEY.Name = "CHR_MONEY";
            this.CHR_MONEY.Width = 63;
            // 
            // CHR_CUSTOMER
            // 
            this.CHR_CUSTOMER.DataPropertyName = "CHR_CUSTOMER";
            this.CHR_CUSTOMER.HeaderText = "Khách hàng";
            this.CHR_CUSTOMER.Name = "CHR_CUSTOMER";
            this.CHR_CUSTOMER.Width = 83;
            // 
            // CHR_CUS_PHONE
            // 
            this.CHR_CUS_PHONE.DataPropertyName = "CHR_CUS_PHONE";
            this.CHR_CUS_PHONE.HeaderText = "SĐT";
            this.CHR_CUS_PHONE.Name = "CHR_CUS_PHONE";
            this.CHR_CUS_PHONE.Width = 54;
            // 
            // CHR_TYPE
            // 
            this.CHR_TYPE.DataPropertyName = "CHR_TYPE";
            this.CHR_TYPE.HeaderText = "Loại hàng";
            this.CHR_TYPE.Name = "CHR_TYPE";
            this.CHR_TYPE.Width = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ ngày:";
            // 
            // dtp_to
            // 
            this.dtp_to.CustomFormat = "dd/MM/yyyy";
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to.Location = new System.Drawing.Point(111, 72);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(112, 20);
            this.dtp_to.TabIndex = 1;
            this.dtp_to.ValueChanged += new System.EventHandler(this.dtp_to_ValueChanged);
            // 
            // dtp_from
            // 
            this.dtp_from.CustomFormat = "dd/MM/yyyy";
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_from.Location = new System.Drawing.Point(111, 33);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(112, 20);
            this.dtp_from.TabIndex = 0;
            this.dtp_from.ValueChanged += new System.EventHandler(this.dtp_from_ValueChanged);
            // 
            // frmRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 533);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRevenue";
            this.Text = "frmRevenue";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Sum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAT_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_MONEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_CUS_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_TYPE;
    }
}