namespace TTCSDL_NHOM7.UserControls
{
    partial class NhanVienUC
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
            dtgv_NhanVienUC = new DataGridView();
            btn_Them = new Button();
            btn_TimKiem = new Button();
            panel1 = new Panel();
            label7 = new Label();
            txt_CMND = new TextBox();
            label6 = new Label();
            txt_SoDienThoai = new TextBox();
            label4 = new Label();
            txt_DiaChi = new TextBox();
            label3 = new Label();
            txt_NgaySinh = new TextBox();
            label2 = new Label();
            txt_HoTen = new TextBox();
            label5 = new Label();
            label1 = new Label();
            txt_MaNV = new TextBox();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_NhanVienUC).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgv_NhanVienUC
            // 
            dtgv_NhanVienUC.AllowUserToAddRows = false;
            dtgv_NhanVienUC.AllowUserToDeleteRows = false;
            dtgv_NhanVienUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_NhanVienUC.BorderStyle = BorderStyle.Fixed3D;
            dtgv_NhanVienUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_NhanVienUC.Location = new Point(15, 211);
            dtgv_NhanVienUC.MultiSelect = false;
            dtgv_NhanVienUC.Name = "dtgv_NhanVienUC";
            dtgv_NhanVienUC.ReadOnly = true;
            dtgv_NhanVienUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_NhanVienUC.Size = new Size(1020, 298);
            dtgv_NhanVienUC.TabIndex = 9;
            dtgv_NhanVienUC.CellClick += dtgv_NhanVienUC_CellClick;
            // 
            // btn_Them
            // 
            btn_Them.FlatStyle = FlatStyle.System;
            btn_Them.Location = new Point(134, 175);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(96, 30);
            btn_Them.TabIndex = 8;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.FlatStyle = FlatStyle.System;
            btn_TimKiem.Location = new Point(32, 175);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(96, 30);
            btn_TimKiem.TabIndex = 7;
            btn_TimKiem.Text = "Tìm Kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_CMND);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_SoDienThoai);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_DiaChi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_NgaySinh);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_HoTen);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_MaNV);
            panel1.Location = new Point(32, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 149);
            panel1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(326, 103);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 18;
            label7.Text = "CMND:";
            // 
            // txt_CMND
            // 
            txt_CMND.BorderStyle = BorderStyle.FixedSingle;
            txt_CMND.Font = new Font("Times New Roman", 12F);
            txt_CMND.Location = new Point(391, 100);
            txt_CMND.Name = "txt_CMND";
            txt_CMND.Size = new Size(231, 26);
            txt_CMND.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(326, 71);
            label6.Name = "label6";
            label6.Size = new Size(109, 19);
            label6.TabIndex = 16;
            label6.Text = "Số Điện Thoại:";
            // 
            // txt_SoDienThoai
            // 
            txt_SoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txt_SoDienThoai.Font = new Font("Times New Roman", 12F);
            txt_SoDienThoai.Location = new Point(441, 68);
            txt_SoDienThoai.Name = "txt_SoDienThoai";
            txt_SoDienThoai.Size = new Size(181, 26);
            txt_SoDienThoai.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(326, 39);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 14;
            label4.Text = "Địa chỉ:";
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.BorderStyle = BorderStyle.FixedSingle;
            txt_DiaChi.Font = new Font("Times New Roman", 12F);
            txt_DiaChi.Location = new Point(391, 36);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(231, 26);
            txt_DiaChi.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(3, 103);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 12;
            label3.Text = "Ngày Sinh:";
            // 
            // txt_NgaySinh
            // 
            txt_NgaySinh.BorderStyle = BorderStyle.FixedSingle;
            txt_NgaySinh.Font = new Font("Times New Roman", 12F);
            txt_NgaySinh.Location = new Point(93, 100);
            txt_NgaySinh.Name = "txt_NgaySinh";
            txt_NgaySinh.Size = new Size(206, 26);
            txt_NgaySinh.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 71);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 10;
            label2.Text = "Họ và Tên:";
            // 
            // txt_HoTen
            // 
            txt_HoTen.BorderStyle = BorderStyle.FixedSingle;
            txt_HoTen.Font = new Font("Times New Roman", 12F);
            txt_HoTen.Location = new Point(93, 68);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(206, 26);
            txt_HoTen.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 0);
            label5.Name = "label5";
            label5.Size = new Size(197, 24);
            label5.TabIndex = 8;
            label5.Text = "Thông tin nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 39);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã Nhân Viên:";
            // 
            // txt_MaNV
            // 
            txt_MaNV.BorderStyle = BorderStyle.FixedSingle;
            txt_MaNV.Enabled = false;
            txt_MaNV.Font = new Font("Times New Roman", 12F);
            txt_MaNV.Location = new Point(121, 36);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.ReadOnly = true;
            txt_MaNV.Size = new Size(178, 26);
            txt_MaNV.TabIndex = 0;
            // 
            // btn_Sua
            // 
            btn_Sua.FlatStyle = FlatStyle.System;
            btn_Sua.Location = new Point(236, 175);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(96, 30);
            btn_Sua.TabIndex = 10;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.FlatStyle = FlatStyle.System;
            btn_Xoa.Location = new Point(338, 175);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(96, 30);
            btn_Xoa.TabIndex = 11;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // NhanVienUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(dtgv_NhanVienUC);
            Controls.Add(btn_Them);
            Controls.Add(btn_TimKiem);
            Controls.Add(panel1);
            Name = "NhanVienUC";
            Size = new Size(1050, 528);
            ((System.ComponentModel.ISupportInitialize)dtgv_NhanVienUC).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgv_NhanVienUC;
        private Button btn_Them;
        private Button btn_TimKiem;
        private Panel panel1;
        private Label label5;
        private Label label1;
        private TextBox txt_MaNV;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Label label7;
        private TextBox txt_CMND;
        private Label label6;
        private TextBox txt_SoDienThoai;
        private Label label4;
        private TextBox txt_DiaChi;
        private Label label3;
        private TextBox txt_NgaySinh;
        private Label label2;
        private TextBox txt_HoTen;
    }
}
