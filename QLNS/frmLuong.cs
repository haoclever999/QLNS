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
    public partial class frmLuong : Form
    {
        public frmLuong()
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
            //Kiểm tra mã số không bỏ trống
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã số nhân viên không được trống", "THÔNG BÁO");
                txtMaNV.Focus();
                return false;
            }
            //Kiểm tra lương cơ bản không bỏ trống
            if (txtLCB.Text.Trim() == "")
            {
                MessageBox.Show("Lương cơ bản không được trống", "THÔNG BÁO");
                txtLCB.Focus();
                return false;
            }
            //Kiểm tra hệ số lương không bỏ trống
            if (txtHSL.Text.Trim() == "")
            {
                MessageBox.Show("Mã số nhân viên không được trống", "THÔNG BÁO");
                txtHSL.Focus();
                return false;
            }
            //Kiểm tra ngày công không bỏ trống
            if (txtNgayCong.Text.Trim() == "")
            {
                MessageBox.Show("Mã số nhân viên không được trống", "THÔNG BÁO");
                txtNgayCong.Focus();
                return false;
            }
            return true;
        }
        public void loadDataGirdView()
        {
            string query = "select nv.MaNV, nv.HoTenNV, nv.DiaChi, nv.CMND, nv.SDT, nv.GioiTinh, nv.Email, nv.NgaySinh, pb.TenPB, cv.TenCV from NhanVien nv, ChucVu cv, PhongBan pb where nv.MaCV=cv.MaCV and nv.MaPB=pb.MaPB";
            dtgvDSLuong.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        void SetHeaderText()
        {
            //đặt tên cột
            dtgvDSLuong.Columns["MaNV"].HeaderText = "Mã NV";
            dtgvDSLuong.Columns["HoTenNV"].HeaderText = "Họ tên";
            dtgvDSLuong.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvDSLuong.Columns["CMND"].HeaderText = "CMND";
            dtgvDSLuong.Columns["SDT"].HeaderText = "SDT";
            dtgvDSLuong.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgvDSLuong.Columns["Email"].HeaderText = "Email";
            dtgvDSLuong.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgvDSLuong.Columns["TenPB"].HeaderText = "Phòng ban";
            dtgvDSLuong.Columns["TenCV"].HeaderText = "Chức vụ";
            //đặt chiều rộng cột
            dtgvDSLuong.Columns["MaNV"].Width = 80;
            dtgvDSLuong.Columns["HoTenNV"].Width = 150;
            dtgvDSLuong.Columns["DiaChi"].Width = 120;
            dtgvDSLuong.Columns["CMND"].Width = 120;
            dtgvDSLuong.Columns["SDT"].Width = 120;
            dtgvDSLuong.Columns["GioiTinh"].Width = 110;
            dtgvDSLuong.Columns["Email"].Width = 150;
            dtgvDSLuong.Columns["NgaySinh"].Width = 120;
            dtgvDSLuong.Columns["TenPB"].Width = 120;
            dtgvDSLuong.Columns["TenCV"].Width = 100;
        }
        void loadComboBox()
        {
            string query1 = "select TenCV from ChucVu";
            string query2 = "select TenPB from PhongBan";
            cmbChucVu.DataSource = DataProvider.Instance.ExcuteQuery(query1);
            cmbPhongBan.DataSource = DataProvider.Instance.ExcuteQuery(query2);
            cmbChucVu.DisplayMember = "TenCV";
            cmbPhongBan.DisplayMember = "TenPB";
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnInLuong_Click(object sender, EventArgs e)
        {

        }

        private void frmLuong_Load(object sender, EventArgs e)
        {

        }

        private void lsvDSLuong_Click(object sender, EventArgs e)
        {

        }
    }
}
