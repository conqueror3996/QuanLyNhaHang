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
    public partial class QLHoaDon : Form
    {
        String cnStr;
        SqlConnection cn;
        DataSet ds;
        DataTable Orders=new DataTable();
        public QLHoaDon()
        {
            InitializeComponent();
        }

        
        

        public DataSet GetDataset(string sql)
        {
            try
            {

                 sql = "SELECT * FROM HoaDon";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                /*DataSet*/
                ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
                //throw;
            }
            finally
            {
                cn.Close();
            }
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM HoaDon";
            Orders = GetDataset(sql).Tables[0];

            cboOrderID.DataSource = Orders;
            cboOrderID.DisplayMember = "MaHD";
            cboOrderID.ValueMember = "MaHD";

            txtMaNV.DataBindings.Add("Text", Orders, "MaNV");
            txtMaKH.DataBindings.Add("Text", Orders, "MaKH");
        }
    }
}
