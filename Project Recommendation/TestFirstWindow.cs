namespace design
{
    public partial class TestFirstWindow : Form
    {
        public TestFirstWindow()
        {
            InitializeComponent();
            label1.Parent = Picture7;
            label1.BackColor = Color.Transparent;
            Town.Parent = Picture7;
            Town.BackColor = Color.Transparent;
            TypeOfRealty.Parent = Picture7;
            TypeOfRealty.BackColor = Color.Transparent;
            Purpose.Parent = Picture7;
            Purpose.BackColor = Color.Transparent;
        }

        private void NextButtonButton_Click(object sender, EventArgs e)
        {
            if (TownCombo.Text == String.Empty && RealtyCombo.Text == String.Empty && PurposeCombo.Text == String.Empty)
            {
                MessageBox.Show("Нужно выбрать все поля");
                return;
            }
            TestSecondWindow testSecondWindow = new TestSecondWindow(TownCombo.Text, RealtyCombo.Text, PurposeCombo.Text);
            testSecondWindow.Show();

        }
    }
}
