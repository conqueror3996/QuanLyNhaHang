using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Nhà_Hàng
{
    public class KhachHang
    {
         public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Fax { get; set; }

        //
        public KhachHang(string id, string name, string Fax, string address, string phone)
        {
            this.MaKH = id;
            this.TenKH = name;
            this.DiaChi = address;
            this.DienThoai = phone;
            this.Fax = Fax;
        }
    }
}
