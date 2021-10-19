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
    public partial class frmRevenue : Form
    {
        public frmRevenue()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }
        private void find(DateTime from, DateTime to)
        {
            if (dbConnection.str_user == "")
            {
                lbl_sum_in.Visible = false;
                lbl_sum_get.Visible = false;
                dataGridView1.Columns["CHR_MONEY_IN"].Visible = false;
            }

            DataSet ds = BUS_TM_SALE.Instance().TM_SALE_Select_by_date(dtp_from.Value, dtp_to.Value);
            if (ds.Tables.Count>0)
            { 
                dataGridView1.DataSource = ds.Tables[0]; 
                lbl_Sum.Text = string.Format("{0:C}", ds.Tables[1].Rows[0]["SUM_DAY"]);
                if (lbl_Sum.Text.Length>0)
                {
                    lbl_Sum.Text = lbl_Sum.Text.Substring(0, lbl_Sum.Text.Length - 3);
                } 
            }
            DataSet ds2 = BUS_TM_SALE.Instance().TM_SALE_SelectBySUM_range_date(dtp_from.Value, dtp_to.Value);
            if (ds2.Tables[0].Rows.Count > 0)
            {
                if (ds2.Tables[0].Rows[0]["SUM_DAY"] != DBNull.Value && ds2.Tables[0].Rows[0]["SUM_DAY"] != null)
                {
                    lbl_sum_in.Text = string.Format("{0:C}", ds2.Tables[0].Rows[0]["SUM_DAY"]);
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

            if (ds2.Tables[1].Rows.Count > 0)
            {
                if (ds2.Tables[1].Rows[0]["SUM_DAY"] != DBNull.Value && ds2.Tables[1].Rows[0]["SUM_DAY"] != null)
                {
                    lbl_sum_get.Text = string.Format("{0:C}", ds2.Tables[1].Rows[0]["SUM_DAY"]);
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

        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            find(dtp_from.Value, dtp_to.Value);
        }

        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            find(dtp_from.Value, dtp_to.Value);
        }
    }
}
