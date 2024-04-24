namespace design
{
    partial class OpenWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenWindow));
            pictureBox1 = new PictureBox();
            LoginTextAutho = new TextBox();
            PasswordTextAutho = new TextBox();
            RegistrationButton = new Button();
            LogInButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(889, 808);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginTextAutho
            // 
            LoginTextAutho.BackColor = Color.FloralWhite;
            LoginTextAutho.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginTextAutho.ForeColor = Color.DimGray;
            LoginTextAutho.Location = new Point(192, 358);
            LoginTextAutho.Margin = new Padding(3, 4, 3, 4);
            LoginTextAutho.Multiline = true;
            LoginTextAutho.Name = "LoginTextAutho";
            LoginTextAutho.Size = new Size(502, 49);
            LoginTextAutho.TabIndex = 1;
            LoginTextAutho.Text = "Электронная почта";
            LoginTextAutho.Click += LoginText_Click;
            // 
            // PasswordTextAutho
            // 
            PasswordTextAutho.BackColor = Color.FloralWhite;
            PasswordTextAutho.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextAutho.ForeColor = Color.DimGray;
            PasswordTextAutho.Location = new Point(192, 456);
            PasswordTextAutho.Margin = new Padding(3, 4, 3, 4);
            PasswordTextAutho.Multiline = true;
            PasswordTextAutho.Name = "PasswordTextAutho";
            PasswordTextAutho.Size = new Size(502, 49);
            PasswordTextAutho.TabIndex = 2;
            PasswordTextAutho.Text = "Пароль";
            PasswordTextAutho.Click += PasswordText_Click;
            // 
            // RegistrationButton
            // 
            RegistrationButton.BackColor = Color.FloralWhite;
            RegistrationButton.BackgroundImageLayout = ImageLayout.None;
            RegistrationButton.FlatStyle = FlatStyle.Popup;
            RegistrationButton.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegistrationButton.ForeColor = Color.DimGray;
            RegistrationButton.Location = new Point(318, 705);
            RegistrationButton.Margin = new Padding(3, 4, 3, 4);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(269, 52);
            RegistrationButton.TabIndex = 4;
            RegistrationButton.Text = "Зарегистрироваться";
            RegistrationButton.UseVisualStyleBackColor = false;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.FloralWhite;
            LogInButton.BackgroundImageLayout = ImageLayout.None;
            LogInButton.FlatStyle = FlatStyle.Popup;
            LogInButton.Font = new Font("Microsoft YaHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogInButton.ForeColor = Color.DimGray;
            LogInButton.Location = new Point(331, 532);
            LogInButton.Margin = new Padding(3, 4, 3, 4);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(221, 55);
            LogInButton.TabIndex = 3;
            LogInButton.Text = "Войти";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(192, 200);
            label1.Name = "label1";
            label1.Size = new Size(515, 84);
            label1.TabIndex = 5;
            label1.Text = "Твой дом там, где ты";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(294, 620);
            label2.Name = "label2";
            label2.Size = new Size(339, 58);
            label2.TabIndex = 6;
            label2.Text = "Нет аккаунта? Создай!";
            // 
            // OpenWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 789);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegistrationButton);
            Controls.Add(LogInButton);
            Controls.Add(PasswordTextAutho);
            Controls.Add(LoginTextAutho);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OpenWindow";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginTextAutho;
        private System.Windows.Forms.TextBox PasswordTextAutho;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

