namespace TTCSDL_NHOM7.GUIs
{
    partial class MONAN
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
            panelCategories = new Panel();
            btnDrinks = new Button();
            btnSnacks = new Button();
            btnCombo = new Button();
            labelCategory = new Label();
            flowLayoutPanelFood = new FlowLayoutPanel();
            panelCart = new Panel();
            labelCartTitle = new Label();
            listViewCart = new ListView();
            columnHeaderItem = new ColumnHeader();
            columnHeaderQuantity = new ColumnHeader();
            columnHeaderPrice = new ColumnHeader();
            labelTotal = new Label();
            labelTotalValue = new Label();
            btnClearCart = new Button();
            btnCheckout = new Button();
            panelOrderSummary = new Panel();
            labelOrderSummary = new Label();
            labelSelectedMovie = new Label();
            labelMovieValue = new Label();
            labelShowtime = new Label();
            labelShowtimeValue = new Label();
            labelSeats = new Label();
            labelSeatsValue = new Label();
            panelHeader.SuspendLayout();
            panelCategories.SuspendLayout();
            panelCart.SuspendLayout();
            panelOrderSummary.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 30, 30);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 80);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(255, 215, 0);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(402, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ĐẶT MÓN ĂN & ĐỒ UỐNG";
            // 
            // panelCategories
            // 
            panelCategories.BackColor = Color.FromArgb(245, 245, 245);
            panelCategories.BorderStyle = BorderStyle.FixedSingle;
            panelCategories.Controls.Add(btnDrinks);
            panelCategories.Controls.Add(btnSnacks);
            panelCategories.Controls.Add(btnCombo);
            panelCategories.Controls.Add(labelCategory);
            panelCategories.Location = new Point(20, 100);
            panelCategories.Name = "panelCategories";
            panelCategories.Size = new Size(650, 80);
            panelCategories.TabIndex = 1;
            // 
            // btnDrinks
            // 
            btnDrinks.BackColor = Color.FromArgb(0, 74, 173);
            btnDrinks.FlatStyle = FlatStyle.Flat;
            btnDrinks.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDrinks.ForeColor = Color.White;
            btnDrinks.Location = new Point(450, 20);
            btnDrinks.Name = "btnDrinks";
            btnDrinks.Size = new Size(120, 40);
            btnDrinks.TabIndex = 3;
            btnDrinks.Text = "ĐỒ UỐNG";
            btnDrinks.UseVisualStyleBackColor = false;
            //btnDrinks.Click += btnDrinks_Click;
            // 
            // btnSnacks
            // 
            btnSnacks.BackColor = Color.FromArgb(220, 20, 60);
            btnSnacks.FlatStyle = FlatStyle.Flat;
            btnSnacks.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSnacks.ForeColor = Color.White;
            btnSnacks.Location = new Point(320, 20);
            btnSnacks.Name = "btnSnacks";
            btnSnacks.Size = new Size(120, 40);
            btnSnacks.TabIndex = 2;
            btnSnacks.Text = "ĂN VẶT";
            btnSnacks.UseVisualStyleBackColor = false;
            //btnSnacks.Click += btnSnacks_Click;
            // 
            // btnCombo
            // 
            btnCombo.BackColor = Color.FromArgb(46, 139, 87);
            btnCombo.FlatStyle = FlatStyle.Flat;
            btnCombo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCombo.ForeColor = Color.White;
            btnCombo.Location = new Point(190, 20);
            btnCombo.Name = "btnCombo";
            btnCombo.Size = new Size(120, 40);
            btnCombo.TabIndex = 1;
            btnCombo.Text = "COMBO";
            btnCombo.UseVisualStyleBackColor = false;
            //btnCombo.Click += btnCombo_Click;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategory.Location = new Point(20, 28);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(147, 21);
            labelCategory.TabIndex = 0;
            labelCategory.Text = "DANH MỤC MÓN:";
            // 
            // flowLayoutPanelFood
            // 
            flowLayoutPanelFood.AutoScroll = true;
            flowLayoutPanelFood.BackColor = Color.White;
            flowLayoutPanelFood.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelFood.Location = new Point(20, 190);
            flowLayoutPanelFood.Name = "flowLayoutPanelFood";
            flowLayoutPanelFood.Size = new Size(650, 500);
            flowLayoutPanelFood.TabIndex = 2;
            // 
            // panelCart
            // 
            panelCart.BackColor = Color.FromArgb(250, 250, 250);
            panelCart.BorderStyle = BorderStyle.FixedSingle;
            panelCart.Controls.Add(labelCartTitle);
            panelCart.Controls.Add(listViewCart);
            panelCart.Controls.Add(labelTotal);
            panelCart.Controls.Add(labelTotalValue);
            panelCart.Controls.Add(btnClearCart);
            panelCart.Controls.Add(btnCheckout);
            panelCart.Location = new Point(680, 100);
            panelCart.Name = "panelCart";
            panelCart.Size = new Size(300, 350);
            panelCart.TabIndex = 3;
            // 
            // labelCartTitle
            // 
            labelCartTitle.AutoSize = true;
            labelCartTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelCartTitle.Location = new Point(20, 20);
            labelCartTitle.Name = "labelCartTitle";
            labelCartTitle.Size = new Size(108, 25);
            labelCartTitle.TabIndex = 0;
            labelCartTitle.Text = "GIỎ HÀNG";
            // 
            // listViewCart
            // 
            listViewCart.Columns.AddRange(new ColumnHeader[] { columnHeaderItem, columnHeaderQuantity, columnHeaderPrice });
            listViewCart.Font = new Font("Segoe UI", 9F);
            listViewCart.FullRowSelect = true;
            listViewCart.GridLines = true;
            listViewCart.Location = new Point(20, 50);
            listViewCart.Name = "listViewCart";
            listViewCart.Size = new Size(260, 180);
            listViewCart.TabIndex = 1;
            listViewCart.UseCompatibleStateImageBehavior = false;
            listViewCart.View = View.Details;
            // 
            // columnHeaderItem
            // 
            columnHeaderItem.Text = "Món ăn";
            columnHeaderItem.Width = 120;
            // 
            // columnHeaderQuantity
            // 
            columnHeaderQuantity.Text = "SL";
            columnHeaderQuantity.Width = 50;
            // 
            // columnHeaderPrice
            // 
            columnHeaderPrice.Text = "Giá";
            columnHeaderPrice.Width = 80;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTotal.Location = new Point(20, 240);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(99, 21);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "TỔNG TIỀN:";
            // 
            // labelTotalValue
            // 
            labelTotalValue.AutoSize = true;
            labelTotalValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTotalValue.ForeColor = Color.FromArgb(220, 20, 60);
            labelTotalValue.Location = new Point(120, 238);
            labelTotalValue.Name = "labelTotalValue";
            labelTotalValue.Size = new Size(40, 25);
            labelTotalValue.TabIndex = 3;
            labelTotalValue.Text = "0 đ";
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.Red;
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.Location = new Point(20, 280);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(120, 40);
            btnClearCart.TabIndex = 4;
            btnClearCart.Text = "XÓA GIỎ";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(46, 139, 87);
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(150, 280);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(130, 40);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "THANH TOÁN";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // panelOrderSummary
            // 
            panelOrderSummary.BackColor = Color.FromArgb(245, 245, 245);
            panelOrderSummary.BorderStyle = BorderStyle.FixedSingle;
            panelOrderSummary.Controls.Add(labelOrderSummary);
            panelOrderSummary.Controls.Add(labelSelectedMovie);
            panelOrderSummary.Controls.Add(labelMovieValue);
            panelOrderSummary.Controls.Add(labelShowtime);
            panelOrderSummary.Controls.Add(labelShowtimeValue);
            panelOrderSummary.Controls.Add(labelSeats);
            panelOrderSummary.Controls.Add(labelSeatsValue);
            panelOrderSummary.Location = new Point(680, 460);
            panelOrderSummary.Name = "panelOrderSummary";
            panelOrderSummary.Size = new Size(300, 230);
            panelOrderSummary.TabIndex = 4;
            // 
            // labelOrderSummary
            // 
            labelOrderSummary.AutoSize = true;
            labelOrderSummary.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelOrderSummary.Location = new Point(20, 20);
            labelOrderSummary.Name = "labelOrderSummary";
            labelOrderSummary.Size = new Size(207, 25);
            labelOrderSummary.TabIndex = 0;
            labelOrderSummary.Text = "THÔNG TIN ĐẶT CHỖ";
            // 
            // labelSelectedMovie
            // 
            labelSelectedMovie.AutoSize = true;
            labelSelectedMovie.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSelectedMovie.Location = new Point(20, 60);
            labelSelectedMovie.Name = "labelSelectedMovie";
            labelSelectedMovie.Size = new Size(47, 19);
            labelSelectedMovie.TabIndex = 1;
            labelSelectedMovie.Text = "Phim:";
            // 
            // labelMovieValue
            // 
            labelMovieValue.AutoSize = true;
            labelMovieValue.Font = new Font("Segoe UI", 10F);
            labelMovieValue.Location = new Point(100, 60);
            labelMovieValue.Name = "labelMovieValue";
            labelMovieValue.Size = new Size(157, 19);
            labelMovieValue.TabIndex = 2;
            labelMovieValue.Text = "MISSION IMPOSSIBLE 7";
            // 
            // labelShowtime
            // 
            labelShowtime.AutoSize = true;
            labelShowtime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelShowtime.Location = new Point(20, 90);
            labelShowtime.Name = "labelShowtime";
            labelShowtime.Size = new Size(81, 19);
            labelShowtime.TabIndex = 3;
            labelShowtime.Text = "Suất chiếu:";
            // 
            // labelShowtimeValue
            // 
            labelShowtimeValue.AutoSize = true;
            labelShowtimeValue.Font = new Font("Segoe UI", 10F);
            labelShowtimeValue.Location = new Point(120, 90);
            labelShowtimeValue.Name = "labelShowtimeValue";
            labelShowtimeValue.Size = new Size(44, 19);
            labelShowtimeValue.TabIndex = 4;
            labelShowtimeValue.Text = "19:00";
            // 
            // labelSeats
            // 
            labelSeats.AutoSize = true;
            labelSeats.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSeats.Location = new Point(20, 120);
            labelSeats.Name = "labelSeats";
            labelSeats.Size = new Size(39, 19);
            labelSeats.TabIndex = 5;
            labelSeats.Text = "Ghế:";
            // 
            // labelSeatsValue
            // 
            labelSeatsValue.AutoSize = true;
            labelSeatsValue.Font = new Font("Segoe UI", 10F);
            labelSeatsValue.Location = new Point(100, 120);
            labelSeatsValue.Name = "labelSeatsValue";
            labelSeatsValue.Size = new Size(50, 19);
            labelSeatsValue.TabIndex = 6;
            labelSeatsValue.Text = "A5, A6";
            // 
            // MonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            Controls.Add(panelOrderSummary);
            Controls.Add(panelCart);
            Controls.Add(flowLayoutPanelFood);
            Controls.Add(panelCategories);
            Controls.Add(panelHeader);
            Name = "MonAn";
            Size = new Size(1000, 710);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCategories.ResumeLayout(false);
            panelCategories.PerformLayout();
            panelCart.ResumeLayout(false);
            panelCart.PerformLayout();
            panelOrderSummary.ResumeLayout(false);
            panelOrderSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelCategories;
        private Button btnDrinks;
        private Button btnSnacks;
        private Button btnCombo;
        private Label labelCategory;
        private FlowLayoutPanel flowLayoutPanelFood;
        private Panel panelCart;
        private Label labelCartTitle;
        private ListView listViewCart;
        private ColumnHeader columnHeaderItem;
        private ColumnHeader columnHeaderQuantity;
        private ColumnHeader columnHeaderPrice;
        private Label labelTotal;
        private Label labelTotalValue;
        private Button btnClearCart;
        private Button btnCheckout;
        private Panel panelOrderSummary;
        private Label labelOrderSummary;
        private Label labelSelectedMovie;
        private Label labelMovieValue;
        private Label labelShowtime;
        private Label labelShowtimeValue;
        private Label labelSeats;
        private Label labelSeatsValue;

    }
}