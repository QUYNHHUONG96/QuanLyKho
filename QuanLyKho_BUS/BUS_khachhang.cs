using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKho_Entity;
using QuanLyKho_DAL;
namespace QuanLyKho_BUS
{
    public class BUS_khachhang
    {
        SQL_khachhang sql = new SQL_khachhang();
        public void themdulieu(EC_khachhang et)

        {
            sql.themdulieu(et);

        }
        //hàm sửa
        public void suadulieu(EC_khachhang et)

        {
            sql.suadulieu(et);
        }

        //hàm xóa 
        public void xoadulieu(EC_khachhang et)
        {
            sql.xoadulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}
