namespace TTCSDL_NHOM7.GUIs
{
    partial class DASHBOARD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DASHBOARD));
            btn_Logout = new Button();
            label1 = new Label();
            btn_QuanLy = new Button();
            btn_BanVe = new Button();
            txt_Ten = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Logout
            // 
            btn_Logout.Location = new Point(12, 394);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(81, 44);
            btn_Logout.TabIndex = 0;
            btn_Logout.Text = "LOGOUT";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 88);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Xin chào,";
            // 
            // btn_QuanLy
            // 
            btn_QuanLy.Location = new Point(74, 166);
            btn_QuanLy.Name = "btn_QuanLy";
            btn_QuanLy.Size = new Size(131, 73);
            btn_QuanLy.TabIndex = 3;
            btn_QuanLy.Text = "QUẢN LÝ";
            btn_QuanLy.UseVisualStyleBackColor = true;
            btn_QuanLy.Click += btn_QuanLy_Click;
            // 
            // btn_BanVe
            // 
            btn_BanVe.Location = new Point(74, 245);
            btn_BanVe.Name = "btn_BanVe";
            btn_BanVe.Size = new Size(131, 73);
            btn_BanVe.TabIndex = 4;
            btn_BanVe.Text = "BÁN VÉ";
            btn_BanVe.UseVisualStyleBackColor = true;
            btn_BanVe.Click += btn_BanVe_Click;
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(74, 85);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(167, 23);
            txt_Ten.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 80);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label2.Location = new Point(99, 28);
            label2.Name = "label2";
            label2.Size = new Size(171, 29);
            label2.TabIndex = 7;
            label2.Text = "DASHBOARD";
            // 
            // DASHBOARD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 450);
            Controls.Add(panel1);
            Controls.Add(txt_Ten);
            Controls.Add(btn_BanVe);
            Controls.Add(btn_QuanLy);
            Controls.Add(label1);
            Controls.Add(btn_Logout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DASHBOARD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DASHBOARD";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Logout;
        private Label label1;
        private Button btn_QuanLy;
        private Button btn_BanVe;
        private TextBox txt_Ten;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}