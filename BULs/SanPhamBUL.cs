using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BULs
{
    public class SanPhamBUL
    {
        SanPhamDAL dal = new SanPhamDAL();
       
        public List<SanPhamDTO> getSanPham()
        {
            return dal.getSanPham();
        }
        public DataTable getLoaiSP()
        {
            
            return dal.getLoaiSP();
        }
        public void addSanPham(SanPhamDTO sp)
        {
            dal.addSanPham(sp);

        }
       public void UpadateSanpham(SanPhamDTO sp)
        {
            dal.upadateSanPham(sp);
        }
        public void DeleteSanpham(string masp)
        {
            dal.deleteSanPham(masp);
        }
        public List<SanPhamDTO> findSanPham(string masp)
        {

            return dal.findSanPham(masp);

        }
    }
}
