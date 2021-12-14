using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập ");
                txtTenDangNhap.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu ");
                txtMatKhau.Focus();
            }
            else
            {
                if ((txtTenDangNhap.Text == "admin") && (txtMatKhau.Text == "admin"))
                {
                    MessageBox.Show("Đăng nhập thành công", "THÔNG BÁO");
                    frmMain f1 = new frmMain();
                    this.Hide();
                    f1.ShowDialog();
                }
                else if((txtTenDangNhap.Text == "user") && (txtMatKhau.Text == "user"))
                {
                    MessageBox.Show("Đăng nhập thành công", "THÔNG BÁO");
                    frmMain f1 = new frmMain();
                    this.Hide();
                    f1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "THÔNG BÁO");
                    this.txtTenDangNhap.Clear();
                    this.txtMatKhau.Clear();
                    this.txtTenDangNhap.Focus();
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
