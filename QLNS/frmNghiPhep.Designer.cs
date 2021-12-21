namespace QLNS
{
    partial class frmNghiPhep
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgDSNghiPhep = new System.Windows.Forms.DataGridView();
            this.txtLydo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgayPhep = new System.Windows.Forms.DateTimePicker();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.gbChon = new System.Windows.Forms.GroupBox();
            this.radHoTen = new System.Windows.Forms.RadioButton();
            this.radMaNV = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.txtSoNgayNghi = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtMaNghiPhep = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSNghiPhep)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.gbChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QLNS.Properties.Resources.adjust;
            this.btnSua.Location = new System.Drawing.Point(804, 76);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 45);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QLNS.Properties.Resources.garbage_bin_104201;
            this.btnXoa.Location = new System.Drawing.Point(804, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 42);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(288, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QLNS.Properties.Resources.Itweek_Knob_Toolbar_Knob_Add;
            this.btnThem.Location = new System.Drawing.Point(804, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 45);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgDSNghiPhep
            // 
            this.dgDSNghiPhep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgDSNghiPhep.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgDSNghiPhep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSNghiPhep.Location = new System.Drawing.Point(15, 198);
            this.dgDSNghiPhep.Name = "dgDSNghiPhep";
            this.dgDSNghiPhep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDSNghiPhep.Size = new System.Drawing.Size(945, 309);
            this.dgDSNghiPhep.TabIndex = 25;
            this.dgDSNghiPhep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSNV_CellClick);
            // 
            // txtLydo
            // 
            this.txtLydo.Location = new System.Drawing.Point(433, 80);
            this.txtLydo.Name = "txtLydo";
            this.txtLydo.Size = new System.Drawing.Size(308, 26);
            this.txtLydo.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ngày nghỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lý do";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Số ngày nghỉ";
            // 
            // dtNgayPhep
            // 
            this.dtNgayPhep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayPhep.Location = new System.Drawing.Point(127, 77);
            this.dtNgayPhep.Name = "dtNgayPhep";
            this.dtNgayPhep.Size = new System.Drawing.Size(135, 26);
            this.dtNgayPhep.TabIndex = 18;
            this.dtNgayPhep.Value = new System.DateTime(2021, 12, 18, 0, 0, 0, 0);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(138, 31);
            this.txtMaNV.MaxLength = 5;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(135, 26);
            this.txtMaNV.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.txtSoNgayNghi);
            this.gbThongTin.Controls.Add(this.cboNV);
            this.gbThongTin.Controls.Add(this.gbChon);
            this.gbThongTin.Controls.Add(this.txtLydo);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.dtNgayPhep);
            this.gbThongTin.Controls.Add(this.btnSua);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.btnXoa);
            this.gbThongTin.Controls.Add(this.lbl1);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.txtMaNghiPhep);
            this.gbThongTin.Controls.Add(this.txtMaNV);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Location = new System.Drawing.Point(15, 14);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(945, 178);
            this.gbThongTin.TabIndex = 24;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Nhập thông tin";
            // 
            // gbChon
            // 
            this.gbChon.BackColor = System.Drawing.Color.Transparent;
            this.gbChon.Controls.Add(this.radHoTen);
            this.gbChon.Controls.Add(this.radMaNV);
            this.gbChon.Controls.Add(this.txtTimKiem);
            this.gbChon.Controls.Add(this.btnTim);
            this.gbChon.Location = new System.Drawing.Point(332, 112);
            this.gbChon.Name = "gbChon";
            this.gbChon.Size = new System.Drawing.Size(409, 66);
            this.gbChon.TabIndex = 22;
            this.gbChon.TabStop = false;
            this.gbChon.Text = "Tìm kiếm";
            // 
            // radHoTen
            // 
            this.radHoTen.AutoSize = true;
            this.radHoTen.BackColor = System.Drawing.Color.Transparent;
            this.radHoTen.Location = new System.Drawing.Point(261, 20);
            this.radHoTen.Name = "radHoTen";
            this.radHoTen.Size = new System.Drawing.Size(68, 23);
            this.radHoTen.TabIndex = 4;
            this.radHoTen.TabStop = true;
            this.radHoTen.Text = "Họ tên";
            this.radHoTen.UseVisualStyleBackColor = false;
            // 
            // radMaNV
            // 
            this.radMaNV.AutoSize = true;
            this.radMaNV.BackColor = System.Drawing.Color.Transparent;
            this.radMaNV.Location = new System.Drawing.Point(180, 21);
            this.radMaNV.Name = "radMaNV";
            this.radMaNV.Size = new System.Drawing.Size(75, 23);
            this.radMaNV.TabIndex = 3;
            this.radMaNV.TabStop = true;
            this.radMaNV.Text = "Mã NV";
            this.radMaNV.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(168, 26);
            this.txtTimKiem.TabIndex = 17;
            this.txtTimKiem.Text = "Nhập thông tin tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Image = global::QLNS.Properties.Resources.Itweek_Knob_Toolbar_Knob_Search;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(335, 16);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(67, 43);
            this.btnTim.TabIndex = 18;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(344, 30);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(151, 27);
            this.cboNV.TabIndex = 23;
            this.cboNV.SelectedIndexChanged += new System.EventHandler(this.cboNV_SelectedIndexChanged_1);
            // 
            // txtSoNgayNghi
            // 
            this.txtSoNgayNghi.Location = new System.Drawing.Point(124, 127);
            this.txtSoNgayNghi.Name = "txtSoNgayNghi";
            this.txtSoNgayNghi.Size = new System.Drawing.Size(138, 26);
            this.txtSoNgayNghi.TabIndex = 24;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Location = new System.Drawing.Point(519, 37);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(92, 19);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Mã nghỉ phép";
            // 
            // txtMaNghiPhep
            // 
            this.txtMaNghiPhep.Location = new System.Drawing.Point(617, 30);
            this.txtMaNghiPhep.MaxLength = 5;
            this.txtMaNghiPhep.Name = "txtMaNghiPhep";
            this.txtMaNghiPhep.Size = new System.Drawing.Size(172, 26);
            this.txtMaNghiPhep.TabIndex = 0;
            this.txtMaNghiPhep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmNghiPhep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 519);
            this.Controls.Add(this.dgDSNghiPhep);
            this.Controls.Add(this.gbThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNghiPhep";
            this.Load += new System.EventHandler(this.frmNghiPhep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSNghiPhep)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbChon.ResumeLayout(false);
            this.gbChon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgDSNghiPhep;
        private System.Windows.Forms.TextBox txtLydo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayPhep;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbChon;
        private System.Windows.Forms.RadioButton radHoTen;
        private System.Windows.Forms.RadioButton radMaNV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.TextBox txtSoNgayNghi;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtMaNghiPhep;
    }
}