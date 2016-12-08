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
        public HoaDon(string MaHD, string MaKH, int MaNV, DateTime NgayLapHD, DateTime NgayGiaoHang)
        {
            this.MaHD = MaHD;
            this.MaKH = MaKH;
            this.MaNV = MaNV ;
            this.NgayLapHD = NgayLapHD;
            this.NgayGiaoHang = NgayGiaoHang;
        }
    }
}
