namespace WinFormsApp2
{
    public partial class ResetPasswordForm : Form
    {
        private readonly DatabaseManager _dbManager;
        private int _attemptCount = 0;
        private const int MAX_ATTEMPTS = 3;

        public ResetPasswordForm()
        {
            InitializeComponent();
            _dbManager = new DatabaseManager();
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string passphrase = txtPassphrase.Text;

            // Проверяем попытки
            if (_attemptCount >= MAX_ATTEMPTS)
            {
                MessageBox.Show("Превышено максимальное количество попыток!\nОкно будет закрыто.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            // Валидация логина
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Пожалуйста, введите логин!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            // Валидация пароля
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Пожалуйста, введите новый пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (newPassword.Length < 4)
            {
                MessageBox.Show("Пароль должен содержать минимум 4 символа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем совпадение паролей
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            // Валидация кодовой фразы
            if (string.IsNullOrEmpty(passphrase))
            {
                MessageBox.Show("Пожалуйста, введите кодовую фразу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassphrase.Focus();
                _attemptCount++;
                UpdateAttemptCounter();
                return;
            }

            // Пытаемся сбросить пароль
            if (!_dbManager.UserExists(username))
            {
                MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _attemptCount++;
                UpdateAttemptCounter();
                return;
            }

            if (_dbManager.ResetPassword(username, newPassword, passphrase))
            {
                MessageBox.Show("Пароль успешно сброшен!\nТеперь вы можете войти с новым паролем.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка сброса пароля!\nПровьте кодовую фразу (подсказка: это слово, описывающее суету).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassphrase.Clear();
                txtPassphrase.Focus();
                _attemptCount++;
                UpdateAttemptCounter();
            }
        }

        private void UpdateAttemptCounter()
        {
            int remaining = MAX_ATTEMPTS - _attemptCount;
            this.Text = $"Сброс пароля (осталось попыток: {remaining})";
            lblAttempts.Text = $"Осталось попыток: {remaining}";

            if (remaining <= 1)
            {
                lblAttempts.ForeColor = Color.Red;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnReset_Click(null, null);
                e.Handled = true;
            }
        }
    }
}
