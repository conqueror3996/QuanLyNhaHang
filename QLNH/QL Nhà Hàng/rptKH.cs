using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
//using System.Configuration;
using Microsoft.Reporting.WinForms;
namespace QL_Nhà_Hàng
{
    public partial class rptKH : Form
    {
        string cnStr;
        SqlConnection cn;
        public rptKH()
        {
            InitializeComponent();
        }

        private void rptKH_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            
                string sql = "SELECT * FROM KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataSet KH = new DataSet();
                DataTable dtKhachHang = new DataTable();
                da.Fill(dtKhachHang);
                ReportDataSource rptSource = new ReportDataSource("DataSet1", dtKhachHang);
                 reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rptSource);
                reportViewer1.LocalReport.ReportPath = @"..\..\rptKhachHang.rdlc";
                this.reportViewer1.RefreshReport();
        }
    }
}
