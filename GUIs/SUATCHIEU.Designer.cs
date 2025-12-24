namespace TTCSDL_NHOM7.GUIs
{
    partial class SUATCHIEU
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
            panelHeader = new Panel();
            labelTitle = new Label();
            panelMovieInfo = new Panel();
            labelMovieTitle = new Label();
            labelMovieInfo = new Label();
            pictureBoxPoster = new PictureBox();
            panelDateSelection = new Panel();
            datePicker = new DateTimePicker();
            labelDate = new Label();
            panelShowtimes = new Panel();
            flowLayoutPanelShowtimes = new FlowLayoutPanel();
            labelShowtimesTitle = new Label();
            panelAction = new Panel();
            btnBookSeats = new Button();
            btnBack = new Button();
            panelHeader.SuspendLayout();
            panelMovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoster).BeginInit();
            panelDateSelection.SuspendLayout();
            panelShowtimes.SuspendLayout();
            panelAction.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 30, 30);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(984, 80);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(255, 215, 0);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(392, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CHỌN RẠP & SUẤT CHIẾU";
            // 
            // panelMovieInfo
            // 
            panelMovieInfo.BackColor = Color.FromArgb(245, 245, 245);
            panelMovieInfo.BorderStyle = BorderStyle.FixedSingle;
            panelMovieInfo.Controls.Add(labelMovieTitle);
            panelMovieInfo.Controls.Add(labelMovieInfo);
            panelMovieInfo.Controls.Add(pictureBoxPoster);
            panelMovieInfo.Location = new Point(20, 100);
            panelMovieInfo.Name = "panelMovieInfo";
            panelMovieInfo.Size = new Size(960, 120);
            panelMovieInfo.TabIndex = 1;
            // 
            // labelMovieTitle
            // 
            labelMovieTitle.AutoSize = true;
            labelMovieTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelMovieTitle.Location = new Point(180, 20);
            labelMovieTitle.Name = "labelMovieTitle";
            labelMovieTitle.Size = new Size(182, 30);
            labelMovieTitle.TabIndex = 2;
            labelMovieTitle.Text = "Chưa chọn phim";
            // 
            // labelMovieInfo
            // 
            labelMovieInfo.AutoSize = true;
            labelMovieInfo.Font = new Font("Segoe UI", 11F);
            labelMovieInfo.Location = new Point(180, 60);
            labelMovieInfo.Name = "labelMovieInfo";
            labelMovieInfo.Size = new Size(163, 20);
            labelMovieInfo.TabIndex = 1;
            labelMovieInfo.Text = "Thời lượng: -- | Năm: --";
            // 
            // pictureBoxPoster
            // 
            pictureBoxPoster.BackColor = Color.LightGray;
            pictureBoxPoster.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxPoster.Location = new Point(20, 20);
            pictureBoxPoster.Name = "pictureBoxPoster";
            pictureBoxPoster.Size = new Size(150, 80);
            pictureBoxPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPoster.TabIndex = 0;
            pictureBoxPoster.TabStop = false;
            // 
            // panelDateSelection
            // 
            panelDateSelection.BackColor = Color.FromArgb(250, 250, 250);
            panelDateSelection.BorderStyle = BorderStyle.FixedSingle;
            panelDateSelection.Controls.Add(datePicker);
            panelDateSelection.Controls.Add(labelDate);
            panelDateSelection.Location = new Point(20, 230);
            panelDateSelection.Name = "panelDateSelection";
            panelDateSelection.Size = new Size(960, 60);
            panelDateSelection.TabIndex = 2;
            // 
            // datePicker
            // 
            datePicker.CalendarFont = new Font("Segoe UI", 11F);
            datePicker.Font = new Font("Segoe UI", 12F);
            datePicker.Location = new Point(150, 15);
            datePicker.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 29);
            datePicker.TabIndex = 1;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelDate.Location = new Point(20, 17);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(131, 25);
            labelDate.TabIndex = 0;
            labelDate.Text = "CHỌN NGÀY:";
            // 
            // panelShowtimes
            // 
            panelShowtimes.BackColor = Color.White;
            panelShowtimes.BorderStyle = BorderStyle.FixedSingle;
            panelShowtimes.Controls.Add(flowLayoutPanelShowtimes);
            panelShowtimes.Controls.Add(labelShowtimesTitle);
            panelShowtimes.Location = new Point(12, 300);
            panelShowtimes.Name = "panelShowtimes";
            panelShowtimes.Size = new Size(968, 350);
            panelShowtimes.TabIndex = 4;
            // 
            // flowLayoutPanelShowtimes
            // 
            flowLayoutPanelShowtimes.AutoScroll = true;
            flowLayoutPanelShowtimes.BackColor = Color.FromArgb(250, 250, 250);
            flowLayoutPanelShowtimes.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelShowtimes.Location = new Point(20, 60);
            flowLayoutPanelShowtimes.Name = "flowLayoutPanelShowtimes";
            flowLayoutPanelShowtimes.Size = new Size(928, 270);
            flowLayoutPanelShowtimes.TabIndex = 1;
            // 
            // labelShowtimesTitle
            // 
            labelShowtimesTitle.AutoSize = true;
            labelShowtimesTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelShowtimesTitle.Location = new Point(372, 17);
            labelShowtimesTitle.Name = "labelShowtimesTitle";
            labelShowtimesTitle.Size = new Size(212, 30);
            labelShowtimesTitle.TabIndex = 0;
            labelShowtimesTitle.Text = "CHỌN SUẤT CHIẾU";
            // 
            // panelAction
            // 
            panelAction.BackColor = Color.FromArgb(245, 245, 245);
            panelAction.BorderStyle = BorderStyle.FixedSingle;
            panelAction.Controls.Add(btnBookSeats);
            panelAction.Controls.Add(btnBack);
            panelAction.Location = new Point(20, 660);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(960, 50);
            panelAction.TabIndex = 5;
            // 
            // btnBookSeats
            // 
            btnBookSeats.BackColor = Color.FromArgb(46, 139, 87);
            btnBookSeats.Enabled = false;
            btnBookSeats.FlatStyle = FlatStyle.Flat;
            btnBookSeats.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnBookSeats.ForeColor = Color.White;
            btnBookSeats.Location = new Point(770, 3);
            btnBookSeats.Name = "btnBookSeats";
            btnBookSeats.Size = new Size(170, 40);
            btnBookSeats.TabIndex = 1;
            btnBookSeats.Text = "CHỌN GHẾ →";
            btnBookSeats.UseVisualStyleBackColor = false;
            btnBookSeats.Click += btnBookSeats_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(169, 169, 169);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 40);
            btnBack.TabIndex = 0;
            btnBack.Text = "← CHỌN PHIM KHÁC";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // SUATCHIEU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 711);
            Controls.Add(panelAction);
            Controls.Add(panelShowtimes);
            Controls.Add(panelDateSelection);
            Controls.Add(panelMovieInfo);
            Controls.Add(panelHeader);
            Name = "SUATCHIEU";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMovieInfo.ResumeLayout(false);
            panelMovieInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPoster).EndInit();
            panelDateSelection.ResumeLayout(false);
            panelDateSelection.PerformLayout();
            panelShowtimes.ResumeLayout(false);
            panelShowtimes.PerformLayout();
            panelAction.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelMovieInfo;
        private Label labelMovieTitle;
        private Label labelMovieInfo;
        private PictureBox pictureBoxPoster;
        private Panel panelDateSelection;
        private DateTimePicker datePicker;
        private Label labelDate;
        private Panel panelShowtimes;
        private FlowLayoutPanel flowLayoutPanelShowtimes;
        private Label labelShowtimesTitle;
        private Panel panelAction;
        private Button btnBookSeats;
        private Button btnBack;

    }
}