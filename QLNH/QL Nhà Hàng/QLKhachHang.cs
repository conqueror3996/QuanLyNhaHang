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
    public partial class QLKhachHang : Form
    {
        String cnStr;
        SqlConnection cn;
        public QLKhachHang()
        {
            InitializeComponent();
        }
        private void Connect()
        {
            try
            {
                string sql = "select * from KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
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
       
        private List<KhachHang> GetKhachHang(string sql)
        {
            cn.Open() ;
            List<KhachHang> list = new List<KhachHang>();
            try
            {
                //sql = "SELECT * FROM KhachHang";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                string id, name, fax, address, phone;

                while (dr.Read())
                {

                    id = dr.GetString(0);
                    name = dr.GetString(1);
                    fax = dr.GetString(2);
                    address = dr.GetString(3);
                    phone = dr.GetString(4);

                    KhachHang cust = new KhachHang(id, name, fax, address, phone);
                    list.Add(cust);
                }
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
            return list;
        }
        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            try
            {
                string sql = "SELECT * FROM KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }
       
        private void btnTim_Click_1(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM KhachHang WHERE";
            if (radMa.Checked == true)
                sql += " MaKH LIKE '%" + txtNhap.Text + "%'";
            else 
                sql += " TenKH LIKE  '%" + txtNhap.Text + "%'";
           
            dataGridView1.DataSource = GetKhachHang(sql);
        }

        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            txtMaKH.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtDienThoai.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtFax.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            //Connect();
            //List<KhachHang> list = new List<KhachHang>();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Form_Main form2 = new Form_Main();
                form2.ShowDialog();
                this.Close();
            
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            
             try
            {
                cn.Open();
                string Insert = "Insert into KhachHang(MaKH, TenKH, DiaChi, DienThoai, Fax) values('" + txtMaKH.Text + "','" + txtTen.Text +"','" +txtDiaChi.Text + "','" + txtDienThoai.Text + "','" + txtFax.Text+ "')";
                SqlCommand cmdadd = new SqlCommand(Insert, cn);
                
                cmdadd.ExecuteNonQuery();
                Connect();
                MessageBox.Show("Them Thanh Cong ", "Thông Báo");
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
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            try
            {
                cn.Open();
                string Delete = "Delete KhachHang WHERE TenKH ='" + txtTen.Text + "'";
                SqlCommand cmddel = new SqlCommand(Delete, cn);
                
                cmddel.ExecuteNonQuery();
                Connect();
                MessageBox.Show("Xóa Thành Công ", "Thông Báo");

                

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi Xoa", "Thông Báo\n" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string Update = "update KhachHang set TenKH ='" + txtTen.Text + "',DiaChi='" + txtDiaChi.Text + "',DienThoai='" + txtDienThoai.Text + "',Fax='" + txtFax.Text + "' where MaKH='" + txtMaKH.Text + "'";
                SqlCommand cmdUpdate = new SqlCommand(Update, cn);
                
                cmdUpdate.ExecuteNonQuery();
                Connect();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "select * from KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            radMa.Checked = false;
            radTen.Checked = false;
            txtNhap.Text = " ";
        }

       
        

        
    }
}
