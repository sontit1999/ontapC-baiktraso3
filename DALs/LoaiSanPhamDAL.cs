using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    class LoaiSanPhamDAL
    {

        SqlConnection con;
        public LoaiSanPhamDAL()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-CMEJ8G1\SQLEXPRESS;Initial Catalog=qlsp;Integrated Security=True");
        }
        public DataTable getLoaiSP()
        {
            con.Open();
            string sql = "select * from loaisanpham";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr  =  cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            return dt;
        } 
    }
}



