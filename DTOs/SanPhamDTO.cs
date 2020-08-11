using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SanPhamDTO
    {
        string masp;
        string tensp;
        int soluong;
        int dongia;
        string maloai;

        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongia { get => dongia; set => dongia = value; }
        public string Maloai { get => maloai; set => maloai = value; }
        public SanPhamDTO()
        {

        }
        public SanPhamDTO(string msp, string tsp, int sl, int dg,string ml)
        {
            this.tensp = tsp;
            this.masp = msp;
            this.dongia = dg;
            this.soluong = sl;
            this.maloai = ml;
        }
    }
}
