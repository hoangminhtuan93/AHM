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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_logon_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "admin" && txt_pass.Text == "123456a@")
            {
                dbConnection.str_user = "admin";
                this.DialogResult = DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
        }
    }
}
