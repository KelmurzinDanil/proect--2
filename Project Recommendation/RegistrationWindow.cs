using DB_993;

namespace design
{
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            PasswordRegText.PasswordChar = '*';
            LoginRegText.KeyPress += LoginRegText_KeyPress;
        }
        private void LoginRegText_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && !char.GetUnicodeCategory(e.KeyChar).Equals(System.Globalization.UnicodeCategory.LowercaseLetter) && !char.GetUnicodeCategory(e.KeyChar).Equals(System.Globalization.UnicodeCategory.UppercaseLetter))
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar >= 'А' && e.KeyChar <= 'я')
                {
                    e.Handled = true;
                }
            }
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameRegText.Text) || string.IsNullOrWhiteSpace(LoginRegText.Text) || string.IsNullOrWhiteSpace(PasswordRegText.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            using (var context = new ApplicationContex())
            {
                var existingUser = context.Users.FirstOrDefault(user => user.Email == LoginRegText.Text);
                if (existingUser != null)
                {
                    MessageBox.Show("Пользователь с такой электронной почтой уже существует.");
                    return;
                }

                var newUser = new User
                {
                    Name = NameRegText.Text,
                    Email = LoginRegText.Text,
                    Password = PasswordRegText.Text
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                MessageBox.Show("Регистрация прошла успешно!");
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
                this.Close();
            }
        }
    }
}
