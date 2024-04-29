namespace WF
{
    partial class RegisterForm
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
            Exit = new Label();
            Pass = new TextBox();
            UserName = new TextBox();
            Background = new Panel();
            UserLastNameInput = new TextBox();
            UserNameInput = new TextBox();
            EnterRegister = new Button();
            LockImage = new PictureBox();
            UserImage = new PictureBox();
            Header = new Panel();
            Login = new Label();
            Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LockImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserImage).BeginInit();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Exit.ForeColor = Color.Black;
            Exit.ImageAlign = ContentAlignment.TopRight;
            Exit.Location = new Point(868, -9);
            Exit.Name = "Exit";
            Exit.Size = new Size(39, 46);
            Exit.TabIndex = 1;
            Exit.Text = "x";
            Exit.Click += Exit_Click;
            Exit.MouseEnter += Exit_MouseEnter;
            Exit.MouseLeave += Exit_MouseLeave;
            // 
            // Pass
            // 
            Pass.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Pass.Location = new Point(129, 244);
            Pass.Name = "Pass";
            Pass.PasswordChar = '*';
            Pass.Size = new Size(362, 65);
            Pass.TabIndex = 4;
            Pass.Text = "Password";
            Pass.UseSystemPasswordChar = true;
            Pass.TextChanged += Pass_TextChanged;
            Pass.Enter += Pass_Enter;
            Pass.Leave += Pass_Leave;
            // 
            // UserName
            // 
            UserName.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserName.Location = new Point(129, 152);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.Size = new Size(362, 64);
            UserName.TabIndex = 2;
            UserName.Text = "Log";
            UserName.Enter += UserName_Enter;
            UserName.Leave += UserName_Leave;
            // 
            // Background
            // 
            Background.BackColor = Color.LightCoral;
            Background.Controls.Add(UserLastNameInput);
            Background.Controls.Add(UserNameInput);
            Background.Controls.Add(EnterRegister);
            Background.Controls.Add(Pass);
            Background.Controls.Add(LockImage);
            Background.Controls.Add(UserName);
            Background.Controls.Add(UserImage);
            Background.Controls.Add(Header);
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Size = new Size(907, 450);
            Background.TabIndex = 1;
            Background.Paint += Background_Paint;
            Background.MouseDown += Background_MouseDown;
            Background.MouseMove += Background_MouseMove;
            // 
            // UserLastNameInput
            // 
            UserLastNameInput.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserLastNameInput.Location = new Point(511, 245);
            UserLastNameInput.Multiline = true;
            UserLastNameInput.Name = "UserLastNameInput";
            UserLastNameInput.Size = new Size(362, 64);
            UserLastNameInput.TabIndex = 7;
            UserLastNameInput.Text = "Last Name";
            UserLastNameInput.Enter += UserLastNameInput_Enter;
            UserLastNameInput.Leave += UserLastNameInput_Leave;
            // 
            // UserNameInput
            // 
            UserNameInput.Font = new Font("Yu Gothic UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UserNameInput.Location = new Point(511, 152);
            UserNameInput.Multiline = true;
            UserNameInput.Name = "UserNameInput";
            UserNameInput.Size = new Size(362, 64);
            UserNameInput.TabIndex = 6;
            UserNameInput.Text = "Name";
            UserNameInput.Enter += UserNameInput_Enter;
            UserNameInput.Leave += UserNameInput_Leave;
            // 
            // EnterRegister
            // 
            EnterRegister.Cursor = Cursors.Hand;
            EnterRegister.FlatAppearance.BorderSize = 0;
            EnterRegister.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            EnterRegister.FlatAppearance.MouseOverBackColor = Color.RosyBrown;
            EnterRegister.FlatStyle = FlatStyle.Flat;
            EnterRegister.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EnterRegister.Location = new Point(129, 334);
            EnterRegister.Name = "EnterRegister";
            EnterRegister.Size = new Size(744, 65);
            EnterRegister.TabIndex = 5;
            EnterRegister.Text = "Register";
            EnterRegister.UseVisualStyleBackColor = true;
            EnterRegister.Click += EnterRegister_Click;
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
            // 
            // Header
            // 
            Header.BackColor = Color.RosyBrown;
            Header.Controls.Add(Exit);
            Header.Controls.Add(Login);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(907, 125);
            Header.TabIndex = 0;
            // 
            // Login
            // 
            Login.Dock = DockStyle.Fill;
            Login.Font = new Font("Verdana", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Login.Location = new Point(0, 0);
            Login.Name = "Login";
            Login.Size = new Size(907, 125);
            Login.TabIndex = 0;
            Login.Text = "Registration";
            Login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 450);
            Controls.Add(Background);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            Background.ResumeLayout(false);
            Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LockImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserImage).EndInit();
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Exit;
        private TextBox Pass;
        private TextBox UserName;
        private Panel Background;
        private PictureBox LockImage;
        private PictureBox UserImage;
        private Panel Header;
        private Label Login;
        private TextBox UserLastNameInput;
        private TextBox UserNameInput;
        private Button EnterRegister;
    }
}