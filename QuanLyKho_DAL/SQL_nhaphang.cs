using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho_Entity;
using System.Data;
namespace QuanLyKho_DAL
{
    public class SQL_nhaphang
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_nhaphang ec)
        {
            string sql = "thempn";
            int so_luong = 3;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@mapn"; Values[0] = ec.Mapn;
            Name[1] = "@ngaynhap"; Values[1] = ec.Ngaynhap.ToString();
            Name[2] = "@manv"; Values[2] = ec.Manv;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public int xoadulieu(EC_nhaphang ec)
        {
            string sql = "xoaphieunhap";
            int so_luong = 1;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@mapn"; Values[0] = ec.Mapn;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from phieunhap " + dieukien);
        }
    }
}
