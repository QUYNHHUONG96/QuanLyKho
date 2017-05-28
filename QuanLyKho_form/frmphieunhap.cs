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
    public partial class frmphieunhap : Form
    {
        public frmphieunhap()
        {
            InitializeComponent();
        }
        EC_nhaphang ec = new EC_nhaphang();
        BUS_nhaphang bus = new BUS_nhaphang();
        SQL_nhaphang sql = new SQL_nhaphang();
        EC_chitietpn et = new EC_chitietpn();
        BUS_chitietpn bu = new BUS_chitietpn();
        SQL_chitietpn sl = new SQL_chitietpn();
        void khoadieukien()
        {
            txtmapn.Enabled = false;
            datengaynhap.Enabled = false;
            cmbmacc.Enabled = false;
            cmbnhanvien.Enabled = false;
            cmbmaloaihang.Enabled = false;
            txtsltheolt.Enabled = false;
            txtslthuc.Enabled = false;
            txttenhang.Enabled = false;
            txtdongia.Enabled = false;
            txtthanhtien.Enabled = false;
            btnthanhtien.Enabled = false;
            btnLuu.Enabled = false;
            btnnhacc.Enabled = true;
          //  btnnhanvien.Enabled = true;
            btnLoaihang.Enabled = true;
           // btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnthemchitiet.Enabled = true;
            //btnsuachitiet.Enabled = true;
            btnluuchitiet.Enabled = true;
            cmbmapn.Enabled = false;
        }
        void modieukienPN()
        {
            txtmapn.Enabled = true;
            datengaynhap.Enabled = true;
            cmbnhanvien.Enabled = true;
            cmbmacc.Enabled = false;
            cmbmapn.Enabled = false;
            cmbmaloaihang.Enabled = false;
            txtsltheolt.Enabled = false;
            txtslthuc.Enabled = false;
            txttenhang.Enabled = false;
            txtdongia.Enabled = false;
            txtthanhtien.Enabled = false;
            btnthanhtien.Enabled = false;
            btnthem.Enabled = false;
            //btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnLuu.Enabled = true;
            btnnhacc.Enabled = true;
            //btnnhanvien.Enabled = true;
            btnLoaihang.Enabled = true;
            btnthemchitiet.Enabled = false;
          //  btnsuachitiet.Enabled = false;
            btnluuchitiet.Enabled = false;
        }
        void modieukienchitiet()
        {
            txtmapn.Enabled = false;
            datengaynhap.Enabled = false;
            cmbnhanvien.Enabled = false;
            cmbmacc.Enabled = true;
            cmbmapn.Enabled = true;
            cmbmaloaihang.Enabled = true;
            txtsltheolt.Enabled = true;
            txtslthuc.Enabled = true;
            txttenhang.Enabled = true;
            txtdongia.Enabled = true;
            txtthanhtien.Enabled = true;
            btnthanhtien.Enabled = true;
            btnthem.Enabled = false;
            //btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnLuu.Enabled = false;
            btnnhacc.Enabled = true;
            //btnnhanvien.Enabled = true;
            btnLoaihang.Enabled = true;
            btnthemchitiet.Enabled = false;
            //btnsuachitiet.Enabled = false;
            btnluuchitiet.Enabled = true;
        }
        void hienthiPN(string where)
        {
            DataTable dt = bus.taobang(where);
            dgvphieunhap.DataSource = dt;
        }
        void hienthiCTP(string where)
        {
            DataTable dt = bu.taobang(where);
            dgvchitietpn.DataSource = dt;
        }
        void setnull()
        {
            txtmapn.Text = "";
            cmbmacc.Text = "";
            cmbnhanvien.Text = "";
            cmbmaloaihang.Text="";
            txtsltheolt.Text="";
            txtslthuc.Text="";
            txttenhang.Text="";
            txtdongia.Text="";
            txtthanhtien.Text="";
            cmbmapn.Text = "";
        }

        private void dgvphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtmapn.Text = dgvphieunhap.Rows[e.RowIndex].Cells[0].Value.ToString();
                datengaynhap.Text = dgvphieunhap.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbnhanvien.Text = dgvphieunhap.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }
        BUS_loaihang blh = new BUS_loaihang();
        BUS_nhacc bcc = new BUS_nhacc();
        BUS_nhanvien bnv = new BUS_nhanvien();
        private void frmphieunhap_Load(object sender, EventArgs e)
        {
            khoadieukien();
            hienthiPN("");
            hienthiCTP("");
            cmbmacc.DataSource = bcc.taobang("");
            cmbmacc.ValueMember = "macc";
            cmbmacc.DisplayMember = "macc";
            cmbnhanvien.DataSource = bnv.taobang("");
            cmbnhanvien.ValueMember = "manv";
            cmbnhanvien.DisplayMember = "manv";
            cmbmaloaihang.DataSource = blh.taobang("");
            cmbmaloaihang.ValueMember = "maloaihang";
            cmbmaloaihang.DisplayMember = "maloaihang";
            cmbmapn.DataSource = bus.taobang("");
            cmbmapn.ValueMember = "mapn";
            cmbmapn.DisplayMember = "mapn";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthiPN("where mapn='" + txttimkiem.Text + "'");
            hienthiCTP("where mapn='" + txttimkiem.Text + "'");
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            modieukienPN();
            setnull();
        }
        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                ec.Mapn = txtmapn.Text;
                
                DialogResult dgr = MessageBox.Show("Xóa phiếu nhập sẽ xóa toàn bộ chi tiêt, bạn có chắc xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dgr == DialogResult.Yes)
                {
                    bus.xoadulieu(ec);
                    MessageBox.Show("Da xoa!");
                }                
                khoadieukien();
                setnull();
                hienthiPN("");
                hienthiCTP("");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                try
                {
                    ec.Mapn = txtmapn.Text;
                    ec.Manv = cmbnhanvien.Text;
                    ec.Ngaynhap = Convert.ToDateTime(datengaynhap.Text);
                    bus.themdulieu(ec);
                    MessageBox.Show("Them thanh cong!");
                }
                catch
                {
                    MessageBox.Show("Loi!");
                    return;
                }
            setnull();
            khoadieukien();
            hienthiPN("");
            hienthiCTP("");
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            this.Hide();
            f.ShowDialog();
        }

        private void btnthanhtien_Click(object sender, EventArgs e)
        {
            txtthanhtien.Text =Convert.ToString(Convert.ToInt32(txtdongia.Text) * Convert.ToInt32(txtslthuc.Text));
        }
        private void btnnhacc_Click(object sender, EventArgs e)
        {
            frmnhacc.ma = cmbmacc.Text.Trim();
            frmnhacc f = new frmnhacc();
            f.ShowDialog();
        }

        private void btnLoaihang_Click(object sender, EventArgs e)
        {
            frmloaihang.ma = cmbmaloaihang.Text.Trim();
            frmloaihang f = new frmloaihang() ;
            f.ShowDialog();
        }

        private void dgvchitietpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txttenhang.Text = dgvchitietpn.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbmacc.Text = dgvchitietpn.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbmapn.Text = dgvchitietpn.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbmaloaihang.Text = dgvchitietpn.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtsltheolt.Text = dgvchitietpn.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtslthuc.Text = dgvchitietpn.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtdongia.Text = dgvchitietpn.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtthanhtien.Text = dgvchitietpn.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch { }
        }
        bool them;
        private void btnthemchitiet_Click(object sender, EventArgs e)
        {
            modieukienchitiet();
            setnull();
            them = true;
        }
        ketnoi kn = new ketnoi();
        private void btnluuchitiet_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                try
                {
                    et.Mapn = cmbmapn.Text;
                    et.Macc = cmbmacc.Text;
                    et.Dongia = Convert.ToInt32(txtdongia.Text);
                    et.Maloaihang = cmbmaloaihang.Text;
                    et.SltheoLT = Convert.ToInt32(txtsltheolt.Text);
                    et.SlThuc = Convert.ToInt32(txtslthuc.Text);
                    et.Tenhang = txttenhang.Text;
                    et.Thanhtien = Convert.ToInt32(txtthanhtien.Text);
                    if (sl.kiemtra(et.Mapn, et.Maloaihang, et.Macc, et.Tenhang) == 1)
                    {
                        MessageBox.Show("Da ton tai hang hoa nay trong phieu nhap!");
                    }
                    else
                    {
                        bu.themdulieu(et);
                        MessageBox.Show("Them thanh cong!");
                    }
                }
                catch
                {
                    MessageBox.Show("Loi!");
                    return;
                }
            }
            else
            {
                try
                {
                    et.Mapn = cmbmapn.Text;
                    et.Macc = cmbmacc.Text;
                    et.Dongia = Convert.ToInt32(txtdongia.Text);
                    et.Maloaihang = cmbmaloaihang.Text;
                    et.SltheoLT = Convert.ToInt32(txtsltheolt.Text);
                    et.SlThuc = Convert.ToInt32(txtslthuc.Text);
                    et.Tenhang = txttenhang.Text;
                    et.Thanhtien = Convert.ToInt32(txtthanhtien.Text);
                    bu.suadulieu(et);
                    kn.ThucThiCauLenhSQL("update khohang set soluong=soluong-" + soluong + "+" + txtslthuc.Text + ",gianhap=" + txtdongia.Text + " where macc='" + cmbmacc.Text + "' and tenhang=N'" + txttenhang.Text + "' and maloaihang='" + cmbmaloaihang.Text + "'");
                    MessageBox.Show("Sua thanh cong!");
                }
                catch
                {
                    MessageBox.Show("Loi!");
                    return;
                }
            }
            setnull();
            khoadieukien();
            hienthiPN("");
            hienthiCTP("");
        }
        string soluong;

        private void btnxoachitiet_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Mapn = txtmapn.Text;
                int a = int.Parse(kn.GetValue("select count(mahang) from khohang where macc='"+cmbmacc.Text+"' and maloaihang='"+cmbmaloaihang.Text+"' and tenhang=N'"+txttenhang.Text+"' and soluong<"+txtslthuc.Text+""));
                DialogResult dgr = MessageBox.Show("Bạn có chắc xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dgr == DialogResult.Yes)
                {
                    if (a == 1)
                    {
                        MessageBox.Show("Khong the xoa!");
                    }
                    else
                    {
                        bu.xoadulieu(et);
                        kn.ThucThiCauLenhSQL("update khohang set soluong=soluong-" + txtslthuc.Text + "where macc='" + cmbmacc.Text + "' and maloaihang='" + cmbmaloaihang.Text + "' and tenhang=N'" + txttenhang.Text + "'");
                        MessageBox.Show("Da xoa!");
                    }
                }
                khoadieukien();
                setnull();
                hienthiPN("");
                hienthiCTP("");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btnsuachitiet_Click(object sender, EventArgs e)
        {
            modieukienchitiet();
            cmbmapn.Enabled = false;
            cmbmacc.Enabled = false;
            cmbmaloaihang.Enabled = false;
            txttenhang.Enabled = false;
            soluong = txtslthuc.Text;
            them = false;
        }

        private void txtmapn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
