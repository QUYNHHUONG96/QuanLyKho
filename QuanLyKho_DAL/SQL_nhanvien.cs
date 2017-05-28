using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKho_Entity;
using System.Data;
namespace QuanLyKho_DAL
{
    public class SQL_nhanvien
    {
        ketnoi kn = new ketnoi();
        public int themdulieu(EC_nhanvien ec)
        {
            string sql = "themnv";
            int so_luong = 5;
            string[] Name = new string[so_luong];
            object[] Values = new string[so_luong];
            Name[0] = "@manv"; Values[0] = ec.Manv;
            
            Name[1] = "@tennv"; Values[1] = ec.Tennv;
            Name[2] = "@ngaysinh"; Values[2] = ec.Ngaysinh.ToString();
            Name[3] = "@sdt"; Values[3] = ec.Sdt;
            Name[4] = "@diachi"; Values[4] = ec.Diachi;
            return kn.StoProc(sql,Name,Values,so_luong);
            }
        public void xoadulieu(EC_nhanvien ec)
        {
            kn.ThucThiCauLenhSQL("delete nhanvien where manv='" + ec.Manv + "'");
        }
        public void suadulieu(EC_nhanvien ec)
        {
            kn.ThucThiCauLenhSQL("update nhanvien set tennv=N'"+ec.Tennv+"',ngaysinh='"+ec.Ngaysinh+"',sdt='"+ec.Sdt+"',diachi=N'"+ec.Diachi+"' where manv='"+ec.Manv+"'");
        }
        public DataTable taobang(string dieukien)
        {
            return kn.GetDataTable("select* from nhanvien " + dieukien);
        }
    }
}
 