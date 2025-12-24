namespace TTCSDL_NHOM7.GUIs
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            panel1 = new Panel();
            btnLogin = new Button();
            PassVisible_checkbox = new CheckBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(PassVisible_checkbox);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(65, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 350);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(223, 215, 191);
            btnLogin.Location = new Point(17, 288);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(270, 41);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // PassVisible_checkbox
            // 
            PassVisible_checkbox.AutoSize = true;
            PassVisible_checkbox.BackColor = Color.FromArgb(224, 224, 224);
            PassVisible_checkbox.Font = new Font("Segoe UI", 12F);
            PassVisible_checkbox.Location = new Point(157, 217);
            PassVisible_checkbox.Name = "PassVisible_checkbox";
            PassVisible_checkbox.Size = new Size(130, 25);
            PassVisible_checkbox.TabIndex = 8;
            PassVisible_checkbox.Text = "Hiện mật khẩu";
            PassVisible_checkbox.UseVisualStyleBackColor = false;
            PassVisible_checkbox.CheckedChanged += PassVisible_checkbox_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(224, 224, 224);
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16.2F);
            txtPassword.Location = new Point(17, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 32);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(224, 224, 224);
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("Microsoft Sans Serif", 16.2F);
            txtUsername.Location = new Point(17, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 32);
            txtUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(223, 215, 191);
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(69, 19);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(484, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(959, 537);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private CheckBox PassVisible_checkbox;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}