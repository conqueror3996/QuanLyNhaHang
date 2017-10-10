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
    public partial class QLBan : Form
    {
        String cnStr;
        SqlConnection cn;
        DataSet ds;
        DataTable Orders = new DataTable();
        public QLBan()
        {
            InitializeComponent();
        }
        public DataSet GetDataset(string sql)
        {
            try
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                /*DataSet*/
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

        private void QLBan_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            LoadKhuVuc();
            hienThiBan();
            txtMaBan.DataBindings.Add("Text", Orders, "MaBan");
            comboKV.DataBindings.Add("Text", Orders, "MaKhuVuc");
            txtTThai.DataBindings.Add("Text", Orders, "TrangThaiBan");
        }
        private void hienThiBan()
        {
            string sql = "select * from Ban";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Orders = ds.Tables[0];
        }
        public void LoadKhuVuc()
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            cn.Open();
            string strCmd = "select MaKhuVuc from KhuVuc";
            SqlCommand cmd = new SqlCommand(strCmd, cn);
            SqlDataAdapter da = new SqlDataAdapter(strCmd, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboKV.DataSource = dt;
            comboKV.DisplayMember = "TenKhuVuc";
            comboKV.ValueMember = "MaKhuVuc";
            comboKV.Enabled = true;
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboKV.Text == "" || txtMaBan.Text == "")
                {
                    MessageBox.Show("Ban Chưa Nhập Thong Tin Hóa Đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    string insert = "insert into Ban(MaBan,MaKhuVuc, ChiTiet, TrangThaiBan, TenBan) values ('" + txtMaBan.Text + "','" + comboKV.SelectedValue.ToString() + "','" + txtChiTiet.Text + "','" + txtTThai.Text + "','" + txtTenBan.Text + "')";

                    SqlCommand cmdthem = new SqlCommand(insert, cn);
                    cn.Open();
                    cmdthem.ExecuteNonQuery();
                    hienThiBan();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string xoa = "delete Ban where MaBan='" + txtMaBan.Text + "'";
                SqlCommand cmdxoa = new SqlCommand(xoa, cn);
                cmdxoa.ExecuteNonQuery();
                hienThiBan();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string update = "update  Ban set MaBan= '" + txtMaBan.Text + "',MaKhuVuc='" + comboKV.SelectedValue.ToString() + "',ChiTiet='" + txtChiTiet.Text + "', TrangThaiBan='" + txtTThai.Text + "',TenBan='" + txtTenBan.Text + "'WHERE MaBan='" + txtMaBan.Text + "'";
                SqlCommand cmdSua = new SqlCommand(update, cn);
                cmdSua.ExecuteNonQuery();
                hienThiBan();
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
                if (radTen.Checked == true)
                {
                    tim = "select * from Ban WHERE TenBan LIKE  '%" + txtNhap.Text + "%'";
                    SqlCommand cmdTim = new SqlCommand(tim, cn);
                    cmdTim.ExecuteNonQuery();
                    hienThiGirdView(tim);

                }
                else if (radKV.Checked == true)
                {
                    tim = "select * from Ban WHERE MaKhuVuc LIKE  '%" + txtNhap.Text + "%'";
                    SqlCommand cmdTim = new SqlCommand(tim, cn);
                    cmdTim.ExecuteNonQuery();
                    hienThiGirdView(tim);
                }
                else
                {
                    tim = "select * from Ban WHERE TrangThaiBan LIKE  '%" + txtNhap.Text + "%'";
                    SqlCommand cmdTim = new SqlCommand(tim, cn);
                    cmdTim.ExecuteNonQuery();
                    hienThiGirdView(tim);
                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show("Loi Tim\n" + ex.Message);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            txtMaBan.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            comboKV.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtChiTiet.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtTThai.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtTenBan.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = "select * from Ban";
            hienThiGirdView(sql);
            radTen.Checked = false;
            radKV.Checked = false;
            radTThai.Checked = false;
            txtMaBan.Text = " ";
            txtChiTiet.Text = " ";
            txtTenBan.Text = " ";
            txtTThai.Text = " ";


        }
    }
}
