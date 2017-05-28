using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho_Entity;
using System.Data;
namespace QuanLyKho_DAL
{
    public class SQL_chitietpx
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_chitietpx ec)
        {
            string sql = "themchitietpx";
            int so_luong = 4;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@mapx"; Values[0] = ec.Mapx;
            Name[1] = "@mahang"; Values[1] = ec.Mahang;
            Name[2] = "@soluong"; Values[2] = ec.Soluong.ToString();
            Name[3] = "@dongia"; Values[3] = ec.Dongia.ToString();
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void xoadulieu(EC_chitietpx ec)
        {
            kn.ThucThiCauLenhSQL("delete chitietphieuxuat where mapx='" + ec.Mapx + "' and mahang='" + ec.Mahang + "'");
        }
        public int kiemtra(string mapx, string mahang)
        {
            return int.Parse(kn.GetValue("select count(mapx) from chitietphieuxuat where mapx='" + mapx + "' and mahang='" + mahang + "'"));
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from chitietphieuxuat " + dieukien);
        }
    }
}
