namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    partial class QuanLyGheUC
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
            tabControl1 = new TabControl();
            tabLoaiGhe = new TabPage();
            groupBox1 = new GroupBox();
            txtChiPhi = new TextBox();
            txtTenLoaiGhe = new TextBox();
            txtMaLoaiGhe = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoaLoaiGhe = new Button();
            btnSuaLoaiGhe = new Button();
            btnThemLoaiGhe = new Button();
            groupBox3 = new GroupBox();
            dgvLoaiGhe = new DataGridView();
            tabGhe = new TabPage();
            groupBox4 = new GroupBox();
            lblTongGhe = new Label();
            txtTimKiem = new TextBox();
            label9 = new Label();
            lblThongTinGhe = new Label();
            btnCapNhatLoaiGhe = new Button();
            cboLoaiGhe = new ComboBox();
            label8 = new Label();
            dgvGhe = new DataGridView();
            groupBox5 = new GroupBox();
            btnXoaTatCaGhe = new Button();
            btnSinhGhe = new Button();
            txtSoCot = new TextBox();
            txtSoHang = new TextBox();
            cboPhongChieu = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabLoaiGhe.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiGhe).BeginInit();
            tabGhe.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGhe).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabLoaiGhe);
            tabControl1.Controls.Add(tabGhe);
            tabControl1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            tabControl1.Location = new Point(13, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(985, 489);
            tabControl1.TabIndex = 0;
            // 
            // tabLoaiGhe
            // 
            tabLoaiGhe.BackColor = Color.White;
            tabLoaiGhe.Controls.Add(groupBox1);
            tabLoaiGhe.Controls.Add(groupBox2);
            tabLoaiGhe.Controls.Add(groupBox3);
            tabLoaiGhe.Location = new Point(4, 25);
            tabLoaiGhe.Name = "tabLoaiGhe";
            tabLoaiGhe.Padding = new Padding(3);
            tabLoaiGhe.Size = new Size(977, 460);
            tabLoaiGhe.TabIndex = 0;
            tabLoaiGhe.Text = "Quản lý Loại Ghế";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChiPhi);
            groupBox1.Controls.Add(txtTenLoaiGhe);
            groupBox1.Controls.Add(txtMaLoaiGhe);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(30, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(737, 130);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại ghế";
            // 
            // txtChiPhi
            // 
            txtChiPhi.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtChiPhi.Location = new Point(455, 83);
            txtChiPhi.Name = "txtChiPhi";
            txtChiPhi.Size = new Size(250, 22);
            txtChiPhi.TabIndex = 5;
            // 
            // txtTenLoaiGhe
            // 
            txtTenLoaiGhe.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtTenLoaiGhe.Location = new Point(140, 80);
            txtTenLoaiGhe.Name = "txtTenLoaiGhe";
            txtTenLoaiGhe.Size = new Size(200, 22);
            txtTenLoaiGhe.TabIndex = 4;
            // 
            // txtMaLoaiGhe
            // 
            txtMaLoaiGhe.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtMaLoaiGhe.Location = new Point(140, 40);
            txtMaLoaiGhe.Name = "txtMaLoaiGhe";
            txtMaLoaiGhe.Size = new Size(200, 22);
            txtMaLoaiGhe.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.5F);
            label3.Location = new Point(365, 86);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 2;
            label3.Text = "Chi phí (đ):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.5F);
            label2.Location = new Point(25, 83);
            label2.Name = "label2";
            label2.Size = new Size(85, 16);
            label2.TabIndex = 1;
            label2.Text = "Tên loại ghế:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.5F);
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(80, 16);
            label1.TabIndex = 0;
            label1.Text = "Mã loại ghế:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoaLoaiGhe);
            groupBox2.Controls.Add(btnSuaLoaiGhe);
            groupBox2.Controls.Add(btnThemLoaiGhe);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(811, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(135, 200);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnXoaLoaiGhe
            // 
            btnXoaLoaiGhe.BackColor = Color.FromArgb(220, 53, 69);
            btnXoaLoaiGhe.FlatStyle = FlatStyle.Flat;
            btnXoaLoaiGhe.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnXoaLoaiGhe.ForeColor = Color.White;
            btnXoaLoaiGhe.Location = new Point(15, 130);
            btnXoaLoaiGhe.Name = "btnXoaLoaiGhe";
            btnXoaLoaiGhe.Size = new Size(105, 40);
            btnXoaLoaiGhe.TabIndex = 2;
            btnXoaLoaiGhe.Text = "Xóa";
            btnXoaLoaiGhe.UseVisualStyleBackColor = false;
            btnXoaLoaiGhe.Click += btnXoaLoaiGhe_Click;
            // 
            // btnSuaLoaiGhe
            // 
            btnSuaLoaiGhe.BackColor = Color.FromArgb(255, 193, 7);
            btnSuaLoaiGhe.FlatStyle = FlatStyle.Flat;
            btnSuaLoaiGhe.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnSuaLoaiGhe.ForeColor = Color.White;
            btnSuaLoaiGhe.Location = new Point(15, 80);
            btnSuaLoaiGhe.Name = "btnSuaLoaiGhe";
            btnSuaLoaiGhe.Size = new Size(105, 40);
            btnSuaLoaiGhe.TabIndex = 1;
            btnSuaLoaiGhe.Text = "Sửa";
            btnSuaLoaiGhe.UseVisualStyleBackColor = false;
            btnSuaLoaiGhe.Click += btnSuaLoaiGhe_Click;
            // 
            // btnThemLoaiGhe
            // 
            btnThemLoaiGhe.BackColor = Color.FromArgb(40, 167, 69);
            btnThemLoaiGhe.FlatStyle = FlatStyle.Flat;
            btnThemLoaiGhe.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnThemLoaiGhe.ForeColor = Color.White;
            btnThemLoaiGhe.Location = new Point(15, 30);
            btnThemLoaiGhe.Name = "btnThemLoaiGhe";
            btnThemLoaiGhe.Size = new Size(105, 40);
            btnThemLoaiGhe.TabIndex = 0;
            btnThemLoaiGhe.Text = "Thêm";
            btnThemLoaiGhe.UseVisualStyleBackColor = false;
            btnThemLoaiGhe.Click += btnThemLoaiGhe_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvLoaiGhe);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            groupBox3.Location = new Point(15, 221);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(945, 219);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách loại ghế";
            // 
            // dgvLoaiGhe
            // 
            dgvLoaiGhe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiGhe.BackgroundColor = Color.White;
            dgvLoaiGhe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiGhe.Location = new Point(15, 38);
            dgvLoaiGhe.Name = "dgvLoaiGhe";
            dgvLoaiGhe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiGhe.Size = new Size(916, 163);
            dgvLoaiGhe.TabIndex = 0;
            dgvLoaiGhe.CellClick += dgvLoaiGhe_CellClick;
            // 
            // tabGhe
            // 
            tabGhe.BackColor = Color.White;
            tabGhe.Controls.Add(groupBox4);
            tabGhe.Controls.Add(groupBox5);
            tabGhe.Location = new Point(4, 25);
            tabGhe.Name = "tabGhe";
            tabGhe.Padding = new Padding(3);
            tabGhe.Size = new Size(977, 460);
            tabGhe.TabIndex = 1;
            tabGhe.Text = "Quản lý Ghế";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblTongGhe);
            groupBox4.Controls.Add(txtTimKiem);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(lblThongTinGhe);
            groupBox4.Controls.Add(btnCapNhatLoaiGhe);
            groupBox4.Controls.Add(cboLoaiGhe);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(dgvGhe);
            groupBox4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            groupBox4.Location = new Point(15, 180);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(946, 259);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách ghế";
            // 
            // lblTongGhe
            // 
            lblTongGhe.AutoSize = true;
            lblTongGhe.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            lblTongGhe.ForeColor = Color.Blue;
            lblTongGhe.Location = new Point(25, 360);
            lblTongGhe.Name = "lblTongGhe";
            lblTongGhe.Size = new Size(98, 16);
            lblTongGhe.TabIndex = 7;
            lblTongGhe.Text = "Tổng số ghế:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtTimKiem.Location = new Point(110, 30);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(300, 22);
            txtTimKiem.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.5F);
            label9.Location = new Point(25, 33);
            label9.Name = "label9";
            label9.Size = new Size(65, 16);
            label9.TabIndex = 5;
            label9.Text = "Tìm kiếm:";
            // 
            // lblThongTinGhe
            // 
            lblThongTinGhe.AutoSize = true;
            lblThongTinGhe.Font = new Font("Microsoft Sans Serif", 9.5F);
            lblThongTinGhe.ForeColor = Color.Green;
            lblThongTinGhe.Location = new Point(740, 33);
            lblThongTinGhe.Name = "lblThongTinGhe";
            lblThongTinGhe.Size = new Size(122, 16);
            lblThongTinGhe.TabIndex = 4;
            lblThongTinGhe.Text = "Chưa chọn ghế nào";
            // 
            // btnCapNhatLoaiGhe
            // 
            btnCapNhatLoaiGhe.BackColor = Color.FromArgb(0, 123, 255);
            btnCapNhatLoaiGhe.FlatStyle = FlatStyle.Flat;
            btnCapNhatLoaiGhe.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnCapNhatLoaiGhe.ForeColor = Color.White;
            btnCapNhatLoaiGhe.Location = new Point(640, 27);
            btnCapNhatLoaiGhe.Name = "btnCapNhatLoaiGhe";
            btnCapNhatLoaiGhe.Size = new Size(90, 28);
            btnCapNhatLoaiGhe.TabIndex = 3;
            btnCapNhatLoaiGhe.Text = "Cập nhật";
            btnCapNhatLoaiGhe.UseVisualStyleBackColor = false;
            btnCapNhatLoaiGhe.Click += btnCapNhatLoaiGhe_Click;
            // 
            // cboLoaiGhe
            // 
            cboLoaiGhe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiGhe.Font = new Font("Microsoft Sans Serif", 9.5F);
            cboLoaiGhe.FormattingEnabled = true;
            cboLoaiGhe.Location = new Point(490, 30);
            cboLoaiGhe.Name = "cboLoaiGhe";
            cboLoaiGhe.Size = new Size(140, 24);
            cboLoaiGhe.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.5F);
            label8.Location = new Point(425, 33);
            label8.Name = "label8";
            label8.Size = new Size(62, 16);
            label8.TabIndex = 1;
            label8.Text = "Loại ghế:";
            // 
            // dgvGhe
            // 
            dgvGhe.BackgroundColor = Color.White;
            dgvGhe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGhe.Location = new Point(15, 65);
            dgvGhe.Name = "dgvGhe";
            dgvGhe.Size = new Size(911, 185);
            dgvGhe.TabIndex = 0;
            dgvGhe.CellContentClick += dgvGhe_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnXoaTatCaGhe);
            groupBox5.Controls.Add(btnSinhGhe);
            groupBox5.Controls.Add(txtSoCot);
            groupBox5.Controls.Add(txtSoHang);
            groupBox5.Controls.Add(cboPhongChieu);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            groupBox5.Location = new Point(15, 15);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(946, 155);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Sinh ghế tự động";
            // 
            // btnXoaTatCaGhe
            // 
            btnXoaTatCaGhe.BackColor = Color.FromArgb(220, 53, 69);
            btnXoaTatCaGhe.FlatStyle = FlatStyle.Flat;
            btnXoaTatCaGhe.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            btnXoaTatCaGhe.ForeColor = Color.White;
            btnXoaTatCaGhe.Location = new Point(786, 91);
            btnXoaTatCaGhe.Name = "btnXoaTatCaGhe";
            btnXoaTatCaGhe.Size = new Size(140, 40);
            btnXoaTatCaGhe.TabIndex = 8;
            btnXoaTatCaGhe.Text = "Xóa tất cả ghế";
            btnXoaTatCaGhe.UseVisualStyleBackColor = false;
            btnXoaTatCaGhe.Click += btnXoaTatCaGhe_Click;
            // 
            // btnSinhGhe
            // 
            btnSinhGhe.BackColor = Color.FromArgb(40, 167, 69);
            btnSinhGhe.FlatStyle = FlatStyle.Flat;
            btnSinhGhe.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnSinhGhe.ForeColor = Color.White;
            btnSinhGhe.Location = new Point(786, 31);
            btnSinhGhe.Name = "btnSinhGhe";
            btnSinhGhe.Size = new Size(140, 50);
            btnSinhGhe.TabIndex = 7;
            btnSinhGhe.Text = "Sinh ghế";
            btnSinhGhe.UseVisualStyleBackColor = false;
            btnSinhGhe.Click += btnSinhGhe_Click;
            // 
            // txtSoCot
            // 
            txtSoCot.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtSoCot.Location = new Point(480, 95);
            txtSoCot.Name = "txtSoCot";
            txtSoCot.ReadOnly = true;
            txtSoCot.Size = new Size(223, 22);
            txtSoCot.TabIndex = 6;
            // 
            // txtSoHang
            // 
            txtSoHang.Font = new Font("Microsoft Sans Serif", 9.5F);
            txtSoHang.Location = new Point(140, 95);
            txtSoHang.Name = "txtSoHang";
            txtSoHang.ReadOnly = true;
            txtSoHang.Size = new Size(149, 22);
            txtSoHang.TabIndex = 5;
            // 
            // cboPhongChieu
            // 
            cboPhongChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongChieu.Font = new Font("Microsoft Sans Serif", 9.5F);
            cboPhongChieu.FormattingEnabled = true;
            cboPhongChieu.Location = new Point(140, 45);
            cboPhongChieu.Name = "cboPhongChieu";
            cboPhongChieu.Size = new Size(449, 24);
            cboPhongChieu.TabIndex = 4;
            cboPhongChieu.SelectedIndexChanged += cboPhongChieu_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.5F);
            label7.Location = new Point(350, 98);
            label7.Name = "label7";
            label7.Size = new Size(111, 16);
            label7.TabIndex = 3;
            label7.Text = "Số ghế mỗi hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.5F);
            label6.Location = new Point(25, 98);
            label6.Name = "label6";
            label6.Size = new Size(86, 16);
            label6.TabIndex = 2;
            label6.Text = "Số hàng ghế:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.5F);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(350, 120);
            label5.Name = "label5";
            label5.Size = new Size(353, 16);
            label5.TabIndex = 1;
            label5.Text = "Ghi chú: Hàng cuối(s) sẽ được gán là loại VIP (tùy cấu hình)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.5F);
            label4.Location = new Point(25, 50);
            label4.Name = "label4";
            label4.Size = new Size(84, 16);
            label4.TabIndex = 0;
            label4.Text = "Phòng chiếu:";
            // 
            // QuanLyGheUC
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(tabControl1);
            Name = "QuanLyGheUC";
            Size = new Size(1012, 516);
            tabControl1.ResumeLayout(false);
            tabLoaiGhe.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiGhe).EndInit();
            tabGhe.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGhe).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        // Controls declaration
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLoaiGhe;
        private System.Windows.Forms.TabPage tabGhe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblThongTinGhe;
        private System.Windows.Forms.Label lblTongGhe;
        private System.Windows.Forms.TextBox txtMaLoaiGhe;
        private System.Windows.Forms.TextBox txtTenLoaiGhe;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.TextBox txtSoHang;
        private System.Windows.Forms.TextBox txtSoCot;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboPhongChieu;
        private System.Windows.Forms.ComboBox cboLoaiGhe;
        private System.Windows.Forms.Button btnThemLoaiGhe;
        private System.Windows.Forms.Button btnSuaLoaiGhe;
        private System.Windows.Forms.Button btnXoaLoaiGhe;
        private System.Windows.Forms.Button btnSinhGhe;
        private System.Windows.Forms.Button btnXoaTatCaGhe;
        private System.Windows.Forms.Button btnCapNhatLoaiGhe;
        private System.Windows.Forms.DataGridView dgvLoaiGhe;
        private System.Windows.Forms.DataGridView dgvGhe;
    }
}
