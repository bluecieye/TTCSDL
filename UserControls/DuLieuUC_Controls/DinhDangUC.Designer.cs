namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    partial class DinhDangUC
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
            label6 = new Label();
            label4 = new Label();
            btn_Them = new Button();
            btn_TimKiem = new Button();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_MaDinhDang = new TextBox();
            dtgv_DinhDangUC = new DataGridView();
            panel1 = new Panel();
            combox_MaManHinh = new ComboBox();
            combox_TenPhim = new ComboBox();
            combox_MaPhim = new ComboBox();
            combox_TenManHinh = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_DinhDangUC).BeginInit();
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
            btn_Sua.TabIndex = 16;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(3, 167);
            label6.Name = "label6";
            label6.Size = new Size(112, 19);
            label6.TabIndex = 16;
            label6.Text = "Tên Màn Hình:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(3, 135);
            label4.Name = "label4";
            label4.Size = new Size(110, 19);
            label4.TabIndex = 14;
            label4.Text = "Mã Màn Hình:";
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.FromArgb(128, 255, 255);
            btn_Them.FlatStyle = FlatStyle.Popup;
            btn_Them.Location = new Point(121, 16);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(96, 30);
            btn_Them.TabIndex = 14;
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
            btn_TimKiem.TabIndex = 13;
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
            label3.Size = new Size(77, 19);
            label3.TabIndex = 12;
            label3.Text = "Tên Phim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(3, 71);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 10;
            label2.Text = "Mã Phim:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(200, 24);
            label5.TabIndex = 8;
            label5.Text = "Thông tin định dạng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 39);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã Định Dạng:";
            // 
            // txt_MaDinhDang
            // 
            txt_MaDinhDang.BackColor = SystemColors.AppWorkspace;
            txt_MaDinhDang.BorderStyle = BorderStyle.FixedSingle;
            txt_MaDinhDang.Enabled = false;
            txt_MaDinhDang.Font = new Font("Times New Roman", 12F);
            txt_MaDinhDang.Location = new Point(121, 36);
            txt_MaDinhDang.Name = "txt_MaDinhDang";
            txt_MaDinhDang.ReadOnly = true;
            txt_MaDinhDang.Size = new Size(178, 26);
            txt_MaDinhDang.TabIndex = 0;
            // 
            // dtgv_DinhDangUC
            // 
            dtgv_DinhDangUC.AllowUserToAddRows = false;
            dtgv_DinhDangUC.AllowUserToDeleteRows = false;
            dtgv_DinhDangUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_DinhDangUC.BorderStyle = BorderStyle.Fixed3D;
            dtgv_DinhDangUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_DinhDangUC.Dock = DockStyle.Bottom;
            dtgv_DinhDangUC.Location = new Point(0, 63);
            dtgv_DinhDangUC.MultiSelect = false;
            dtgv_DinhDangUC.Name = "dtgv_DinhDangUC";
            dtgv_DinhDangUC.ReadOnly = true;
            dtgv_DinhDangUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_DinhDangUC.Size = new Size(701, 427);
            dtgv_DinhDangUC.TabIndex = 15;
            dtgv_DinhDangUC.CellClick += dtgv_DinhDangUC_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(combox_MaManHinh);
            panel1.Controls.Add(combox_TenPhim);
            panel1.Controls.Add(combox_MaPhim);
            panel1.Controls.Add(combox_TenManHinh);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_MaDinhDang);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(701, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 490);
            panel1.TabIndex = 12;
            // 
            // combox_MaManHinh
            // 
            combox_MaManHinh.FlatStyle = FlatStyle.Popup;
            combox_MaManHinh.Font = new Font("Times New Roman", 12F);
            combox_MaManHinh.FormattingEnabled = true;
            combox_MaManHinh.Location = new Point(119, 132);
            combox_MaManHinh.Name = "combox_MaManHinh";
            combox_MaManHinh.Size = new Size(180, 27);
            combox_MaManHinh.TabIndex = 20;
            combox_MaManHinh.SelectedIndexChanged += combox_MaManHinh_SelectedIndexChanged;
            // 
            // combox_TenPhim
            // 
            combox_TenPhim.FlatStyle = FlatStyle.Popup;
            combox_TenPhim.Font = new Font("Times New Roman", 12F);
            combox_TenPhim.FormattingEnabled = true;
            combox_TenPhim.Location = new Point(84, 100);
            combox_TenPhim.Name = "combox_TenPhim";
            combox_TenPhim.Size = new Size(215, 27);
            combox_TenPhim.TabIndex = 19;
            combox_TenPhim.SelectedIndexChanged += combox_TenPhim_SelectedIndexChanged;
            // 
            // combox_MaPhim
            // 
            combox_MaPhim.FlatStyle = FlatStyle.Popup;
            combox_MaPhim.Font = new Font("Times New Roman", 12F);
            combox_MaPhim.FormattingEnabled = true;
            combox_MaPhim.Location = new Point(84, 68);
            combox_MaPhim.Name = "combox_MaPhim";
            combox_MaPhim.Size = new Size(215, 27);
            combox_MaPhim.TabIndex = 18;
            combox_MaPhim.SelectedIndexChanged += combox_MaPhim_SelectedIndexChanged;
            // 
            // combox_TenManHinh
            // 
            combox_TenManHinh.FlatStyle = FlatStyle.Popup;
            combox_TenManHinh.Font = new Font("Times New Roman", 12F);
            combox_TenManHinh.FormattingEnabled = true;
            combox_TenManHinh.Location = new Point(119, 164);
            combox_TenManHinh.Name = "combox_TenManHinh";
            combox_TenManHinh.Size = new Size(180, 27);
            combox_TenManHinh.TabIndex = 17;
            combox_TenManHinh.SelectedIndexChanged += combox_TenManHinh_SelectedIndexChanged;
            // 
            // DinhDangUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(btn_TimKiem);
            Controls.Add(dtgv_DinhDangUC);
            Controls.Add(panel1);
            Name = "DinhDangUC";
            Size = new Size(1012, 490);
            ((System.ComponentModel.ISupportInitialize)dtgv_DinhDangUC).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Sua;
        private Label label6;
        private Label label4;
        private Button btn_Them;
        private Button btn_TimKiem;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label1;
        private TextBox txt_MaDinhDang;
        private DataGridView dtgv_DinhDangUC;
        private Panel panel1;
        private ComboBox combox_TenManHinh;
        private ComboBox combox_MaManHinh;
        private ComboBox combox_TenPhim;
        private ComboBox combox_MaPhim;
    }
}
