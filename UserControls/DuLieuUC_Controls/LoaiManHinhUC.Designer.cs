namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    partial class LoaiManHinhUC
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
            txt_TenManHinh = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_MaManHinh = new TextBox();
            btn_Xoa = new Button();
            btn_TimKiem = new Button();
            dtgv_LoaiManHinhUC = new DataGridView();
            btn_Them = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_LoaiManHinhUC).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txt_TenManHinh);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_MaManHinh);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(701, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 490);
            panel1.TabIndex = 28;
            // 
            // txt_TenManHinh
            // 
            txt_TenManHinh.BorderStyle = BorderStyle.FixedSingle;
            txt_TenManHinh.Font = new Font("Times New Roman", 12F);
            txt_TenManHinh.Location = new Point(122, 71);
            txt_TenManHinh.Name = "txt_TenManHinh";
            txt_TenManHinh.Size = new Size(177, 26);
            txt_TenManHinh.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(112, 19);
            label2.TabIndex = 10;
            label2.Text = "Tên Màn Hình:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(267, 24);
            label5.TabIndex = 8;
            label5.Text = "Thông tin các loại màn hình:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã Màn Hình:";
            // 
            // txt_MaManHinh
            // 
            txt_MaManHinh.BackColor = SystemColors.AppWorkspace;
            txt_MaManHinh.BorderStyle = BorderStyle.FixedSingle;
            txt_MaManHinh.Enabled = false;
            txt_MaManHinh.Font = new Font("Times New Roman", 12F);
            txt_MaManHinh.Location = new Point(122, 39);
            txt_MaManHinh.Name = "txt_MaManHinh";
            txt_MaManHinh.ReadOnly = true;
            txt_MaManHinh.Size = new Size(177, 26);
            txt_MaManHinh.TabIndex = 0;
            // 
            // btn_Xoa
            // 
            btn_Xoa.BackColor = Color.FromArgb(128, 255, 255);
            btn_Xoa.FlatStyle = FlatStyle.Popup;
            btn_Xoa.Location = new Point(223, 16);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(96, 30);
            btn_Xoa.TabIndex = 33;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = false;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.BackColor = Color.FromArgb(128, 255, 255);
            btn_TimKiem.FlatStyle = FlatStyle.Popup;
            btn_TimKiem.Location = new Point(19, 16);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(96, 30);
            btn_TimKiem.TabIndex = 29;
            btn_TimKiem.Text = "Tìm Kiếm";
            btn_TimKiem.UseVisualStyleBackColor = false;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // dtgv_LoaiManHinhUC
            // 
            dtgv_LoaiManHinhUC.AllowUserToAddRows = false;
            dtgv_LoaiManHinhUC.AllowUserToDeleteRows = false;
            dtgv_LoaiManHinhUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_LoaiManHinhUC.BorderStyle = BorderStyle.Fixed3D;
            dtgv_LoaiManHinhUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_LoaiManHinhUC.Location = new Point(0, 63);
            dtgv_LoaiManHinhUC.MultiSelect = false;
            dtgv_LoaiManHinhUC.Name = "dtgv_LoaiManHinhUC";
            dtgv_LoaiManHinhUC.ReadOnly = true;
            dtgv_LoaiManHinhUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_LoaiManHinhUC.Size = new Size(701, 427);
            dtgv_LoaiManHinhUC.TabIndex = 31;
            dtgv_LoaiManHinhUC.CellClick += dtgv_LoaiManHinhUC_CellClick;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.FromArgb(128, 255, 255);
            btn_Them.FlatStyle = FlatStyle.Popup;
            btn_Them.Location = new Point(121, 16);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(96, 30);
            btn_Them.TabIndex = 30;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = false;
            btn_Them.Click += btn_Them_Click;
            // 
            // LoaiManHinhUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(panel1);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_TimKiem);
            Controls.Add(dtgv_LoaiManHinhUC);
            Controls.Add(btn_Them);
            Name = "LoaiManHinhUC";
            Size = new Size(1012, 490);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_LoaiManHinhUC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_TenManHinh;
        private Label label2;
        private Label label5;
        private Label label1;
        private TextBox txt_MaManHinh;
        private Button btn_Xoa;
        private Button btn_TimKiem;
        private DataGridView dtgv_LoaiManHinhUC;
        private Button btn_Them;
    }
}
