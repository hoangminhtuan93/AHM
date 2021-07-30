namespace AnhHuyMobile
{
    partial class frmGoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_money_in = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHR_GOODS_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INT_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INT_GOOD_QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MN_PRICE_IN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MN_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_qty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.num_money = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name_goods = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_money_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_money)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_money_in);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.num_qty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.num_money);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_name_goods);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_type);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 587);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập kho";
            // 
            // num_money_in
            // 
            this.num_money_in.Location = new System.Drawing.Point(156, 66);
            this.num_money_in.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_money_in.Name = "num_money_in";
            this.num_money_in.Size = new System.Drawing.Size(166, 20);
            this.num_money_in.TabIndex = 24;
            this.num_money_in.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Giá nhập (nghìn đồng):";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(11, 190);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 13);
            this.lbl_ID.TabIndex = 22;
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
            this.ID,
            this.ID_TYPE,
            this.CHR_TYPE,
            this.CHR_GOODS_NAME,
            this.INT_QTY,
            this.INT_GOOD_QTY,
            this.Avai,
            this.MN_PRICE_IN,
            this.MN_PRICE});
            this.dataGridView1.Location = new System.Drawing.Point(6, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(852, 405);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ID_TYPE
            // 
            this.ID_TYPE.DataPropertyName = "ID_TYPE";
            this.ID_TYPE.HeaderText = "ID_TYPE";
            this.ID_TYPE.Name = "ID_TYPE";
            this.ID_TYPE.ReadOnly = true;
            this.ID_TYPE.Visible = false;
            // 
            // CHR_TYPE
            // 
            this.CHR_TYPE.DataPropertyName = "CHR_TYPE";
            this.CHR_TYPE.HeaderText = "Loại hàng";
            this.CHR_TYPE.Name = "CHR_TYPE";
            this.CHR_TYPE.ReadOnly = true;
            this.CHR_TYPE.Width = 73;
            // 
            // CHR_GOODS_NAME
            // 
            this.CHR_GOODS_NAME.DataPropertyName = "CHR_GOODS_NAME";
            this.CHR_GOODS_NAME.HeaderText = "Mặt hàng";
            this.CHR_GOODS_NAME.Name = "CHR_GOODS_NAME";
            this.CHR_GOODS_NAME.ReadOnly = true;
            this.CHR_GOODS_NAME.Width = 71;
            // 
            // INT_QTY
            // 
            this.INT_QTY.DataPropertyName = "INT_QTY";
            this.INT_QTY.HeaderText = "Số lượng nhập kho";
            this.INT_QTY.Name = "INT_QTY";
            this.INT_QTY.ReadOnly = true;
            this.INT_QTY.Width = 96;
            // 
            // INT_GOOD_QTY
            // 
            this.INT_GOOD_QTY.DataPropertyName = "INT_GOOD_QTY";
            this.INT_GOOD_QTY.HeaderText = "Số lượng đã bán";
            this.INT_GOOD_QTY.Name = "INT_GOOD_QTY";
            this.INT_GOOD_QTY.ReadOnly = true;
            this.INT_GOOD_QTY.Width = 86;
            // 
            // Avai
            // 
            this.Avai.DataPropertyName = "Avai";
            this.Avai.HeaderText = "Số lượng còn lại";
            this.Avai.Name = "Avai";
            this.Avai.ReadOnly = true;
            this.Avai.Width = 90;
            // 
            // MN_PRICE_IN
            // 
            this.MN_PRICE_IN.DataPropertyName = "MN_PRICE_IN";
            dataGridViewCellStyle1.Format = "C0";
            this.MN_PRICE_IN.DefaultCellStyle = dataGridViewCellStyle1;
            this.MN_PRICE_IN.HeaderText = "Giá nhập";
            this.MN_PRICE_IN.Name = "MN_PRICE_IN";
            this.MN_PRICE_IN.ReadOnly = true;
            this.MN_PRICE_IN.Width = 69;
            // 
            // MN_PRICE
            // 
            this.MN_PRICE.DataPropertyName = "MN_PRICE";
            dataGridViewCellStyle2.Format = "C0";
            this.MN_PRICE.DefaultCellStyle = dataGridViewCellStyle2;
            this.MN_PRICE.HeaderText = "Giá bán";
            this.MN_PRICE.Name = "MN_PRICE";
            this.MN_PRICE.ReadOnly = true;
            this.MN_PRICE.Width = 64;
            // 
            // num_qty
            // 
            this.num_qty.Location = new System.Drawing.Point(156, 118);
            this.num_qty.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_qty.Name = "num_qty";
            this.num_qty.Size = new System.Drawing.Size(166, 20);
            this.num_qty.TabIndex = 20;
            this.num_qty.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Giá bán (nghìn đồng):";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(253, 139);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(80, 34);
            this.btn_del.TabIndex = 18;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(146, 139);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(80, 34);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(31, 139);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(80, 34);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // num_money
            // 
            this.num_money.Location = new System.Drawing.Point(156, 92);
            this.num_money.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.num_money.Name = "num_money";
            this.num_money.Size = new System.Drawing.Size(166, 20);
            this.num_money.TabIndex = 15;
            this.num_money.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số lượng:";
            // 
            // txt_name_goods
            // 
            this.txt_name_goods.Location = new System.Drawing.Point(156, 41);
            this.txt_name_goods.Name = "txt_name_goods";
            this.txt_name_goods.Size = new System.Drawing.Size(166, 20);
            this.txt_name_goods.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên mặt hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại hàng:";
            // 
            // cbo_type
            // 
            this.cbo_type.DisplayMember = "CHR_TYPE";
            this.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Location = new System.Drawing.Point(156, 15);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(166, 21);
            this.cbo_type.TabIndex = 4;
            this.cbo_type.ValueMember = "ID";
            this.cbo_type.SelectedIndexChanged += new System.EventHandler(this.cbo_type_SelectedIndexChanged);
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 587);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGoods";
            this.Text = "frmGoods";
            this.Load += new System.EventHandler(this.frmGoods_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_money_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_money)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_type;
        private System.Windows.Forms.NumericUpDown num_money;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name_goods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown num_qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.NumericUpDown num_money_in;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHR_GOODS_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn INT_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn INT_GOOD_QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MN_PRICE_IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MN_PRICE;
    }
}