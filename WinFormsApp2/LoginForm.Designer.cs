namespace WinFormsApp2
{
    partial class LoginForm
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
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            btnRegister = new Button();
            btnResetPassword = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(62, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(176, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Вход в систему";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(30, 80);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(50, 19);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Логин:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(30, 105);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 25);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(30, 145);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 19);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(30, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(270, 25);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 215);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(200, 200, 200);
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.Location = new Point(170, 215);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(100, 180, 100);
            btnRegister.Font = new Font("Segoe UI", 9F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(30, 270);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(270, 35);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Создать новый аккаунт";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.FromArgb(255, 165, 0);
            btnResetPassword.Font = new Font("Segoe UI", 9F);
            btnResetPassword.ForeColor = Color.Black;
            btnResetPassword.Location = new Point(30, 315);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(270, 35);
            btnResetPassword.TabIndex = 8;
            btnResetPassword.Text = "Забыли пароль?";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(330, 375);
            Controls.Add(btnResetPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginForm";
            Text = "Вход";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
        private Button btnRegister;
        private Button btnResetPassword;
    }
}
