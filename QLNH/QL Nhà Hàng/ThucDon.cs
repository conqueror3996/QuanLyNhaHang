using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Nhà_Hàng
{
    public class ThucDon
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Donvitinh { get; set; }
        //public float Dongia { get; set; }
        public int MaLoaiSP { get; set; }
        

        //
        public ThucDon(string MaSP, string TenSP, string Donvitinh,/*float Dongia,*/ int MaLoaiSP)
        {
            this.MaSP= MaSP;
            this.TenSP = TenSP;
            this.Donvitinh = Donvitinh;
           // this.Dongia = Dongia;
            this.MaLoaiSP= MaLoaiSP;
            
        }
    }
}
