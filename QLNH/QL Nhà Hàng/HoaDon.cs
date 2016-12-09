using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Nhà_Hàng
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public int MaNV { get; set; }
        public DateTime NgayLapHD { get; set; }
        public DateTime NgayGiaoHang { get; set; }

        //
        public HoaDon(string mahd, string makh, int manv, DateTime ngaylaphd, DateTime ngaygiaohang)
        {
            this.MaHD = mahd;
            this.MaKH = makh;
            this.MaNV = manv ;
            this.NgayLapHD = ngaylaphd;
            this.NgayGiaoHang = ngaygiaohang;
        }
    }
}
