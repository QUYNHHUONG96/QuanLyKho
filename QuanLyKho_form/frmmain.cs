using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho_form
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rsl = MessageBox.Show(" Bạn chắc chắn muốn thoát khỏi hệ thống ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rsl != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnphieunhap_Click(object sender, EventArgs e)
        {
            frmphieunhap frm = new frmphieunhap();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void btnkhohang_Click(object sender, EventArgs e)
        {
            frmkhohang frm = new frmkhohang();
            this.Hide();
            frm.ShowDialog();
         
        }

        private void btnphieuxuat_Click(object sender, EventArgs e)
        {
            frmphieuxuat frm = new frmphieuxuat();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHuongDan f = new frmHuongDan();
            this.Hide();
            f.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmthongke frm = new frmthongke();
            this.Hide();
            frm.ShowDialog();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNguoiDung f = new frmNguoiDung();
            this.Hide();
            f.ShowDialog();
        }
    }
}
