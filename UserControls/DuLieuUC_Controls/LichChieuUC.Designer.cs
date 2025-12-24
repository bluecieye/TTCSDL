namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    partial class LichChieuUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichChieuUC));
            panel1 = new Panel();
            label9 = new Label();
            txt_GiaVe = new TextBox();
            label8 = new Label();
            txt_DinhDangPhim = new TextBox();
            label7 = new Label();
            txt_TenPhim = new TextBox();
            combox_MaDinhDang = new ComboBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            combox_PhongChieu = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_MaLichChieu = new TextBox();
            btn_Xoa = new Button();
            btn_Sua = new Button();
            btn_TimKiem = new Button();
            dtgv_LichChieuUC = new DataGridView();
            btn_Them = new Button();
            txt_TimKiem_input = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_LichChieuUC).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_GiaVe);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_DinhDangPhim);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_TenPhim);
            panel1.Controls.Add(combox_MaDinhDang);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(combox_PhongChieu);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_MaLichChieu);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(701, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 490);
            panel1.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label9.Location = new Point(8, 333);
            label9.Name = "label9";
            label9.Size = new Size(61, 19);
            label9.TabIndex = 35;
            label9.Text = "Giá Vé:";
            // 
            // txt_GiaVe
            // 
            txt_GiaVe.BackColor = SystemColors.Control;
            txt_GiaVe.BorderStyle = BorderStyle.FixedSingle;
            txt_GiaVe.Font = new Font("Times New Roman", 12F);
            txt_GiaVe.Location = new Point(126, 331);
            txt_GiaVe.Name = "txt_GiaVe";
            txt_GiaVe.Size = new Size(173, 26);
            txt_GiaVe.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label8.Location = new Point(8, 138);
            label8.Name = "label8";
            label8.Size = new Size(86, 19);
            label8.TabIndex = 33;
            label8.Text = "Định Dạng:";
            // 
            // txt_DinhDangPhim
            // 
            txt_DinhDangPhim.BackColor = SystemColors.AppWorkspace;
            txt_DinhDangPhim.BorderStyle = BorderStyle.FixedSingle;
            txt_DinhDangPhim.Enabled = false;
            txt_DinhDangPhim.Font = new Font("Times New Roman", 12F);
            txt_DinhDangPhim.Location = new Point(126, 136);
            txt_DinhDangPhim.Name = "txt_DinhDangPhim";
            txt_DinhDangPhim.ReadOnly = true;
            txt_DinhDangPhim.Size = new Size(173, 26);
            txt_DinhDangPhim.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label7.Location = new Point(8, 106);
            label7.Name = "label7";
            label7.Size = new Size(47, 19);
            label7.TabIndex = 31;
            label7.Text = "Phim:";
            // 
            // txt_TenPhim
            // 
            txt_TenPhim.BackColor = SystemColors.AppWorkspace;
            txt_TenPhim.BorderStyle = BorderStyle.FixedSingle;
            txt_TenPhim.Enabled = false;
            txt_TenPhim.Font = new Font("Times New Roman", 12F);
            txt_TenPhim.Location = new Point(126, 104);
            txt_TenPhim.Name = "txt_TenPhim";
            txt_TenPhim.ReadOnly = true;
            txt_TenPhim.Size = new Size(173, 26);
            txt_TenPhim.TabIndex = 30;
            // 
            // combox_MaDinhDang
            // 
            combox_MaDinhDang.FlatStyle = FlatStyle.Popup;
            combox_MaDinhDang.Font = new Font("Times New Roman", 12F);
            combox_MaDinhDang.FormattingEnabled = true;
            combox_MaDinhDang.Location = new Point(126, 71);
            combox_MaDinhDang.Name = "combox_MaDinhDang";
            combox_MaDinhDang.Size = new Size(173, 27);
            combox_MaDinhDang.TabIndex = 29;
            combox_MaDinhDang.SelectedIndexChanged += combox_MaDinhDang_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.RoyalBlue;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(8, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 117);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thời Gian Chiếu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(6, 69);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 31;
            label6.Text = "Giờ Chiếu:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Times New Roman", 12F);
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(142, 63);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(134, 26);
            dateTimePicker2.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(130, 19);
            label4.TabIndex = 29;
            label4.Text = "Ngày Khởi Chiếu:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(142, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(134, 26);
            dateTimePicker1.TabIndex = 0;
            // 
            // combox_PhongChieu
            // 
            combox_PhongChieu.FlatStyle = FlatStyle.Popup;
            combox_PhongChieu.Font = new Font("Times New Roman", 12F);
            combox_PhongChieu.FormattingEnabled = true;
            combox_PhongChieu.Location = new Point(126, 169);
            combox_PhongChieu.Name = "combox_PhongChieu";
            combox_PhongChieu.Size = new Size(173, 27);
            combox_PhongChieu.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(8, 172);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 21;
            label3.Text = "Phòng Chiếu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(5, 74);
            label2.Name = "label2";
            label2.Size = new Size(114, 19);
            label2.TabIndex = 10;
            label2.Text = "Mã Định Dạng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(195, 24);
            label5.TabIndex = 8;
            label5.Text = "Thông tin lịch chiếu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(5, 41);
            label1.Name = "label1";
            label1.Size = new Size(114, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã Lịch Chiếu:";
            // 
            // txt_MaLichChieu
            // 
            txt_MaLichChieu.BackColor = SystemColors.AppWorkspace;
            txt_MaLichChieu.BorderStyle = BorderStyle.FixedSingle;
            txt_MaLichChieu.Enabled = false;
            txt_MaLichChieu.Font = new Font("Times New Roman", 12F);
            txt_MaLichChieu.Location = new Point(126, 39);
            txt_MaLichChieu.Name = "txt_MaLichChieu";
            txt_MaLichChieu.ReadOnly = true;
            txt_MaLichChieu.Size = new Size(173, 26);
            txt_MaLichChieu.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.FromArgb(128, 255, 255);
            btn_Xoa.FlatStyle = FlatStyle.Popup;
            btn_Xoa.Location = new Point(217, 16);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(96, 30);
            btn_Xoa.TabIndex = 33;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.BackColor = Color.FromArgb(128, 255, 255);
            btn_Sua.FlatStyle = FlatStyle.Popup;
            btn_Sua.Location = new Point(115, 16);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(96, 30);
            btn_Sua.TabIndex = 32;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = Color.FromArgb(128, 255, 255);
            btn_TimKiem.BackgroundImage = (Image)resources.GetObject("btn_TimKiem.BackgroundImage");
            btn_TimKiem.BackgroundImageLayout = ImageLayout.Stretch;
            btn_TimKiem.FlatAppearance.BorderSize = 0;
            btn_TimKiem.Location = new Point(658, 16);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(31, 30);
            btn_TimKiem.TabIndex = 29;
            btn_TimKiem.TextAlign = ContentAlignment.MiddleRight;
            btn_TimKiem.UseVisualStyleBackColor = false;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // dtgv_LichChieuUC
            // 
            dtgv_LichChieuUC.AllowUserToAddRows = false;
            dtgv_LichChieuUC.AllowUserToDeleteRows = false;
            dtgv_LichChieuUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_LichChieuUC.BorderStyle = BorderStyle.Fixed3D;
            dtgv_LichChieuUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_LichChieuUC.Location = new Point(0, 63);
            dtgv_LichChieuUC.MultiSelect = false;
            dtgv_LichChieuUC.Name = "dtgv_LichChieuUC";
            dtgv_LichChieuUC.ReadOnly = true;
            dtgv_LichChieuUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_LichChieuUC.Size = new Size(701, 427);
            dtgv_LichChieuUC.TabIndex = 31;
            dtgv_LichChieuUC.CellClick += dtgv_LichChieuUC_CellClick;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.FromArgb(128, 255, 255);
            btn_Them.FlatStyle = FlatStyle.Popup;
            btn_Them.Location = new Point(13, 16);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(96, 30);
            btn_Them.TabIndex = 30;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // txt_TimKiem_input
            // 
            txt_TimKiem_input.BorderStyle = BorderStyle.FixedSingle;
            txt_TimKiem_input.Font = new Font("Times New Roman", 12F);
            txt_TimKiem_input.Location = new Point(403, 18);
            txt_TimKiem_input.Name = "txt_TimKiem_input";
            txt_TimKiem_input.Size = new Size(255, 26);
            txt_TimKiem_input.TabIndex = 34;
            txt_TimKiem_input.Text = "Tìm theo tên phim....";
            // 
            // LichChieuUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(btn_TimKiem);
            Controls.Add(txt_TimKiem_input);
            Controls.Add(panel1);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(dtgv_LichChieuUC);
            Controls.Add(btn_Them);
            Name = "LichChieuUC";
            Size = new Size(1012, 490);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_LichChieuUC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox combox_PhongChieu;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label1;
        private TextBox txt_MaLichChieu;
        private Button btn_Xoa;
        private Button btn_Sua;
        private Button btn_TimKiem;
        private DataGridView dtgv_LichChieuUC;
        private Button btn_Them;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private ComboBox combox_MaDinhDang;
        private Label label8;
        private TextBox txt_DinhDangPhim;
        private Label label7;
        private TextBox txt_TenPhim;
        private TextBox txt_GiaVe;
        private Label label9;
        private TextBox txt_TimKiem_input;
    }
}
