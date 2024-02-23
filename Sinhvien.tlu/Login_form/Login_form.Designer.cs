namespace Sinhvien.tlu.Login_form
{
    partial class System_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(System_Login));
            Logo_thuyloi = new PictureBox();
            name_school = new Label();
            login_front = new PictureBox();
            Back_login = new PictureBox();
            Exit_Button = new PictureBox();
            Login_Button = new PictureBox();
            Login_label_center = new Label();
            USR_label = new TextBox();
            PASS_label = new TextBox();
            Login_label = new Label();
            Exit_label = new Label();
            Login_action = new Label();
            ((System.ComponentModel.ISupportInitialize)Logo_thuyloi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)login_front).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Back_login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit_Button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Login_Button).BeginInit();
            SuspendLayout();
            // 
            // Logo_thuyloi
            // 
            Logo_thuyloi.Image = Properties.Resources.logo_thuyloi1;
            Logo_thuyloi.Location = new Point(138, 12);
            Logo_thuyloi.Name = "Logo_thuyloi";
            Logo_thuyloi.Size = new Size(99, 80);
            Logo_thuyloi.SizeMode = PictureBoxSizeMode.Zoom;
            Logo_thuyloi.TabIndex = 1;
            Logo_thuyloi.TabStop = false;
            // 
            // name_school
            // 
            name_school.AutoSize = true;
            name_school.Font = new Font("SVN-Avo", 15F);
            name_school.ForeColor = Color.Transparent;
            name_school.Location = new Point(71, 108);
            name_school.Name = "name_school";
            name_school.Size = new Size(234, 29);
            name_school.TabIndex = 2;
            name_school.Text = "Trường Đại học Thủy lợi";
            // 
            // login_front
            // 
            login_front.BackgroundImage = Properties.Resources.login_side_back2;
            login_front.BackgroundImageLayout = ImageLayout.Zoom;
            login_front.Image = Properties.Resources.login_side_front;
            login_front.Location = new Point(12, 186);
            login_front.Name = "login_front";
            login_front.Size = new Size(358, 252);
            login_front.SizeMode = PictureBoxSizeMode.Zoom;
            login_front.TabIndex = 4;
            login_front.TabStop = false;
            // 
            // Back_login
            // 
            Back_login.BackColor = Color.Transparent;
            Back_login.BackgroundImageLayout = ImageLayout.Stretch;
            Back_login.Image = Properties.Resources.back_login;
            Back_login.Location = new Point(399, 0);
            Back_login.Name = "Back_login";
            Back_login.Size = new Size(403, 450);
            Back_login.SizeMode = PictureBoxSizeMode.StretchImage;
            Back_login.TabIndex = 5;
            Back_login.TabStop = false;
            // 
            // Exit_Button
            // 
            Exit_Button.BackColor = Color.White;
            Exit_Button.Image = Properties.Resources.Button_login;
            Exit_Button.Location = new Point(477, 275);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(104, 42);
            Exit_Button.SizeMode = PictureBoxSizeMode.Zoom;
            Exit_Button.TabIndex = 6;
            Exit_Button.TabStop = false;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // Login_Button
            // 
            Login_Button.BackColor = Color.White;
            Login_Button.Image = Properties.Resources.Button_login;
            Login_Button.Location = new Point(631, 275);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(104, 42);
            Login_Button.SizeMode = PictureBoxSizeMode.Zoom;
            Login_Button.TabIndex = 7;
            Login_Button.TabStop = false;
            Login_Button.Click += Login_Button_Click;
            // 
            // Login_label_center
            // 
            Login_label_center.AutoSize = true;
            Login_label_center.BackColor = Color.White;
            Login_label_center.Font = new Font("Montserrat", 18F, FontStyle.Bold);
            Login_label_center.ForeColor = Color.FromArgb(29, 53, 87);
            Login_label_center.Location = new Point(529, 80);
            Login_label_center.Name = "Login_label_center";
            Login_label_center.Size = new Size(157, 33);
            Login_label_center.TabIndex = 8;
            Login_label_center.Text = "Đăng nhập";
            // 
            // USR_label
            // 
            USR_label.BorderStyle = BorderStyle.FixedSingle;
            USR_label.Cursor = Cursors.IBeam;
            USR_label.Font = new Font("Montserrat", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            USR_label.Location = new Point(477, 159);
            USR_label.MaxLength = 128;
            USR_label.Name = "USR_label";
            USR_label.Size = new Size(260, 23);
            USR_label.TabIndex = 9;
            USR_label.Text = "Mã sinh viên";
            USR_label.KeyPress += Login_KeyPress;
            // 
            // PASS_label
            // 
            PASS_label.BorderStyle = BorderStyle.FixedSingle;
            PASS_label.Cursor = Cursors.IBeam;
            PASS_label.Font = new Font("Montserrat", 9.749999F);
            PASS_label.Location = new Point(477, 203);
            PASS_label.MaxLength = 128;
            PASS_label.Name = "PASS_label";
            PASS_label.Size = new Size(260, 23);
            PASS_label.TabIndex = 10;
            PASS_label.Text = "Mật khẩu";
            PASS_label.UseSystemPasswordChar = true;
            PASS_label.KeyPress += Login_KeyPress;
            // 
            // Login_label
            // 
            Login_label.AutoSize = true;
            Login_label.BackColor = Color.FromArgb(69, 123, 157);
            Login_label.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            Login_label.ForeColor = Color.White;
            Login_label.Location = new Point(637, 285);
            Login_label.Name = "Login_label";
            Login_label.Size = new Size(93, 20);
            Login_label.TabIndex = 11;
            Login_label.Text = "Đăng nhập";
            Login_label.Click += Login_label_Click;
            // 
            // Exit_label
            // 
            Exit_label.AutoSize = true;
            Exit_label.BackColor = Color.FromArgb(69, 123, 157);
            Exit_label.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            Exit_label.ForeColor = Color.White;
            Exit_label.Location = new Point(503, 285);
            Exit_label.Name = "Exit_label";
            Exit_label.Size = new Size(52, 20);
            Exit_label.TabIndex = 12;
            Exit_label.Text = "Thoát";
            Exit_label.Click += Exit_label_Click;
            // 
            // Login_action
            // 
            Login_action.AutoSize = true;
            Login_action.BackColor = Color.White;
            Login_action.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_action.Location = new Point(477, 338);
            Login_action.Name = "Login_action";
            Login_action.Size = new Size(0, 16);
            Login_action.TabIndex = 14;
            // 
            // System_Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(69, 123, 157);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(Login_action);
            Controls.Add(Exit_label);
            Controls.Add(Login_label);
            Controls.Add(PASS_label);
            Controls.Add(USR_label);
            Controls.Add(Login_label_center);
            Controls.Add(Login_Button);
            Controls.Add(Exit_Button);
            Controls.Add(login_front);
            Controls.Add(name_school);
            Controls.Add(Logo_thuyloi);
            Controls.Add(Back_login);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "System_Login";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Education | System login";
            ((System.ComponentModel.ISupportInitialize)Logo_thuyloi).EndInit();
            ((System.ComponentModel.ISupportInitialize)login_front).EndInit();
            ((System.ComponentModel.ISupportInitialize)Back_login).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit_Button).EndInit();
            ((System.ComponentModel.ISupportInitialize)Login_Button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo_thuyloi;
        private Label name_school;
        private PictureBox login_front;
        private PictureBox Back_login;
        private PictureBox Exit_Button;
        private PictureBox Login_Button;
        private Label Login_label_center;
        private TextBox USR_label;
        private TextBox PASS_label;
        private Label Login_label;
        private Label Exit_label;
        private Label Login_action;
    }
}