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
            return true;
        }
        public void loadDataGirdView()
        {
            string query = "select nv.MaNV, nv.HoTenNV, cv.TenCV, pb.TenPB, l.Thuong, l.PhuCap, l.LuongCB, l.HSL, l.KiLuat, l.GhiChu from NhanVien nv, ChucVu cv, PhongBan pb, Luong l where nv.MaCV=cv.MaCV and nv.MaPB=pb.MaPB and nv.MaNV=l.MaNV";
            dtgvDSLuong.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        void SetHeaderText()
        {
            //đặt tên cột
            //dtgvDSLuong.Columns["MaLuong"].HeaderText = "Mã lương";
            dtgvDSLuong.Columns["LuongCB"].HeaderText = "Lương cơ bản";
            dtgvDSLuong.Columns["HSL"].HeaderText = "Hệ số lương";
            dtgvDSLuong.Columns["PhuCap"].HeaderText = "Phụ cấp";
            dtgvDSLuong.Columns["HoTenNV"].HeaderText = "Họ tên";
            dtgvDSLuong.Columns["TenCV"].HeaderText = "Chức vụ";
            dtgvDSLuong.Columns["TenPB"].HeaderText = "Phòng ban";
            dtgvDSLuong.Columns["Thuong"].HeaderText = "Thưởng";
            dtgvDSLuong.Columns["KiLuat"].HeaderText = "Kỉ Luật";
            dtgvDSLuong.Columns["GhiChu"].HeaderText = "Ghi chú";
           // dtgvDSLuong.Columns["TienLuong"].HeaderText = "Tiền Lương";
            dtgvDSLuong.Columns["MaNV"].HeaderText = "Mã NV";
            //dtgvDSLuong.Rows. = TinhLuong().ToString();
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
            int luong = (hsl * lcb + pc + thuong - kiluat);
            return luong;
        }
        private void btnTongLuong_Click(object sender, EventArgs e)
        {
            /*int tong = 0;
            foreach(DataGridViewRow row in dtgvDSLuong.Rows)
            {
                //tong = tong + row.Cells["TienLuong"].Value;
            }*/
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int tienluong = TinhLuong();
            string update = "update Luong set LuongCB = N'" + txtLCB.Text + "',HSL=N'" + txtHSL.Text + "',PhuCap = N'" + txtPhuCap.Text + "',Thuong = N'" + txtThuong.Text + "',KiLuat = N'" + txtKiLuat.Text + "',TienLuong = N'" + tienluong.ToString() + "',GhiChu = N'" + txtGhiChu.Text + "'";

            if (DataProvider.Instance.ExcuteQuery("select MaNV from NhanVien").ToString() == txtMaNV.Text)
            {
                if (KTThongTin())
                {
                    DataProvider.Instance.ExcuteNonQuery(update);
                    dtgvDSLuong.Refresh();
                    loadDataGirdView();
                    MessageBox.Show("Sửa thành công");
                }
            }
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
            cmbPhongBan.Text = dtgvDSLuong.Rows[i].Cells["TenPB"].Value.ToString();
            cmbChucVu.Text = dtgvDSLuong.Rows[i].Cells["TenCV"].Value.ToString();
            txtThuong.Text = dtgvDSLuong.Rows[i].Cells["Thuong"].Value.ToString();
            txtPhuCap.Text = dtgvDSLuong.Rows[i].Cells["PhuCap"].Value.ToString();
            txtLCB.Text = dtgvDSLuong.Rows[i].Cells["LuongCB"].Value.ToString();
            txtHSL.Text = dtgvDSLuong.Rows[i].Cells["HSL"].Value.ToString();
            txtKiLuat.Text = dtgvDSLuong.Rows[i].Cells["KiLuat"].Value.ToString();
            txtGhiChu.Text = dtgvDSLuong.Rows[i].Cells["GhiChu"].Value.ToString();
        }

    }
}
