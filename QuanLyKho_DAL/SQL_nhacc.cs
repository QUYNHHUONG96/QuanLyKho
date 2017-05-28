using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKho_Entity;
namespace QuanLyKho_DAL
{
    public class SQL_nhacc
    {

        ketnoi kn = new ketnoi();
        public int themdulieu(EC_nhacc ec)
        {
            string sql = "themnhacc";
            int so_luong = 5;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@macc"; Values[0] = ec.Macc;
            Name[1] = "@tencc"; Values[1] = ec.Tencc;
            Name[2] = "@diachi"; Values[2] = ec.Diachi;
            Name[3] = "@sdt"; Values[3] = ec.Sdt;
            Name[4] = "@nuocsx"; Values[4] = ec.Nuocsx;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void xoadulieu(EC_nhacc ec)
        {
            kn.ThucThiCauLenhSQL("delete nhacc where macc='" + ec.Macc + "'");
        }
        public void suadulieu(EC_nhacc ec)
        {
            kn.ThucThiCauLenhSQL("update nhacc set tencc=N'" + ec.Tencc + "',sdt='" + ec.Sdt + "',diachi=N'" + ec.Diachi + "',nuocsx=N'" + ec.Nuocsx + "' where macc='" + ec.Macc + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from nhacc " + dieukien);
        }
    }
}
