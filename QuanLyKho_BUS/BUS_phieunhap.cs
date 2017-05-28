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
    public class BUS_nhaphang
    {
        SQL_nhaphang sql = new SQL_nhaphang ();
        public void themdulieu(EC_nhaphang et)

        {
            sql.themdulieu(et);

        }
        //hàm xóa 
        public void xoadulieu(EC_nhaphang et)
        {
            sql.xoadulieu(et);
        }
        public DataTable taobang(string DieuKien)
        {
            return sql.taobang(DieuKien);
        }
    }
}
