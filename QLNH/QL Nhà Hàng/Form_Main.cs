using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Nhà_Hàng
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhanVien formQLNV = new QLNhanVien();
            formQLNV.ShowDialog();

        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form2 = new Login();
            form2.ShowDialog();
            this.Close();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //tùy chình kích thước của form Menu Chính
            this.Size = new Size(1010,650);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult thoat = new DialogResult();
            thoat = MessageBox.Show("Bạn Có Muốn Thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (thoat ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void quảnLíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKhachHang formQLKH = new QLKhachHang();
            formQLKH.ShowDialog();
        }

        private void quảnLíHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHoaDon formQLHD = new QLHoaDon();
            formQLHD.ShowDialog();
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLThucDon fromQLTD = new QLThucDon();
            fromQLTD.ShowDialog();
        }

        private void reportKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptKH rptKH = new rptKH();
            rptKH.Show();
        }

        private void reportHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptHD rptHD = new rptHD();
            rptHD.Show();
        }

        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLBan fromQLBan = new QLBan();
            fromQLBan.ShowDialog();
        }

      
       
    }
}
