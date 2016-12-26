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
    public partial class rptHD : Form
    {
        string cnStr;
        SqlConnection cn;
        public rptHD()
        {
            InitializeComponent();
        }

        private void rptHD_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);

            string sql = "SELECT * FROM HoaDon";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet KH = new DataSet();
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            ReportDataSource rptSource = new ReportDataSource("HD", dtHoaDon);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rptSource);
            reportViewer1.LocalReport.ReportPath = @"..\..\rptHoaDon.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
