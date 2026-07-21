namespace WinFormsApp2
{
    /// <summary>
    /// Класс для управления текущим пользователем
    /// </summary>
    public static class CurrentUser
    {
        public static string? Username { get; set; }
        public static string? Email { get; set; }
        public static DateTime? LoginTime { get; set; }

        public static void Clear()
        {
            Username = null;
            Email = null;
            LoginTime = null;
        }

        public static void SetUser(string username, string email)
        {
            Username = username;
            Email = email;
            LoginTime = DateTime.Now;
        }

        public static bool IsLoggedIn => !string.IsNullOrEmpty(Username);
    }
}
