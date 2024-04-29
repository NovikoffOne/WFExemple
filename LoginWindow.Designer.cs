namespace WF
{
    partial class LoginWindow
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
            Background = new Panel();
            EnterButton = new Button();
            Pass = new TextBox();
            LockImage = new PictureBox();
            UserName = new TextBox();
            UserImage = new PictureBox();
            Header = new Panel();
            Exit = new Label();
            Login = new Label();
            RegistryButton = new Label();
            Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LockImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserImage).BeginInit();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // Background
            // 
            Background.BackColor = Color.LightCoral;
            Background.Controls.Add(RegistryButton);
            Background.Controls.Add(EnterButton);
            Background.Controls.Add(Pass);
            Background.Controls.Add(LockImage);
            Background.Controls.Add(UserName);
            Background.Controls.Add(UserImage);
            Background.Controls.Add(Header);
            Background.Dock = DockStyle.Fill;
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Size = new Size(465, 406);
            Background.TabIndex = 0;
            Background.MouseDown += Background_MouseDown;
            Background.MouseEnter += Exit_MouseEnter;
            Background.MouseLeave += Exit_MouseLeave;
            Background.MouseMove += Background_MouseMove;
            // 
            // EnterButton
            // 
            EnterButton.Cursor = Cursors.Hand;
            EnterButton.FlatAppearance.BorderSize = 0;
            EnterButton.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            EnterButton.FlatAppearance.MouseOverBackColor = Color.RosyBrown;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EnterButton.Location = new Point(129, 334);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(302, 60);
            EnterButton.TabIndex = 5;
            EnterButton.Text = "Enter";
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += EnterButton_Click;
            EnterButton.MouseEnter += Exit_MouseEnter;
            EnterButton.MouseLeave += Exit_MouseLeave;
            // 
            // Pass
            // 
            Pass.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Pass.Location = new Point(129, 244);
            Pass.Name = "Pass";
            Pass.PasswordChar = '*';
            Pass.Size = new Size(302, 65);
            Pass.TabIndex = 4;
            Pass.UseSystemPasswordChar = true;
            Pass.MouseEnter += Exit_MouseEnter;
            Pass.MouseLeave += Exit_MouseLeave;
            // 
            // LockImage
            // 
            LockImage.Image = Properties.Resources.Lock128;
            LockImage.Location = new Point(34, 244);
            LockImage.Name = "LockImage";
            LockImage.Size = new Size(64, 64);
            LockImage.SizeMode = PictureBoxSizeMode.StretchImage;
            LockImage.TabIndex = 3;
            LockImage.TabStop = false;
            LockImage.MouseEnter += Exit_MouseEnter;
            LockImage.MouseLeave += Exit_MouseLeave;
            // 
            // UserName
            // 
            UserName.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserName.Location = new Point(129, 152);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.Size = new Size(302, 64);
            UserName.TabIndex = 2;
            UserName.MouseEnter += Exit_MouseEnter;
            UserName.MouseLeave += Exit_MouseLeave;
            // 
            // UserImage
            // 
            UserImage.Image = Properties.Resources.User128;
            UserImage.Location = new Point(34, 152);
            UserImage.Name = "UserImage";
            UserImage.Size = new Size(64, 64);
            UserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            UserImage.TabIndex = 1;
            UserImage.TabStop = false;
            UserImage.MouseEnter += Exit_MouseEnter;
            UserImage.MouseLeave += Exit_MouseLeave;
            // 
            // Header
            // 
            Header.BackColor = Color.RosyBrown;
            Header.Controls.Add(Exit);
            Header.Controls.Add(Login);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(465, 125);
            Header.TabIndex = 0;
            Header.MouseEnter += Header_MouseEnter;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Exit.ForeColor = Color.Black;
            Exit.ImageAlign = ContentAlignment.TopRight;
            Exit.Location = new Point(426, -10);
            Exit.Name = "Exit";
            Exit.Size = new Size(39, 46);
            Exit.TabIndex = 1;
            Exit.Text = "x";
            Exit.Click += Exit_Click;
            Exit.MouseEnter += Exit_MouseEnter;
            Exit.MouseLeave += Exit_MouseLeave;
            // 
            // Login
            // 
            Login.Dock = DockStyle.Fill;
            Login.Font = new Font("Verdana", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Login.Location = new Point(0, 0);
            Login.Name = "Login";
            Login.Size = new Size(465, 125);
            Login.TabIndex = 0;
            Login.Text = "Log in";
            Login.TextAlign = ContentAlignment.MiddleCenter;
            Login.MouseDown += Background_MouseDown;
            Login.MouseMove += Background_MouseMove;
            // 
            // RegistryButton
            // 
            RegistryButton.AutoSize = true;
            RegistryButton.Location = new Point(36, 352);
            RegistryButton.Name = "RegistryButton";
            RegistryButton.Size = new Size(62, 20);
            RegistryButton.TabIndex = 6;
            RegistryButton.Text = "Registry";
            RegistryButton.Click += RegistryButton_Click;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 406);
            Controls.Add(Background);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginWindow";
            Text = "LoginWindow";
            Background.ResumeLayout(false);
            Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LockImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserImage).EndInit();
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private Panel Background;
        private Panel Header;
        private Label Login;
        private Label Exit;
        private PictureBox UserImage;
        private TextBox Pass;
        private PictureBox LockImage;
        private TextBox UserName;
        private Button EnterButton;
        private Label RegistryButton;
    }
}