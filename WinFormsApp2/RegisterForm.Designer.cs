namespace WinFormsApp2
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
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(75, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Создание аккаунта";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(30, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(50, 19);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Логин:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.Location = new Point(30, 85);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 25);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(30, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 19);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(30, 145);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 25);
            txtPassword.TabIndex = 4;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F);
            lblConfirmPassword.Location = new Point(30, 180);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(124, 19);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Подтвердите пароль:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10F);
            txtConfirmPassword.Location = new Point(30, 205);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(300, 25);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.KeyDown += txtConfirmPassword_KeyDown;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(30, 240);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 19);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(30, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 25);
            txtEmail.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(0, 120, 215);
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(30, 310);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 40);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Создать аккаунт";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(200, 200, 200);
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.Location = new Point(190, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 40);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(360, 370);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "RegisterForm";
            Text = "Регистрация";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnRegister;
        private Button btnCancel;
    }
}
