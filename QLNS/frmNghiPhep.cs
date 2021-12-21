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
        DataSet ds = new DataSet("dsQLNP");
        SqlCommand cmd;
        SqlDataAdapter daNhanVien;
        SqlConnection conn = new SqlConnection(@"Data Source=TIEN-PC\SQLEXPRESS;Initial Catalog=QLNSu;Integrated Security=True");
        private void ResetTT()
        {
            //Trả thông tin nhập về trống như ban đầu
            txtSoNgayNghi.Text = "";
            cboNV.ResetText();
            dtNgayPhep.ResetText();
            txtSoNgayNghi.Focus();
        }
        private Boolean KiemTraTT()
        {
            //Kiểm tra hạn hợp đồng không bỏ trống
            if (txtSoNgayNghi.Text.Trim() == "")
            {
                ResetTT();
                MessageBox.Show("Không được để trống số ngày nghỉ của nhân viên!", "Thông báo");
                return false;
            }
            //Kiểm tra lý do không bỏ trống
            if (txtLydo.Text.Trim() == "")
            {
                ResetTT();
                MessageBox.Show("Không được để trống lý do của nhân viên!", "Thông báo");
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
                string nn = dtNgayPhep.Value.ToString("yyyy/MM/dd");
                //Kiểm tra xem nhân viên này đã có dữ liệu ngày nghỉ này chưa 
                string sql = "Select Count(*) From NghiPhep Where MaNV ='" + txtMaNV.Text + "' and NgayNghi = '" + nn + "'";
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

        void SetHeaderText()
        {
            //đặt tên cột
            dgDSNghiPhep.Columns["MaNghiPhep"].HeaderText = "Mã nghỉ phép";
            dgDSNghiPhep.Columns["MaNV"].HeaderText = "Mã NV";
            dgDSNghiPhep.Columns["HoTenNV"].HeaderText = "Họ tên";
            dgDSNghiPhep.Columns["SoNgayNghi"].HeaderText = "Số ngày nghỉ";
            dgDSNghiPhep.Columns["LyDo"].HeaderText = "Lý do";
            dgDSNghiPhep.Columns["NgayNghi"].HeaderText = "Ngày nghỉ";
        }
        private void Connectionsql()
        {
            //Mở kết nối
            conn.Open();
            //lấy dữ liệu trong bản Nghỉ phép
            String SQL = "select n.*, c.HoTenNV from NghiPhep n, NhanVien c where n.manv = c.manv";
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
            dgDSNghiPhep.DataSource = dt;
            //Reset thông tin trên hàng nhập
            txtMaNV.Enabled = false;
            ResetTT();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTT() == true)
            {
                if (KiemTraNV() == false)
                    MessageBox.Show("Đã có dữ liệu này rồi, không thể thêm!", "Thông báo");
                else
                {
                    //Lưu biến tạm thời
                    string nn = dtNgayPhep.Value.ToString("yyyy/MM/dd");
                    //Các thông tin nhân viên cần thêm
                    string sql = "insert into NghiPhep (MaNghiPhep,NgayNghi,SoNgayNghi,LyDo,MaNV) values(";
                    
                    sql += "'" + txtMaNghiPhep.Text + "'";
                    sql += ",'" + nn + "'";
                    sql += ",'" + txtSoNgayNghi.Text + "'";                  
                    sql += ", N'" + txtLydo.Text + "'" ;
                    sql += ",'" + txtMaNV.Text + "'";
                    //Thực thi lệnh
                    conn.Open();
                    var cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Connectionsql();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraTT() == true)
                if (KiemTraNV() == true)
                    MessageBox.Show("Chưa có dữ liệu này, không thể sửa, hãy thêm dữ liệu trước!", "Thông báo");
                else
                {
                    //Lưu biến tạm thời
                    string nn = dtNgayPhep.Value.ToString("yyyy/MM/dd");
                    //Các thông tin nhân viên cần thêm
                    string sql = "Update NghiPhep SET ";
                    sql += "MaNghiPhep" + txtMaNghiPhep.Text + "'";
                    sql += "NgayNghi = '" + nn + "'";
                    sql += ", SoNgayNghi = " + txtSoNgayNghi.Text;
                    sql += ", LyDo = N'" + txtLydo.Text + "' ";
                    sql += " Where MaNV = '" + txtMaNV.Text + "'";
                    //Thực thi lệnh
                    conn.Open();
                    var cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Connectionsql();
                }
        }

        private void frmNghiPhep_Load(object sender, EventArgs e)
        {
            Connectionsql();
            // Dữ liệu combobox nhân viên
            string sQueryNhanVien = @"select * from NhanVien";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblNhanVien");
            cboNV.DataSource = ds.Tables["tblNhanVien"];
            cboNV.DisplayMember = "HoTenNV";
            cboNV.ValueMember = "MaNV";
            txtMaNV.Text = cboNV.SelectedValue.ToString();
        }

        private void dtgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Trả các dữ liệu của hàng đang chọn lên các textbox nhập
            int i = e.RowIndex;
            txtMaNghiPhep.Text = dgDSNghiPhep.Rows[i].Cells["MaNghiPhep"].Value.ToString();
            dtNgayPhep.Text = dgDSNghiPhep.Rows[i].Cells["NgayNghi"].Value.ToString();
            txtMaNV.Text = dgDSNghiPhep.Rows[i].Cells["MaNV"].Value.ToString();
            cboNV.Text = dgDSNghiPhep.Rows[i].Cells["HoTenNV"].Value.ToString();
            txtSoNgayNghi.Text = dgDSNghiPhep.Rows[i].Cells["SoNgayNghi"].Value.ToString();
            txtLydo.Text = dgDSNghiPhep.Rows[i].Cells["LyDo"].Value.ToString();
        }

        private void cboNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Khi thay đổi combobox tên NV thì textbox mã NV thay đổi theo
            txtMaNV.Text = cboNV.SelectedValue.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Lưu biến tạm thời
            string np = dtNgayPhep.Value.ToString("yyyy/MM/dd");
            if (KiemTraNV() == true)
                MessageBox.Show("Chưa có dữ liệu của nhân viên này, không thể xóa!", "Thông báo");
            else
            {
                //Câu lệnh xóa
                string sql = "delete from NghiPhep ";
                sql += "where MaNV = '" + txtMaNV.Text + "' and NgayNghi = '" + np + "'";
                //Thực thi lệnh
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                Connectionsql();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboNV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Khi thay đổi combobox tên NV thì textbox mã NV thay đổi theo
            txtMaNV.Text = cboNV.SelectedValue.ToString();
        }
    }
}
