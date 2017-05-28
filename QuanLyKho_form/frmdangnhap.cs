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
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void rdocheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rdocheck.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
        BUS_dangnhap bus = new BUS_dangnhap();
        SQL_dangnhap sql = new SQL_dangnhap();
        EC_dangnhap ec = new EC_dangnhap();
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (sql.kiemtra(txtname.Text,txtpass.Text)==0)
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau!");
            }
            else
            {
                frmmain frm = new frmmain();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            frmdoimk frm = new frmdoimk();
            frm.ShowDialog();
        }

        private void frmdangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
