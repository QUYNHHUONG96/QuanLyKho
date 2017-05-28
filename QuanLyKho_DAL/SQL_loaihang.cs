using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho_Entity;
using System.Data;
namespace QuanLyKho_DAL
{
    public class SQL_loaihang
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_loaihang ec)
        {
            string sql = "themloaihang";
            int so_luong = 3;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@maloaihang"; Values[0] = ec.Maloaihang;
            Name[1] = "@tenloaihang"; Values[1] = ec.Tenloaihang;
            Name[2] = "@chitietloaihang";Values[2] = ec.Chitietloaihang;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void suadulieu(EC_loaihang ec)
        {
            kn.ThucThiCauLenhSQL("update loaihang set tenloaihang=N'" + ec.Tenloaihang + "',chitietloaihang=N'"+ec.Chitietloaihang+"' where maloaihang='" + ec.Maloaihang + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from loaihang " + dieukien);
        }
    }
}
