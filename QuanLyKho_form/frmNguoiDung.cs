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
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }
        BUS_dangnhap bus = new BUS_dangnhap();
        SQL_dangnhap sql = new SQL_dangnhap();
        EC_dangnhap ec = new EC_dangnhap();
        void khoadieukien()
        {
            txtid.Enabled = false;
            txtpass.Enabled = false;
            txtusername.Enabled = false;
            btncapnhat.Enabled = false;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
        }
        void xoadieukien()
        {
            txtid.Enabled = false;
            txtpass.Enabled = true;
            txtusername.Enabled = true;
            btncapnhat.Enabled = true;
            btnsua.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
        }
        void hienthi(string dieukien)
        {
            dgvloaihang.DataSource = bus.taobang(dieukien);
        }
        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            hienthi("");
            khoadieukien();
        }
        bool themmoi;
        private void btnthem_Click(object sender, EventArgs e)
        {
            xoadieukien();
            themmoi = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            xoadieukien();
            themmoi = false;
        }
        void setnull()
        {
            txtid.Text = "";
            txtpass.Text = "";
            txtusername.Text = "";
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Id = Convert.ToInt32(txtid.Text);
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
                    ec.Pass = txtpass.Text;
                    ec.Username = txtusername.Text;
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
                    ec.Id = Convert.ToInt32(txtid.Text);
                    ec.Pass = txtpass.Text;
                    ec.Username = txtusername.Text;
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            this.Hide();
            f.ShowDialog();
        }

        private void dgvloaihang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtusername.Text = dgvloaihang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtpass.Text = dgvloaihang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtid.Text = dgvloaihang.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
