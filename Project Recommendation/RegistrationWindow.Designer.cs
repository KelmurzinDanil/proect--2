namespace design
{
    partial class RegistrationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationWindow));
            this.Picture2 = new System.Windows.Forms.PictureBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.NameRegText = new System.Windows.Forms.TextBox();
            this.LoginRegText = new System.Windows.Forms.TextBox();
            this.PasswordRegText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture2
            // 
            this.Picture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Picture2.Image = ((System.Drawing.Image)(resources.GetObject("Picture2.Image")));
            this.Picture2.Location = new System.Drawing.Point(-5, -3);
            this.Picture2.Name = "Picture2";
            this.Picture2.Size = new System.Drawing.Size(893, 647);
            this.Picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture2.TabIndex = 0;
            this.Picture2.TabStop = false;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.FloralWhite;
            this.RegistrationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrationButton.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.ForeColor = System.Drawing.Color.DimGray;
            this.RegistrationButton.Location = new System.Drawing.Point(318, 520);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(269, 42);
            this.RegistrationButton.TabIndex = 5;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // NameRegText
            // 
            this.NameRegText.BackColor = System.Drawing.Color.FloralWhite;
            this.NameRegText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRegText.ForeColor = System.Drawing.Color.DimGray;
            this.NameRegText.Location = new System.Drawing.Point(422, 271);
            this.NameRegText.Multiline = true;
            this.NameRegText.Name = "NameRegText";
            this.NameRegText.Size = new System.Drawing.Size(305, 33);
            this.NameRegText.TabIndex = 6;
            // 
            // LoginRegText
            // 
            this.LoginRegText.BackColor = System.Drawing.Color.FloralWhite;
            this.LoginRegText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginRegText.ForeColor = System.Drawing.Color.DimGray;
            this.LoginRegText.Location = new System.Drawing.Point(422, 337);
            this.LoginRegText.Multiline = true;
            this.LoginRegText.Name = "LoginRegText";
            this.LoginRegText.Size = new System.Drawing.Size(305, 33);
            this.LoginRegText.TabIndex = 7;
            // 
            // PasswordRegText
            // 
            this.PasswordRegText.BackColor = System.Drawing.Color.FloralWhite;
            this.PasswordRegText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordRegText.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordRegText.Location = new System.Drawing.Point(422, 401);
            this.PasswordRegText.Multiline = true;
            this.PasswordRegText.Name = "PasswordRegText";
            this.PasswordRegText.Size = new System.Drawing.Size(305, 33);
            this.PasswordRegText.TabIndex = 8;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 637);
            this.Controls.Add(this.PasswordRegText);
            this.Controls.Add(this.LoginRegText);
            this.Controls.Add(this.NameRegText);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.Picture2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RegistrationWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture2;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TextBox NameRegText;
        private System.Windows.Forms.TextBox LoginRegText;
        private System.Windows.Forms.TextBox PasswordRegText;
    }
}