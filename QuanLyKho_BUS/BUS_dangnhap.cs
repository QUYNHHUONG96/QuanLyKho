using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho_DAL;
using QuanLyKho_Entity;
using System.Data;
namespace QuanLyKho_BUS
{
    public class BUS_dangnhap
    {
        SQL_dangnhap sql = new SQL_dangnhap();
        public void kiemtra(string id, string pass)
        {
            sql.kiemtra(id,pass);
        }
        public void doimatkhau(string id, string pass, EC_dangnhap et)
        {
            sql.doimatkhau(id, pass, et);
        }
        public void themdulieu(EC_dangnhap ec)
        {
            sql.themdulieu(ec);
        }
        public void suadulieu(EC_dangnhap ec)
        {
            sql.suadulieu(ec);
        }
        public void xoadulieu(EC_dangnhap ec)
        {
            sql.xoadulieu(ec);
        }
        public DataTable taobang(string dieukien)
        {
            return sql.taobang(dieukien);
        }
    }
}
