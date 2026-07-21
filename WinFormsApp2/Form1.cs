namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetFormIcon();
        }

        private void SetFormIcon()
        {
            try
            {
                string iconPath = Path.Combine(Application.StartupPath, "Resources", "app_icon.png");
                if (File.Exists(iconPath))
                {
                    using (var bitmap = new Bitmap(iconPath))
                    {
                        this.Icon = Icon.FromHandle(bitmap.GetHicon());
                    }
                }
            }
            catch
            {
                // Если иконка не найдена, просто пропускаем
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Устанавливаем текущего пользователя в labels
            if (CurrentUser.IsLoggedIn && !string.IsNullOrEmpty(CurrentUser.Username))
            {
                label1.Text = $"Здравствуйте, {CurrentUser.Username}\r\n";
                label3.Text = $"Профиль: {CurrentUser.Username}";
            }
            else
            {
                label1.Text = "Здравствуйте, Гость\r\n";
                label3.Text = "Профиль: Гость";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
