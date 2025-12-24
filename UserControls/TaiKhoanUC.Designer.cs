namespace TTCSDL_NHOM7.UserControls
{
    partial class TaiKhoanUC
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
            panel1 = new Panel();
            label6 = new Label();
            txt_MatKhau = new TextBox();
            combox_LoaiTaiKhoan = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_TenNV = new TextBox();
            txt_MaNV = new TextBox();
            txt_UserName = new TextBox();
            btn_TimKiem = new Button();
            btn_Sua = new Button();
            dtgv_TaiKhoanUC = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_TaiKhoanUC).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_MatKhau);
            panel1.Controls.Add(combox_LoaiTaiKhoan);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_TenNV);
            panel1.Controls.Add(txt_MaNV);
            panel1.Controls.Add(txt_UserName);
            panel1.Location = new Point(29, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 116);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(652, 42);
            label6.Name = "label6";
            label6.Size = new Size(83, 19);
            label6.TabIndex = 11;
            label6.Text = "Mật Khẩu:";
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.BorderStyle = BorderStyle.FixedSingle;
            txt_MatKhau.Font = new Font("Times New Roman", 12F);
            txt_MatKhau.Location = new Point(741, 39);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(188, 26);
            txt_MatKhau.TabIndex = 10;
            // 
            // combox_LoaiTaiKhoan
            // 
            combox_LoaiTaiKhoan.Font = new Font("Times New Roman", 12F);
            combox_LoaiTaiKhoan.FormattingEnabled = true;
            combox_LoaiTaiKhoan.Location = new Point(442, 39);
            combox_LoaiTaiKhoan.Name = "combox_LoaiTaiKhoan";
            combox_LoaiTaiKhoan.Size = new Size(184, 27);
            combox_LoaiTaiKhoan.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 10);
            label5.Name = "label5";
            label5.Size = new Size(193, 24);
            label5.TabIndex = 8;
            label5.Text = "Thông tin tài khoản:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(322, 82);
            label4.Name = "label4";
            label4.Size = new Size(114, 19);
            label4.TabIndex = 7;
            label4.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(15, 82);
            label3.Name = "label3";
            label3.Size = new Size(116, 19);
            label3.TabIndex = 6;
            label3.Text = "Mã Nhân Viên: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(322, 42);
            label2.Name = "label2";
            label2.Size = new Size(118, 19);
            label2.TabIndex = 5;
            label2.Text = "Loại Tài Khoản:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(15, 42);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 4;
            label1.Text = "Username: ";
            // 
            // txt_TenNV
            // 
            txt_TenNV.BorderStyle = BorderStyle.FixedSingle;
            txt_TenNV.Font = new Font("Times New Roman", 12F);
            txt_TenNV.Location = new Point(438, 79);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(188, 26);
            txt_TenNV.TabIndex = 3;
            // 
            // txt_MaNV
            // 
            txt_MaNV.BorderStyle = BorderStyle.FixedSingle;
            txt_MaNV.Font = new Font("Times New Roman", 12F);
            txt_MaNV.Location = new Point(137, 79);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(171, 26);
            txt_MaNV.TabIndex = 1;
            // 
            // txt_UserName
            // 
            txt_UserName.BorderStyle = BorderStyle.FixedSingle;
            txt_UserName.Font = new Font("Times New Roman", 12F);
            txt_UserName.Location = new Point(106, 39);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(202, 26);
            txt_UserName.TabIndex = 0;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.FlatStyle = FlatStyle.System;
            btn_TimKiem.Location = new Point(29, 144);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(96, 30);
            btn_TimKiem.TabIndex = 1;
            btn_TimKiem.Text = "Tìm Kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.FlatStyle = FlatStyle.System;
            btn_Sua.Location = new Point(131, 144);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(96, 30);
            btn_Sua.TabIndex = 2;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            // 
            // dtgv_TaiKhoanUC
            // 
            dtgv_TaiKhoanUC.AllowUserToAddRows = false;
            dtgv_TaiKhoanUC.AllowUserToDeleteRows = false;
            dtgv_TaiKhoanUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_TaiKhoanUC.BorderStyle = BorderStyle.Fixed3D;
            dtgv_TaiKhoanUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_TaiKhoanUC.GridColor = SystemColors.ControlDark;
            dtgv_TaiKhoanUC.Location = new Point(12, 180);
            dtgv_TaiKhoanUC.MultiSelect = false;
            dtgv_TaiKhoanUC.Name = "dtgv_TaiKhoanUC";
            dtgv_TaiKhoanUC.ReadOnly = true;
            dtgv_TaiKhoanUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_TaiKhoanUC.Size = new Size(1020, 331);
            dtgv_TaiKhoanUC.TabIndex = 5;
            dtgv_TaiKhoanUC.CellClick += dtgv_TaiKhoanUC_CellClick;
            // 
            // TaiKhoanUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgv_TaiKhoanUC);
            Controls.Add(btn_Sua);
            Controls.Add(btn_TimKiem);
            Controls.Add(panel1);
            Name = "TaiKhoanUC";
            Size = new Size(1050, 528);
            Load += TaiKhoanUC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_TaiKhoanUC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_TenNV;
        private TextBox txt_MaNV;
        private TextBox txt_UserName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Button btn_TimKiem;
        private Button btn_Sua;
        private DataGridView dtgv_TaiKhoanUC;
        private ComboBox combox_LoaiTaiKhoan;
        private Label label6;
        private TextBox txt_MatKhau;
    }
}
