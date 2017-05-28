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
    public class BUS_nhacc
    {
        SQL_nhacc sql = new SQL_nhacc();
        public void themdulieu(EC_nhacc et)

        {
            sql.themdulieu(et);

        }
        //hàm sửa
        public void suadulieu(EC_nhacc et)

        {
            sql.suadulieu(et);
        }

        //hàm xóa 
        public void xoadulieu(EC_nhacc et)
        {
            sql.xoadulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}
