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
    public class BUS_khohang
    {
        SQL_khohang sql = new SQL_khohang();
        //hàm sửa
        public void suadulieu(EC_khohang et)
        {
            sql.suadulieu(et);
        }

        //hàm xóa 
        public void xoadulieu(EC_khohang et)
        {
            sql.xoadulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}
