namespace design
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            Picture4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NameText = new TextBox();
            EmailText = new TextBox();
            PasswordText = new TextBox();
            EditButton = new Button();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Picture4).BeginInit();
            SuspendLayout();
            // 
            // Picture4
            // 
            Picture4.BackgroundImageLayout = ImageLayout.Center;
            Picture4.Image = (Image)resources.GetObject("Picture4.Image");
            Picture4.Location = new Point(-1, 0);
            Picture4.Margin = new Padding(3, 4, 3, 4);
            Picture4.Name = "Picture4";
            Picture4.Size = new Size(797, 850);
            Picture4.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture4.TabIndex = 0;
            Picture4.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(207, 79);
            label1.Name = "label1";
            label1.Size = new Size(432, 76);
            label1.TabIndex = 6;
            label1.Text = "Личный кабинет";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 19.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(90, 194);
            label2.Name = "label2";
            label2.Size = new Size(109, 54);
            label2.TabIndex = 7;
            label2.Text = "Имя:";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Constantia", 19.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(90, 266);
            label3.Name = "label3";
            label3.Size = new Size(418, 56);
            label3.TabIndex = 8;
            label3.Text = "Электронная почта:";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Constantia", 19.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(90, 406);
            label4.Name = "label4";
            label4.Size = new Size(176, 56);
            label4.TabIndex = 9;
            label4.Text = "Пароль:";
            // 
            // NameText
            // 
            NameText.BackColor = Color.FloralWhite;
            NameText.BorderStyle = BorderStyle.None;
            NameText.Font = new Font("Constantia", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameText.ForeColor = Color.DimGray;
            NameText.Location = new Point(217, 195);
            NameText.Margin = new Padding(3, 4, 3, 4);
            NameText.Multiline = true;
            NameText.Name = "NameText";
            NameText.Size = new Size(491, 52);
            NameText.TabIndex = 10;
            // 
            // EmailText
            // 
            EmailText.BackColor = Color.FloralWhite;
            EmailText.BorderStyle = BorderStyle.None;
            EmailText.Font = new Font("Constantia", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EmailText.ForeColor = Color.DimGray;
            EmailText.Location = new Point(91, 338);
            EmailText.Margin = new Padding(3, 4, 3, 4);
            EmailText.Multiline = true;
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(617, 52);
            EmailText.TabIndex = 11;
            // 
            // PasswordText
            // 
            PasswordText.BackColor = Color.FloralWhite;
            PasswordText.BorderStyle = BorderStyle.None;
            PasswordText.Font = new Font("Constantia", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordText.ForeColor = Color.DimGray;
            PasswordText.Location = new Point(91, 480);
            PasswordText.Margin = new Padding(3, 4, 3, 4);
            PasswordText.Multiline = true;
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(617, 52);
            PasswordText.TabIndex = 12;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FloralWhite;
            EditButton.BackgroundImageLayout = ImageLayout.None;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Microsoft JhengHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditButton.ForeColor = Color.DimGray;
            EditButton.Location = new Point(461, 679);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(247, 55);
            EditButton.TabIndex = 13;
            EditButton.Text = "РЕДАКТИРОВАТЬ";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FloralWhite;
            SaveButton.BackgroundImageLayout = ImageLayout.None;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Microsoft JhengHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.DimGray;
            SaveButton.Location = new Point(217, 679);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(221, 55);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "СОХРАНИТЬ";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 849);
            Controls.Add(SaveButton);
            Controls.Add(EditButton);
            Controls.Add(PasswordText);
            Controls.Add(EmailText);
            Controls.Add(NameText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Picture4);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Picture4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
    }
}