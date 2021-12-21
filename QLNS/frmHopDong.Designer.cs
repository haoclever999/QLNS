namespace QLNS
{
    partial class frmHopDong
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
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHanHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvDSNV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnThem);
            this.grbThongTin.Controls.Add(this.cboNV);
            this.grbThongTin.Controls.Add(this.btnSua);
            this.grbThongTin.Controls.Add(this.txtMaNV);
            this.grbThongTin.Controls.Add(this.btnXoa);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.dtNgayBD);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.txtHanHD);
            this.grbThongTin.Controls.Add(this.label8);
            this.grbThongTin.ForeColor = System.Drawing.Color.Black;
            this.grbThongTin.Location = new System.Drawing.Point(12, 93);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(386, 391);
            this.grbThongTin.TabIndex = 23;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Nhập thông tin";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLNS.Properties.Resources.garbage_bin_10420;
            this.btnXoa.Location = new System.Drawing.Point(278, 278);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 44);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLNS.Properties.Resources.adjust;
            this.btnSua.Location = new System.Drawing.Point(139, 278);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 43);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QLNS.Properties.Resources.Itweek_Knob_Toolbar_Knob_Add;
            this.btnThem.Location = new System.Drawing.Point(6, 279);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 42);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(167, 80);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(193, 27);
            this.cboNV.TabIndex = 29;
            this.cboNV.SelectedIndexChanged += new System.EventHandler(this.cboNV_SelectedIndexChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(167, 31);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(193, 26);
            this.txtMaNV.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên nhân viên";
            // 
            // dtNgayBD
            // 
            this.dtNgayBD.Location = new System.Drawing.Point(167, 167);
            this.dtNgayBD.Name = "dtNgayBD";
            this.dtNgayBD.Size = new System.Drawing.Size(193, 26);
            this.dtNgayBD.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hạn hợp đồng";
            // 
            // txtHanHD
            // 
            this.txtHanHD.BackColor = System.Drawing.SystemColors.Window;
            this.txtHanHD.Location = new System.Drawing.Point(167, 123);
            this.txtHanHD.Name = "txtHanHD";
            this.txtHanHD.Size = new System.Drawing.Size(193, 26);
            this.txtHanHD.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(41, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày bắt đầu";
            // 
            // dtgvDSNV
            // 
            this.dtgvDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvDSNV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSNV.Location = new System.Drawing.Point(416, 102);
            this.dtgvDSNV.Name = "dtgvDSNV";
            this.dtgvDSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSNV.Size = new System.Drawing.Size(549, 382);
            this.dtgvDSNV.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(348, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "QUẢN LÝ HỢP ĐỒNG";
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvDSNV);
            this.Controls.Add(this.grbThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHopDong";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHanHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgvDSNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
    }
}