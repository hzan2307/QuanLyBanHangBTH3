namespace BuoiTH2_Bai1
{
    partial class frmSanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            gbTTSanPham = new GroupBox();
            groupBox2 = new GroupBox();
            cboLoaiSanPham = new ComboBox();
            cboHangSanXuat = new ComboBox();
            txtTenSanPham = new TextBox();
            txtMoTa = new TextBox();
            numSoLuong = new NumericUpDown();
            numDonGia = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            bthXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            picHinhAnh = new PictureBox();
            btnDoiAnh = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            gbTTSanPham.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbTTSanPham
            // 
            gbTTSanPham.Controls.Add(btnDoiAnh);
            gbTTSanPham.Controls.Add(picHinhAnh);
            gbTTSanPham.Controls.Add(btnXuat);
            gbTTSanPham.Controls.Add(btnNhap);
            gbTTSanPham.Controls.Add(btnTimKiem);
            gbTTSanPham.Controls.Add(btnThoat);
            gbTTSanPham.Controls.Add(btnHuyBo);
            gbTTSanPham.Controls.Add(btnLuu);
            gbTTSanPham.Controls.Add(bthXoa);
            gbTTSanPham.Controls.Add(btnSua);
            gbTTSanPham.Controls.Add(btnThem);
            gbTTSanPham.Controls.Add(label6);
            gbTTSanPham.Controls.Add(label5);
            gbTTSanPham.Controls.Add(label4);
            gbTTSanPham.Controls.Add(label3);
            gbTTSanPham.Controls.Add(label2);
            gbTTSanPham.Controls.Add(label1);
            gbTTSanPham.Controls.Add(numDonGia);
            gbTTSanPham.Controls.Add(numSoLuong);
            gbTTSanPham.Controls.Add(txtMoTa);
            gbTTSanPham.Controls.Add(txtTenSanPham);
            gbTTSanPham.Controls.Add(cboHangSanXuat);
            gbTTSanPham.Controls.Add(cboLoaiSanPham);
            gbTTSanPham.Location = new Point(12, 12);
            gbTTSanPham.Name = "gbTTSanPham";
            gbTTSanPham.Size = new Size(776, 201);
            gbTTSanPham.TabIndex = 0;
            gbTTSanPham.TabStop = false;
            gbTTSanPham.Text = "Thông Tin Sản Phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 219);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Sản Phẩm";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(87, 21);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(187, 23);
            cboLoaiSanPham.TabIndex = 0;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(87, 50);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(187, 23);
            cboHangSanXuat.TabIndex = 1;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(87, 79);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(413, 23);
            txtTenSanPham.TabIndex = 2;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(87, 108);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(413, 23);
            txtMoTa.TabIndex = 3;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(380, 21);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(120, 23);
            numSoLuong.TabIndex = 4;
            numSoLuong.ThousandsSeparator = true;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(380, 50);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(120, 23);
            numDonGia.TabIndex = 5;
            numDonGia.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 6;
            label1.Text = "Phân Loại (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 7;
            label2.Text = "Hãng SX (*):";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Tên  SP(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 9;
            label4.Text = "Mô Tả SP (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 23);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 10;
            label5.Text = "Số Lượng (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 54);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 11;
            label6.Text = "Đơn Giá (*):";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(29, 148);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(110, 148);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // bthXoa
            // 
            bthXoa.ForeColor = Color.Brown;
            bthXoa.Location = new Point(191, 148);
            bthXoa.Name = "bthXoa";
            bthXoa.Size = new Size(75, 23);
            bthXoa.TabIndex = 14;
            bthXoa.Text = "Xóa";
            bthXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(272, 148);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(353, 148);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 23);
            btnHuyBo.TabIndex = 16;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(434, 148);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(515, 148);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 18;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(596, 148);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 23);
            btnNhap.TabIndex = 19;
            btnNhap.Text = "Nhập..";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(677, 148);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 23);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(538, 21);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(95, 110);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 21;
            picHinhAnh.TabStop = false;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(639, 22);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(75, 23);
            btnDoiAnh.TabIndex = 22;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(770, 197);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "PhânLoại";
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng SX";
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên SP";
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            DonGia.DefaultCellStyle = dataGridViewCellStyle2;
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình Ảnh";
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(gbTTSanPham);
            Name = "frmSanPham";
            Text = "SanPham";
            gbTTSanPham.ResumeLayout(false);
            gbTTSanPham.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbTTSanPham;
        private GroupBox groupBox2;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private TextBox txtMoTa;
        private TextBox txtTenSanPham;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button bthXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}
