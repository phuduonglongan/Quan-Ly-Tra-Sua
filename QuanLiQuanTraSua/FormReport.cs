using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUS;
using DTO;

namespace QuanLiQuanTraSua
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!rbtDay.Checked && !rbtMonth.Checked)
            {
                MessageBox.Show("Xin hãy chọn loại thống kê!!", "Lỗi");
            }
            else
            {
                string type = "";

                if (rbtDay.Checked)
                {
                    type = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();

                }
                else if (rbtMonth.Checked)
                {
                    type = DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
                }
                XuatFile(type);
            }
        }
        private void XuatFile(string type)
        {
            String fileName = "Report" + type;
            String filePath = "D:\\" + fileName + ".txt";
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sWriter.WriteLine("THỐNG KÊ " + type);
            sWriter.WriteLine("------------------------------------------------------------------------------------");
            StringBuilder sb;
            sb = new StringBuilder();
            sb.Append(string.Format("Tổng số hóa đơn: {0,-40}\nTổng doanh thu: {1, -40}", txtTotalBill.Text, txtTotalRevenu.Text));
            sWriter.WriteLine(sb.ToString());
            sWriter.WriteLine("------------------------------------------------------------------------------------");
            sWriter.Flush();
            fs.Close();
            fs = new FileStream(filePath, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String data = rd.ReadToEnd();
            rd.Close();
            MessageBox.Show(data, "HÓA ĐƠN TÍNH TIỀN");
        }
        private void rbtDay_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            List<Account> list = new AccountBUS().GetAllAccount();
            int totalBill = 0, total = 0;

            if (rb.Name == "rbtDay")
            {
                foreach (Account item in list)
                {
                    totalBill += item.CountDay;
                    total += item.TotalDay;
                }
            }
            else
            {
                foreach (Account item in list)
                {
                    totalBill += item.CountDay;
                    total += item.TotalDay;
                }
            }
            txtTotalBill.Text = totalBill.ToString();
            txtTotalRevenu.Text = total.ToString();
        }
    }
}
