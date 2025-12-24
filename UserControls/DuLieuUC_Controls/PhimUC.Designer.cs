namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    partial class PhimUC
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
            dtgv_PhimUC = new DataGridView();
            btn_Them = new Button();
            btn_TimKiem = new Button();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_MaPhim = new TextBox();
            panel1 = new Panel();
            checklist_TheLoai = new CheckedListBox();
            label12 = new Label();
            btn_ThemAnh = new Button();
            picture_AnhPhim = new PictureBox();
            label11 = new Label();
            datepicker_KetThuc = new DateTimePicker();
            datepick_KhoiChieu = new DateTimePicker();
            label10 = new Label();
            label9 = new Label();
            txt_NamSX = new TextBox();
            label8 = new Label();
            txt_DaoDien = new TextBox();
            label7 = new Label();
            txt_SanXuat = new TextBox();
            label6 = new Label();
            txt_ThoiLuongPhim = new TextBox();
            label4 = new Label();
            txt_TenPhim = new TextBox();
            richtxt_MoTa = new RichTextBox();
            btn_Xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_PhimUC).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_AnhPhim).BeginInit();
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
            // dtgv_PhimUC
            // 
            dtgv_PhimUC.AllowUserToAddRows = false;
            dtgv_PhimUC.AllowUserToDeleteRows = false;
            dtgv_PhimUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_PhimUC.BorderStyle = BorderStyle.Fixed3D;
            dtgv_PhimUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_PhimUC.Dock = DockStyle.Bottom;
            dtgv_PhimUC.Location = new Point(0, 63);
            dtgv_PhimUC.MultiSelect = false;
            dtgv_PhimUC.Name = "dtgv_PhimUC";
            dtgv_PhimUC.ReadOnly = true;
            dtgv_PhimUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_PhimUC.Size = new Size(701, 427);
            dtgv_PhimUC.TabIndex = 25;
            dtgv_PhimUC.CellClick += dtgv_PhimUC_CellClick;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(3, 103);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 12;
            label3.Text = "Mô Tả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 71);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 10;
            label2.Text = "Tên Phim:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(154, 24);
            label5.TabIndex = 8;
            label5.Text = "Thông tin phim:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 39);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã Phim:";
            // 
            // txt_MaPhim
            // 
            txt_MaPhim.BackColor = SystemColors.AppWorkspace;
            txt_MaPhim.BorderStyle = BorderStyle.FixedSingle;
            txt_MaPhim.Enabled = false;
            txt_MaPhim.Font = new Font("Times New Roman", 12F);
            txt_MaPhim.Location = new Point(84, 36);
            txt_MaPhim.Name = "txt_MaPhim";
            txt_MaPhim.ReadOnly = true;
            txt_MaPhim.Size = new Size(215, 26);
            txt_MaPhim.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checklist_TheLoai);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(btn_ThemAnh);
            panel1.Controls.Add(picture_AnhPhim);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(datepicker_KetThuc);
            panel1.Controls.Add(datepick_KhoiChieu);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_NamSX);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_DaoDien);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_SanXuat);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_ThoiLuongPhim);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_TenPhim);
            panel1.Controls.Add(richtxt_MoTa);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_MaPhim);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(701, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 490);
            panel1.TabIndex = 22;
            // 
            // checklist_TheLoai
            // 
            checklist_TheLoai.FormattingEnabled = true;
            checklist_TheLoai.Location = new Point(76, 341);
            checklist_TheLoai.Name = "checklist_TheLoai";
            checklist_TheLoai.ScrollAlwaysVisible = true;
            checklist_TheLoai.Size = new Size(223, 58);
            checklist_TheLoai.Sorted = true;
            checklist_TheLoai.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label12.Location = new Point(1, 343);
            label12.Name = "label12";
            label12.Size = new Size(69, 19);
            label12.TabIndex = 37;
            label12.Text = "Thể Loại";
            // 
            // btn_ThemAnh
            // 
            btn_ThemAnh.Location = new Point(3, 439);
            btn_ThemAnh.Name = "btn_ThemAnh";
            btn_ThemAnh.Size = new Size(77, 23);
            btn_ThemAnh.TabIndex = 36;
            btn_ThemAnh.Text = "Thêm Ảnh";
            btn_ThemAnh.UseVisualStyleBackColor = true;
            btn_ThemAnh.Click += btn_ThemAnh_Click;
            // 
            // picture_AnhPhim
            // 
            picture_AnhPhim.BackColor = Color.LightBlue;
            picture_AnhPhim.Enabled = false;
            picture_AnhPhim.Location = new Point(86, 405);
            picture_AnhPhim.Name = "picture_AnhPhim";
            picture_AnhPhim.Size = new Size(140, 177);
            picture_AnhPhim.TabIndex = 35;
            picture_AnhPhim.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label11.Location = new Point(3, 417);
            label11.Name = "label11";
            label11.Size = new Size(57, 19);
            label11.TabIndex = 34;
            label11.Text = "Poster:";
            // 
            // datepicker_KetThuc
            // 
            datepicker_KetThuc.CalendarFont = new Font("Times New Roman", 12F);
            datepicker_KetThuc.Format = DateTimePickerFormat.Short;
            datepicker_KetThuc.Location = new Point(95, 312);
            datepicker_KetThuc.Name = "datepicker_KetThuc";
            datepicker_KetThuc.Size = new Size(202, 23);
            datepicker_KetThuc.TabIndex = 33;
            // 
            // datepick_KhoiChieu
            // 
            datepick_KhoiChieu.CalendarFont = new Font("Times New Roman", 12F);
            datepick_KhoiChieu.Format = DateTimePickerFormat.Short;
            datepick_KhoiChieu.Location = new Point(95, 280);
            datepick_KhoiChieu.Name = "datepick_KhoiChieu";
            datepick_KhoiChieu.Size = new Size(202, 23);
            datepick_KhoiChieu.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label10.Location = new Point(1, 315);
            label10.Name = "label10";
            label10.Size = new Size(76, 19);
            label10.TabIndex = 31;
            label10.Text = "Kết Thúc:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.Location = new Point(1, 283);
            label9.Name = "label9";
            label9.Size = new Size(90, 19);
            label9.TabIndex = 29;
            label9.Text = "Khởi Chiếu:";
            // 
            // txt_NamSX
            // 
            txt_NamSX.BorderStyle = BorderStyle.FixedSingle;
            txt_NamSX.Font = new Font("Times New Roman", 12F);
            txt_NamSX.Location = new Point(86, 249);
            txt_NamSX.Name = "txt_NamSX";
            txt_NamSX.Size = new Size(213, 26);
            txt_NamSX.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(1, 251);
            label8.Name = "label8";
            label8.Size = new Size(70, 19);
            label8.TabIndex = 27;
            label8.Text = "Năm SX:";
            // 
            // txt_DaoDien
            // 
            txt_DaoDien.BorderStyle = BorderStyle.FixedSingle;
            txt_DaoDien.Font = new Font("Times New Roman", 12F);
            txt_DaoDien.Location = new Point(86, 217);
            txt_DaoDien.Name = "txt_DaoDien";
            txt_DaoDien.Size = new Size(213, 26);
            txt_DaoDien.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(1, 219);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 25;
            label7.Text = "Đạo diễn:";
            // 
            // txt_SanXuat
            // 
            txt_SanXuat.BorderStyle = BorderStyle.FixedSingle;
            txt_SanXuat.Font = new Font("Times New Roman", 12F);
            txt_SanXuat.Location = new Point(86, 185);
            txt_SanXuat.Name = "txt_SanXuat";
            txt_SanXuat.Size = new Size(213, 26);
            txt_SanXuat.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(1, 187);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 23;
            label6.Text = "Sản xuất:";
            // 
            // txt_ThoiLuongPhim
            // 
            txt_ThoiLuongPhim.BorderStyle = BorderStyle.FixedSingle;
            txt_ThoiLuongPhim.Font = new Font("Times New Roman", 12F);
            txt_ThoiLuongPhim.Location = new Point(101, 153);
            txt_ThoiLuongPhim.Name = "txt_ThoiLuongPhim";
            txt_ThoiLuongPhim.Size = new Size(198, 26);
            txt_ThoiLuongPhim.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(1, 155);
            label4.Name = "label4";
            label4.Size = new Size(94, 19);
            label4.TabIndex = 21;
            label4.Text = "Thời Lượng:";
            // 
            // txt_TenPhim
            // 
            txt_TenPhim.BorderStyle = BorderStyle.FixedSingle;
            txt_TenPhim.Font = new Font("Times New Roman", 12F);
            txt_TenPhim.Location = new Point(84, 69);
            txt_TenPhim.Name = "txt_TenPhim";
            txt_TenPhim.Size = new Size(213, 26);
            txt_TenPhim.TabIndex = 20;
            // 
            // richtxt_MoTa
            // 
            richtxt_MoTa.Location = new Point(69, 101);
            richtxt_MoTa.Name = "richtxt_MoTa";
            richtxt_MoTa.Size = new Size(230, 46);
            richtxt_MoTa.TabIndex = 19;
            richtxt_MoTa.Text = "";
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
            // PhimUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(dtgv_PhimUC);
            Controls.Add(btn_Them);
            Controls.Add(btn_TimKiem);
            Controls.Add(panel1);
            Name = "PhimUC";
            Size = new Size(1012, 490);
            ((System.ComponentModel.ISupportInitialize)dtgv_PhimUC).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_AnhPhim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Sua;
        private DataGridView dtgv_PhimUC;
        private Button btn_Them;
        private Button btn_TimKiem;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label1;
        private TextBox txt_MaPhim;
        private Panel panel1;
        private TextBox txt_TenPhim;
        private RichTextBox richtxt_MoTa;
        private TextBox txt_ThoiLuongPhim;
        private Label label4;
        private Label label10;
        private Label label9;
        private TextBox txt_NamSX;
        private Label label8;
        private TextBox txt_DaoDien;
        private Label label7;
        private TextBox txt_SanXuat;
        private Label label6;
        private DateTimePicker datepick_KhoiChieu;
        private DateTimePicker datepicker_KetThuc;
        private PictureBox picture_AnhPhim;
        private Label label11;
        private Button btn_ThemAnh;
        private Label label12;
        private CheckedListBox checklist_TheLoai;
        private Button btn_Xoa;
    }
}
