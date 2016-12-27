using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Nhà_Hàng
{
    public class Ban
    {
           public string MaBan { get; set; }
        public string TenKhuVuc { get; set; }
        public string TenBan { get; set; }
        public string ChiTiet { get; set; }
        public string TrangThaiBan { get; set; }

        //
        public Ban(string MaBan, string TenKhuVuc, string TenBan, string ChiTiet, string TrangThaiBan)
        {
            this.MaBan = MaBan;
            this.TenKhuVuc = TenKhuVuc;
            this.TenBan = TenBan;
            this.ChiTiet = ChiTiet;
            this.TrangThaiBan = TrangThaiBan;
        }
    }
}
