using Microsoft.Data.Sqlite;
using System.Text.RegularExpressions;

namespace WinFormsApp2
{
    public class DatabaseManager
    {
        private readonly string _connectionString;
        private const string DbFileName = "users.db";
        private const int MAX_ACCOUNTS = 2;

        public DatabaseManager()
        {
            string dbPath = Path.Combine(Application.StartupPath, DbFileName);
            _connectionString = $"Data Source={dbPath};";
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                // Создаём таблицу пользователей если её нет
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        PasswordHash TEXT NOT NULL,
                        Email TEXT NOT NULL,
                        CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
                        IsActive INTEGER DEFAULT 1
                    )";

                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Создаёт новый аккаунт пользователя
        /// </summary>
        public bool CreateUser(string username, string password, string email)
        {
            try
            {
                // Проверяем лимит аккаунтов
                if (GetUserCount() >= MAX_ACCOUNTS)
                    return false;

                // Валидация входных данных
                if (!ValidateUsername(username))
                    return false;

                if (!ValidatePassword(password))
                    return false;

                if (!ValidateEmail(email))
                    return false;

                // Хешируем пароль используя BCrypt
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                using (var connection = new SqliteConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = @"
                        INSERT INTO Users (Username, PasswordHash, Email) 
                        VALUES (@username, @passwordHash, @email)";

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@passwordHash", passwordHash);
                    command.Parameters.AddWithValue("@email", email);

                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (SqliteException ex) when (ex.Message.Contains("UNIQUE"))
            {
                // Пользователь уже существует
                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Проверяет учётные данные пользователя
        /// </summary>
        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (var connection = new SqliteConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = @"
                        SELECT PasswordHash FROM Users 
                        WHERE Username = @username AND IsActive = 1";

                    command.Parameters.AddWithValue("@username", username);

                    var result = command.ExecuteScalar();

                    if (result == null)
                        return false;

                    string passwordHash = result.ToString() ?? "";

                    // Проверяем пароль используя BCrypt
                    return BCrypt.Net.BCrypt.Verify(password, passwordHash);
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Проверяет, существует ли пользователь с данным логином
        /// </summary>
        public bool UserExists(string username)
        {
            try
            {
                using (var connection = new SqliteConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                    command.Parameters.AddWithValue("@username", username);

                    var result = command.ExecuteScalar();
                    return result != null && (long)result > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        private bool ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            if (username.Length < 3 || username.Length > 50)
                return false;

            // Только буквы, цифры и подчёркивание
            return Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$");
        }

        private bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            return password.Length >= 4 && password.Length <= 100;
        }

        private bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Получает информацию о пользователе
        /// </summary>
        public (string username, string email, DateTime createdAt)? GetUserInfo(string username)
        {
            try
            {
                using (var connection = new SqliteConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = @"
                        SELECT Username, Email, CreatedAt FROM Users 
                        WHERE Username = @username AND IsActive = 1";

                    command.Parameters.AddWithValue("@username", username);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetDateTime(2)
                            );
                        }
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Получает количество активных пользователей
        /// </summary>
        public int GetUserCount()
        {
            try
            {
                using (var connection = new SqliteConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = "SELECT COUNT(*) FROM Users WHERE IsActive = 1";

                    var result = command.ExecuteScalar();
                    return result != null ? (int)(long)result : 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Проверяет, достигнут ли лимит аккаунтов
        /// </summary>
        public bool IsAccountLimitReached()
        {
            return GetUserCount() >= MAX_ACCOUNTS;
        }

        /// <summary>
        /// Возвращает количество оставшихся слотов для регистрации
        /// </summary>
        public int GetRemainingSlots()
        {
            return Math.Max(0, MAX_ACCOUNTS - GetUserCount());
        }

        /// <summary>
        /// Возвращает максимальное количество допустимых аккаунтов
        /// </summary>
        public int GetMaxAccounts()
        {
            return MAX_ACCOUNTS;
        }

        /// <summary>
        /// Сбрасывает пароль пользователя (требуется проверка кодовой фразы)
        /// </summary>
        public bool ResetPassword(string username, string newPassword, string passphrase)
        {
            try
            {
                // Проверяем кодовую фразу
                if (passphrase != "движуха")
                    return false;

                // Валидация пароля
                if (!ValidatePassword(newPassword))
                    return false;

                // Проверяем, существует ли пользователь
                if (!UserExists(username))
                    return false;

                // Хешируем новый пароль
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

                using (var connection = new SqliteConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = @"
                        UPDATE Users 
                        SET PasswordHash = @passwordHash 
                        WHERE Username = @username AND IsActive = 1";

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@passwordHash", passwordHash);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
