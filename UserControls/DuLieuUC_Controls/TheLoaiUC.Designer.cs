namespace TTCSDL_NHOM7.UserControls.DuLieuUC_Controls
{
    partial class TheLoaiUC
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
            dtgv_TheLoaiUC = new DataGridView();
            btn_Them = new Button();
            btn_TimKiem = new Button();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_MaTheLoai = new TextBox();
            panel1 = new Panel();
            richtxt_MoTa = new RichTextBox();
            txt_TenTheLoai = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgv_TheLoaiUC).BeginInit();
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
            btn_Sua.TabIndex = 21;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = false;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // dtgv_TheLoaiUC
            // 
            dtgv_TheLoaiUC.AllowUserToAddRows = false;
            dtgv_TheLoaiUC.AllowUserToDeleteRows = false;
            dtgv_TheLoaiUC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_TheLoaiUC.BorderStyle = BorderStyle.Fixed3D;
            dtgv_TheLoaiUC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_TheLoaiUC.Dock = DockStyle.Bottom;
            dtgv_TheLoaiUC.Location = new Point(0, 63);
            dtgv_TheLoaiUC.MultiSelect = false;
            dtgv_TheLoaiUC.Name = "dtgv_TheLoaiUC";
            dtgv_TheLoaiUC.ReadOnly = true;
            dtgv_TheLoaiUC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_TheLoaiUC.Size = new Size(701, 427);
            dtgv_TheLoaiUC.TabIndex = 20;
            dtgv_TheLoaiUC.CellClick += dtgv_TheLoaiUC_CellClick;
            // 
            // btn_Them
            // 
            btn_Them.BackColor = Color.FromArgb(128, 255, 255);
            btn_Them.FlatStyle = FlatStyle.Popup;
            btn_Them.Location = new Point(121, 16);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(96, 30);
            btn_Them.TabIndex = 19;
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
            btn_TimKiem.TabIndex = 18;
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
            label2.Size = new Size(104, 19);
            label2.TabIndex = 10;
            label2.Text = "Tên Thể Loại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 9);
            label5.Name = "label5";
            label5.Size = new Size(174, 24);
            label5.TabIndex = 8;
            label5.Text = "Thông tin thể loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 39);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 4;
            label1.Text = "Mã Thể Loại:";
            // 
            // txt_MaTheLoai
            // 
            txt_MaTheLoai.BackColor = SystemColors.AppWorkspace;
            txt_MaTheLoai.BorderStyle = BorderStyle.FixedSingle;
            txt_MaTheLoai.Enabled = false;
            txt_MaTheLoai.Font = new Font("Times New Roman", 12F);
            txt_MaTheLoai.Location = new Point(121, 36);
            txt_MaTheLoai.Name = "txt_MaTheLoai";
            txt_MaTheLoai.ReadOnly = true;
            txt_MaTheLoai.Size = new Size(178, 26);
            txt_MaTheLoai.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txt_TenTheLoai);
            panel1.Controls.Add(richtxt_MoTa);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_MaTheLoai);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(701, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 490);
            panel1.TabIndex = 17;
            // 
            // richtxt_MoTa
            // 
            richtxt_MoTa.Location = new Point(69, 103);
            richtxt_MoTa.Name = "richtxt_MoTa";
            richtxt_MoTa.Size = new Size(230, 147);
            richtxt_MoTa.TabIndex = 19;
            richtxt_MoTa.Text = "";
            // 
            // txt_TenTheLoai
            // 
            txt_TenTheLoai.BorderStyle = BorderStyle.FixedSingle;
            txt_TenTheLoai.Font = new Font("Times New Roman", 12F);
            txt_TenTheLoai.Location = new Point(121, 71);
            txt_TenTheLoai.Name = "txt_TenTheLoai";
            txt_TenTheLoai.Size = new Size(178, 26);
            txt_TenTheLoai.TabIndex = 20;
            // 
            // TheLoaiUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            Controls.Add(btn_Sua);
            Controls.Add(dtgv_TheLoaiUC);
            Controls.Add(btn_Them);
            Controls.Add(btn_TimKiem);
            Controls.Add(panel1);
            Name = "TheLoaiUC";
            Size = new Size(1012, 490);
            ((System.ComponentModel.ISupportInitialize)dtgv_TheLoaiUC).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Sua;
        private DataGridView dtgv_TheLoaiUC;
        private Button btn_Them;
        private Button btn_TimKiem;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label1;
        private TextBox txt_MaTheLoai;
        private Panel panel1;
        private RichTextBox richtxt_MoTa;
        private TextBox txt_TenTheLoai;
    }
}
