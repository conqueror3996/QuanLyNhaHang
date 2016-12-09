using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace QL_Nhà_Hàng
{
    public partial class Form_Thêm : Form
    {
        public Form_Thêm()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        string cnStr;
    
        private void connect()
        {
            try
            {
                string sql = "select * from NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi Ket Noi" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }         
        string insert;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtHo.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Ban Chưa Nhập Thong Tin Khach Hang", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else
            {
                cn.Open();
                insert = "Insert into NhanVien(HoNV,Ten,DiaChi,DienThoai) values(N'" + txtHo.Text + "',N'" + txtTen.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "')";
                SqlCommand cmdthem = new SqlCommand(insert, cn);
                cmdthem.ExecuteNonQuery();
                connect();
                MessageBox.Show("Them Thanh Cong ", "Thông Báo");
            }
        }

        private void Form_Thêm_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            connect();
        }
        private void hienThiGirdView(string sql)
        {
            //string sql = "select * from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void btmQuayLai_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //QLNhanVien form3 = new QLNhanVien();
            //form3.ShowDialog();
            //this.Close();
            this.Close();
        
        }
       
    
       

     
    }
}
