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
    public class BUS_phieuxuat
    {
        SQL_phieuxuat sql = new SQL_phieuxuat();
        public void themdulieu(EC_phieuxuat et)

        {
            sql.themdulieu(et);

        }
        //hàm sửa
        public void suadulieu(EC_phieuxuat et)

        {
            sql.suadulieu(et);
        }

        //hàm xóa 
        public void xoadulieu(EC_phieuxuat et)
        {
            sql.xoadulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}
