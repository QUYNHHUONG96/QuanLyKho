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
    public class BUS_chitietpn
    {
        SQL_chitietpn sql = new SQL_chitietpn();
        public void themdulieu(EC_chitietpn et)

        {
            sql.themdulieu(et);

        }
        public void suadulieu(EC_chitietpn ec)
        {
            sql.suadulieu(ec);
        }
        public void xoadulieu(EC_chitietpn ec)
        {
            sql.xoadulieu(ec);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}
