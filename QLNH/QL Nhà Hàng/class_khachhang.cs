using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace QL_Nhà_Hàng
{
    public class class_khachhang
    {        
        SqlConnection cn;

        public void them(string makh, string ten, string diachi, string dienthoai, string fax)
        {
            String cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            cn.Open();
            string Insert = "Insert into KhachHang(MaKH, TenKH, DiaChi, DienThoai, Fax) values('" + makh + "','" + ten + "','" + diachi + "','" + dienthoai + "','" + fax + "')";
            SqlCommand cmdadd = new SqlCommand(Insert, cn);
            cmdadd.ExecuteNonQuery();
        }
        public void xoa(string ten)
        {
            String cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            cn.Open();
            string Delete = "Delete KhachHang WHERE TenKH ='" + ten + "'";
            SqlCommand cmddel = new SqlCommand(Delete, cn);
            cmddel.ExecuteNonQuery();
        }
        public void sua(string makh, string ten, string diachi, string dienthoai, string fax)
        {
            String cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            cn.Open();
            string Update = "update KhachHang set TenKH ='" + ten + "',DiaChi='" + diachi + "',DienThoai='" + dienthoai + "',Fax='" + fax + "' where MaKH='" + makh + "'";
            SqlCommand cmdUpdate = new SqlCommand(Update, cn);
            cmdUpdate.ExecuteNonQuery();
        }
        public bool kiemtra(string makh, string ten, string diachi, string dienthoai, string fax)
        {
            if (makh.Length == 0 || ten.Length == 0 || diachi.Length == 0 || dienthoai.Length == 0 || fax.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
