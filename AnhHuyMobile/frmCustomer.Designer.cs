namespace AnhHuyMobile
{
    partial class frmCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CHR_CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_CUS_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INT_GOOD_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txt_find);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHR_CUSTOMER,
            this.CHR_CUS_PHONE,
            this.DAT_DATE,
            this.CHR_TYPE,
            this.CHR_NAME,
            this.INT_GOOD_QTY,
            this.CHR_MONEY});
            this.dataGridView1.Location = new System.Drawing.Point(6, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 361);
            this.dataGridView1.TabIndex = 16;
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(126, 30);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(166, 20);
            this.txt_find.TabIndex = 15;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên hoặc SĐT:";
            // 
            // CHR_CUSTOMER
            // 
            this.CHR_CUSTOMER.DataPropertyName = "CHR_CUSTOMER";
            this.CHR_CUSTOMER.HeaderText = "Tên khách hàng";
            this.CHR_CUSTOMER.Name = "CHR_CUSTOMER";
            // 
            // CHR_CUS_PHONE
            // 
            this.CHR_CUS_PHONE.DataPropertyName = "CHR_CUS_PHONE";
            this.CHR_CUS_PHONE.HeaderText = "SĐT";
            this.CHR_CUS_PHONE.Name = "CHR_CUS_PHONE";
            // 
            // DAT_DATE
            // 
            this.DAT_DATE.DataPropertyName = "DAT_DATE";
            this.DAT_DATE.HeaderText = "Ngày";
            this.DAT_DATE.Name = "DAT_DATE";
            // 
            // CHR_TYPE
            // 
            this.CHR_TYPE.DataPropertyName = "CHR_TYPE";
            this.CHR_TYPE.HeaderText = "Loại hàng";
            this.CHR_TYPE.Name = "CHR_TYPE";
            // 
            // CHR_NAME
            // 
            this.CHR_NAME.DataPropertyName = "CHR_NAME";
            this.CHR_NAME.HeaderText = "Tên hàng";
            this.CHR_NAME.Name = "CHR_NAME";
            // 
            // INT_GOOD_QTY
            // 
            this.INT_GOOD_QTY.DataPropertyName = "INT_GOOD_QTY";
            this.INT_GOOD_QTY.HeaderText = "Số lượng";
            this.INT_GOOD_QTY.Name = "INT_GOOD_QTY";
            // 
            // CHR_MONEY
            // 
            this.CHR_MONEY.DataPropertyName = "CHR_MONEY";
            this.CHR_MONEY.HeaderText = "Giá tiền";
            this.CHR_MONEY.Name = "CHR_MONEY";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 435);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_CUS_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAT_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn INT_GOOD_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_MONEY;
    }
}