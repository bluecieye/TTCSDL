namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    partial class PhongChieuUC
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
            btn_Sua = new Button();
            dtgv_PhongChieuUC = new DataGridView();
            btn_Them = new Button();
            btn_TimKiem = new Button();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_MaPhongChieu = new TextBox();
            panel1 = new Panel();
            txt_SoCotGhe = new TextBox();
            label8 = new Label();
            txt_SoHangGhe = new TextBox();
            label7 = new Label();
            combox_LoaiManHinh = new ComboBox();
            txt_SoGhe = new TextBox();
            label6 = new Label();
            txt_TinhTrangPhong = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_TenPhongChieu = new TextBox();
            btn_Xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_PhongChieuUC).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = Color.FromArgb(128, 255, 255);
            btn_Sua.FlatStyle = FlatStyle.Popup;
            btn_Sua.Location = new Point(223, 16);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(96, 30);
            btn_Sua.TabIndex = 26;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // dtgv_PhongChieuUC
            // 
            dtgv_PhongChieuUC.AllowUserToAddRows = false;
            dtgv_PhongChieuUC.AllowUserToDeleteRows = false;
            dtgv_PhongChieuUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_PhongChieuUC.BorderStyle = BorderStyle.Fixed3D;
            dtgv_PhongChieuUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_PhongChieuUC.Dock = DockStyle.Bottom;
            dtgv_PhongChieuUC.Location = new Point(0, 63);
            dtgv_PhongChieuUC.MultiSelect = false;
            dtgv_PhongChieuUC.Name = "dtgv_PhongChieuUC";
            dtgv_PhongChieuUC.ReadOnly = true;
            dtgv_PhongChieuUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_PhongChieuUC.Size = new Size(701, 427);
            dtgv_PhongChieuUC.TabIndex = 25;
            //dtgv_PhongChieuUC.CellClick += dtgv_PhongChieuUC_CellClick;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.FromArgb(128, 255, 255);
            btn_Them.FlatStyle = FlatStyle.Popup;
            btn_Them.Location = new Point(121, 16);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(96, 30);
            btn_Them.TabIndex = 24;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = Color.FromArgb(128, 255, 255);
            btn_TimKiem.FlatStyle = FlatStyle.Popup;
            btn_TimKiem.Location = new Point(19, 16);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(96, 30);
            btn_TimKiem.TabIndex = 23;
            btn_TimKiem.Text = "Tìm Kiếm";
            btn_TimKiem.UseVisualStyleBackColor = false;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 10;
            label2.Text = "Tên Phòng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(252, 24);
            label5.TabIndex = 8;
            label5.Text = "Thông tin các phòng chiếu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã Phòng:";
            // 
            // txt_MaPhongChieu
            // 
            txt_MaPhongChieu.BackColor = SystemColors.AppWorkspace;
            txt_MaPhongChieu.BorderStyle = BorderStyle.FixedSingle;
            txt_MaPhongChieu.Enabled = false;
            txt_MaPhongChieu.Font = new Font("Times New Roman", 12F);
            txt_MaPhongChieu.Location = new Point(95, 39);
            txt_MaPhongChieu.Name = "txt_MaPhongChieu";
            txt_MaPhongChieu.ReadOnly = true;
            txt_MaPhongChieu.Size = new Size(204, 26);
            txt_MaPhongChieu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txt_SoCotGhe);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_SoHangGhe);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(combox_LoaiManHinh);
            panel1.Controls.Add(txt_SoGhe);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_TinhTrangPhong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_TenPhongChieu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_MaPhongChieu);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(701, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 490);
            panel1.TabIndex = 22;
            // 
            // txt_SoCotGhe
            // 
            txt_SoCotGhe.BorderStyle = BorderStyle.FixedSingle;
            txt_SoCotGhe.Font = new Font("Times New Roman", 12F);
            txt_SoCotGhe.Location = new Point(95, 231);
            txt_SoCotGhe.Name = "txt_SoCotGhe";
            txt_SoCotGhe.Size = new Size(204, 26);
            txt_SoCotGhe.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(6, 233);
            label8.Name = "label8";
            label8.Size = new Size(70, 19);
            label8.TabIndex = 30;
            label8.Text = "Cột Ghế:";
            // 
            // txt_SoHangGhe
            // 
            txt_SoHangGhe.BorderStyle = BorderStyle.FixedSingle;
            txt_SoHangGhe.Font = new Font("Times New Roman", 12F);
            txt_SoHangGhe.Location = new Point(95, 199);
            txt_SoHangGhe.Name = "txt_SoHangGhe";
            txt_SoHangGhe.Size = new Size(204, 26);
            txt_SoHangGhe.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(6, 201);
            label7.Name = "label7";
            label7.Size = new Size(82, 19);
            label7.TabIndex = 28;
            label7.Text = "Hàng Ghế:";
            // 
            // combox_LoaiManHinh
            // 
            combox_LoaiManHinh.FlatStyle = FlatStyle.Popup;
            combox_LoaiManHinh.Font = new Font("Times New Roman", 12F);
            combox_LoaiManHinh.FormattingEnabled = true;
            combox_LoaiManHinh.Location = new Point(128, 102);
            combox_LoaiManHinh.Name = "combox_LoaiManHinh";
            combox_LoaiManHinh.Size = new Size(171, 27);
            combox_LoaiManHinh.TabIndex = 27;
            // 
            // txt_SoGhe
            // 
            txt_SoGhe.BorderStyle = BorderStyle.FixedSingle;
            txt_SoGhe.Font = new Font("Times New Roman", 12F);
            txt_SoGhe.Location = new Point(95, 167);
            txt_SoGhe.Name = "txt_SoGhe";
            txt_SoGhe.Size = new Size(204, 26);
            txt_SoGhe.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(6, 169);
            label6.Name = "label6";
            label6.Size = new Size(63, 19);
            label6.TabIndex = 25;
            label6.Text = "Số Ghế:";
            // 
            // txt_TinhTrangPhong
            // 
            txt_TinhTrangPhong.BorderStyle = BorderStyle.FixedSingle;
            txt_TinhTrangPhong.Font = new Font("Times New Roman", 12F);
            txt_TinhTrangPhong.Location = new Point(95, 135);
            txt_TinhTrangPhong.Name = "txt_TinhTrangPhong";
            txt_TinhTrangPhong.Size = new Size(204, 26);
            txt_TinhTrangPhong.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(6, 137);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 23;
            label4.Text = "Tình Trạng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 21;
            label3.Text = "Loại Màn Hình:";
            // 
            // txt_TenPhongChieu
            // 
            txt_TenPhongChieu.BorderStyle = BorderStyle.FixedSingle;
            txt_TenPhongChieu.Font = new Font("Times New Roman", 12F);
            txt_TenPhongChieu.Location = new Point(95, 71);
            txt_TenPhongChieu.Name = "txt_TenPhongChieu";
            txt_TenPhongChieu.Size = new Size(204, 26);
            txt_TenPhongChieu.TabIndex = 20;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.FromArgb(128, 255, 255);
            btn_Xoa.FlatStyle = FlatStyle.Popup;
            btn_Xoa.Location = new Point(325, 16);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(96, 30);
            btn_Xoa.TabIndex = 27;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // PhongChieuUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(dtgv_PhongChieuUC);
            Controls.Add(btn_Them);
            Controls.Add(btn_TimKiem);
            Controls.Add(panel1);
            Name = "PhongChieuUC";
            Size = new Size(1012, 490);
            ((System.ComponentModel.ISupportInitialize)dtgv_PhongChieuUC).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Sua;
        private DataGridView dtgv_PhongChieuUC;
        private Button btn_Them;
        private Button btn_TimKiem;
        private Label label2;
        private Label label5;
        private Label label1;
        private TextBox txt_MaPhongChieu;
        private Panel panel1;
        private TextBox txt_TenPhongChieu;
        private Button btn_Xoa;
        private TextBox txt_SoGhe;
        private Label label6;
        private TextBox txt_TinhTrangPhong;
        private Label label4;
        private Label label3;
        private ComboBox combox_LoaiManHinh;
        private TextBox txt_SoHangGhe;
        private Label label7;
        private TextBox txt_SoCotGhe;
        private Label label8;
    }
}
