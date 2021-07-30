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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BUS_TM_SALE.Instance().TM_SALE_Select_rev_by_cus(txt_find.Text);
        }
    }
}
