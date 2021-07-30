using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnhHuyMobile
{
    public partial class frmGoods : Form
    {
        public frmGoods()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmGoods_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            DataTable type = BUS_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_Select_dgv();
            DataRow dr = type.NewRow();
            dr["ID"] = 0;
            type.Rows.InsertAt(dr, 0);
            cbo_type.DataSource = type;
            load_dgv();
        }
        private void load_dgv()
        {
            dataGridView1.DataSource = BUS_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_Select_dgv();
        }
        private void clear_data()
        {
            cbo_type.SelectedIndex = 0;
            txt_name_goods.Clear();
            num_qty.Value = 0;
            num_money.Value = 0;
            load_dgv();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cbo_type.SelectedIndex > 0 && txt_name_goods.Text != "" && num_money.Value != 0 && num_qty.Value != 0 && num_money_in.Value != 0)
            {
                TM_MASTER_GOODSInfo add = new TM_MASTER_GOODSInfo();
                add.ID_TYPE = (int)cbo_type.SelectedValue;
                add.CHR_GOODS_NAME = txt_name_goods.Text;
                add.INT_QTY = (int)num_qty.Value;
                add.MN_PRICE_IN = (double)num_money_in.Value * 1000;
                add.MN_PRICE = (double)num_money.Value * 1000;
                add.BIT_USING = true;
                if (int.Parse(DAL_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_Insert(add).ToString()) > 0)
                {
                    clear_data();
                    MessageBox.Show("Bạn đã thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể thêm dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                lbl_ID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                cbo_type.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["ID_TYPE"].Value;
                txt_name_goods.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_TYPE"].Value.ToString();
                num_money_in.Value = dataGridView1.Rows[e.RowIndex].Cells["MN_PRICE_IN"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["MN_PRICE_IN"].Value == DBNull.Value ? 0 : (decimal)dataGridView1.Rows[e.RowIndex].Cells["MN_PRICE_IN"].Value;
                num_money.Value = dataGridView1.Rows[e.RowIndex].Cells["MN_PRICE"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["MN_PRICE"].Value == DBNull.Value ? 0 : (decimal)dataGridView1.Rows[e.RowIndex].Cells["MN_PRICE"].Value;
                num_qty.Value = dataGridView1.Rows[e.RowIndex].Cells["INT_QTY"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["INT_QTY"].Value == DBNull.Value ? 0 : (int)dataGridView1.Rows[e.RowIndex].Cells["INT_QTY"].Value;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text != "")
            {
                if (BUS_TM_SALE.Instance().TM_SALE_check_good(int.Parse(lbl_ID.Text)).Rows.Count == 0)
                {
                    BUS_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_Delete(int.Parse(lbl_ID.Text));
                    load_dgv();
                    MessageBox.Show("Bạn đã xóa thành công");
                }
                else
                {
                    MessageBox.Show("Loại hàng này đã sử dụng, không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text != "")
            {
                if (cbo_type.SelectedIndex > 0 && txt_name_goods.Text != "" && num_money.Value != 0 && num_qty.Value != 0 && num_money_in.Value != 0)
                {
                    TM_MASTER_GOODSInfo add = new TM_MASTER_GOODSInfo();
                    add.ID = int.Parse(lbl_ID.Text);
                    add.ID_TYPE = (int)cbo_type.SelectedValue;
                    add.CHR_GOODS_NAME = txt_name_goods.Text;
                    add.INT_QTY = (int)num_qty.Value;
                    add.MN_PRICE_IN = (double)num_money_in.Value;
                    add.MN_PRICE = (double)num_money.Value;
                    add.BIT_USING = true;
                    if (int.Parse(DAL_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_Update(add).ToString()) > 0)
                    {
                        clear_data();
                        MessageBox.Show("Bạn đã sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(" Lỗi hệ thống, không thể sửa dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_name_goods.Clear();
            //num_money_in.Value = 0;
            //num_money.Value = 0;
            //num_qty.Value = 0;
        }
    }
}
