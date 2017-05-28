using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKho_DAL
{
    public class ketnoi
    {
        public static SqlConnection connect;

        // Mở kết nối 
        public static void MoKetNoi()
        {
            if (ketnoi.connect == null)
                ketnoi.connect = new SqlConnection(@"Data Source=ADMINS\SQLEXPRESS;Initial Catalog=QuanLyKho;Integrated Security=True");
            if (ketnoi.connect.State != ConnectionState.Open)
                ketnoi.connect.Open();
        }

        // Đóng kết nối
        public static void DongKetNoi()
        {
            if (ketnoi.connect.State != null)
            {
                if (ketnoi.connect.State == ConnectionState.Open)
                {
                    ketnoi.connect.Close();
                }
            }
        }

        // Hàm để thực thi các câu lệnh sql : insert, update, delete 
        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery(); // không trả về gì hết
                DongKetNoi();
            }
            catch { }
        }
        public DataTable GetDataTable(string strSQL)  // truyền vào câu lệnh select
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }

            catch
            {
                return null;
            }
        }

        // 
        public string GetValue(string strSQL) //select
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            // sqlcmd cho ta 1 table, hàm có tác dụng khi ta select 1 cái đơn trị
            // 0,1,2,3.. là chỉ số của các trường.
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString(); // 0 là chỉ số, trường thứ 0
            DongKetNoi();
            return temp;
        }

        public int StoProc(string sql, string []name, object []values,int so_luong)
        {
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(sql,connect);
                cmd.CommandType = CommandType.StoredProcedure;
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                for(int i=0; i<so_luong; i++)
                {
                    cmd.Parameters.AddWithValue(name[i], values[i]);
                }
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                return 0;
            }
        }
    }
}
