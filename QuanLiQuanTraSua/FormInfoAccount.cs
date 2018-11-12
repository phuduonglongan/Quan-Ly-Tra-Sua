using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLiQuanTraSua
{
    public partial class FormInfoAccount : Form
    {
        public FormInfoAccount()
        {
            InitializeComponent();
            
        }
        private void FormInfoAccount_Load(object sender, EventArgs e)
        {
            List<Account> list = new AccountBUS().GetAccount();
            dtgvInfoAccount.DataSource = list; 
        }

        private void btAddAccount_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "" || txtDisplayName.Text == "")
            {
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin", "Lỗi");
            }
            else
            {
                try
                {
                    new AccountBUS().AddNewAccount(txtUserName.Text, txtPassword.Text, txtDisplayName.Text);
                    MessageBox.Show("Đã thêm nhân viên thành công", "Thành công!");
                    LoadDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }

        }
        public void LoadDgv()
        {
            try
            {
                dtgvInfoAccount.DataSource = new AccountBUS().GetAccount();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi!!!\n" + ex.Message);
            }
        }

        private void dtgvInfoAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dtgvInfoAccount.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dtgvInfoAccount.Rows[e.RowIndex];
                    new AccountBUS().UpdateInfo(row.Cells["UserName"].Value.ToString(), row.Cells["PassWord"].Value.ToString(), row.Cells["DisplayName"].Value.ToString());
                    MessageBox.Show("Đã chỉnh sửa thành công!!!");
                    LoadDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
            if (e.ColumnIndex == dtgvInfoAccount.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dtgvInfoAccount.Rows[e.RowIndex];
                    new AccountBUS().DeleteAccount(row.Cells["UserName"].Value.ToString());
                    MessageBox.Show("Đã xóa thành công!!!");
                    LoadDgv();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

    }
}
