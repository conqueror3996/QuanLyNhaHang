
using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;

using System.Data.SqlClient;

namespace QuanLyNhaHang
{
    public partial class Form1 : Form
    {
        String cnStr;
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
            
        }
    
    private void Connect()
    {
        try 
	    {	        
		    if ( cn  !=null && cn.State == ConnectionState.Closed)
                cn.Open();
	    }
	    catch (SqlException ex)
	    {
		    MessageBox.Show (ex.Message);
		//throw;
	    }
    }
    private void Disconnect()
    {
        try
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
            //throw;
        }
    }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {

                SqlCommand cmd = new SqlCommand("uspInsertEmployee", cn);
                // cmd.Connection = cn;
                // cmd.CommandText = "uspInsertEmployee";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Ho", txtHo.Text));
                cmd.Parameters.Add(new SqlParameter("@Ten", txtTen.Text));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@DienThoai", txtDienThoai.Text));
                //MessageBox.Show(" Ket Noi  Thanh Cong");

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
              
                MessageBox.Show(ex.Message);
                //throw;
            }
            //finally
          //  { Disconnect(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnStr = "Server =.; Database = QLBanHang; Integrated security = true;";
            cn = new SqlConnection(cnStr);
            //String sql = "SELECT * FROM NhanVien";
            dataGridView1.DataSource = GetNhanVien();
        }

        private List<NhanVien> GetNhanVien()
        {
            Connect();
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                string sql = "SELECT * FROM NhanVien";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string HoNV, Ten, DiaChi, DienThoai;

                while (dr.Read())
                {

                    HoNV = dr.GetString(1);
                    Ten = dr.GetString(2);
                    DiaChi = dr.GetString(3);
                    DienThoai = dr.GetString(4);


                    NhanVien prod = new NhanVien(HoNV, Ten, DiaChi, DienThoai);
                    list.Add(prod);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                Disconnect();
            }
            return list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Connect();
            List<NhanVien> list = new List<NhanVien>();

        }
    }
}
