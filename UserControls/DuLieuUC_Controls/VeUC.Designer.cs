namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    partial class VeUC
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
            panel61 = new Panel();
            btn_TatCaVeTheoLichChieu = new Button();
            btnVeDaMuaTheoLichChieu = new Button();
            btnThemVeTheoLichChieu = new Button();
            btnXemTatCaLichChieu = new Button();
            btnXemLichChieuChuaTaoVe = new Button();
            btnXoaVeTheoLichChieu = new Button();
            panel1 = new Panel();
            listview_TatCaLichChieu = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            dtgvVe = new DataGridView();
            panel61.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvVe).BeginInit();
            SuspendLayout();
            // 
            // panel61
            // 
            panel61.Controls.Add(btn_TatCaVeTheoLichChieu);
            panel61.Controls.Add(btnVeDaMuaTheoLichChieu);
            panel61.Controls.Add(btnThemVeTheoLichChieu);
            panel61.Controls.Add(btnXemTatCaLichChieu);
            panel61.Controls.Add(btnXemLichChieuChuaTaoVe);
            panel61.Controls.Add(btnXoaVeTheoLichChieu);
            panel61.Dock = DockStyle.Top;
            panel61.Location = new Point(0, 0);
            panel61.Margin = new Padding(4, 3, 4, 3);
            panel61.Name = "panel61";
            panel61.Size = new Size(1012, 60);
            panel61.TabIndex = 10;
            // 
            // btn_TatCaVeTheoLichChieu
            // 
            btn_TatCaVeTheoLichChieu.Location = new Point(439, 3);
            btn_TatCaVeTheoLichChieu.Margin = new Padding(4, 3, 4, 3);
            btn_TatCaVeTheoLichChieu.Name = "btn_TatCaVeTheoLichChieu";
            btn_TatCaVeTheoLichChieu.Size = new Size(135, 53);
            btn_TatCaVeTheoLichChieu.TabIndex = 5;
            btn_TatCaVeTheoLichChieu.Text = "Xem Tất Cả Các Vé Theo Lịch Chiếu";
            btn_TatCaVeTheoLichChieu.UseVisualStyleBackColor = true;
            btn_TatCaVeTheoLichChieu.Click += btn_TatCaVeTheoLichChieu_Click;
            // 
            // btnVeDaMuaTheoLichChieu
            // 
            btnVeDaMuaTheoLichChieu.Location = new Point(297, 3);
            btnVeDaMuaTheoLichChieu.Margin = new Padding(4, 3, 4, 3);
            btnVeDaMuaTheoLichChieu.Name = "btnVeDaMuaTheoLichChieu";
            btnVeDaMuaTheoLichChieu.Size = new Size(135, 53);
            btnVeDaMuaTheoLichChieu.TabIndex = 4;
            btnVeDaMuaTheoLichChieu.Text = "Xem Các Vé Được Bán Theo Lịch Chiếu";
            btnVeDaMuaTheoLichChieu.UseVisualStyleBackColor = true;
            btnVeDaMuaTheoLichChieu.Click += btnVeDaMuaTheoLichChieu_Click;
            // 
            // btnThemVeTheoLichChieu
            // 
            btnThemVeTheoLichChieu.Location = new Point(4, 3);
            btnThemVeTheoLichChieu.Margin = new Padding(4, 3, 4, 3);
            btnThemVeTheoLichChieu.Name = "btnThemVeTheoLichChieu";
            btnThemVeTheoLichChieu.Size = new Size(135, 53);
            btnThemVeTheoLichChieu.TabIndex = 0;
            btnThemVeTheoLichChieu.Text = "Tự Động Thêm Vé Theo Lịch Chiếu\r\n";
            btnThemVeTheoLichChieu.UseVisualStyleBackColor = true;
            btnThemVeTheoLichChieu.Click += btnThemVeTheoLichChieu_Click;
            // 
            // btnXemTatCaLichChieu
            // 
            btnXemTatCaLichChieu.Location = new Point(722, 3);
            btnXemTatCaLichChieu.Margin = new Padding(4, 3, 4, 3);
            btnXemTatCaLichChieu.Name = "btnXemTatCaLichChieu";
            btnXemTatCaLichChieu.Size = new Size(135, 53);
            btnXemTatCaLichChieu.TabIndex = 3;
            btnXemTatCaLichChieu.Text = "Xem Tất Cả Lịch Chiếu\r\n";
            btnXemTatCaLichChieu.UseVisualStyleBackColor = true;
            btnXemTatCaLichChieu.Click += btnXemTatCaLichChieu_Click;
            // 
            // btnXemLichChieuChuaTaoVe
            // 
            btnXemLichChieuChuaTaoVe.Location = new Point(580, 3);
            btnXemLichChieuChuaTaoVe.Margin = new Padding(4, 3, 4, 3);
            btnXemLichChieuChuaTaoVe.Name = "btnXemLichChieuChuaTaoVe";
            btnXemLichChieuChuaTaoVe.Size = new Size(135, 53);
            btnXemLichChieuChuaTaoVe.TabIndex = 3;
            btnXemLichChieuChuaTaoVe.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            btnXemLichChieuChuaTaoVe.UseVisualStyleBackColor = true;
            btnXemLichChieuChuaTaoVe.Click += btnXemLichChieuChuaTaoVe_Click;
            // 
            // btnXoaVeTheoLichChieu
            // 
            btnXoaVeTheoLichChieu.Location = new Point(145, 3);
            btnXoaVeTheoLichChieu.Margin = new Padding(4, 3, 4, 3);
            btnXoaVeTheoLichChieu.Name = "btnXoaVeTheoLichChieu";
            btnXoaVeTheoLichChieu.Size = new Size(144, 53);
            btnXoaVeTheoLichChieu.TabIndex = 1;
            btnXoaVeTheoLichChieu.Text = "Xóa Vé Theo Lịch Chiếu";
            btnXoaVeTheoLichChieu.UseVisualStyleBackColor = true;
            btnXoaVeTheoLichChieu.Click += btnXoaVeTheoLichChieu_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(listview_TatCaLichChieu);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(409, 60);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 430);
            panel1.TabIndex = 11;
            // 
            // listview_TatCaLichChieu
            // 
            listview_TatCaLichChieu.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listview_TatCaLichChieu.Dock = DockStyle.Right;
            listview_TatCaLichChieu.FullRowSelect = true;
            listview_TatCaLichChieu.GridLines = true;
            listview_TatCaLichChieu.Location = new Point(137, 0);
            listview_TatCaLichChieu.Margin = new Padding(2);
            listview_TatCaLichChieu.Name = "listview_TatCaLichChieu";
            listview_TatCaLichChieu.Size = new Size(466, 430);
            listview_TatCaLichChieu.TabIndex = 9;
            listview_TatCaLichChieu.UseCompatibleStateImageBehavior = false;
            listview_TatCaLichChieu.View = View.Details;
            listview_TatCaLichChieu.SelectedIndexChanged += listview_TatCaLichChieu_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Phòng Chiếu";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Phim";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Thời Gian";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Trạng Thái";
            columnHeader4.Width = 90;
            // 
            // dtgvVe
            // 
            dtgvVe.AllowUserToAddRows = false;
            dtgvVe.AllowUserToDeleteRows = false;
            dtgvVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVe.Location = new Point(0, 60);
            dtgvVe.Margin = new Padding(4, 3, 4, 3);
            dtgvVe.Name = "dtgvVe";
            dtgvVe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvVe.Size = new Size(546, 430);
            dtgvVe.TabIndex = 12;
            // 
            // VeUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgvVe);
            Controls.Add(panel1);
            Controls.Add(panel61);
            Margin = new Padding(2);
            Name = "VeUC";
            Size = new Size(1012, 490);
            panel61.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvVe).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Button btn_TatCaVeTheoLichChieu;
        private System.Windows.Forms.Button btnVeDaMuaTheoLichChieu;
        private System.Windows.Forms.Button btnThemVeTheoLichChieu;
        private System.Windows.Forms.Button btnXemTatCaLichChieu;
        private System.Windows.Forms.Button btnXemLichChieuChuaTaoVe;
        private System.Windows.Forms.Button btnXoaVeTheoLichChieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listview_TatCaLichChieu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DataGridView dtgvVe;
    }
}
