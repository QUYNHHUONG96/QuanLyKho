using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho_Entity;
using System.Data;
namespace QuanLyKho_DAL
{
    public class SQL_chitietpn
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_chitietpn ec)
        {
            string sql = "themchitietpn";
            int so_luong = 8;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@macc"; Values[0] = ec.Macc;
            Name[1] = "@mapn"; Values[1] = ec.Mapn;
            Name[2] = "@SLtheoLT"; Values[2] = ec.SltheoLT.ToString();
            Name[3] = "@maloaihang"; Values[3] = ec.Maloaihang;
            Name[4] = "@SLthuc"; Values[4] = ec.SlThuc.ToString();
            Name[5] = "@dongia"; Values[5] = ec.Dongia.ToString();
            Name[6] = "@thanhtien"; Values[6] = ec.Thanhtien.ToString();
            Name[7] = "@tenhang"; Values[7] = ec.Tenhang;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void suadulieu(EC_chitietpn ec)
        {
            kn.ThucThiCauLenhSQL("update chitietphieunhap set SLthuc='" + ec.SlThuc + "',SLtheoLT='" + ec.SltheoLT + "',dongia='" + ec.Dongia + "',thanhtien='" + ec.Thanhtien + "' where mapn='" + ec.Mapn + "' and macc='" + ec.Macc + "' and maloaihang='" + ec.Maloaihang + "' and tenhang=N'" + ec.Tenhang + "'");
        }
        public void xoadulieu(EC_chitietpn ec)
        {
            kn.ThucThiCauLenhSQL("delete chitietphieunhap where mapn='" + ec.Mapn + "' and macc='" + ec.Macc + "' and maloaihang='" + ec.Maloaihang + "' and tenhang='" + ec.Tenhang + "'");
        }
        public int kiemtra(string mapn, string maloaihang, string macc, string ten)
        {
            return int.Parse(kn.GetValue("select count(mapn) from chitietphieunhap where mapn='"+mapn+"' and macc='"+macc+"' and maloaihang='"+maloaihang+"' and tenhang=N'"+ten+"'"));
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from chitietphieunhap " + dieukien);
        }
    }
}
