using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    class LoaiSanPhamDTO
    {

        public string Maloai { get; set; }
        public string Tenloai { get; set; }
        public LoaiSanPhamDTO()
        {

        }
        public LoaiSanPhamDTO(string ml, string tl)
        {
            this.Maloai = ml;
            this.Tenloai = tl;
        }
    }
}
