using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnhHuyMobile
{
    public partial class frmDaily : Form
    {
        public frmDaily()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (/*(txt_name.Text != "" || (cbo_goods.SelectedIndex > 0 && num_qty.Value != 0)) &&*/ cbo_type.SelectedIndex > 0 && num_money.Value != 0 && num_qty.Value > 0)
            {
                TM_SALEInfo add = new TM_SALEInfo();
                add.DAT_DATE = dtp_date.Value;
                add.ID_TYPE = (int)cbo_type.SelectedValue;

                add.CHR_MONEY = (double)num_money.Value * 1000;
                add.DTM_UPDATE = DateTime.Now;
                add.CHR_CUSTOMER = txt_customer.Text;
                add.CHR_CUS_PHONE = txt_cus_phone.Text;
                add.CHR_MONEY_IN = (double)num_money_in.Value * 1000;
                add.INT_GUARANTEE_MONTH = (int)num_guarantee_month.Value;
                add.INT_GOOD_QTY = (int)num_qty.Value;
                add.DTM_UPDATE = DateTime.Now;
                add.CHR_USER_UPDATE = txt_user.Text;
                if (cbo_goods.SelectedIndex > 0)
                {
                    add.ID_GOODS = int.Parse(cbo_goods.SelectedValue.ToString());
                    add.CHR_NAME = cbo_goods.Text;
                }
                else
                {
                    add.CHR_NAME = txt_name.Text;
                }

                if (int.Parse(DAL_TM_SALE.Instance().TM_SALE_Insert(add).ToString()) > 0)
                {
                    load_sum_by_date();
                    load_dgv_by_date();
                    clear_data();
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi thêm dữ liệu, hãy liên hệ với người quản lý hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu có dấu *", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clear_data()
        {
            lbl_ID.Text = "";
            cbo_type.SelectedIndex = 0;
            txt_name.Clear();
            num_money.Value = 0;
            num_qty.Value = 1;
            num_money_in.Value = 0;
            num_guarantee_month.Value = 0;
            cbo_goods.DataSource = null;
            txt_customer.Clear();
            txt_cus_phone.Clear();
            txt_user.Clear();
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
            btn_del.Enabled = false;
        }
        private void frmDaily_Load(object sender, EventArgs e)
        {
            if (dbConnection.str_user == "")
            {
                lbl_sum_in.Visible = false;
                lbl_sum_get.Visible = false;
                dataGridView1.Columns["CHR_MONEY_IN"].Visible = false;
            }
            DataTable type = BUS_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_Select_dgv();
            DataRow dr = type.NewRow();
            dr["ID"] = 0;
            type.Rows.InsertAt(dr, 0);
            cbo_type.DataSource = type;

            load_sum_by_date();
            load_dgv_by_date();
        }

        private void load_dgv()
        {
            dataGridView1.DataSource = BUS_TM_SALE.Instance().TM_SALE_Select_dgv();
        }
        private void load_dgv_by_date()
        {
            dataGridView1.DataSource = BUS_TM_SALE.Instance().TM_SALE_SelectByDate(dtp_date.Value);
        }
        private void load_sum_by_date()
        {
            DataTable dt = BUS_TM_SALE.Instance().TM_SALE_SelectBySUM(dtp_date.Value);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["SUM_DAY"] != DBNull.Value && dt.Rows[0]["SUM_DAY"] != null)
                {
                    lbl_Sum.Text = string.Format("{0:C}", dt.Rows[0]["SUM_DAY"]);
                    lbl_Sum.Text = lbl_Sum.Text.Substring(0, lbl_Sum.Text.Length - 3);
                }
                else
                {
                    lbl_Sum.Text = "0";
                }
            }
            else
            {
                lbl_Sum.Text = "0";
            }

            DataTable dt2 = BUS_TM_SALE.Instance().TM_SALE_SelectBySUM_in(dtp_date.Value);
            if (dt2.Rows.Count > 0)
            {
                if (dt2.Rows[0]["SUM_DAY"] != DBNull.Value && dt2.Rows[0]["SUM_DAY"] != null)
                {
                    lbl_sum_in.Text = string.Format("{0:C}", dt2.Rows[0]["SUM_DAY"]);
                    lbl_sum_in.Text = lbl_sum_in.Text.Substring(0, lbl_sum_in.Text.Length - 3);
                }
                else
                {
                    lbl_sum_in.Text = "0";
                }
            }
            else
            {
                lbl_sum_in.Text = "0";
            }

            //TM_SALE_SelectBySUM_get
            DataTable dt3 = BUS_TM_SALE.Instance().TM_SALE_SelectBySUM_get(dtp_date.Value);
            if (dt3.Rows.Count > 0)
            {
                if (dt3.Rows[0]["SUM_DAY"] != DBNull.Value && dt3.Rows[0]["SUM_DAY"] != null)
                {
                    lbl_sum_get.Text = string.Format("{0:C}", dt3.Rows[0]["SUM_DAY"]);
                    lbl_sum_get.Text = lbl_sum_get.Text.Substring(0, lbl_sum_get.Text.Length - 3);
                }
                else
                {
                    lbl_sum_get.Text = "0";
                }
            }
            else
            {
                lbl_sum_get.Text = "0";
            }
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            load_sum_by_date();
            load_dgv_by_date();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                btn_add.Enabled = false;
                btn_edit.Enabled = true;
                btn_del.Enabled = true;
                lbl_ID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                cbo_type.SelectedValue = (int)dataGridView1.Rows[e.RowIndex].Cells["ID_TYPE"].Value;
                if (dataGridView1.Rows[e.RowIndex].Cells["ID_GOODS"].Value != null && dataGridView1.Rows[e.RowIndex].Cells["ID_GOODS"].Value != DBNull.Value)
                {
                    cbo_goods.SelectedValue = (int)dataGridView1.Rows[e.RowIndex].Cells["ID_GOODS"].Value;
                }
                else
                {
                    if (cbo_goods.Items.Count > 0)
                    {
                        cbo_goods.SelectedIndex = 0;
                    }
                }
                num_qty.Value = (dataGridView1.Rows[e.RowIndex].Cells["INT_GOOD_QTY"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["INT_GOOD_QTY"].Value == DBNull.Value) ? 0 : decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells["INT_GOOD_QTY"].Value.ToString());
                txt_name.Text = (dataGridView1.Rows[e.RowIndex].Cells["CHR_NAME"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["CHR_NAME"].Value == DBNull.Value) ? "" : dataGridView1.Rows[e.RowIndex].Cells["CHR_NAME"].Value.ToString();
                num_money_in.Value = (dataGridView1.Rows[e.RowIndex].Cells["CHR_MONEY_IN"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["CHR_MONEY_IN"].Value == DBNull.Value) ? 0 : (decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells["CHR_MONEY_IN"].Value.ToString())/1000);
                num_money.Value = (dataGridView1.Rows[e.RowIndex].Cells["CHR_MONEY"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["CHR_MONEY"].Value == DBNull.Value) ? 0 : (decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells["CHR_MONEY"].Value.ToString())/1000);
                num_guarantee_month.Value = (dataGridView1.Rows[e.RowIndex].Cells["INT_GUARANTEE_MONTH"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["INT_GUARANTEE_MONTH"].Value == DBNull.Value) ? 0 : decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells["INT_GUARANTEE_MONTH"].Value.ToString());
                txt_customer.Text = (dataGridView1.Rows[e.RowIndex].Cells["CHR_CUSTOMER"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["CHR_CUSTOMER"].Value == DBNull.Value) ? "" : dataGridView1.Rows[e.RowIndex].Cells["CHR_CUSTOMER"].Value.ToString();
                txt_cus_phone.Text = (dataGridView1.Rows[e.RowIndex].Cells["CHR_CUS_PHONE"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["CHR_CUS_PHONE"].Value == DBNull.Value) ? "" : dataGridView1.Rows[e.RowIndex].Cells["CHR_CUS_PHONE"].Value.ToString();
                txt_cus_phone.Text = (dataGridView1.Rows[e.RowIndex].Cells["CHR_CUSTOMER"].Value == null || dataGridView1.Rows[e.RowIndex].Cells["CHR_CUSTOMER"].Value == DBNull.Value) ? "" : dataGridView1.Rows[e.RowIndex].Cells["CHR_CUSTOMER"].Value.ToString();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text != "")
            {
                DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.Yes)
                {
                    BUS_TM_SALE.Instance().TM_SALE_Delete(int.Parse(lbl_ID.Text));
                    load_sum_by_date();
                    load_dgv_by_date();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu cần xóa", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text != "")
            {
                if ((txt_name.Text != "" || (cbo_goods.SelectedIndex > 0 && num_qty.Value != 0)) && cbo_type.SelectedIndex > 0 && num_money.Value != 0 && num_qty.Value > 0)
                {
                    TM_SALEInfo add = new TM_SALEInfo();
                    add.ID = int.Parse(lbl_ID.Text);
                    add.DAT_DATE = dtp_date.Value;
                    add.ID_TYPE = (int)cbo_type.SelectedValue;
                    add.CHR_MONEY = (double)num_money.Value * 1000;
                    add.DTM_UPDATE = DateTime.Now;
                    add.CHR_CUSTOMER = txt_customer.Text;
                    add.CHR_CUS_PHONE = txt_cus_phone.Text;
                    add.CHR_MONEY_IN = (double)num_money_in.Value * 1000;
                    add.INT_GUARANTEE_MONTH = (int)num_guarantee_month.Value;
                    add.INT_GOOD_QTY = (int)num_qty.Value;
                    add.DTM_UPDATE = DateTime.Now;
                    add.CHR_USER_UPDATE = txt_user.Text;
                    if (cbo_goods.SelectedIndex > 0)
                    {
                        add.ID_GOODS = int.Parse(cbo_goods.SelectedValue.ToString());
                        add.CHR_NAME = cbo_goods.Text;
                    }
                    else
                    {
                        add.CHR_NAME = txt_name.Text;
                    }

                    if (int.Parse(DAL_TM_SALE.Instance().TM_SALE_Update(add).ToString()) > 0)
                    {
                        load_sum_by_date();
                        load_dgv_by_date();
                        clear_data();
                        MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi thêm dữ liệu, hãy liên hệ với người quản lý hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ dữ liệu có dấu *", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_goods.DataSource = null;
            if (cbo_type.SelectedIndex > 0)
            {
                DataTable gd = BUS_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_SelectBy_ID_type((int)cbo_type.SelectedValue);
                if (gd.Rows.Count > 0)
                {
                    cbo_goods.Enabled = true;
                    txt_name.Enabled = false;

                    cbo_goods.DisplayMember = "CHR_GOODS_NAME";
                    cbo_goods.ValueMember = "ID";
                    DataRow dr = gd.NewRow();
                    dr["ID"] = 0;
                    gd.Rows.InsertAt(dr, 0);
                    cbo_goods.DataSource = gd;
                }
                else
                {
                    cbo_goods.Enabled = false;
                    txt_name.Enabled = true;
                }
            }
            else
            {
                cbo_goods.Enabled = false;
                txt_name.Enabled = true;
            }
        }

        private void cbo_goods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_goods.SelectedIndex > 0)
            {
                txt_name.Enabled = false;
                TM_MASTER_GOODSInfo gd = BUS_TM_MASTER_GOODS.Instance().TM_MASTER_GOODS_SelectById(int.Parse(cbo_goods.SelectedValue.ToString()));
                num_money_in.Value = (decimal)gd.MN_PRICE_IN;
                num_money.Value = (decimal)gd.MN_PRICE;
            }
            else
            {

                txt_name.Enabled = true;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            clear_data();
        }
    }
}
