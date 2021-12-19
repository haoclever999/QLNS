using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNS
{
    public partial class frmNghiPhep : Form
    {
        public frmNghiPhep()
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
                if (ctr is DateTimePicker || ctr is NumericUpDown)
                    ctr.ResetText();
            }
            txtMaNV.Focus();
        }
        private Boolean KTThongTin()
        {
         
            //Kiểm tra mã số không bỏ trống
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã số nhân viên không được trống", "THÔNG BÁO");
                txtMaNV.Focus();
                return false;
            }

            return true;
        }
        public void loadDataGirdView()
        {
            string query = "select nv.MaNV, nv.HoTenNV";
            dtgvDSNV.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        void SetHeaderText()
        {
            //đặt tên cột
            dtgvDSNV.Columns["MaNV"].HeaderText = "Mã NV";
            dtgvDSNV.Columns["HoTenNV"].HeaderText = "Họ tên";
            dtgvDSNV.Columns["SoNgayNghi"].HeaderText = "Số ngày nghỉ";
            dtgvDSNV.Columns["LyDo"].HeaderText = "Lý do";
            dtgvDSNV.Columns["NgayPhep"].HeaderText = "Ngày nghỉ";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string insert = "insert into NhanVien values(N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + ")";
           
            if ((DataProvider.Instance.ExcuteQuery("select MaNV from NhanVien").ToString() != txtMaNV.Text))
            {
                if (KTThongTin())
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
            string insert = "insert into NhanVien values(N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + ")";
            
            if ((DataProvider.Instance.ExcuteQuery("select MaNV from NhanVien").ToString() != txtMaNV.Text))
            {
                if (KTThongTin())
                {
                    DataProvider.Instance.ExcuteNonQuery(insert);
                    dtgvDSNV.Refresh();
                    loadDataGirdView();
                    MessageBox.Show("Thêm thành công");
                }
            }
        }
    }
}
