using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho_Entity;
using System.Data;
namespace QuanLyKho_DAL
{
    public class SQL_phieuxuat
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_phieuxuat ec)
        {
            string sql = "thempx";
            int so_luong = 4;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@mapx"; Values[0] = ec.Mapx;
            Name[1] = "@ngayxuat"; Values[1] = ec.Ngayxuat.ToString();
            Name[2] = "@manv"; Values[2] = ec.Manv;
            Name[3] = "@makh"; Values[3] = ec.Makh;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public int xoadulieu(EC_phieuxuat ec)
        {
            string sql = "xoaphieuxuat";
            int so_luong = 1;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@mapx"; Values[0] = ec.Mapx;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void suadulieu(EC_phieuxuat ec)
        {
            kn.ThucThiCauLenhSQL("update phieuxuat set ngayxuat='" + ec.Ngayxuat + "',manv='" + ec.Manv + "',makh='" + ec.Makh + "' where mapx='" + ec.Mapx + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from phieuxuat " + dieukien);
        }
    }
}
