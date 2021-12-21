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
using System.Data.SqlClient;

namespace QLNS
{
    public partial class frmNhanSu : Form
    {
        public frmNhanSu()
        {
            InitializeComponent();
        }

        //SqlConnection conn;
        /*SqlCommand cmd;
        SQLDatabase sql;*/
        SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC\SQLEXPRESS;Initial Catalog=QLNSu;Integrated Security=True");

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
            txtMaNV.Focus();
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
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã số nhân viên không được trống", "THÔNG BÁO");
                txtMaNV.Focus();
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
        public void loadDataGirdView()
        {
            string query = "select nv.MaNV, nv.HoTenNV, nv.DiaChi, nv.CMND, nv.SDT, nv.GioiTinh, nv.Email, nv.NgaySinh, pb.TenPB, cv.TenCV from NhanVien nv, ChucVu cv, PhongBan pb where nv.MaCV=cv.MaCV and nv.MaPB=pb.MaPB";
            dtgvDSNV.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        void SetHeaderText()
        {
            //đặt tên cột
            dtgvDSNV.Columns["MaNV"].HeaderText = "Mã NV";
            dtgvDSNV.Columns["HoTenNV"].HeaderText = "Họ tên";
            dtgvDSNV.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvDSNV.Columns["CMND"].HeaderText = "CMND";
            dtgvDSNV.Columns["SDT"].HeaderText = "SDT";
            dtgvDSNV.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgvDSNV.Columns["Email"].HeaderText = "Email";
            dtgvDSNV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgvDSNV.Columns["TenPB"].HeaderText = "Phòng ban";
            dtgvDSNV.Columns["TenCV"].HeaderText = "Chức vụ";
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
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (radNam.Checked == true)
                gioitinh = "Nam";
            if (radNu.Checked == true)
                gioitinh = "Nữ";
            string insert = "insert into NhanVien values(N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + txtDiaChi.Text + "',N'" +txtCMND.Text + "',N'" + txtSDT.Text + "',N'" + gioitinh + "',N'" + txtEmail.Text + "',N'" + dtpNgaySinh.Text + "')";
            //Còn chức vụ và phòng ban
            if ((DataProvider.Instance.ExcuteQuery("select MaNV from NhanVien").ToString() != txtMaNV.Text) && (DataProvider.Instance.ExcuteQuery("select Email from NhanVien").ToString() != txtEmail.Text) && (DataProvider.Instance.ExcuteQuery("select SDT from NhanVien").ToString() != txtSDT.Text) && (DataProvider.Instance.ExcuteQuery("select CMND from NhanVien").ToString() != txtCMND.Text))
            {
                if(KTThongTin())
                {
                    DataProvider.Instance.ExcuteNonQuery(insert);
                    dtgvDSNV.Refresh();
                    loadDataGirdView();
                    MessageBox.Show("Thêm thành công");
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string gioitinh = "";
            if (radNam.Checked == true)
                gioitinh = "Nam";
            if (radNu.Checked == true)
                gioitinh = "Nữ";
            string update = "update NhanVien set HoTenNV = N'" + txtHoTen.Text + "',DiaChi=N'" + txtDiaChi.Text + "',CMND = N'" + txtCMND.Text + "',SDT = N'" + txtSDT.Text + "',GioiTinh = N'" + gioitinh + "',Email = N'" + txtEmail.Text + "',NgaySinh = N'" + dtpNgaySinh.Text + "'where MaNV = N'" +txtMaNV.Text + "'";
            
            if (DataProvider.Instance.ExcuteQuery("select MaNV from NhanVien").ToString() == txtMaNV.Text)
            {
                if (KTThongTin())
                {
                    DataProvider.Instance.ExcuteNonQuery(update);
                    dtgvDSNV.Refresh();
                    loadDataGirdView();
                    MessageBox.Show("Sửa thành công");
                }
            }
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from NhanVien where MaNV = '" + txtMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataProvider.Instance.ExcuteNonQuery(delete);
                dtgvDSNV.Refresh();
                loadDataGirdView();
                MessageBox.Show("Đã xóa dữ liệu");
            }
            if (DataProvider.Instance.ExcuteQuery("select MaNV from NhanVien").ToString() != txtMaNV.Text) 
                MessageBox.Show("Nhân viên này chưa có dữ liệu, không thể xóa");
        }
        private void frmNhanSu_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadDataGirdView();
            SetHeaderText();
        }
        private void dtgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //đổ dữ liệu lên textbox, combobox
            int i = e.RowIndex;
            txtMaNV.Text = dtgvDSNV.Rows[i].Cells["MaNV"].Value.ToString();
            txtHoTen.Text = dtgvDSNV.Rows[i].Cells["HoTenNV"].Value.ToString();
            txtDiaChi.Text = dtgvDSNV.Rows[i].Cells["DiaChi"].Value.ToString();
            txtCMND.Text = dtgvDSNV.Rows[i].Cells["CMND"].Value.ToString();
            txtSDT.Text = dtgvDSNV.Rows[i].Cells["SDT"].Value.ToString();
            if (dtgvDSNV.Rows[i].Cells["GioiTinh"].Value.ToString() == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtEmail.Text = dtgvDSNV.Rows[i].Cells["Email"].Value.ToString();
            dtpNgaySinh.Text = dtgvDSNV.Rows[i].Cells["NgaySinh"].Value.ToString();
            cmbPhongBan.SelectedValue = dtgvDSNV.Rows[i].Cells["TenPB"].Value.ToString();
            cmbChucVu.SelectedValue = dtgvDSNV.Rows[i].Cells["TenCV"].Value.ToString();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if ((txtTimKiem.Text == "") || (txtTimKiem.Text == "Nhập thông tin tìm kiếm"))
            {
                MessageBox.Show("Bạn chưa nhập thông tin cần tìm", "THÔNG BÁO");
            }
            else
            {
                if (radMaNV.Checked == true)
                {
                    string query = "select * from NhanVien where MaCV=N'" + txtTimKiem.Text + "'";
                    dtgvDSNV.DataSource = DataProvider.Instance.ExcuteQuery(query);
                }
                else if (radHoTen.Checked == true)
                {
                    string query = "select * from NhanVien where HoTenNV=N'" + txtTimKiem.Text + "'";
                    dtgvDSNV.DataSource = DataProvider.Instance.ExcuteQuery(query);
                }
                else
                    MessageBox.Show("Không tìm thấy thông tin", "THÔNG BÁO");
            }
        }
        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void gbThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {

        }
        //nút Button thêm sửa xóa còn lỗi
    }
}
