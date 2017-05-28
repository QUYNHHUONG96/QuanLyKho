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
    public partial class frmthongke : Form
    {
        public frmthongke()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        BUS_khohang bk = new BUS_khohang();
        
        private void frmthongke_Load(object sender, EventArgs e)
        {
            DataTable dt = kn.GetDataTable("select mahang,tenhang,soluong from khohang");
            dgvThongKe.DataSource = dt;
        }
        void setnull()
        {
            cmbthang.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            this.Hide();
            f.ShowDialog();
        }

        private void btnHangtrongkho_Click(object sender, EventArgs e)
        {
            DataTable dt = kn.GetDataTable("select mahang,tenhang,soluong from khohang");
            dgvThongKe.DataSource = dt;
        }

        private void btnHangdaxuat_Click(object sender, EventArgs e)
        {
            DataTable dt = kn.GetDataTable("luuluongxuat'" + cmbthang.Text + "'");
            dgvThongKe.DataSource = dt;
        }

        private void btnhangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = kn.GetDataTable("luuluongnhap'" + cmbthang.Text + "'");
            dgvThongKe.DataSource = dt;
        }
    }
}
