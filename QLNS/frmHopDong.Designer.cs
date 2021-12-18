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
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHanHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbThuViec = new System.Windows.Forms.CheckBox();
            this.cbChinhThuc = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDSNV = new System.Windows.Forms.DataGridView();
            this.grbThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnSua);
            this.grbThongTin.Controls.Add(this.txtTenNV);
            this.grbThongTin.Controls.Add(this.btnThem);
            this.grbThongTin.Controls.Add(this.txtMaNV);
            this.grbThongTin.Controls.Add(this.btnXoa);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.dtNgayBD);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.txtHanHD);
            this.grbThongTin.Controls.Add(this.label8);
            this.grbThongTin.Controls.Add(this.groupBox1);
            this.grbThongTin.ForeColor = System.Drawing.Color.Black;
            this.grbThongTin.Location = new System.Drawing.Point(20, 12);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(938, 215);
            this.grbThongTin.TabIndex = 23;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Nhập thông tin";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNV.Location = new System.Drawing.Point(167, 31);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(382, 26);
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
            this.dtNgayBD.Size = new System.Drawing.Size(382, 26);
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
            this.txtHanHD.Size = new System.Drawing.Size(382, 26);
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
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenNV.Location = new System.Drawing.Point(167, 76);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(382, 26);
            this.txtTenNV.TabIndex = 21;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(790, 98);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 36);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(790, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 36);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(790, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 36);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // cbThuViec
            // 
            this.cbThuViec.AutoSize = true;
            this.cbThuViec.Location = new System.Drawing.Point(41, 51);
            this.cbThuViec.Name = "cbThuViec";
            this.cbThuViec.Size = new System.Drawing.Size(81, 23);
            this.cbThuViec.TabIndex = 27;
            this.cbThuViec.Text = "Thử việc";
            this.cbThuViec.UseVisualStyleBackColor = true;
            // 
            // cbChinhThuc
            // 
            this.cbChinhThuc.AutoSize = true;
            this.cbChinhThuc.Location = new System.Drawing.Point(41, 101);
            this.cbChinhThuc.Name = "cbChinhThuc";
            this.cbChinhThuc.Size = new System.Drawing.Size(94, 23);
            this.cbChinhThuc.TabIndex = 27;
            this.cbChinhThuc.Text = "Chính thức";
            this.cbChinhThuc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChinhThuc);
            this.groupBox1.Controls.Add(this.cbThuViec);
            this.groupBox1.Location = new System.Drawing.Point(583, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 164);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại hợp đồng";
            // 
            // dtgvDSNV
            // 
            this.dtgvDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvDSNV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSNV.Location = new System.Drawing.Point(20, 233);
            this.dtgvDSNV.Name = "dtgvDSNV";
            this.dtgvDSNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSNV.Size = new System.Drawing.Size(938, 274);
            this.dtgvDSNV.TabIndex = 26;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 519);
            this.Controls.Add(this.dtgvDSNV);
            this.Controls.Add(this.grbThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHopDong";
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNV)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbChinhThuc;
        private System.Windows.Forms.CheckBox cbThuViec;
        private System.Windows.Forms.DataGridView dtgvDSNV;
    }
}