using DB_993;

namespace design
{
    public partial class Profile : Form
    {
        string Email_ { get; set; }
        public Profile()
        {
            InitializeComponent();
            SaveButton.Hide();
            LoadUserData();
            label1.Parent = Picture4;
            label1.BackColor = Color.Transparent;
            label2.Parent = Picture4;
            label2.BackColor = Color.Transparent;
            label3.Parent = Picture4;
            label3.BackColor = Color.Transparent;
            label4.Parent = Picture4;
            label4.BackColor = Color.Transparent;
            EmailText.KeyPress += EmailText_KeyPress;
            NameText.ReadOnly = true;
            EmailText.ReadOnly = true;
            PasswordText.ReadOnly = true;

        }
        public Profile(string email)
        {
            Email_ = email;
            InitializeComponent();
            SaveButton.Hide();
            LoadUserData();
            label1.Parent = Picture4;
            label1.BackColor = Color.Transparent;
            label2.Parent = Picture4;
            label2.BackColor = Color.Transparent;
            label3.Parent = Picture4;
            label3.BackColor = Color.Transparent;
            label4.Parent = Picture4;
            label4.BackColor = Color.Transparent;
            EmailText.KeyPress += EmailText_KeyPress;
            NameText.ReadOnly = true;
            EmailText.ReadOnly = true;
            PasswordText.ReadOnly = true;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            NameText.ReadOnly = false;
            EmailText.ReadOnly = false;
            PasswordText.ReadOnly = false;
            SaveButton.Show();
        }

        private void LoadUserData()
        {
            using (var context = new ApplicationContex())
            {

                var user = context.Users.FirstOrDefault(user => user.Email == Email_);
                if (user != null)
                {
                    NameText.Text = user.Name ?? string.Empty;
                    EmailText.Text = user.Email ?? string.Empty;
                    PasswordText.Text = user.Password ?? string.Empty;
                }
            }
        }

        private void EmailText_KeyPress(object? sender, KeyPressEventArgs e)
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

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameText.Text) || string.IsNullOrWhiteSpace(EmailText.Text) || string.IsNullOrWhiteSpace(PasswordText.Text))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            using (var context = new ApplicationContex())
            {

                var existingUser = context.Users.FirstOrDefault(user => user.Email == EmailText.Text && user.Email != Email_);
                if (existingUser != null)
                {
                    MessageBox.Show("Пользователь с такой электронной почтой уже существует.");
                    return;
                }

                var user = context.Users.FirstOrDefault(user => user.Email == Email_);
                if (user != null)
                {
                    user.Name = NameText.Text;
                    user.Email = EmailText.Text;
                    user.Password = PasswordText.Text;
                    context.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!");
                }
                else
                {
                    MessageBox.Show("Пользователь не найден.");
                }
            }
        }
    }
}
