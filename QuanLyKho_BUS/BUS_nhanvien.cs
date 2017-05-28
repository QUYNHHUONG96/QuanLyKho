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
    public class BUS_nhanvien
    {
        SQL_nhanvien sql = new SQL_nhanvien();
        public void themdulieu(EC_nhanvien et)

        {
            sql.themdulieu(et);

        }
        //hàm sửa
        public void suadulieu(EC_nhanvien et)

        {
            sql.suadulieu(et);
        }

        //hàm xóa 
        public void xoadulieu(EC_nhanvien et)
        {
            sql.xoadulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}
