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
    public partial class QLThucDon : Form
    {
        
        public QLThucDon()
        {
            InitializeComponent();
        }
        string cnStr = " ";
        SqlConnection cn;
        private void Connect()
        {
            try
            {
                string sql = "select * from ThucDon";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ket Noi Khong Thanh Cong" + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        } 
        private void QLMonAn_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            Connect();
            try
            {
                string sql = "SELECT * FROM ThucDon";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            txtMaSP.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtDonvitinh.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtDongia.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtLoaiSP.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();

        }
        private void hienThiGirdView(string sql)
        {
            
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        string tim;
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                if (radMa.Checked == true)
                {
                    tim = "select * from ThucDon WHERE MaSP LIKE  '%" + txtNhap.Text + "%'";
                    SqlCommand cmdTim = new SqlCommand(tim, cn);
                    cmdTim.ExecuteNonQuery();
                    hienThiGirdView(tim);

                }
                else if (radLoai.Checked == true)
                    {
                        tim = "select * from ThucDon WHERE MaLoaiSP LIKE  '%" + txtNhap.Text + "%'";
                        SqlCommand cmdTim = new SqlCommand(tim, cn);
                        cmdTim.ExecuteNonQuery();
                        hienThiGirdView(tim);
                    }
                else
                       
                        {
                            tim = "select * from ThucDon WHERE TenSP LIKE  '%" + txtNhap.Text + "%'";
                            SqlCommand cmdTim = new SqlCommand(tim, cn);
                            cmdTim.ExecuteNonQuery();
                            hienThiGirdView(tim);
                        }
                       
              
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi Tim\n"+ex.Message);
                throw;
            }
            finally
            {
                cn.Close();
            }
            
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string Insert = "Insert into ThucDon(MaSP, TenSP, MaLoaiSP, Dongia, Donvitinh) values('" + txtMaSP.Text + "','" + txtTenSP.Text + "','" + txtLoaiSP.Text + "','" + txtDongia.Text + "','" + txtDonvitinh.Text + "')";
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
                string Delete = "Delete ThucDon WHERE TenSP ='" + txtTenSP.Text + "'";
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
                string Update = "update ThucDon set MaSP ='" + txtMaSP.Text + "',TenSP='" + txtTenSP.Text + "',Dongia='" + txtDongia.Text + "' where MaSP='" + txtMaSP.Text + "'";
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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sql = "select * from ThucDon";
            hienThiGirdView(sql);
            radMa.Checked = false;
            radLoai.Checked = false;
            radTen.Checked = false;
            txtNhap.Text = " ";
            txtMaSP.Text = " ";
            txtTenSP.Text = " ";
            txtDonvitinh.Text = " ";
            txtDongia.Text = " ";
            txtLoaiSP.Text = " ";
        }

       
        
    }
}
