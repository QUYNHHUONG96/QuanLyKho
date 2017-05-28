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
    public partial class frmkhachhang : Form
    {
        public frmkhachhang()
        {
            InitializeComponent();
        }
        BUS_khachhang bus = new BUS_khachhang();
        SQL_khachhang sql = new SQL_khachhang();
        EC_khachhang ec = new EC_khachhang();
        bool themmoi;
        void khoadieukien()
        {
            txtmakh.Enabled = false;
            txttenkh.Enabled = false;
            txtdiachi.Enabled = false;
            txtsdt.Enabled = false;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btncapnhat.Enabled = false;
        }
        void modieukien()
        {
            txtmakh.Enabled = true;
            txttenkh.Enabled = true;
            txtdiachi.Enabled = true;
            txtsdt.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btncapnhat.Enabled = true;
        }
        void hienthi(string where)
        {
            DataTable dt = bus.taobang(where);
            dgvkhachhang.DataSource = dt;
        }
        void setnull()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
    
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            modieukien();
            setnull();
            themmoi = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            modieukien();
            txtmakh.Enabled = false;
            themmoi = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Makh = txtmakh.Text;
                bus.xoadulieu(ec);
                MessageBox.Show("Da xoa!");
                khoadieukien();
                setnull();
                hienthi("");
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {

            if (themmoi == true)
            {
                try
                {
                    ec.Makh = txtmakh.Text;
                    ec.Tenkh = txttenkh.Text;
                    ec.Diachi = txtdiachi.Text;
                    ec.Sdt = txtsdt.Text; ;
                    bus.themdulieu(ec);
                    MessageBox.Show("Them thanh cong!");
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
                    ec.Makh = txtmakh.Text;
                    ec.Tenkh = txttenkh.Text;
                    ec.Diachi = txtdiachi.Text;
                    ec.Sdt = txtsdt.Text; ;
                    bus.suadulieu(ec);
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
            hienthi("");
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthi("where makh like N'%" + txttimkiem.Text + "%'");
        }
        public static string mak;
        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("where makh='"+mak+"'");
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtmakh.Text = dgvkhachhang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenkh.Text = dgvkhachhang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsdt.Text = dgvkhachhang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtdiachi.Text = dgvkhachhang.Rows[e.RowIndex].Cells[3].Value.ToString();                        
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
