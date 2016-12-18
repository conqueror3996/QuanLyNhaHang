using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Nhà_Hàng
{
    public partial class ThemHD : Form
    {
        public ThemHD()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        string cnStr;
        SqlConnection cn;
        private void ThemHD_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            //lấy du lieu tu combo box MANV, MaKH
            LoadMaNV();
            LoadMaKH();
            hienThiHD();

            string sql = "select * from HoaDon";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            //Orderss = ds.Tables[0];

            dateTime1.DataBindings.Add("Text", ds.Tables[0], "NgayLapHD", true, DataSourceUpdateMode.OnValidation, "", "dd-MM-yyyy");
            dateTime2.DataBindings.Add("Text", ds.Tables[0], "NgayGiaoHang", true, DataSourceUpdateMode.OnValidation, "", "dd-MM-yyyy");

        }
        private void hienThiHD()
        {
            string sql = "select * from HoaDon";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    
        public void LoadMaKH()
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            cn.Open();
            string strCmd = "select MaKH from KhachHang";
            SqlCommand cmd = new SqlCommand(strCmd, cn);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboMaKH.DataSource = dt;
            comboMaKH.DisplayMember = "MaKH";
            comboMaKH.ValueMember = "MaKH";
            comboMaKH.Enabled = true;
            cmd.ExecuteNonQuery();
            cn.Close();

        }
        public void LoadMaNV()
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            cn.Open();
            string sql = "select MaNV from Nhanvien";
            SqlCommand cmdd = new SqlCommand(sql, cn);
            SqlDataAdapter daa = new SqlDataAdapter(sql, cn);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);

            comboMaNV.DataSource = dtt;
            comboMaNV.DisplayMember = "MaNV";
            comboMaNV.ValueMember = "MaNV";
            comboMaNV.Enabled = true;
        
            cmdd.ExecuteNonQuery();
            cn.Close();

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                   if (comboMaKH.Text == "" || comboMaNV.Text == "" || txtMaHD.Text == "")
                {
                    MessageBox.Show("Ban Chưa Nhập Thong Tin Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {   

                    string insert = "insert into HoaDon(MaHD,MaKH,MaNV,NgayLapHD,NgayGiaoHang) values ('" + txtMaHD.Text + "','" + comboMaKH.SelectedValue.ToString() + "','" + comboMaNV.SelectedValue.ToString() + "','" + dateTime1.Text + "','" + dateTime2.Text + "')";
                    SqlCommand cmdthem = new SqlCommand(insert, cn);
                    cn.Open();
                    cmdthem.ExecuteNonQuery();
                    hienThiHD();
                    MessageBox.Show("Them Thanh Cong ", "Thông Báo");
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("lỗi Thêm Dữ liệu\n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
               

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
          
            
        }


        private void dateTime1_Validating_1(object sender, CancelEventArgs e)
        {
            DateTime dateValue;

            if (!String.IsNullOrEmpty(dateTime1.Text))
            {
                if (DateTime.TryParseExact(dateTime1.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue))
                    dateTime1.Text = String.Format("{0:dd/MM/yyyy}", dateValue);
            }
        }

        private void dateTime2_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateValue2;

            if (!String.IsNullOrEmpty(dateTime2.Text))
            {
                if (DateTime.TryParseExact(dateTime2.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateValue2))
                    dateTime2.Text = String.Format("{0:dd/MM/yyyy}", dateValue2);
            }
        }

       
       
    }
}
