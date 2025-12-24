namespace TTCSDL_NHOM7.UserControls
{
    partial class QuanLyMonAnUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnXoaAnh = new Button();
            btnChonAnh = new Button();
            picHinhAnh = new PictureBox();
            cboTrangThai = new ComboBox();
            cboLoaiMon = new ComboBox();
            txtDonGia = new TextBox();
            txtMoTa = new TextBox();
            txtTenMon = new TextBox();
            txtMaMon = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dgvMonAn = new DataGridView();
            label8 = new Label();
            txtTimKiem = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaAnh);
            groupBox1.Controls.Add(btnChonAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(cboLoaiMon);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(txtTenMon);
            groupBox1.Controls.Add(txtMaMon);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(838, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin món ăn";
            // 
            // btnXoaAnh
            // 
            btnXoaAnh.Font = new Font("Microsoft Sans Serif", 9F);
            btnXoaAnh.Location = new Point(737, 177);
            btnXoaAnh.Name = "btnXoaAnh";
            btnXoaAnh.Size = new Size(85, 25);
            btnXoaAnh.TabIndex = 8;
            btnXoaAnh.Text = "Xóa ảnh";
            btnXoaAnh.UseVisualStyleBackColor = true;
            btnXoaAnh.Click += btnXoaAnh_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Font = new Font("Microsoft Sans Serif", 9F);
            btnChonAnh.Location = new Point(647, 177);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(85, 25);
            btnChonAnh.TabIndex = 7;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.BackColor = Color.WhiteSmoke;
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(647, 24);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(175, 145);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 14;
            picHinhAnh.TabStop = false;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Microsoft Sans Serif", 9.5F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(380, 180);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(200, 24);
            cboTrangThai.TabIndex = 6;
            // 
            // cboLoaiMon
            // 
            cboLoaiMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiMon.Font = new Font("Microsoft Sans Serif", 9.5F);
            cboLoaiMon.FormattingEnabled = true;
            cboLoaiMon.Location = new Point(380, 145);
            cboLoaiMon.Name = "cboLoaiMon";
            cboLoaiMon.Size = new Size(200, 24);
            cboLoaiMon.TabIndex = 5;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtDonGia.Location = new Point(380, 110);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(200, 22);
            txtDonGia.TabIndex = 4;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtMoTa.Location = new Point(120, 110);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(171, 95);
            txtMoTa.TabIndex = 3;
            // 
            // txtTenMon
            // 
            txtTenMon.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtTenMon.Location = new Point(120, 70);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(171, 22);
            txtTenMon.TabIndex = 2;
            // 
            // txtMaMon
            // 
            txtMaMon.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtMaMon.Location = new Point(120, 30);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(171, 22);
            txtMaMon.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.5F);
            label6.Location = new Point(309, 183);
            label6.Name = "label6";
            label6.Size = new Size(70, 16);
            label6.TabIndex = 5;
            label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.5F);
            label5.Location = new Point(309, 148);
            label5.Name = "label5";
            label5.Size = new Size(65, 16);
            label5.TabIndex = 4;
            label5.Text = "Loại món:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.5F);
            label4.Location = new Point(309, 113);
            label4.Name = "label4";
            label4.Size = new Size(56, 16);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.5F);
            label3.Location = new Point(25, 113);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 2;
            label3.Text = "Mô tả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.5F);
            label2.Location = new Point(25, 73);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 1;
            label2.Text = "Tên món:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.5F);
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 16);
            label1.TabIndex = 0;
            label1.Text = "Mã món:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.5F);
            label7.Location = new Point(309, 33);
            label7.Name = "label7";
            label7.Size = new Size(62, 16);
            label7.TabIndex = 6;
            label7.Text = "Hình ảnh:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLamMoi);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(859, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(150, 220);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(20, 165);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 40);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(20, 118);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 40);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 193, 7);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(20, 71);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(20, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvMonAn);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            groupBox3.Location = new Point(15, 245);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(974, 258);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách món ăn";
            // 
            // dgvMonAn
            // 
            dgvMonAn.AllowUserToAddRows = false;
            dgvMonAn.AllowUserToDeleteRows = false;
            dgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonAn.BackgroundColor = Color.White;
            dgvMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonAn.Location = new Point(6, 65);
            dgvMonAn.Name = "dgvMonAn";
            dgvMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonAn.Size = new Size(962, 187);
            dgvMonAn.TabIndex = 2;
            dgvMonAn.CellClick += dgvMonAn_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.5F);
            label8.Location = new Point(15, 33);
            label8.Name = "label8";
            label8.Size = new Size(65, 16);
            label8.TabIndex = 1;
            label8.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtTimKiem.Location = new Point(90, 30);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(302, 22);
            txtTimKiem.TabIndex = 13;
            // 
            // QuanLyMonAnUC
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QuanLyMonAnUC";
            Size = new Size(1012, 516);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboLoaiMon;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnXoaAnh;
        private System.Windows.Forms.DataGridView dgvMonAn;

    }
}
