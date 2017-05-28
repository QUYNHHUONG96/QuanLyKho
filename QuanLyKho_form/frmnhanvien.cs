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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }
        EC_nhanvien ec = new EC_nhanvien();
        BUS_nhanvien bus = new BUS_nhanvien();
        SQL_nhanvien sql = new SQL_nhanvien();
        bool themmoi;
        void khoadieukien()
        {
            txtmanv.Enabled = false;
           // cmbmacv.Enabled = false;
            txttennv.Enabled = false;
            datengaysinh.Enabled = false;
            txtsdt.Enabled = false;
            txtdiachi.Enabled = false;
           // txtmathukho.Enabled = false;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btncapnhat.Enabled = false;
        }
        void modieukien()
        {
            txtmanv.Enabled = true;
            //cmbmacv.Enabled = true;
            txttennv.Enabled = true;
            datengaysinh.Enabled = true;
            txtsdt.Enabled = true;
            txtdiachi.Enabled = true;
           // txtmathukho.Enabled = true;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btncapnhat.Enabled = true;
        }
        void setnull()
        {
            txtmanv.Text = "";
            //cmbmacv.Text = "";
            txttennv.Text = "";
            txtsdt.Text = "";
            txtdiachi.Text = "";
            //txtmathukho.Text = "";
        }
        void hienthi(string where)
        {
            dgvnhanvien.DataSource = bus.taobang(where);
        }
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("");
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
            txtmanv.Enabled = false;
            themmoi = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Manv = txtmanv.Text;
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
                    ec.Manv = txtmanv.Text;
              //      ec.Macv = cmbmacv.Text;
                    ec.Tennv = txttennv.Text;
                    ec.Ngaysinh = Convert.ToDateTime(datengaysinh.Text);
                    ec.Sdt = txtsdt.Text;
                    ec.Diachi = txtdiachi.Text;
              //      ec.Mathukho = txtmathukho.Text;
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
                    ec.Manv = txtmanv.Text;
                //    ec.Macv = cmbmacv.Text;
                    ec.Tennv = txttennv.Text;
                    ec.Ngaysinh = Convert.ToDateTime(datengaysinh.Text);
                    ec.Sdt = txtsdt.Text;
                    ec.Diachi = txtdiachi.Text;
                //    ec.Mathukho = txtmathukho.Text;
                  //  ec.Macv = cmbmacv.Text;
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

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            khoadieukien();
            try
            {
                txtmanv.Text = dgvnhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                //cmbmacv.Text = dgvnhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txttennv.Text = dgvnhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                datengaysinh.Text = dgvnhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtsdt.Text = dgvnhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtdiachi.Text = dgvnhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                //txtmathukho.Text = dgvnhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();    
            }
            catch
            {

            }
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            modieukien();
            hienthi("where tennv like N'%" + txttimkiem.Text + "%'");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            frmmain f = new frmmain();
            this.Hide();
            f.ShowDialog();
        }

        private void btnxemdanhsach_Click(object sender, EventArgs e)
        {
            khoadieukien();
            hienthi("");
        }
    }
}
