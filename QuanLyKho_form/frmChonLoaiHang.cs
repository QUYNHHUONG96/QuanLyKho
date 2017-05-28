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
    public partial class frmChonLoaiHang : Form
    {
        public frmChonLoaiHang()
        {
            InitializeComponent();
        }
        BUS_khohang bus = new BUS_khohang();
        EC_khohang ec = new EC_khohang();
        SQL_khohang sql = new SQL_khohang();
        
        private void frmChonLoaiHang_Load(object sender, EventArgs e)
        {
            dgvdanhsach.DataSource = bus.taobang("");
        }

        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmahang.Text = dgvdanhsach.Rows[e.RowIndex].Cells[0].Value.ToString();                
            }
            catch
            {

            }
        }
        ketnoi kn = new ketnoi();
        private void btnChon_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(kn.GetValue("select soluong from khohang where mahang='" + txtmahang.Text + "'"));
            if (Convert.ToInt32(txtsoluong.Text) > ma)
            {
                MessageBox.Show("So luong trong kho khong du!");
            }
            else
            {
                frmphieuxuat.instance.hienthisaukhichonhang(txtmahang.Text, Convert.ToInt32(txtsoluong.Text));
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
