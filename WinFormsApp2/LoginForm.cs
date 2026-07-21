namespace WinFormsApp2
{
    public partial class LoginForm : Form
    {
        private readonly DatabaseManager _dbManager;

        public LoginForm()
        {
            InitializeComponent();
            _dbManager = new DatabaseManager();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Обновляем статус кнопки регистрации если лимит достигнут
            if (_dbManager.IsAccountLimitReached())
            {
                btnRegister.Enabled = false;
                btnRegister.Text = "Регистрация (лимит достигнут)";
            }
            else
            {
                btnRegister.Enabled = true;
                int remaining = _dbManager.GetRemainingSlots();
                btnRegister.Text = $"Создать новый аккаунт ({remaining}/{_dbManager.GetMaxAccounts()})";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Простая локальная проверка (можно заменить на более сложную логику)
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Пожалуйста, введите логин!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Пример простой проверки (замените на вашу логику)
            if (ValidateCredentials(username, password))
            {
                // Получаем информацию пользователя
                var userInfo = _dbManager.GetUserInfo(username);
                if (userInfo.HasValue)
                {
                    CurrentUser.SetUser(userInfo.Value.username, userInfo.Value.email);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            // Используем DatabaseManager для проверки учётных данных
            return _dbManager.AuthenticateUser(username, password);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
                e.Handled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Аккаунт создан успешно!\nТеперь вы можете войти в систему.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPasswordForm resetForm = new ResetPasswordForm();
            if (resetForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Пароль успешно сброшен!\nТеперь вы можете войти с новым паролем.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
