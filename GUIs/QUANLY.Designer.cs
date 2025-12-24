namespace TTCSDL_NHOM7.GUIs
{
    partial class QUANLY
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QUANLY));
            menuStrip1 = new MenuStrip();
            thôngTinNhânViênToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btn_MonAn = new Button();
            btn_TaiKhoan = new Button();
            btn_KhachHang = new Button();
            btn_NhanVien = new Button();
            btn_DuLieu = new Button();
            btn_DoanhThu = new Button();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel_ADMIN = new Panel();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.Items.AddRange(new ToolStripItem[] { thôngTinNhânViênToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1155, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            thôngTinNhânViênToolStripMenuItem.Image = (Image)resources.GetObject("thôngTinNhânViênToolStripMenuItem.Image");
            thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            thôngTinNhânViênToolStripMenuItem.Size = new Size(142, 20);
            thôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên";
            thôngTinNhânViênToolStripMenuItem.Click += thôngTinNhânViênToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(btn_MonAn);
            panel1.Controls.Add(btn_TaiKhoan);
            panel1.Controls.Add(btn_KhachHang);
            panel1.Controls.Add(btn_NhanVien);
            panel1.Controls.Add(btn_DuLieu);
            panel1.Controls.Add(btn_DoanhThu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 607);
            panel1.TabIndex = 1;
            // 
            // btn_MonAn
            // 
            btn_MonAn.Dock = DockStyle.Top;
            btn_MonAn.FlatAppearance.BorderSize = 0;
            btn_MonAn.FlatStyle = FlatStyle.Flat;
            btn_MonAn.Font = new Font("Century Gothic", 11.25F);
            btn_MonAn.ForeColor = SystemColors.ActiveCaptionText;
            btn_MonAn.Image = (Image)resources.GetObject("btn_MonAn.Image");
            btn_MonAn.ImageAlign = ContentAlignment.MiddleLeft;
            btn_MonAn.Location = new Point(0, 315);
            btn_MonAn.Margin = new Padding(2);
            btn_MonAn.Name = "btn_MonAn";
            btn_MonAn.Size = new Size(143, 63);
            btn_MonAn.TabIndex = 5;
            btn_MonAn.Text = "Món Ăn";
            btn_MonAn.TextAlign = ContentAlignment.MiddleRight;
            btn_MonAn.UseVisualStyleBackColor = false;
            btn_MonAn.Click += btn_MonAn_Click;
            // 
            // btn_TaiKhoan
            // 
            btn_TaiKhoan.Dock = DockStyle.Top;
            btn_TaiKhoan.FlatAppearance.BorderSize = 0;
            btn_TaiKhoan.FlatStyle = FlatStyle.Flat;
            btn_TaiKhoan.Font = new Font("Century Gothic", 11.25F);
            btn_TaiKhoan.ForeColor = SystemColors.ActiveCaptionText;
            btn_TaiKhoan.Image = (Image)resources.GetObject("btn_TaiKhoan.Image");
            btn_TaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btn_TaiKhoan.Location = new Point(0, 252);
            btn_TaiKhoan.Margin = new Padding(2);
            btn_TaiKhoan.Name = "btn_TaiKhoan";
            btn_TaiKhoan.Size = new Size(143, 63);
            btn_TaiKhoan.TabIndex = 4;
            btn_TaiKhoan.Text = "Tài Khoản";
            btn_TaiKhoan.TextAlign = ContentAlignment.MiddleRight;
            btn_TaiKhoan.UseVisualStyleBackColor = false;
            btn_TaiKhoan.Click += btn_TaiKhoan_Click;
            // 
            // btn_KhachHang
            // 
            btn_KhachHang.Dock = DockStyle.Top;
            btn_KhachHang.FlatAppearance.BorderSize = 0;
            btn_KhachHang.FlatStyle = FlatStyle.Flat;
            btn_KhachHang.Font = new Font("Century Gothic", 11.25F);
            btn_KhachHang.ForeColor = SystemColors.ActiveCaptionText;
            btn_KhachHang.Image = (Image)resources.GetObject("btn_KhachHang.Image");
            btn_KhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_KhachHang.Location = new Point(0, 189);
            btn_KhachHang.Margin = new Padding(2);
            btn_KhachHang.Name = "btn_KhachHang";
            btn_KhachHang.Size = new Size(143, 63);
            btn_KhachHang.TabIndex = 3;
            btn_KhachHang.Text = "Khách Hàng";
            btn_KhachHang.TextAlign = ContentAlignment.MiddleRight;
            btn_KhachHang.UseVisualStyleBackColor = false;
            btn_KhachHang.Click += btn_KhachHang_Click;
            // 
            // btn_NhanVien
            // 
            btn_NhanVien.Dock = DockStyle.Top;
            btn_NhanVien.FlatAppearance.BorderSize = 0;
            btn_NhanVien.FlatStyle = FlatStyle.Flat;
            btn_NhanVien.Font = new Font("Century Gothic", 11.25F);
            btn_NhanVien.ForeColor = SystemColors.ActiveCaptionText;
            btn_NhanVien.Image = (Image)resources.GetObject("btn_NhanVien.Image");
            btn_NhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btn_NhanVien.Location = new Point(0, 126);
            btn_NhanVien.Margin = new Padding(2);
            btn_NhanVien.Name = "btn_NhanVien";
            btn_NhanVien.Size = new Size(143, 63);
            btn_NhanVien.TabIndex = 2;
            btn_NhanVien.Text = "Nhân Viên";
            btn_NhanVien.TextAlign = ContentAlignment.MiddleRight;
            btn_NhanVien.UseVisualStyleBackColor = false;
            btn_NhanVien.Click += btn_NhanVien_Click;
            // 
            // btn_DuLieu
            // 
            btn_DuLieu.Dock = DockStyle.Top;
            btn_DuLieu.FlatAppearance.BorderSize = 0;
            btn_DuLieu.FlatStyle = FlatStyle.Flat;
            btn_DuLieu.Font = new Font("Century Gothic", 11.25F);
            btn_DuLieu.ForeColor = SystemColors.ActiveCaptionText;
            btn_DuLieu.Image = (Image)resources.GetObject("btn_DuLieu.Image");
            btn_DuLieu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DuLieu.Location = new Point(0, 63);
            btn_DuLieu.Margin = new Padding(2);
            btn_DuLieu.Name = "btn_DuLieu";
            btn_DuLieu.Size = new Size(143, 63);
            btn_DuLieu.TabIndex = 1;
            btn_DuLieu.Text = "Dữ Liệu";
            btn_DuLieu.TextAlign = ContentAlignment.MiddleRight;
            btn_DuLieu.UseVisualStyleBackColor = false;
            btn_DuLieu.Click += btn_DuLieu_Click;
            // 
            // btn_DoanhThu
            // 
            btn_DoanhThu.Dock = DockStyle.Top;
            btn_DoanhThu.FlatAppearance.BorderSize = 0;
            btn_DoanhThu.FlatStyle = FlatStyle.Flat;
            btn_DoanhThu.Font = new Font("Century Gothic", 11.25F);
            btn_DoanhThu.ForeColor = SystemColors.ActiveCaptionText;
            btn_DoanhThu.Image = (Image)resources.GetObject("btn_DoanhThu.Image");
            btn_DoanhThu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DoanhThu.Location = new Point(0, 0);
            btn_DoanhThu.Margin = new Padding(2);
            btn_DoanhThu.Name = "btn_DoanhThu";
            btn_DoanhThu.Size = new Size(143, 63);
            btn_DoanhThu.TabIndex = 0;
            btn_DoanhThu.Text = "Doanh Thu";
            btn_DoanhThu.TextAlign = ContentAlignment.MiddleRight;
            btn_DoanhThu.UseVisualStyleBackColor = false;
            btn_DoanhThu.Click += btn_DoanhThu_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(143, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 91);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(391, 26);
            label2.Name = "label2";
            label2.Size = new Size(337, 37);
            label2.TabIndex = 8;
            label2.Text = "QUẢN LÝ RẠP PHIM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel_ADMIN
            // 
            panel_ADMIN.Dock = DockStyle.Fill;
            panel_ADMIN.Location = new Point(143, 115);
            panel_ADMIN.Name = "panel_ADMIN";
            panel_ADMIN.Padding = new Padding(2);
            panel_ADMIN.Size = new Size(1012, 516);
            panel_ADMIN.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(919, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // QUANLY
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 631);
            Controls.Add(panel_ADMIN);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QUANLY";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUANLY";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel panel1;
        private Panel panel2;
        private Button btn_DoanhThu;
        private Button btn_MonAn;
        private Button btn_TaiKhoan;
        private Button btn_KhachHang;
        private Button btn_NhanVien;
        private Button btn_DuLieu;
        private Panel panel_ADMIN;
        private ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}