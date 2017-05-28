using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho_Entity;
using System.Data;
namespace QuanLyKho_DAL
{
    public class SQL_khachhang
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_khachhang ec)
        {
            string sql = "themkh";
            int so_luong = 4;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@makh"; Values[0] = ec.Makh;
            Name[1] = "@tenkh"; Values[1] = ec.Tenkh;
            Name[2] = "@sdt"; Values[2] = ec.Sdt;
            Name[3] = "@diachi"; Values[3] = ec.Diachi;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void xoadulieu(EC_khachhang ec)
        {
            kn.ThucThiCauLenhSQL("delete khachhang where makh='" + ec.Makh + "'");
        }
        public void suadulieu(EC_khachhang ec)
        {
            kn.ThucThiCauLenhSQL("update khachhang set tenkh=N'" + ec.Tenkh + "',sdt='" + ec.Sdt + "',diachi=N'" + ec.Diachi + "' where makh='" + ec.Makh + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from khachhang " + dieukien);
        }
    }
}
