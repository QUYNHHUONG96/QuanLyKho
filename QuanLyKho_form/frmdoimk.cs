using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKho_BUS;
using QuanLyKho_DAL;
using QuanLyKho_Entity;
namespace QuanLyKho_form
{
    public partial class frmdoimk : Form
    {
        public frmdoimk()
        {
            InitializeComponent();
        }
        BUS_dangnhap bus = new BUS_dangnhap();
        SQL_dangnhap sql = new SQL_dangnhap();
        EC_dangnhap ec = new EC_dangnhap();
        private void btndoimk_Click(object sender, EventArgs e)
        {
            if (sql.kiemtra(txtname.Text, txtmkcu.Text) == 0)
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau cu!");
            }
            else
            {
                try
                {
                    ec.Username = txtname.Text;
                    ec.Pass = txtmkcu.Text;
                    bus.doimatkhau(txtname.Text,txtmkmoi.Text, ec);
                    MessageBox.Show("Doi thanh cong!");
                }
                catch { MessageBox.Show("Loi!"); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
