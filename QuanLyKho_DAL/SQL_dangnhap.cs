using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho_Entity;
using System.Data;
namespace QuanLyKho_DAL
{
    public class SQL_dangnhap
    {
        ketnoi kn = new ketnoi();
        public int kiemtra(string id, string pass)
        {
            return int.Parse(kn.GetValue("select count(*) from dangnhap where username='" + id + "' and pass='" + pass + "'"));
        }
        public void doimatkhau(string id, string pass, EC_dangnhap et)
        {
            kn.ThucThiCauLenhSQL("update dangnhap set username = '"+id+"', pass = '"+pass+"' where username = '"+et.Username+"' and pass = '"+et.Pass+"'");
        }
        public int themdulieu(EC_dangnhap ec)
        {

            string sql = "themuser";
            int so_luong = 2;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@username"; Values[0] = ec.Username;
            Name[1] = "@pass"; Values[1] = ec.Pass;
            return kn.StoProc(sql, Name, Values, so_luong);
        }
        public void suadulieu(EC_dangnhap ec)
        {
            kn.ThucThiCauLenhSQL("update dangnhap set username='" + ec.Username + "', pass='"+ec.Pass+"' where ID='"+ec.Id+"'");
        }
        public void xoadulieu(EC_dangnhap ec)
        {
            kn.ThucThiCauLenhSQL("delete dangnhap where ID='" + ec.Id + "'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select * from dangnhap " + dieukien);
        }
    }
}
