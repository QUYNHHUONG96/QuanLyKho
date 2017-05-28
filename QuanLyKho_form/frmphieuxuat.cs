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
using QuanLyKho_form;
namespace QuanLyKho_form
{
    public partial class frmphieuxuat : Form
    {
        public static frmphieuxuat instance;
        public frmphieuxuat()
        {
            instance = this;
            InitializeComponent();
        }
        BUS_phieuxuat bus = new BUS_phieuxuat();
        EC_phieuxuat ec = new EC_phieuxuat();
        SQL_phieuxuat sql = new SQL_phieuxuat();
    
        void khoadieukien()
        {
            txtmapx.Enabled = false;
            datengayxuat.Enabled = false;
            cmbmanv.Enabled = false;
            cmbmakh.Enabled = false;
            btnthem.Enabled = true;
            //  btnsua.Enabled = true;
            btnkhohang.Enabled = false;
            btnxoa.Enabled = true;
            btncapnhat.Enabled = false;
            btnkhachhang.Enabled = true;
            //btnnhanvien.Enabled = true;
            btnkhohang.Enabled = true;
            txtdongia.Enabled = false;
            cmbmahang.Enabled = false;
            cmbmapx.Enabled = false;
            txtsoluong.Enabled = false;
            btnluuchitiet.Enabled = false;
            btnsuachitiet.Enabled = true;
            btnthemchitiet.Enabled = true;
            btnThanhTien.Enabled = false;
        }
        void modieukien()
        {
            txtmapx.Enabled = true;
            datengayxuat.Enabled = true;
            cmbmanv.Enabled = true;
            cmbmakh.Enabled = true;
            btnthem.Enabled = false;
            //btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btncapnhat.Enabled = true;
            btnkhachhang.Enabled = true;
            //btnnhanvien.Enabled = true;
            btnkhohang.Enabled = true;
            btnkhohang.Enabled = true;
            txtdongia.Enabled = true;
            cmbmahang.Enabled = true;
            cmbmapx.Enabled = true;
            txtsoluong.Enabled = true;
            btnluuchitiet.Enabled = false;
            btnsuachitiet.Enabled = false;
            btnthemchitiet.Enabled = false;
            btnThanhTien.Enabled = true;
        }
        void modieukienPX()
        {
            modieukien();
            txtdongia.Enabled = false;
            cmbmahang.Enabled = false;
            cmbmapx.Enabled = false;
            txtsoluong.Enabled = false;
            btnluuchitiet.Enabled = false;
            btnsuachitiet.Enabled = false;
            btnthemchitiet.Enabled = false;
            btnThanhTien.Enabled = false;
        }
        void modieukienchitiet()
        {
            modieukien();
            btnluuchitiet.Enabled = true;
            txtmapx.Enabled = false;
            datengayxuat.Enabled = false;
            cmbmanv.Enabled = false;
            cmbmakh.Enabled = false;
            btnthem.Enabled = false;
            //btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btncapnhat.Enabled = false;
        }
        void hienthiPX(string where)
        {
            DataTable dt = bus.taobang(where);
            dgvphieunhap.DataSource = dt;
        }
        BUS_chitietpx bu = new BUS_chitietpx();
        SQL_chitietpx sl = new SQL_chitietpx();
        EC_chitietpx et = new EC_chitietpx();
        bool them;
        void hienthichitiet(string where)
        {
            DataTable dt = bu.taobang(where);
            dgvchitietpx.DataSource = dt;
        }
        void setnull()
        {
            txtdongia.Text = "";
            txtsoluong.Text = "";
            cmbmahang.Text = "";
            cmbmapx.Text = "";
            txtmapx.Text = "";
            cmbmanv.Text = "";
            cmbmakh.Text = "";
        }
        BUS_nhanvien bnv = new BUS_nhanvien();
        BUS_khachhang bkh = new BUS_khachhang();
        BUS_khohang bk = new BUS_khohang();
        private void frmphieuxuat_Load(object sender, EventArgs e)
        {
            khoadieukien();
            hienthiPX("");
            hienthichitiet("");
            cmbmanv.DataSource = bnv.taobang("");
            cmbmanv.ValueMember = "manv";
            cmbmanv.DisplayMember = "manv";
            cmbmakh.DataSource = bkh.taobang("");
            cmbmakh.ValueMember = "makh";
            cmbmakh.DisplayMember = "makh";
            cmbmahang.DataSource = bk.taobang("");
            cmbmahang.ValueMember = "mahang";
            cmbmahang.DisplayMember = "mahang";
            cmbmapx.DataSource = bus.taobang("");
            cmbmapx.ValueMember = "mapx";
            cmbmapx.DisplayMember = "mapx";
        }
        
        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            frmkhachhang.mak = cmbmakh.Text.Trim();
            frmkhachhang frm = new frmkhachhang();
            frm.ShowDialog();
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            modieukienPX();
            setnull();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Mapx = txtmapx.Text;

                DialogResult dgr = MessageBox.Show("Xóa phiếu xuất sẽ xóa toàn bộ chi tiêt, bạn có chắc xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dgr == DialogResult.Yes)
                {
                    bus.xoadulieu(ec);
                    MessageBox.Show("Da xoa!");
                }
                khoadieukien();
                setnull();
                hienthiPX("");
                hienthichitiet("");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
                try
                {
                    ec.Mapx = txtmapx.Text;
                    ec.Manv = cmbmanv.Text;
                    ec.Makh = cmbmakh.Text;
                    ec.Ngayxuat = Convert.ToDateTime(datengayxuat.Text);
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
            hienthiPX("");
            hienthichitiet("");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            this.Hide();
            f.ShowDialog();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthiPX("where mapx like N'%" + txttimkiem.Text + "%'");
            hienthichitiet("where mapx like N'%" + txttimkiem.Text + "%'");
        }

        private void dgvphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtmapx.Text = dgvphieunhap.Rows[e.RowIndex].Cells[0].Value.ToString();
                datengayxuat.Text = dgvphieunhap.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbmanv.Text = dgvphieunhap.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbmakh.Text = dgvphieunhap.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnthemchitiet_Click(object sender, EventArgs e)
        {
            modieukienchitiet();
            setnull();
            them = true;
        }
        string mapx, mahang;
        int soluong, dongia;
        private void btnsuachitiet_Click(object sender, EventArgs e)
        {
            modieukienchitiet();
            cmbmapx.Enabled = false;
            them = false;
            mapx = cmbmapx.Text; mahang = cmbmahang.Text; soluong = Convert.ToInt32(txtsoluong.Text); dongia = Convert.ToInt32(txtdongia.Text);
        }
        public void hienthisaukhichonhang(string mahang,int soluong)
        {
            cmbmahang.Text = mahang;
            txtsoluong.Text = soluong.ToString();
        }
        private void btnluuchitiet_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                try
                {
                    et.Dongia = Convert.ToInt32(txtdongia.Text);
                    et.Soluong = Convert.ToInt32(txtsoluong.Text);
                    et.Mahang = cmbmahang.Text;
                    et.Mapx = cmbmapx.Text;
                    if (sl.kiemtra(et.Mapx, et.Mahang) == 1)
                    {
                        MessageBox.Show("Da ton tai chi tiet phieu xuat!");
                    }
                    else
                    {
                        bu.themdulieu(et);
                        MessageBox.Show("Them chi tiet phieu thanh cong!");
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
                    et.Mapx = cmbmapx.Text;
                    et.Mahang = cmbmahang.Text;
                    et.Dongia = Convert.ToInt32(txtdongia.Text);
                    et.Soluong = Convert.ToInt32(txtsoluong.Text);
                        kn.ThucThiCauLenhSQL("update chitietphieuxuat set mahang='" + cmbmahang.Text + "',soluong='" + txtsoluong.Text + "',dongia='" + txtdongia.Text + "' where mapx='" + cmbmapx.Text + "' and mahang='" + mahang + "'");
                        MessageBox.Show("Sua chi tiet phieu thanh cong!");
                        if (mahang != cmbmahang.Text)
                        {
                            kn.ThucThiCauLenhSQL("update khohang set soluong=soluong+" + soluong + " where mahang='" + mahang + "'");
                            kn.ThucThiCauLenhSQL("update khohang set soluong=soluong-" + txtsoluong.Text + " where mahang='" + cmbmahang.Text + "'");
                        }
                        else
                        {
                            kn.ThucThiCauLenhSQL("update khohang set soluong=soluong+" + soluong + "-" + txtsoluong.Text + "where mahang='" + cmbmahang.Text + "'");
                        }
                    
                }
                catch
                {
                    MessageBox.Show("Loi!");
                    return;
                }
            }
            setnull();
            khoadieukien();
            hienthiPX("");
            hienthichitiet("");
        }
        ketnoi kn = new ketnoi();
        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(kn.GetValue("select giaxuat from khohang where mahang='" + cmbmahang.Text + "'"));
            txtdongia.Text = Convert.ToString(ma * Convert.ToInt32(txtsoluong.Text));
        }

        private void btnxoachitiet_Click(object sender, EventArgs e)
        {
            try
            {
                et.Mapx = cmbmapx.Text;
                et.Mahang = cmbmahang.Text;

                DialogResult dgr = MessageBox.Show("Bạn có chắc xóa?", "Thông báo", MessageBoxButtons.YesNo);
                if (dgr == DialogResult.Yes)
                {
                    bu.xoadulieu(et);
                    kn.ThucThiCauLenhSQL("update khohang set soluong=soluong+" + txtsoluong.Text + "where mahang='" + cmbmahang.Text + "'");
                    MessageBox.Show("Da xoa!");
                }
                khoadieukien();
                setnull();
                hienthiPX("");
                hienthichitiet("");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void dgvchitietpx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                cmbmapx.Text = dgvchitietpx.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbmahang.Text = dgvchitietpx.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsoluong.Text = dgvchitietpx.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdongia.Text = dgvchitietpx.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnkhohang_Click(object sender, EventArgs e)
        {
            frmChonLoaiHang f = new frmChonLoaiHang();
            f.ShowDialog();
        }
    }
}
