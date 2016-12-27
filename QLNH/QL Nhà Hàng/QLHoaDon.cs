using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
namespace QL_Nhà_Hàng
{
    public partial class QLHoaDon : Form
    {
        String cnStr;
        SqlConnection cn;
        DataSet ds;
        DataTable Orders = new DataTable();
        public QLHoaDon()
        {
            InitializeComponent();
        }

        public DataSet GetDataset(string sql)
        {
            try
            {
                cn.Open();
                
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

                //throw;
            }
            finally
            {
                cn.Close();
            }
            return null;
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            LoadMaKH();
            LoadMaNV();
          
            //string sql = "select * from HoaDon";
            //SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //Orders = ds.Tables[0];
            hienthiHD();
            
            txtMaHD.DataBindings.Add("Text", Orders, "MaHD");
            
            //comboMaNV.DataSource = ds.Tables[0]; 
            //comboMaNV.DisplayMember = "MaHD";
            //comboMaNV.ValueMember = "MaHD";



            comboMaNV.DataBindings.Add("Text", Orders, "MaNV");
            comboMaKH.DataBindings.Add("Text", Orders, "MaKH");
            dateTimePicker1.DataBindings.Add("Text", Orders, "NgayLapHD", true, DataSourceUpdateMode.OnValidation, "", "dd-MM-yyyy");
            dateTimePicker2.DataBindings.Add("Text", Orders, "NgayGiaoHang", true, DataSourceUpdateMode.OnValidation, "", "dd-MM-yyyy");
            
        }

        //private void dataGridView1_Click(object sender, EventArgs e)
        //{
        //    int index;
        //    index = dataGridView1.CurrentRow.Index;
        //    dateTimePicker1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        //    dateTimePicker2.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        //}

        private void btnLuu_Click(object sender, EventArgs e)
        {

            hienthiHD();
          
          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
       
  
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            ThemHD themHD = new ThemHD();
            themHD.Show();
            

        }

      public void hienthiHD()
        {
            string sql = "select * from HoaDon";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Orders = ds.Tables[0];
        }

      private void btmXoaHD_Click(object sender, EventArgs e)
      {
          try
          {
              cn.Open();
              
              //string xoa = "delete HoaDon where MaHD='" + comboMaNV.SelectedValue.ToString() + "'";
              string xoa = "delete HoaDon where MaHD='"+txtMaHD.Text+"'";
              SqlCommand cmdxoa = new SqlCommand(xoa, cn);
              cmdxoa.ExecuteNonQuery();
              hienthiHD();
              MessageBox.Show("Xóa Thành Công ", "Thông Báo");

          }
          catch (SqlException ex)
          {
              MessageBox.Show("Loi Xoa" + ex.Message);
          }
          finally
          {
              cn.Close();
          }
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
    

    

      private void btmSuaHD_Click_1(object sender, EventArgs e)
      {
          try
          {
              cn.Open();
              string sua = "update HoaDon set NgayLapHD='" + dateTimePicker1.Value.Date + "',NgayGiaoHang='" + dateTimePicker2.Value.Date + "', MaKH='" + comboMaKH.SelectedValue.ToString() + "' ,MaNV='" + comboMaNV.SelectedValue.ToString() + "' WHERE MaHD='" + txtMaHD.Text + "'";
              SqlCommand cmdSua = new SqlCommand(sua, cn);
              cmdSua.ExecuteNonQuery();
              hienthiHD();
              MessageBox.Show("Sửa Thành Công ", "Thông Báo");
          }
          catch (SqlException ex)
          {
              MessageBox.Show("Loi Sua" + ex.Message);
              //throw;
          }
          finally
          {
              cn.Close();
          }
      }
      int index;
      private void dataGridView1_Click_1(object sender, EventArgs e)
      {
          index = dataGridView1.CurrentRow.Index;
          txtMaHD.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
          comboMaKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
          comboMaNV.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
          dateTimePicker1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
          dateTimePicker2.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
      }

    }
}
