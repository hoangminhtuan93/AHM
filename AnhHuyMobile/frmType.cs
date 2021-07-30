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
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_type.Text != "")
            {
                TM_MASTER_TYPEInfo add = new TM_MASTER_TYPEInfo();
                add.CHR_TYPE = txt_type.Text;
                add.BIT_USING = true;
                BUS_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_Insert(add);

                MessageBox.Show("Bạn đã thêm thành công");
                load_dgv();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                load_dgv();
            }
        }

        private void frmType_Load(object sender, EventArgs e)
        {
            load_dgv();
        }
        private void load_dgv()
        {
            txt_type.Clear();
            lbl_ID.Text = "";
            dataGridView1.DataSource = BUS_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_Select_dgv();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1 && e.ColumnIndex >= -1)
            {
                lbl_ID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txt_type.Text = dataGridView1.Rows[e.RowIndex].Cells["CHR_TYPE"].Value.ToString();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text != "")
            {
                if (txt_type.Text != "")
                {
                    TM_MASTER_TYPEInfo add = new TM_MASTER_TYPEInfo();
                    add.ID = int.Parse(lbl_ID.Text);
                    add.CHR_TYPE = txt_type.Text;
                    add.BIT_USING = true;
                    BUS_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_Update(add);
                    load_dgv();
                    MessageBox.Show("Bạn đã sửa thành công");
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

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text != "")
            {
                if (BUS_TM_SALE.Instance().TM_SALE_check_type(int.Parse(lbl_ID.Text)).Rows.Count == 0)
                {
                    BUS_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_Delete(int.Parse(lbl_ID.Text));
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
    }

}
