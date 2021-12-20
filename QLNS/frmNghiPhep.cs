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
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-01UK3N8\SQLEXPRESS;Initial Catalog=QLNSu;Integrated Security=True");
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
        private Boolean KiemTraNV()
        {
            conn.Open();
                //Kiểm tra xem mã nhân viên này đã có hợp đồng chưa 
            if (txtMaNV.Text.Trim() != "")
            {
                    //Lưu biến tạm thời
                string np = dtpNgayNghi.Value.ToString("yyyy/MM/dd");
                    //Kiểm tra xem nhân viên này đã có dữ liệu ngày nghỉ này chưa 
                string sql = "Select Count(*) From NghiPhep Where MaNV ='" + txtMaNV.Text + "' and NgayPhep = '" + np + "'";
                cmd = new SqlCommand(sql, conn);
                int val = (int)cmd.ExecuteScalar();
                if (val > 0)
                {
                    conn.Close();
                        //Nếu có return false
                    return false;
                }
                conn.Close();
                return true;
            }
            conn.Close();
                //Nếu chưa return true
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
        private void Connectionsql()
        {
            conn.Open();
                         //lấy dữ liệu trong bản Hợp đồng
            String SQL = "select n.*, c.HoTenNV from HopDong n, NhanVien c where n.manv = c.manv";
                    //Bắt đầu truy vấn
            SqlCommand com = new SqlCommand(SQL, conn);
            com.CommandType = CommandType.Text;
                    //Chuyển dữ liệu về
            SqlDataAdapter data = new SqlDataAdapter(com);
                    //Tạo một kho ảo để lưu trữ dữ liệu
            DataTable dt = new DataTable();
                    //Đổ dữ liệu vào kho
            data.Fill(dt);
                    //Đóng kết nối
            conn.Close();
                    //Đổ dữ liệu vào datagridview
            dtgvDSNV.DataSource = dt;
                    //Reset thông tin trên hàng nhập
            txtMaNV.Enabled = false;
            LamMoi();
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
            string insert = "update NhanVien values(N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + ")";
            
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

        private void frmNghiPhep_Load(object sender, EventArgs e)
        {
        /*    Connectionsql();
            // Dữ liệu combobox nhân viên
            string sQueryNhanVien = @"select * from NhanVien";
            sql = new SqlDataAdapter(sQueryNhanVien, conn);
            sql.Fill(ds, "tblNhanVien");
            txtHoTen.DataSource = ds.Tables["tblNhanVien"];
            cboNV.DisplayMember = "HoTenNV";
            cboNV.ValueMember = "MaNV";
            txtMaNV.Text = cboNV.SelectedValue.ToString();
            */
        }

        private void dtgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                //Trả các dữ liệu của hàng đang chọn lên các textbox nhập
            int i = e.RowIndex;
            txtMaNV.Text = dtgvDSNV.Rows[i].Cells["MaNV"].Value.ToString();
            txtHoTen.Text = dtgvDSNV.Rows[i].Cells["HoTenNV"].Value.ToString();
            dtpNgayNghi.Text = dtgvDSNV.Rows[i].Cells["NgayPhep"].Value.ToString();
            numSoNgayNghi.Text = dtgvDSNV.Rows[i].Cells["SoNgayNghi"].Value.ToString();
            txtLyDo.Text = dtgvDSNV.Rows[i].Cells["LyDo"].Value.ToString();
        }
    }
}
