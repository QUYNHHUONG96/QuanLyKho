using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho_Entity;
using System.Data;
namespace QuanLyKho_DAL
{
    public class SQL_khohang
    {
        ketnoi kn = new ketnoi();
        public void xoadulieu(EC_khohang ec)
        {
            kn.ThucThiCauLenhSQL("delete khohang where mahang='" + ec.Mahang + "'");
        }
        public void suadulieu(EC_khohang ec)
        {
            kn.ThucThiCauLenhSQL("update khohang set tenhang=N'" + ec.Tenhang + "',soluong='" + ec.Soluong + "',gianhap='" + ec.Gianhap + "',giaxuat='"+ec.Giaxuat+"',macc='" + ec.Macc + "',maloaihang='" + ec.Maloaihang + "' where mahang='" + ec.Mahang + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from khohang " + dieukien);
        }
    }
}
