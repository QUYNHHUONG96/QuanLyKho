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
    public class BUS_loaihang
    {
        SQL_loaihang sql = new SQL_loaihang();
        public void themdulieu(EC_loaihang et)

        {
            sql.themdulieu(et);

        }
        //hàm sửa
        public void suadulieu(EC_loaihang et)

        {
            sql.suadulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}
