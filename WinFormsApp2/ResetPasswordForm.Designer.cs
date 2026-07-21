namespace WinFormsApp2
{
    partial class ResetPasswordForm
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
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblPassphrase = new Label();
            txtPassphrase = new TextBox();
            btnReset = new Button();
            btnCancel = new Button();
            lblAttempts = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(75, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(196, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Сброс пароля";
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
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 10F);
            lblNewPassword.Location = new Point(30, 120);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(103, 19);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "Новый пароль:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 10F);
            txtNewPassword.Location = new Point(30, 145);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(300, 25);
            txtNewPassword.TabIndex = 4;
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
            // 
            // lblPassphrase
            // 
            lblPassphrase.AutoSize = true;
            lblPassphrase.Font = new Font("Segoe UI", 10F);
            lblPassphrase.Location = new Point(30, 240);
            lblPassphrase.Name = "lblPassphrase";
            lblPassphrase.Size = new Size(97, 19);
            lblPassphrase.TabIndex = 7;
            lblPassphrase.Text = "Кодовая фраза:";
            // 
            // txtPassphrase
            // 
            txtPassphrase.Font = new Font("Segoe UI", 10F);
            txtPassphrase.Location = new Point(30, 265);
            txtPassphrase.Name = "txtPassphrase";
            txtPassphrase.PasswordChar = '*';
            txtPassphrase.Size = new Size(300, 25);
            txtPassphrase.TabIndex = 8;
            txtPassphrase.KeyDown += txtConfirmPassword_KeyDown;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(0, 120, 215);
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(30, 310);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(140, 40);
            btnReset.TabIndex = 9;
            btnReset.Text = "Сбросить пароль";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
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
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Font = new Font("Segoe UI", 9F);
            lblAttempts.ForeColor = Color.FromArgb(100, 100, 100);
            lblAttempts.Location = new Point(30, 360);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(143, 15);
            lblAttempts.TabIndex = 11;
            lblAttempts.Text = "Осталось попыток: 3";
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(360, 390);
            Controls.Add(lblAttempts);
            Controls.Add(btnCancel);
            Controls.Add(btnReset);
            Controls.Add(txtPassphrase);
            Controls.Add(lblPassphrase);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ResetPasswordForm";
            Text = "Сброс пароля";
            Load += ResetPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lblPassphrase;
        private TextBox txtPassphrase;
        private Button btnReset;
        private Button btnCancel;
        private Label lblAttempts;
    }
}
