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
    public class BUS_chitietpx
    {
        SQL_chitietpx sql = new SQL_chitietpx();
        public void themdulieu(EC_chitietpx et)
        {
            sql.themdulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
        public void xoadulieu(EC_chitietpx et)
        {
            sql.xoadulieu(et);
        }
    }
}
