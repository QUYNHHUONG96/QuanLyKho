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
    public partial class frmnhacc : Form
    {
        public frmnhacc()
        {
            InitializeComponent();
        }
        BUS_nhacc bus = new BUS_nhacc();
        SQL_nhacc sql = new SQL_nhacc();
        EC_nhacc ec = new EC_nhacc();

        void hienthi(string where)
        {
            DataTable dt = bus.taobang(where);
            dgvnhacc.DataSource = dt;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string ma;
        private void frmnhacc_Load(object sender, EventArgs e)
        {
            hienthi("where macc='"+ma+"'");
        }

        private void btnxemdanhsach_Click(object sender, EventArgs e)
        {
            hienthi("");
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
