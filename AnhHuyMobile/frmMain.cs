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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmType frm = new frmType();
            frm.MdiParent = this;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDaily frm = new frmDaily();
            frm.MdiParent = this;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDaily frm = new frmDaily();
            frm.MdiParent = this;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void importWHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoods frm = new frmGoods();
            frm.MdiParent = this;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.MdiParent = this;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRevenue frm = new frmRevenue();
            frm.MdiParent = this;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void findTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindType frm = new frmFindType();
            frm.MdiParent = this;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logonToolStripMenuItem.Text == "Đăng nhập")
            {
                frm_login frm = new frm_login();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frmDaily frm2 = new frmDaily();
                    frm2.MdiParent = this;
                    frm2.BringToFront();
                    frm2.Dock = DockStyle.Fill;
                    frm2.Show();

                    logonToolStripMenuItem.Text = "Đăng xuất";
                    stockmenu.Enabled = true;
                }
            }
           else
            {
                dbConnection.str_user = "";
                stockmenu.Enabled = false;

                frmDaily frm2 = new frmDaily();
                frm2.MdiParent = this;
                frm2.BringToFront();
                frm2.Dock = DockStyle.Fill;
                frm2.Show();
            }    
        }
    }
}
