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

        private void btnTuyenDung_Click(object sender, EventArgs e)
        {

        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {

        }

        private void btnNghiPhep_Click(object sender, EventArgs e)
        {

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn đóng chương trình", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        
    }
}
