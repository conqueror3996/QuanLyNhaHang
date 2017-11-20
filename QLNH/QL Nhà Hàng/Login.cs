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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length ==0 && txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (this.txtUsername.Text.Length ==0)
            {
                 MessageBox.Show("Bạn Chưa Nhập Username", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
            else if (txtUsername.Text =="admin" && txtPassword.Text=="123456")
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form_Main form2 = new Form_Main();
                form2.ShowDialog();
                this.Close();
                
            }
            else
                MessageBox.Show("Tên Đăng Nhập không Đúng,Vui Lòng Kiểm Tra lại", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtPassword.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thoat = new DialogResult();
            thoat = MessageBox.Show("Bạn Có Muốn Thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;               
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        public bool ktdangnhap(string user, string pass)
        {
            if (user == "admin" && pass == "123456")
            {
                return true;
            }
            else
                return false;
        }

       
    }
}
