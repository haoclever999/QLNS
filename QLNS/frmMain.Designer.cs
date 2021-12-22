namespace QLNS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNghiPhep = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnLuong = new System.Windows.Forms.Button();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.btnNhanSu = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.panelCentral);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(116, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 543);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Image = global::QLNS.Properties.Resources.x_button;
            this.btnThoat.Location = new System.Drawing.Point(949, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(29, 24);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.White;
            this.panelCentral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCentral.BackgroundImage")));
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCentral.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentral.Location = new System.Drawing.Point(0, 24);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(978, 519);
            this.panelCentral.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTaiKhoan,
            this.menuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLyTaiKhoan,
            this.menuDoiMatKhau,
            this.menuDangXuat});
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(69, 20);
            this.menuTaiKhoan.Text = "Tài khoản";
            // 
            // menuQuanLyTaiKhoan
            // 
            this.menuQuanLyTaiKhoan.Name = "menuQuanLyTaiKhoan";
            this.menuQuanLyTaiKhoan.Size = new System.Drawing.Size(167, 22);
            this.menuQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.menuQuanLyTaiKhoan.Click += new System.EventHandler(this.menuQuanLyTaiKhoan_Click);
            // 
            // menuDoiMatKhau
            // 
            this.menuDoiMatKhau.Name = "menuDoiMatKhau";
            this.menuDoiMatKhau.Size = new System.Drawing.Size(167, 22);
            this.menuDoiMatKhau.Text = "Đổi mật khẩu";
            this.menuDoiMatKhau.Click += new System.EventHandler(this.menuDoiMatKhau_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(167, 22);
            this.menuDangXuat.Text = "Đăng xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuTroGiup
            // 
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new System.Drawing.Size(62, 20);
            this.menuTroGiup.Text = "Trợ giúp";
            this.menuTroGiup.Click += new System.EventHandler(this.menuTroGiup_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = global::QLNS.Properties.Resources.c41af8sehaf1d3be;
            this.panelLeft.Controls.Add(this.btnDangXuat);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.btnNghiPhep);
            this.panelLeft.Controls.Add(this.btnHopDong);
            this.panelLeft.Controls.Add(this.btnLuong);
            this.panelLeft.Controls.Add(this.btnTongQuan);
            this.panelLeft.Controls.Add(this.btnNhanSu);
            this.panelLeft.Controls.Add(this.panelSlide);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(116, 543);
            this.panelLeft.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Image = global::QLNS.Properties.Resources.power;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 485);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(113, 55);
            this.btnDangXuat.TabIndex = 34;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLNS.Properties.Resources._189_1894796_cathay_life_việt_nam_mở_3_văn_phòng_kinh_doanh_mới_cathay_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnNghiPhep
            // 
            this.btnNghiPhep.BackColor = System.Drawing.Color.Transparent;
            this.btnNghiPhep.FlatAppearance.BorderSize = 0;
            this.btnNghiPhep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNghiPhep.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNghiPhep.Image = global::QLNS.Properties.Resources.switch_off;
            this.btnNghiPhep.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNghiPhep.Location = new System.Drawing.Point(4, 285);
            this.btnNghiPhep.Name = "btnNghiPhep";
            this.btnNghiPhep.Size = new System.Drawing.Size(111, 53);
            this.btnNghiPhep.TabIndex = 35;
            this.btnNghiPhep.Text = "Nghỉ phép";
            this.btnNghiPhep.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNghiPhep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNghiPhep.UseVisualStyleBackColor = false;
            this.btnNghiPhep.Click += new System.EventHandler(this.btnNghiPhep_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.Color.Transparent;
            this.btnHopDong.FlatAppearance.BorderSize = 0;
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHopDong.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.Image = global::QLNS.Properties.Resources.icons8_signing_a_document_48;
            this.btnHopDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHopDong.Location = new System.Drawing.Point(4, 232);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(111, 53);
            this.btnHopDong.TabIndex = 36;
            this.btnHopDong.Text = "Hợp đồng";
            this.btnHopDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.Color.Transparent;
            this.btnLuong.FlatAppearance.BorderSize = 0;
            this.btnLuong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuong.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuong.Image = global::QLNS.Properties.Resources.coin_dollar_2534;
            this.btnLuong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuong.Location = new System.Drawing.Point(4, 179);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(111, 53);
            this.btnLuong.TabIndex = 37;
            this.btnLuong.Text = "Lương";
            this.btnLuong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTongQuan.BackColor = System.Drawing.Color.Transparent;
            this.btnTongQuan.FlatAppearance.BorderSize = 0;
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTongQuan.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongQuan.ForeColor = System.Drawing.Color.Black;
            this.btnTongQuan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTongQuan.ImageKey = "(none)";
            this.btnTongQuan.Location = new System.Drawing.Point(5, 73);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Size = new System.Drawing.Size(111, 53);
            this.btnTongQuan.TabIndex = 38;
            this.btnTongQuan.Text = "Tổng quan";
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTongQuan.UseVisualStyleBackColor = false;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // btnNhanSu
            // 
            this.btnNhanSu.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanSu.FlatAppearance.BorderSize = 0;
            this.btnNhanSu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhanSu.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanSu.Image = global::QLNS.Properties.Resources.icons8_people_64;
            this.btnNhanSu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNhanSu.Location = new System.Drawing.Point(4, 126);
            this.btnNhanSu.Name = "btnNhanSu";
            this.btnNhanSu.Size = new System.Drawing.Size(111, 53);
            this.btnNhanSu.TabIndex = 39;
            this.btnNhanSu.Text = "Nhân sự";
            this.btnNhanSu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhanSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNhanSu.UseVisualStyleBackColor = false;
            this.btnNhanSu.Click += new System.EventHandler(this.btnNhanSu_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.DarkGreen;
            this.panelSlide.Location = new System.Drawing.Point(2, 72);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(4, 53);
            this.panelSlide.TabIndex = 40;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Quản lý nhân sự";
            this.MaximumSizeChanged += new System.EventHandler(this.frmMain_MaximumSizeChanged);
            this.MinimumSizeChanged += new System.EventHandler(this.frmMain_MinimumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuTroGiup;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNghiPhep;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Button btnNhanSu;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem menuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.Button btnThoat;
    }
}