using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{

    public class SanPhamDAL
    {
        SqlConnection con;
        public SanPhamDAL()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-CMEJ8G1\SQLEXPRESS;Initial Catalog=qlsp;Integrated Security=True");
        }
        public List<SanPhamDTO> getSanPham()
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            string sql = "select * from sanpham";
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SanPhamDTO sp = new SanPhamDTO(dr["masp"].ToString(), dr["tensp"].ToString(), Convert.ToInt32(dr["soluong"]), Convert.ToInt32(dr["dongia"]), dr["maloai"].ToString());
                list.Add(sp);
            }


            con.Close();
            return list;
        }
        public void addSanPham(SanPhamDTO sp)
        {
            con.Open();

            string sql = "insert into sanpham values(@msp, @tsp, @sl, @dg, @ml)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("msp", sp.Masp);
            cmd.Parameters.AddWithValue("tsp", sp.Tensp);
            cmd.Parameters.AddWithValue("sl", sp.Soluong);
            cmd.Parameters.AddWithValue("dg", sp.Dongia);
            cmd.Parameters.AddWithValue("ml", sp.Maloai);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable getLoaiSP()
        {
            con.Open();
            string sql = "select * from loaisanpham";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;
        }
        public void upadateSanPham(SanPhamDTO sp)
        {
            con.Open();
            string sql = "update sanpham set tensp = @tsp,soluong = @sl, dongia = @dg, maloai = @ml where masp = @msp ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("msp", sp.Masp);
            cmd.Parameters.AddWithValue("tsp", sp.Tensp);
            cmd.Parameters.AddWithValue("sl", sp.Soluong);
            cmd.Parameters.AddWithValue("dg", sp.Dongia);
            cmd.Parameters.AddWithValue("ml", sp.Maloai);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void deleteSanPham(String msp)
        {
            con.Open();
            string sql = "delete from sanpham where masp = @msp ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("msp", msp);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<SanPhamDTO> findSanPham(string masp)
        {
            con.Open();
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            string sql = "select * from sanpham where masp = @msp";
            

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("msp", masp);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SanPhamDTO sp = new SanPhamDTO(dr["masp"].ToString(), dr["tensp"].ToString(), Convert.ToInt32(dr["soluong"]), Convert.ToInt32(dr["dongia"]), dr["maloai"].ToString());
                list.Add(sp);
            }


            con.Close();
            return list;

        }
    }
}
