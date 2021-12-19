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
            dtgvDSLuong.Columns["TenCV"].HeaderText = "Chức vụ";
            dtgvDSLuong.Columns["TenPB"].HeaderText = "Phòng ban";
            dtgvDSLuong.Columns["Thuong"].HeaderText = "Thưởng";
            dtgvDSLuong.Columns["PhuCap"].HeaderText = "Phụ cấp";
            dtgvDSLuong.Columns["LuongCB"].HeaderText = "Lương cơ bản";
            dtgvDSLuong.Columns["SoGioTangCa"].HeaderText = "Số giờ tăng ca";
            dtgvDSLuong.Columns["HSL"].HeaderText = "Hệ số lương";
            dtgvDSLuong.Columns["KiLuat"].HeaderText = "Kỉ Luật";
            dtgvDSLuong.Columns["NgayCong"].HeaderText = "Ngày công";
            dtgvDSLuong.Columns["TienLuong"].HeaderText = "Tiền Lương";
            dtgvDSLuong.Columns["GhiChu"].HeaderText = "Ghi chú";
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
        private int TinhLuong()
        {
            int hsl = Int32.Parse(txtHSL.Text);
            int pc = Int32.Parse(txtPhuCap.Text);
            int thuong = Int32.Parse(txtThuong.Text);
            int kiluat = Int32.Parse(txtKiLuat.Text);
            int lcb = Int32.Parse(txtLCB.Text);
            int tangca = Int32.Parse(txtSoGioTangCa.Text);
            int ngaycong = Int32.Parse(txtNgayCong.Text);
            int luong = (((hsl * lcb + pc) / 26) * ngaycong + (tangca * 40000) + thuong - kiluat);
            return luong;
        }
        private void btnTongLuong_Click(object sender, EventArgs e)
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
            loadComboBox();
            loadDataGirdView();
            SetHeaderText();
        }
        private void dtgvDSLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //đổ dữ liệu lên textbox, combobox
            int i = e.RowIndex;
            txtMaNV.Text = dtgvDSLuong.Rows[i].Cells["MaNV"].Value.ToString();
            txtHoTen.Text = dtgvDSLuong.Rows[i].Cells["HoTenNV"].Value.ToString();
            cmbPhongBan.SelectedValue = dtgvDSLuong.Rows[i].Cells["TenPB"].Value.ToString();
            cmbChucVu.SelectedValue = dtgvDSLuong.Rows[i].Cells["TenCV"].Value.ToString();
            txtThuong.Text = dtgvDSLuong.Rows[i].Cells["Thuong"].Value.ToString();
            txtPhuCap.Text = dtgvDSLuong.Rows[i].Cells["PhuCap"].Value.ToString();
            txtLCB.Text = dtgvDSLuong.Rows[i].Cells["LuongCB"].Value.ToString();
            txtSoGioTangCa.Text = dtgvDSLuong.Rows[i].Cells["SoGioTangCa"].Value.ToString();
            txtHSL.Text = dtgvDSLuong.Rows[i].Cells["HSL"].Value.ToString();
            txtKiLuat.Text = dtgvDSLuong.Rows[i].Cells["KiLuat"].Value.ToString();
            txtNgayCong.Text = dtgvDSLuong.Rows[i].Cells["NgayCong"].Value.ToString();
            txtGhiChu.Text = dtgvDSLuong.Rows[i].Cells["GhiChu"].Value.ToString();
        }

    }
}
