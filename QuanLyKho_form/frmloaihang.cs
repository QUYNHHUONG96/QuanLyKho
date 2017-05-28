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
    public partial class frmloaihang : Form
    {
        public frmloaihang()
        {
            InitializeComponent();
        }
        BUS_loaihang bus = new BUS_loaihang();
        SQL_loaihang sql = new SQL_loaihang();
        EC_loaihang ec = new EC_loaihang();

        void hienthi(string where)
        {
            DataTable dt = bus.taobang(where);
            dgvloaihang.DataSource = dt;
        }

        public static string ma;
        private void frmloaihang_Load(object sender, EventArgs e)
        {
            hienthi("where maloaihang='"+ma+"'");
        }

        private void btnXemdanhsach_Click(object sender, EventArgs e)
        {
            hienthi("");
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
