namespace WinFormsApp2
{
    public partial class RegisterForm : Form
    {
        private readonly DatabaseManager _dbManager;

        public RegisterForm()
        {
            InitializeComponent();
            _dbManager = new DatabaseManager();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Проверяем лимит при загрузке формы
            if (_dbManager.IsAccountLimitReached())
            {
                MessageBox.Show("Достигнут лимит создания аккаунтов! Максимально допустимо: 2 аккаунта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else
            {
                int remaining = _dbManager.GetRemainingSlots();
                this.Text = $"Регистрация (осталось слотов: {remaining})";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string email = txtEmail.Text.Trim();

            // Валидация полей
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Пожалуйста, введите логин!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (username.Length < 3)
            {
                MessageBox.Show("Логин должен содержать минимум 3 символа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (password.Length < 4)
            {
                MessageBox.Show("Пароль должен содержать минимум 4 символа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                MessageBox.Show("Пожалуйста, введите корректный email!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Если все проверки прошли успешно
            if (SaveAccount(username, password, email))
            {
                MessageBox.Show("Аккаунт успешно создан!\nТеперь вы можете войти!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Проверяем причину ошибки
                if (_dbManager.IsAccountLimitReached())
                {
                    MessageBox.Show("Достигнут лимит создания аккаунтов!\nМаксимально допустимо: 2 аккаунта.", "Ошибка лимита", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ошибка при создании аккаунта.\nЛогин может быть уже занят!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SaveAccount(string username, string password, string email)
        {
            try
            {
                // Используем DatabaseManager вместо файла
                return _dbManager.CreateUser(username, password, email);
            }
            catch
            {
                return false;
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
                btnRegister_Click(null, null);
                e.Handled = true;
            }
        }
    }
}
