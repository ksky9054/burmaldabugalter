namespace WinFormsApp2
{
    /// <summary>
    /// Класс для получения информации о системе и лимитах
    /// </summary>
    public class SystemInfo
    {
        private readonly DatabaseManager _dbManager;

        public SystemInfo()
        {
            _dbManager = new DatabaseManager();
        }

        /// <summary>
        /// Получает информацию о текущем состоянии системы
        /// </summary>
        public void DisplaySystemInfo()
        {
            int totalAccounts = _dbManager.GetUserCount();
            int maxAccounts = _dbManager.GetMaxAccounts();
            int remainingSlots = _dbManager.GetRemainingSlots();
            bool limitReached = _dbManager.IsAccountLimitReached();

            string info = $"=== ИНФОРМАЦИЯ О СИСТЕМЕ ===\n\n" +
                          $"Активных аккаунтов: {totalAccounts}\n" +
                          $"Максимум аккаунтов: {maxAccounts}\n" +
                          $"Оставшихся слотов: {remainingSlots}\n" +
                          $"Лимит достигнут: {(limitReached ? "ДА" : "НЕТ")}\n\n" +
                          $"Прогресс: [{GetProgressBar(totalAccounts, maxAccounts)}]";

            MessageBox.Show(info, "Информация системы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetProgressBar(int current, int max)
        {
            int filledLength = (int)((double)current / max * 20);
            return new string('█', filledLength) + new string('░', 20 - filledLength);
        }
    }
}
