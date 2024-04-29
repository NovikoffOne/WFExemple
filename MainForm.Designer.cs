namespace WF
{
    partial class MainForm
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
            Login = new Label();
            LoginButton = new Button();
            Background = new Panel();
            Header = new Panel();
            Exit = new Label();
            Registry = new Button();
            Background.SuspendLayout();
            Header.SuspendLayout();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Dock = DockStyle.Fill;
            Login.Font = new Font("Verdana", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Login.Location = new Point(0, 0);
            Login.Name = "Login";
            Login.Size = new Size(800, 125);
            Login.TabIndex = 0;
            Login.Text = "Main";
            Login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            LoginButton.FlatAppearance.MouseOverBackColor = Color.RosyBrown;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginButton.Location = new Point(21, 251);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(370, 89);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Background
            // 
            Background.BackColor = Color.LightCoral;
            Background.Controls.Add(Registry);
            Background.Controls.Add(LoginButton);
            Background.Controls.Add(Header);
            Background.Dock = DockStyle.Fill;
            Background.Location = new Point(0, 0);
            Background.Name = "Background";
            Background.Size = new Size(800, 450);
            Background.TabIndex = 1;
            // 
            // Header
            // 
            Header.BackColor = Color.RosyBrown;
            Header.Controls.Add(Exit);
            Header.Controls.Add(Login);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(800, 125);
            Header.TabIndex = 0;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Exit.ForeColor = Color.Black;
            Exit.ImageAlign = ContentAlignment.TopRight;
            Exit.Location = new Point(761, -9);
            Exit.Name = "Exit";
            Exit.Size = new Size(39, 46);
            Exit.TabIndex = 1;
            Exit.Text = "x";
            Exit.Click += Exit_Click;
            // 
            // Registry
            // 
            Registry.Cursor = Cursors.Hand;
            Registry.FlatAppearance.BorderSize = 0;
            Registry.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            Registry.FlatAppearance.MouseOverBackColor = Color.RosyBrown;
            Registry.FlatStyle = FlatStyle.Flat;
            Registry.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Registry.Location = new Point(444, 251);
            Registry.Name = "Registry";
            Registry.Size = new Size(344, 89);
            Registry.TabIndex = 6;
            Registry.Text = "Registry";
            Registry.UseVisualStyleBackColor = true;
            Registry.Click += Registry_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Background);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Background.ResumeLayout(false);
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Login;
        private Button LoginButton;
        private Panel Background;
        private Panel Header;
        private Label Exit;
        private Button Registry;
    }
}