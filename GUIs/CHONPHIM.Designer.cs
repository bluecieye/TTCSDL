namespace TTCSDL_NHOM7.GUIs
{
    partial class CHONPHIM
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbphim;
        private System.Windows.Forms.Button btnSearchdate;
        private System.Windows.Forms.DateTimePicker dtpNgayChieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhim;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnBack = new Button();
            label4 = new Label();
            lbphim = new Label();
            btnSearchdate = new Button();
            dtpNgayChieu = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            panelContainer = new Panel();
            flowLayoutPanelPhim = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 215, 191);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lbphim);
            panel1.Controls.Add(btnSearchdate);
            panel1.Controls.Add(dtpNgayChieu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 100);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(192, 0, 0);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(1000, 15);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 40);
            btnBack.TabIndex = 11;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(586, 52);
            label4.Name = "label4";
            label4.Size = new Size(145, 15);
            label4.TabIndex = 10;
            label4.Text = "Tìm kiếm phim theo ngày";
            // 
            // lbphim
            // 
            lbphim.AutoSize = true;
            lbphim.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbphim.ForeColor = Color.SaddleBrown;
            lbphim.Location = new Point(12, 62);
            lbphim.Name = "lbphim";
            lbphim.Size = new Size(120, 18);
            lbphim.TabIndex = 5;
            lbphim.Text = "Đang tải dữ liệu...";
            // 
            // btnSearchdate
            // 
            btnSearchdate.BackColor = Color.SaddleBrown;
            btnSearchdate.FlatStyle = FlatStyle.Flat;
            btnSearchdate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchdate.ForeColor = Color.White;
            btnSearchdate.Location = new Point(600, 10);
            btnSearchdate.Margin = new Padding(3, 2, 3, 2);
            btnSearchdate.Name = "btnSearchdate";
            btnSearchdate.Size = new Size(120, 40);
            btnSearchdate.TabIndex = 8;
            btnSearchdate.Text = "Tìm kiếm";
            btnSearchdate.UseVisualStyleBackColor = false;
            btnSearchdate.Click += btnSearchdate_Click;
            // 
            // dtpNgayChieu
            // 
            dtpNgayChieu.CalendarFont = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayChieu.CustomFormat = "dd/MM/yyyy";
            dtpNgayChieu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayChieu.Format = DateTimePickerFormat.Custom;
            dtpNgayChieu.Location = new Point(400, 20);
            dtpNgayChieu.Margin = new Padding(2, 3, 2, 3);
            dtpNgayChieu.Name = "dtpNgayChieu";
            dtpNgayChieu.Size = new Size(180, 23);
            dtpNgayChieu.TabIndex = 4;
            dtpNgayChieu.Value = DateTime.Now;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(250, 20);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày chiếu:";
            // 
            // label1
            // 
            label1.Font = new Font("JetBrains Mono NL", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(220, 60);
            label1.TabIndex = 0;
            label1.Text = "LỰA PHIM";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(flowLayoutPanelPhim);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 100);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(20);
            panelContainer.Size = new Size(1200, 655);
            panelContainer.TabIndex = 1;
            // 
            // flowLayoutPanelPhim
            // 
            flowLayoutPanelPhim.AutoScroll = true;
            flowLayoutPanelPhim.BackColor = Color.FromArgb(250, 248, 240);
            flowLayoutPanelPhim.Dock = DockStyle.Fill;
            flowLayoutPanelPhim.Location = new Point(20, 20);
            flowLayoutPanelPhim.Name = "flowLayoutPanelPhim";
            flowLayoutPanelPhim.Padding = new Padding(10);
            flowLayoutPanelPhim.Size = new Size(1160, 615);
            flowLayoutPanelPhim.TabIndex = 0;
            // 
            // BANVE
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1200, 755);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(800, 600);
            Name = "BANVE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách phim";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}