using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QL_Nhà_Hàng
{
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        string cnStr=" ";
        private void Form1_Load(object sender, EventArgs e)
        {
            //cnStr = "Server=X451\\SQLEXPRESS; Database=QLBanHang; Integrated Security=True;";
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
            dataGridView1.DataSource = ds.Tables[0];  
        }
        private void connect()
        {
          try
            {
                string sql = "select * from NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi Ket Noi"+ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }         
       int index;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //click vào dataGirdView nó sẽ hiện thông tin lên các ột tương ứng trong texBox.
            index = dataGridView1.CurrentRow.Index;
            txtMaNV.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtHo.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }
        
        private void btbThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form_Thêm formthem = new Form_Thêm();
                formthem.ShowDialog();                    
               
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi Them", "Thong Bao" + ex.Message);
               
            }
            finally
            {
                cn.Close();
            }
        }
        string xoa;
        private void btmXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();               
                xoa="delete NhanVien WHERE MaNV ="+txtMaNV.Text+"";
                SqlCommand cmdxoa = new SqlCommand(xoa, cn);
                cmdxoa.ExecuteNonQuery();
                connect();
                MessageBox.Show("Xoa Thanh Cong ", "Thông Báo");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi Xoa","thong Bao\n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        string update;
     
        private void btmSua_Click(object sender, EventArgs e)
        {      
            try
            {
                cn.Open();
                update = "update Nhanvien set HoNV =N'"+txtHo.Text+"',Ten=N'"+txtTen.Text+"',Diachi=N'"+txtDiaChi.Text+"',Dienthoai='"+txtSDT.Text+"' where MaNV='" + txtMaNV.Text + "'";
                SqlCommand cmdUpdate = new SqlCommand(update, cn);
                cmdUpdate.ExecuteNonQuery();
                connect();
                MessageBox.Show("Sua Thanh Cong ", "Thông Báo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi Sua", "thong Bao\n" + ex.Message);
            
            }
            finally
            {
                cn.Close();
            }
           
        }

        private void btmThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = new DialogResult();
            thoat = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();

            }
               
          
           
        }
        string tim;
        private void bmtSearch_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                if (radioMa.Checked==true)
                {
                    tim = "select * from NhanVien WHERE MaNV =" + txtSearch.Text + "";
                    SqlCommand cmdTim = new SqlCommand(tim, cn);
                    cmdTim.ExecuteNonQuery();
                    hienThiGirdView(tim);
                }
                else
                    if (radioHo.Checked==true)
                    {
                        tim = "select * from NhanVien WHERE HoNV LIKE  '%" + txtSearch.Text + "%'";
                        SqlCommand cmdTim = new SqlCommand(tim, cn);
                        cmdTim.ExecuteNonQuery();
                        hienThiGirdView(tim);
                    }
                    else
                        if(radioTen.Checked==true)
                        {
                            tim = "select * from NhanVien WHERE Ten LIKE  '%" + txtSearch.Text + "%'";
                            SqlCommand cmdTim = new SqlCommand(tim, cn);
                            cmdTim.ExecuteNonQuery();
                            hienThiGirdView(tim);
                        }
                       
              

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Loi Tim\n"+ex.Message);
            }
            finally
            {
                cn.Close();
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            radioHo.Checked = false;
            radioMa.Checked = false;
            radioTen.Checked = false;
            txtSearch.Text = " ";

        }

     

        private void btmTroVe_Click_1(object sender, EventArgs e)
        {
         
            this.Close();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string sql = "select * from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            radioHo.Checked = false;
            radioMa.Checked = false;
            radioTen.Checked = false;
            txtSearch.Text = " ";

        }

       

  

    
   
       
    }
}
