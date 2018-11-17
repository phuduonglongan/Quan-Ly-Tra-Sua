using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Data.SqlClient;

namespace QuanLiQuanTraSua
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUserName.Text.Trim();
            pass = txtPassWord.Text.Trim();
            bool b = false;

            try
            {
                LoginBUS lgb = new LoginBUS();
                b = lgb.login(user, pass);
                LocalData.localData.AccountUserName = user;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Đăng Nhập");
            }


            if (b)
            {
                this.DialogResult = user == "duong" ? DialogResult.Yes : DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông Báo!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    txtUserName.Focus();
                    txtPassWord.Text = "";
                }
            }
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            FormLogin fg = new FormLogin();
            DialogResult result = MessageBox.Show("Bạn muốn thoát khỏi chương trình ?", "Thông Báo !", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                fg.ShowDialog();
            }
        }

        private void panelFromLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


