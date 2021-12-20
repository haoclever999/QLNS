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
    public partial class frmDoiMk : Form
    {
        public frmDoiMk()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string update = "update TaiKhoan set Matkhau='" + txtMKMoi.Text + "' where (TenDangNhap = N'" + txtTaiKhoan.Text + "'and MatKhau='" + txtMKCu.Text + "')";
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "THÔNG BÁO");
                txtTaiKhoan.Focus();
            }
            else
            {
                if (txtMKCu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "THÔNG BÁO");
                    txtMKCu.Focus();
                }
                else if (txtMKMoi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu mới", "THÔNG BÁO");
                    txtMKMoi.Focus();
                }
                else if (txtXacNhanMK.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập lại mật khẩu", "THÔNG BÁO");
                    txtXacNhanMK.Focus();
                }
                else
                {
                    if (txtMKMoi.Text == txtXacNhanMK.Text)
                    {
                        DataProvider.Instance.ExcuteNonQuery(update);
                        MessageBox.Show("Bạn đã thay đổi mật khẩu thành công", "THÔNG BÁO");
                        this.Close();
                    }
                }

            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
