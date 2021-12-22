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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        static bool isMax;
        static Point old_loc, default_loc;
        static Size old_size, default_size;
        public static void SetIntial(Form frm)
        {
            old_loc = frm.Location;
            old_size = frm.Size;
            default_loc = frm.Location;
            default_size = frm.Size;
        }
        public static void Maximize(Form frm)
        {
            if (isMax == false)//chưa maximized
            {
                old_loc = new Point(frm.Location.X, frm.Location.Y);
                old_size = new Size(frm.Size.Width, frm.Size.Height);
                int x = SystemInformation.WorkingArea.Width;
                int y = SystemInformation.WorkingArea.Height;
                frm.WindowState = FormWindowState.Normal;
                frm.Location = new Point(0, 0);
                frm.Size = new Size(x, y);
                isMax = true;
            }
            else //đang Maximized
            {
                frm.Location = old_loc;
                frm.Size = old_size;
                isMax = false;
            }
        }
        public static void Minimize(Form frm)
        {
            if (frm.WindowState == FormWindowState.Minimized)
                frm.WindowState = FormWindowState.Normal;
            else if (frm.WindowState == FormWindowState.Normal)
                frm.WindowState = FormWindowState.Minimized;
        }
        private void DiChuyenPanel(Button btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private Form KTForm(Type form)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == form)
                    return f;
            return null;
        }
        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            Form frm = this.KTForm(typeof(frmMain));
            if (frm != null)
                frm.Activate();
            else
            {
                panelCentral.Controls.Clear();
                DiChuyenPanel(btnTongQuan);
            }
        }

        private void btnNhanSu_Click(object sender, EventArgs e)
        {
            Form frm = this.KTForm(typeof(frmNhanSu));
            if (frm != null)
                frm.Activate();
            else
            {
                DiChuyenPanel(btnNhanSu);
                frmNhanSu f1 = new frmNhanSu();
                f1.TopLevel = false;
                f1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f1.Dock = DockStyle.Fill;
                f1.Show();
                panelCentral.Controls.Clear();
                panelCentral.Controls.Add(f1);
            }
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            Form frm = this.KTForm(typeof(frmLuong));
            if (frm != null)
                frm.Activate();
            else
            {
                DiChuyenPanel(btnLuong);
                frmLuong f2 = new frmLuong();
                f2.TopLevel = false;
                f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f2.Dock = DockStyle.Fill;
                f2.Show();
                panelCentral.Controls.Clear();
                panelCentral.Controls.Add(f2);
            }
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            Form frm = this.KTForm(typeof(frmHopDong));
            if (frm != null)
                frm.Activate();
            else
            {
                DiChuyenPanel(btnHopDong);
                frmHopDong f3 = new frmHopDong();
                f3.TopLevel = false;
                f3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f3.Dock = DockStyle.Fill;
                f3.Show();
                panelCentral.Controls.Clear();
                panelCentral.Controls.Add(f3);
            }
        }

        private void btnNghiPhep_Click(object sender, EventArgs e)
        {
            Form frm = this.KTForm(typeof(frmNghiPhep));
            if (frm != null)
                frm.Activate();
            else
            {
                DiChuyenPanel(btnNghiPhep);
                frmNghiPhep f4 = new frmNghiPhep();
                f4.TopLevel = false;
                f4.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f4.Dock = DockStyle.Fill;
                f4.Show();
                panelCentral.Controls.Clear();
                panelCentral.Controls.Add(f4);
            }
        }

        private void menuQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            frmUser f5 = new frmUser();
            f5.Show();
        }

        private void menuDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMk mk = new frmDoiMk();
            mk.ShowDialog();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            btnDangXuat_Click(sender, e);

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn đóng chương trình", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
            else if (traloi == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void frmMain_MaximumSizeChanged(object sender, EventArgs e)
        {
            Maximize(this);
        }

        private void frmMain_MinimumSizeChanged(object sender, EventArgs e)
        {
            Minimize(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuTroGiup_Click(object sender, EventArgs e)
        {
            Form frm = this.KTForm(typeof(frmTroGiup));
            if (frm != null)
                frm.Activate();
            else
            {
                DiChuyenPanel(btnNghiPhep);
                frmTroGiup f4 = new frmTroGiup();
                f4.TopLevel = false;
                f4.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f4.Dock = DockStyle.Fill;
                f4.Show();
                panelCentral.Controls.Clear();
                panelCentral.Controls.Add(f4);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã đăng xuất!!!", "THÔNG BÁO");
            frmDangNhap fdn = new frmDangNhap();
            this.Hide();
            fdn.ShowDialog();
        }
    }
}
