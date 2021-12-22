using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlCommand cmd;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string query = "Select * From TaiKhoan where TenDangNhap='" + txtTenDangNhap.Text + "' and MatKhau='" + txtMatKhau.Text + "' and PhanQuyen='Admin'";
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
                DataTable table = DataProvider.Instance.ExcuteQuery(query);
                int quyen = Convert.ToInt32(table);
                if (table.Rows.Count>0)
                {
                    MessageBox.Show("Đăng nhập thành công (quyền admin)", "THÔNG BÁO");
                    frmMain f1 = new frmMain();
                    f1.quyen = "admin";
                    this.Hide();
                    f1.ShowDialog();
                }
                else if(table.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công (quyền user)", "THÔNG BÁO");
                    frmMain f1 = new frmMain();
                    f1.quyen = "user";
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

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
