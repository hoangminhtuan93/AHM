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
    public partial class frmFindType : Form
    {
        public frmFindType()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmFindType_Load(object sender, EventArgs e)
        {
            DataTable type = BUS_TM_MASTER_TYPE.Instance().TM_MASTER_TYPE_Select_dgv();
            DataRow dr = type.NewRow();
            dr["ID"] = 0;
            type.Rows.InsertAt(dr, 0);
            cbo_type.DataSource = type;
             
            dataGridView1.DataSource = BUS_TM_SALE.Instance().TM_SALE_Select_dgv();
        }

        private void cbo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_type.SelectedIndex > 0)
            {
                StringBuilder querry_text = new StringBuilder();
                querry_text.Append("SELECT TM_SALE.[ID],[DAT_DATE],[ID_TYPE],[CHR_NAME],[CHR_MONEY],[CHR_USER_UPDATE],[DTM_UPDATE]");
                querry_text.Append(",CHR_CUSTOMER,CHR_CUS_PHONE,CHR_TYPE,INT_GOOD_QTY FROM TM_SALE");
                querry_text.Append(" inner join TM_MASTER_TYPE on TM_MASTER_TYPE.ID = TM_SALE.ID_TYPE");
                querry_text.Append(" where TM_SALE.ID_TYPE = ");
                querry_text.Append(cbo_type.SelectedValue.ToString());
                querry_text.Append(" order by DAT_DATE desc");
                querry_text.Append("");
                dataGridView1.DataSource = dbConnection.ExecuteDataset_text(querry_text.ToString()).Tables[0];
            }
        }
    }
}
