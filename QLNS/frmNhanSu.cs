using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLNS
{
    public partial class frmNhanSu : Form
    {
        public frmNhanSu()
        {
            InitializeComponent();
        }
        private void LamMoi()
        {
            foreach (Control ctr in this.gbThongTin.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
                if (ctr is ComboBox || ctr is DateTimePicker)
                    ctr.ResetText();
            }
            radNam.Checked = false;
            radNu.Checked = false;
            txtMaSo.Focus();
        }
        private Boolean KTThongTin()
        {
            //Kiểm tra tên không bỏ trống
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên nhân viên không được trống", "THÔNG BÁO");
                txtHoTen.Focus();
                return false;
            }
            //Kiểm tra ngày sinh hợp lệ
            if (dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "THÔNG BÁO");
                return false;
            }
            //Kiểm tra địa chỉ không bỏ trống
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được trống", "THÔNG BÁO");
                txtDiaChi.Focus();
                return false;
            }
            //Kiểm tra sdt không bỏ trống
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được trống", "THÔNG BÁO");
                txtSDT.Focus();
                return false;
            }
            else
            {
                Regex reg = new Regex(@"0(\d{9})");
                if (reg.IsMatch(this.txtSDT.Text))
                { }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "THÔNG BÁO");
                    txtSDT.Clear();
                    txtSDT.Focus();
                    return false;
                }
            }
            //Kiểm tra mã số không bỏ trống
            if (txtMaSo.Text.Trim() == "")
            {
                MessageBox.Show("Mã số nhân viên không được trống", "THÔNG BÁO");
                txtMaSo.Focus();
                return false;
            }
            //Kiểm tra giới tính không chọn
            if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Hãy chọn giới tính", "THÔNG BÁO");
                return false;
            }

            //Kiểm tra email không bỏ trống
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên nhân viên không được trống", "THÔNG BÁO");
                txtEmail.Focus();
                return false;
            }
            else
            {
                String match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                Regex reg = new Regex(match);
                if (reg.IsMatch(this.txtEmail.Text))
                { }
                else
                {
                    MessageBox.Show("Email không hợp lệ", "THÔNG BÁO");
                    txtEmail.Clear();
                    txtEmail.Focus();
                    return false;
                }
            }
            return true;
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
