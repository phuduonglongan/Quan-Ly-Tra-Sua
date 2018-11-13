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
using DTO;
using System.IO;

namespace QuanLiQuanTraSua
{
    public partial class Form1 : Form
    {
        class Const
        {
            public static int BUTTON_WIDTH = 200;
            public static int BUTTON_HEIGHT = 50;
        }
        bool isAdmin = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void logOutMenustrip_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            FormLogin fg = new FormLogin();
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất ?", "Thông Báo !", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (isAdmin)
                {
                    adminToolStripMenuItem.Enabled = false;
                }
                LocalData.localData.AccountUserName = null;
                this.Visible = false;
                this.ShowDialog();
                fg.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = false;
            FormLogin lg = new FormLogin();
            DialogResult result = lg.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                if (result == DialogResult.Yes)
                {
                    isAdmin = true;
                    adminToolStripMenuItem.Enabled = true;
                }
                this.Enabled = true;
                loadDataDrinkTopping(panelDrinks, "D");
                loadDataDrinkTopping(panelTopping, "T");
            }
            else
            {
                Application.Exit();
            }
        }

        private void infoAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfoAccount fia = new FormInfoAccount();
            fia.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport frp = new FormReport();
            frp.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbShopName.Text = lbShopName.Text.Substring(1) + lbShopName.Text.Substring(0, 1);
        }

        private void loadDataDrinkTopping(Panel pn, string type)
        {
            List<Drinks> list = new DrinksBUS().GetDrinks_Topping(type);
            Button obt = new Button() { Width = 0, Location = new Point(0, 0) };
            foreach (var item in list)
            {
                Button bt = new Button()
                {
                    Width = Const.BUTTON_WIDTH,
                    Height = Const.BUTTON_HEIGHT,
                    Location = new Point(obt.Location.X + obt.Width, obt.Location.Y),
                    Text = item.Name,
                    Tag = item.Price
                };
                bt.Click += btn_Click;
                pn.Controls.Add(bt);
                obt = bt;
                if (obt.Location.X + Const.BUTTON_WIDTH >= pn.Width)
                {
                    obt.Location = new Point(0, obt.Location.Y + Const.BUTTON_HEIGHT);
                    obt.Width = Const.BUTTON_WIDTH;
                    obt.Height = Const.BUTTON_HEIGHT;
                }
            }
        }

        private void btn_Click(object sender, System.EventArgs e)
        {
            Button bt = (Button)sender;
            var listViewItem = new ListViewItem(bt.Text);
            listViewItem.SubItems.Add(bt.Tag.ToString());
            listViewItem.SubItems.Add("1");
            listViewItem.SubItems.Add(bt.Tag.ToString());
            lvBill.Items.Add(listViewItem);
            bt.Enabled = false;
            TinhTien();
        }
        ListViewItem.ListViewSubItem Count;
        ListViewItem.ListViewSubItem Price;
        ListViewItem.ListViewSubItem Sum;
        private void lvBill_MouseDown(object sender, MouseEventArgs e)
        {
            HideTextEditor();
        }
        private void TxtEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                HideTextEditor();
                TinhTien();
            }
        }
        private void HideTextEditor()
        {
            TxtEdit.Visible = false;
            if (Count != null)
            {
                Count.Text = TxtEdit.Text;
                Sum.Text = (Convert.ToInt32(Count.Text) * Convert.ToInt32(Price.Text)).ToString();
            }
            Count = null;
            TxtEdit.Text = "";
        }

        private void lvBill_MouseUp(object sender, MouseEventArgs e)
        {
            ListViewItem ItemSelected = lvBill.GetItemAt(e.X, e.Y);
            ListViewHitTestInfo i = lvBill.HitTest(e.X, e.Y);
            Count = i.SubItem;
            Price = ItemSelected.SubItems[1];
            Sum = ItemSelected.SubItems[3];
            TxtEdit.Location = new Point(ItemSelected.SubItems[2].Bounds.X, ItemSelected.SubItems[2].Bounds.Y);
            TxtEdit.Visible = true;
            TxtEdit.BringToFront();
            TxtEdit.Text = ItemSelected.SubItems[2].Text;
            TxtEdit.Select();
            TxtEdit.SelectAll();
        }

        private void btPay_Click(object sender, EventArgs e)
        {
            foreach (Button item in panelDrinks.Controls)
            {
                if (!item.Enabled)
                {
                    item.Enabled = true;
                }
            }
            foreach (Button item in panelTopping.Controls)
            {
                if (!item.Enabled)
                {
                    item.Enabled = true;
                }
            }
            new AccountBUS().UpdateCountDay(LocalData.localData.AccountUserName, Convert.ToInt32(txtTotal.Text));
            new AccountBUS().UpdateCountMonth(LocalData.localData.AccountUserName, Convert.ToInt32(txtTotal.Text));
            XuatFile();
            lvBill.Clear();
        }

        private void TinhTien()
        {
            double total = 0;
            foreach (ListViewItem item in lvBill.Items)
            {
                total += Convert.ToInt32(item.SubItems[3].Text);
            }
            txtTotal.Text = total.ToString();
        }

        private void XuatFile()
        {
            String fileName = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            String filePath = "D:\\" + fileName + ".txt";
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sWriter.WriteLine("HÓA ĐƠN TÍNH TIỀN");
            sWriter.WriteLine("------------------------------------------------------------------------------------");
            StringBuilder sb;
           foreach (ListViewItem lvi in lvBill.Items)
            {
                sb = new StringBuilder();
                
                    sb.Append(string.Format("{0,-40} {1, -11} {2, -30} {3}", lvi.SubItems[0].Text, lvi.SubItems[1].Text, lvi.SubItems[2].Text, lvi.SubItems[3].Text));
                
                sWriter.WriteLine(sb.ToString());
            }
            sWriter.WriteLine("------------------------------------------------------------------------------------");
            sWriter.WriteLine("Thành tiền:\t" + txtTotal.Text);
            sWriter.Flush();
            fs.Close();
            fs = new FileStream(filePath, FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            String data = rd.ReadToEnd();
            rd.Close();
            MessageBox.Show(data, "HÓA ĐƠN TÍNH TIỀN");
        }
    }
}
