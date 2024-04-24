using DB_993;

namespace design
{
    public partial class OpenWindow : Form
    {
        public OpenWindow()
        {
            ApplicationContex applicationContex = new ApplicationContex();
            applicationContex.ApplicationContext();
            InitializeComponent();
            MaximizeBox = false;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            LoginTextAutho.PlaceholderText = "Электронная почта";
            PasswordTextAutho.PlaceholderText = "Пароль";
            LoginTextAutho.KeyPress += LoginTextAutho_KeyPress;
            PasswordTextAutho.Enter += PasswordTextAutho_Enter;
        }
        private void PasswordTextAutho_Enter(object? sender, EventArgs e)
        {
            if (PasswordTextAutho.Text == "Пароль")
            {
                PasswordTextAutho.Text = "";
                PasswordTextAutho.PasswordChar = '*';
            }
        }
        private void LoginTextAutho_KeyPress(object? sender, KeyPressEventArgs e)
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

            LoginTextAutho.GotFocus += (sender, e) =>
            {
                if (LoginTextAutho.Text == "Электронная почта")
                {
                    LoginTextAutho.Text = "";
                    LoginTextAutho.ForeColor = Color.Black;
                }
            };
        }

        private void LoginText_Click(object sender, EventArgs e)
        {
            LoginTextAutho.Clear();
        }
        private void PasswordText_Click(object sender, EventArgs e)
        {
            PasswordTextAutho.Clear();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var reg_win = new RegistrationWindow();
            reg_win.ShowDialog();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextAutho.Text) || string.IsNullOrWhiteSpace(PasswordTextAutho.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            using (var context = new ApplicationContex())
            {
                var user = context.Users.FirstOrDefault(user => user.Email == LoginTextAutho.Text && user.Password == PasswordTextAutho.Text);
                if (user == null)
                {
                    MessageBox.Show("Неверный адрес электронной почты или пароль.");
                    return;
                }

                MessageBox.Show("Вы успешно вошли в аккаунт!");
                var mainWindow = new MainWindow(LoginTextAutho.Text);
                mainWindow.ShowDialog();
                this.Hide();
            }
        }
    }
}
