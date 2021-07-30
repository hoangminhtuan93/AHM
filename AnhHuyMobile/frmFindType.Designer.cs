namespace AnhHuyMobile
{
    partial class frmFindType
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
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DAT_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_MONEY_IN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_CUS_PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_USER_UPDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTM_UPDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cbo_type
            // 
            this.cbo_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_type.DisplayMember = "CHR_TYPE";
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(124, 28);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(397, 21);
            this.cbo_type.TabIndex = 2;
            this.cbo_type.ValueMember = "ID";
            this.cbo_type.SelectedIndexChanged += new System.EventHandler(this.cbo_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại mặt hàng:";
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
            this.CHR_TYPE,
            this.CHR_NAME,
            this.CHR_MONEY,
            this.CHR_MONEY_IN,
            this.CHR_CUSTOMER,
            this.CHR_CUS_PHONE,
            this.CHR_USER_UPDATE,
            this.DTM_UPDATE});
            this.dataGridView1.Location = new System.Drawing.Point(6, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // DAT_DATE
            // 
            this.DAT_DATE.DataPropertyName = "DAT_DATE";
            this.DAT_DATE.HeaderText = "Ngày bán";
            this.DAT_DATE.Name = "DAT_DATE";
            this.DAT_DATE.Width = 72;
            // 
            // CHR_TYPE
            // 
            this.CHR_TYPE.DataPropertyName = "CHR_TYPE";
            this.CHR_TYPE.HeaderText = "Loại mặt hàng";
            this.CHR_TYPE.Name = "CHR_TYPE";
            this.CHR_TYPE.Width = 91;
            // 
            // CHR_NAME
            // 
            this.CHR_NAME.DataPropertyName = "CHR_NAME";
            this.CHR_NAME.HeaderText = "Tên mặt hàng";
            this.CHR_NAME.Name = "CHR_NAME";
            this.CHR_NAME.Width = 90;
            // 
            // CHR_MONEY
            // 
            this.CHR_MONEY.DataPropertyName = "CHR_MONEY";
            this.CHR_MONEY.HeaderText = "Giá bán";
            this.CHR_MONEY.Name = "CHR_MONEY";
            this.CHR_MONEY.Width = 64;
            // 
            // CHR_MONEY_IN
            // 
            this.CHR_MONEY_IN.DataPropertyName = "CHR_MONEY_IN";
            this.CHR_MONEY_IN.HeaderText = "Giá nhập hàng";
            this.CHR_MONEY_IN.Name = "CHR_MONEY_IN";
            this.CHR_MONEY_IN.Width = 94;
            // 
            // CHR_CUSTOMER
            // 
            this.CHR_CUSTOMER.DataPropertyName = "CHR_CUSTOMER";
            this.CHR_CUSTOMER.HeaderText = "Tên khách hàng";
            this.CHR_CUSTOMER.Name = "CHR_CUSTOMER";
            this.CHR_CUSTOMER.Width = 102;
            // 
            // CHR_CUS_PHONE
            // 
            this.CHR_CUS_PHONE.DataPropertyName = "CHR_CUS_PHONE";
            this.CHR_CUS_PHONE.HeaderText = "SĐT";
            this.CHR_CUS_PHONE.Name = "CHR_CUS_PHONE";
            this.CHR_CUS_PHONE.Width = 54;
            // 
            // CHR_USER_UPDATE
            // 
            this.CHR_USER_UPDATE.DataPropertyName = "CHR_USER_UPDATE";
            this.CHR_USER_UPDATE.HeaderText = "Người nhập";
            this.CHR_USER_UPDATE.Name = "CHR_USER_UPDATE";
            this.CHR_USER_UPDATE.Width = 80;
            // 
            // DTM_UPDATE
            // 
            this.DTM_UPDATE.DataPropertyName = "DTM_UPDATE";
            this.DTM_UPDATE.HeaderText = "Thời gian nhập";
            this.DTM_UPDATE.Name = "DTM_UPDATE";
            this.DTM_UPDATE.Width = 95;
            // 
            // frmFindType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFindType";
            this.Text = "frmFindType";
            this.Load += new System.EventHandler(this.frmFindType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAT_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_MONEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_MONEY_IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_CUS_PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_USER_UPDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTM_UPDATE;
    }
}