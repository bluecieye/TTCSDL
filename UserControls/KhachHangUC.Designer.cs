namespace TTCSDL_NHOM7.UserControls
{
    partial class KhachHangUC
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
            btn_Xoa = new Button();
            btn_Sua = new Button();
            label7 = new Label();
            txt_CMNDKH = new TextBox();
            label6 = new Label();
            txt_SoDienThoaiKH = new TextBox();
            label4 = new Label();
            txt_DiaChiKH = new TextBox();
            dtgv_KhachHangUC = new DataGridView();
            btn_Them = new Button();
            label3 = new Label();
            txt_NgaySinhKH = new TextBox();
            label2 = new Label();
            txt_HoTenKH = new TextBox();
            label5 = new Label();
            label1 = new Label();
            txt_MaKH = new TextBox();
            btn_TimKiem = new Button();
            panel1 = new Panel();
            numeric_DiemTichLuyKH = new NumericUpDown();
            label8 = new Label();
            txt_TimKiemTheoTen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_KhachHangUC).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_DiemTichLuyKH).BeginInit();
            SuspendLayout();
            // 
            // btn_Xoa
            // 
            btn_Xoa.FlatStyle = FlatStyle.System;
            btn_Xoa.Location = new Point(221, 169);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(96, 30);
            btn_Xoa.TabIndex = 17;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.FlatStyle = FlatStyle.System;
            btn_Sua.Location = new Point(119, 169);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(96, 30);
            btn_Sua.TabIndex = 16;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
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
            // txt_CMNDKH
            // 
            txt_CMNDKH.BorderStyle = BorderStyle.FixedSingle;
            txt_CMNDKH.Font = new Font("Times New Roman", 12F);
            txt_CMNDKH.Location = new Point(391, 100);
            txt_CMNDKH.Name = "txt_CMNDKH";
            txt_CMNDKH.Size = new Size(231, 26);
            txt_CMNDKH.TabIndex = 17;
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
            // txt_SoDienThoaiKH
            // 
            txt_SoDienThoaiKH.BorderStyle = BorderStyle.FixedSingle;
            txt_SoDienThoaiKH.Font = new Font("Times New Roman", 12F);
            txt_SoDienThoaiKH.Location = new Point(441, 68);
            txt_SoDienThoaiKH.Name = "txt_SoDienThoaiKH";
            txt_SoDienThoaiKH.Size = new Size(181, 26);
            txt_SoDienThoaiKH.TabIndex = 15;
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
            // txt_DiaChiKH
            // 
            txt_DiaChiKH.BorderStyle = BorderStyle.FixedSingle;
            txt_DiaChiKH.Font = new Font("Times New Roman", 12F);
            txt_DiaChiKH.Location = new Point(391, 36);
            txt_DiaChiKH.Name = "txt_DiaChiKH";
            txt_DiaChiKH.Size = new Size(231, 26);
            txt_DiaChiKH.TabIndex = 13;
            // 
            // dtgv_KhachHangUC
            // 
            dtgv_KhachHangUC.AllowUserToAddRows = false;
            dtgv_KhachHangUC.AllowUserToDeleteRows = false;
            dtgv_KhachHangUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_KhachHangUC.BorderStyle = BorderStyle.Fixed3D;
            dtgv_KhachHangUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_KhachHangUC.Location = new Point(-4, 205);
            dtgv_KhachHangUC.MultiSelect = false;
            dtgv_KhachHangUC.Name = "dtgv_KhachHangUC";
            dtgv_KhachHangUC.ReadOnly = true;
            dtgv_KhachHangUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_KhachHangUC.Size = new Size(1020, 298);
            dtgv_KhachHangUC.TabIndex = 15;
            dtgv_KhachHangUC.CellClick += dtgv_KhachHangUC_CellClick;
            // 
            // btn_Them
            // 
            btn_Them.FlatStyle = FlatStyle.System;
            btn_Them.Location = new Point(17, 169);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(96, 30);
            btn_Them.TabIndex = 14;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
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
            // txt_NgaySinhKH
            // 
            txt_NgaySinhKH.BorderStyle = BorderStyle.FixedSingle;
            txt_NgaySinhKH.Font = new Font("Times New Roman", 12F);
            txt_NgaySinhKH.Location = new Point(93, 100);
            txt_NgaySinhKH.Name = "txt_NgaySinhKH";
            txt_NgaySinhKH.Size = new Size(206, 26);
            txt_NgaySinhKH.TabIndex = 11;
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
            // txt_HoTenKH
            // 
            txt_HoTenKH.BorderStyle = BorderStyle.FixedSingle;
            txt_HoTenKH.Font = new Font("Times New Roman", 12F);
            txt_HoTenKH.Location = new Point(93, 68);
            txt_HoTenKH.Name = "txt_HoTenKH";
            txt_HoTenKH.ReadOnly = true;
            txt_HoTenKH.Size = new Size(206, 26);
            txt_HoTenKH.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 0);
            label5.Name = "label5";
            label5.Size = new Size(215, 24);
            label5.TabIndex = 8;
            label5.Text = "Thông tin khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 39);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã Khách Hàng:";
            // 
            // txt_MaKH
            // 
            txt_MaKH.BorderStyle = BorderStyle.FixedSingle;
            txt_MaKH.Enabled = false;
            txt_MaKH.Font = new Font("Times New Roman", 12F);
            txt_MaKH.Location = new Point(134, 37);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.ReadOnly = true;
            txt_MaKH.Size = new Size(178, 26);
            txt_MaKH.TabIndex = 0;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.FlatStyle = FlatStyle.System;
            btn_TimKiem.Location = new Point(867, 169);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(96, 30);
            btn_TimKiem.TabIndex = 13;
            btn_TimKiem.Text = "Tìm Kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(numeric_DiemTichLuyKH);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_CMNDKH);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_SoDienThoaiKH);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_DiaChiKH);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_NgaySinhKH);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_HoTenKH);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_MaKH);
            panel1.Location = new Point(13, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 149);
            panel1.TabIndex = 12;
            // 
            // numeric_DiemTichLuyKH
            // 
            numeric_DiemTichLuyKH.Font = new Font("Times New Roman", 12F);
            numeric_DiemTichLuyKH.Location = new Point(766, 36);
            numeric_DiemTichLuyKH.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numeric_DiemTichLuyKH.Name = "numeric_DiemTichLuyKH";
            numeric_DiemTichLuyKH.Size = new Size(94, 26);
            numeric_DiemTichLuyKH.TabIndex = 20;
            numeric_DiemTichLuyKH.ThousandsSeparator = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(658, 39);
            label8.Name = "label8";
            label8.Size = new Size(102, 19);
            label8.TabIndex = 19;
            label8.Text = "Điểm tích lũy:";
            // 
            // txt_TimKiemTheoTen
            // 
            txt_TimKiemTheoTen.BorderStyle = BorderStyle.FixedSingle;
            txt_TimKiemTheoTen.Font = new Font("Times New Roman", 12F);
            txt_TimKiemTheoTen.Location = new Point(655, 172);
            txt_TimKiemTheoTen.Name = "txt_TimKiemTheoTen";
            txt_TimKiemTheoTen.Size = new Size(206, 26);
            txt_TimKiemTheoTen.TabIndex = 21;
            // 
            // KhachHangUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_TimKiemTheoTen);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(dtgv_KhachHangUC);
            Controls.Add(btn_Them);
            Controls.Add(btn_TimKiem);
            Controls.Add(panel1);
            Name = "KhachHangUC";
            Size = new Size(1012, 516);
            ((System.ComponentModel.ISupportInitialize)dtgv_KhachHangUC).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_DiemTichLuyKH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Xoa;
        private Button btn_Sua;
        private Label label7;
        private TextBox txt_CMNDKH;
        private Label label6;
        private TextBox txt_SoDienThoaiKH;
        private Label label4;
        private TextBox txt_DiaChiKH;
        private DataGridView dtgv_KhachHangUC;
        private Button btn_Them;
        private Label label3;
        private TextBox txt_NgaySinhKH;
        private Label label2;
        private TextBox txt_HoTenKH;
        private Label label5;
        private Label label1;
        private TextBox txt_MaKH;
        private Button btn_TimKiem;
        private Panel panel1;
        private Label label8;
        private NumericUpDown numeric_DiemTichLuyKH;
        private TextBox txt_TimKiemTheoTen;
    }
}
