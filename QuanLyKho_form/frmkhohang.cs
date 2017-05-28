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
    public partial class frmkhohang : Form
    {
        public frmkhohang()
        {
            InitializeComponent();
        }
        BUS_khohang bus = new BUS_khohang();
        EC_khohang ec = new EC_khohang();
        SQL_khohang sql = new SQL_khohang();
        bool themmoi;
        void khoadieukien()
        {
            txtgianhap.Enabled = false;
            txtgiaban.Enabled = false;
            txtmahang.Enabled = false;
            txttenhang.Enabled = false;
            txtsoluong.Enabled = false;
            cmbmaloaihang.Enabled = false;
            cmbmacc.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }
        void modieukien()
        {
            txtmahang.Enabled = true;
            txtgianhap.Enabled = true;
            txttenhang.Enabled = true;
            txtsoluong.Enabled = true;
            cmbmaloaihang.Enabled = true;
            txtgiaban.Enabled = true;
            cmbmacc.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        void hienthi(string where)
        {
            DataTable dt = bus.taobang(where);
            dgvchitietpn.DataSource = dt;
        }
        void setnull()
        {
            txtgiaban.Text = "";
            txtmahang.Text = "";
            txttenhang.Text = "";
            txtsoluong.Text = "";
            cmbmaloaihang.Text = "";
            cmbmacc.Text = "";
            txtgianhap.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BUS_nhacc bcc = new BUS_nhacc();
        BUS_loaihang bl = new BUS_loaihang();
        private void frmhanghoa_Load(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("");
            cmbmacc.DataSource = bcc.taobang("");
            cmbmacc.ValueMember = "macc";
            cmbmacc.DisplayMember = "macc";
            cmbmaloaihang.DataSource = bl.taobang("");
            cmbmaloaihang.ValueMember = "maloaihang";
            cmbmaloaihang.DisplayMember = "maloaihang";
            cmbtimLH.DataSource = bl.taobang("");
            cmbtimLH.ValueMember = "maloaihang";
            cmbtimLH.DisplayMember = "maloaihang";
        }

        private void dgvchitietpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtmahang.Text = dgvchitietpn.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttenhang.Text = dgvchitietpn.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsoluong.Text = dgvchitietpn.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtgiaban.Text = dgvchitietpn.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtgianhap.Text= dgvchitietpn.Rows[e.RowIndex].Cells[4].Value.ToString();                
                cmbmacc.Text = dgvchitietpn.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbmaloaihang.Text = dgvchitietpn.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (rdbtmahang.Checked == true)
            {
                hienthi("where mahang like N'%" + txttimkiem.Text + "%'");
            }
            if (rdbtten.Checked == true)
            {
                hienthi("where tenhang like N'%" + txttimkiem.Text + "%'");
            }
            if (rdbtmaloaihang.Checked == true)
            {
                hienthi("where maloaihang like N'%" + cmbtimLH.Text + "%'");
            }
        }

        private void btnloaihang_Click(object sender, EventArgs e)
        {
            frmloaihang frm = new frmloaihang();
            frm.ShowDialog();
        }

        private void btnnhacc_Click(object sender, EventArgs e)
        {
            frmnhacc frm = new frmnhacc();
            frm.ShowDialog();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            khoadieukien();
            txtgiaban.Enabled = true;
            txttenhang.Enabled = true;
            themmoi = false;
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                ec.Mahang = txtmahang.Text;
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

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (themmoi == false)
            {
                try
                {
                    ec.Mahang = txtmahang.Text;
                    ec.Tenhang = txttenhang.Text;
                    ec.Soluong = Convert.ToInt32(txtsoluong.Text);
                    ec.Giaxuat = Convert.ToInt32(txtgiaban.Text);
                    ec.Gianhap = Convert.ToInt32(txtgianhap.Text);
                    ec.Maloaihang = cmbmaloaihang.Text; ;
                    ec.Macc = cmbmacc.Text;
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

        private void btnnhacc_Click_1(object sender, EventArgs e)
        {
            frmnhacc.ma = cmbmacc.Text.Trim();
            frmnhacc f = new frmnhacc();
            f.Show();
        }

        private void btnLoaihang_Click_1(object sender, EventArgs e)
        {
            frmloaihang.ma = cmbmaloaihang.Text.Trim();
            frmloaihang f = new frmloaihang();
            f.ShowDialog();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            this.Hide();
            f.ShowDialog();
        }
    }
}
