﻿using System;
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

        SqlConnection conn;
        SqlCommand cmd;
        SQLDatabase sql;
      
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
        public void loadListView()
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
            //đặt chiều rộng cột
            dtgvDSNV.Columns["MaNV"].Width = 80;
            dtgvDSNV.Columns["HoTenNV"].Width = 150;
            dtgvDSNV.Columns["DiaChi"].Width = 120;
            dtgvDSNV.Columns["CMND"].Width = 120;
            dtgvDSNV.Columns["SDT"].Width = 120;
            dtgvDSNV.Columns["GioiTinh"].Width = 110;
            dtgvDSNV.Columns["Email"].Width = 150;
            dtgvDSNV.Columns["NgaySinh"].Width = 120;
            dtgvDSNV.Columns["TenPB"].Width = 120;
            dtgvDSNV.Columns["TenCV"].Width = 100;
        }


        public void loadComboBox()
        {
            sql.KetNoi();
            cmd = new SqlCommand("select * from ChucVu", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                cmbChucVu.Items.Add(reader["TenCV"]);
                cmbChucVu.ValueMember = reader["MaCV"].ToString();
            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            sql.KetNoi();
            string gioitinh = "";
            if (radNam.Checked == true)
                gioitinh = "Nam";
            if (radNu.Checked == true)
                gioitinh = "Nữ";
            //Các thông tin cần thêm
            string insert = "insert into NhanVien values(N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + txtDiaChi.Text + "',N'" +txtCMND.Text + "',N'" + txtSDT.Text + "',N'" + gioitinh + "',N'" + txtEmail.Text + "',N'" + dtpNgaySinh.Text + "',N'" + cmbChucVu.Text + "',N'" + cmbPhongBan.Text + "')";
            if ((!sql.kttrungkhoa(txtMaNV.Text, "select MaNV from NhanVien")) && (!sql.kttrungkhoa(txtEmail.Text, "select Email from NhanVien")) && (!sql.kttrungkhoa(txtSDT.Text, "select SDT from NhanVien")) && (!sql.kttrungkhoa(txtCMND.Text, "select CMND from NhanVien")))
            {
                if(KTThongTin())
                {
                    sql.KetNoi();
                    sql.ThucThiKetNoi(insert);
                    //lsvDSNV.Refresh();
                    loadListView();
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
            //+ txtDiaChi.Text + "',N'" +txtCMND.Text + "',N'" + txtSDT.Text + "',N'" + gioitinh + "',N'" + txtEmail.Text + "',N'" + dtpNgaySinh.Text + "',N'" + cmbChucVu.Text + "',N'" + cmbPhongBan.Text + "')";
            string update = "update NhanVien set HoTenNV = N'" + txtHoTen.Text + "',DiaChi=N'" + txtDiaChi.Text + "',CMND = N'" + txtCMND.Text + "',SDT = N'" + txtSDT.Text + "',GioiTinh = N'" + gioitinh + "',Email = N'" + txtEmail.Text + "',NgaySinh = N'" + dtpNgaySinh.Text + "'where MaNV = N'" +txtMaNV.Text + "'";
            if (sql.kttrungkhoa(txtMaNV.Text, "select MaNV from NhanVien"))
            {
                sql.ThucThiKetNoi(update);
                //lsvDSNV.Refresh();
                loadListView();
                MessageBox.Show("Sửa thành công");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string delete = "delete from NhanVien where MaNV = '" + txtMaNV.Text + "'";
            if (MessageBox.Show("Bạn có muốn xóa không", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sql.ThucThiKetNoi(delete);
                loadListView();
                MessageBox.Show("Đã xóa dữ liệu");
            }
            if (!sql.kttrungkhoa(txtMaNV.Text, "select MaNV from NhanVien"))
                MessageBox.Show("Nhân viên này chưa có dữ liệu, không thể xóa");
        }
        private void frmNhanSu_Load(object sender, EventArgs e)
        {
            
            loadListView();
            //sql.KetNoi();
            //loadListView();
            //loadComboBox();
            SetHeaderText();
        }

        private void dtgvDSNV_Click(object sender, EventArgs e)
        {

        }
    }
}
