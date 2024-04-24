namespace design
{
    partial class CollectionCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionCard));
            this.MyListsButton = new System.Windows.Forms.Button();
            this.BlackListButton = new System.Windows.Forms.Button();
            this.FavButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.Picture7 = new System.Windows.Forms.PictureBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture7)).BeginInit();
            this.SuspendLayout();
            // 
            // MyListsButton
            // 
            this.MyListsButton.Image = ((System.Drawing.Image)(resources.GetObject("MyListsButton.Image")));
            this.MyListsButton.Location = new System.Drawing.Point(584, 4);
            this.MyListsButton.Name = "MyListsButton";
            this.MyListsButton.Size = new System.Drawing.Size(64, 64);
            this.MyListsButton.TabIndex = 22;
            this.MyListsButton.UseVisualStyleBackColor = true;
            // 
            // BlackListButton
            // 
            this.BlackListButton.Image = ((System.Drawing.Image)(resources.GetObject("BlackListButton.Image")));
            this.BlackListButton.Location = new System.Drawing.Point(487, 4);
            this.BlackListButton.Name = "BlackListButton";
            this.BlackListButton.Size = new System.Drawing.Size(64, 64);
            this.BlackListButton.TabIndex = 21;
            this.BlackListButton.UseVisualStyleBackColor = true;
            // 
            // FavButton
            // 
            this.FavButton.Image = ((System.Drawing.Image)(resources.GetObject("FavButton.Image")));
            this.FavButton.Location = new System.Drawing.Point(235, 4);
            this.FavButton.Name = "FavButton";
            this.FavButton.Size = new System.Drawing.Size(70, 64);
            this.FavButton.TabIndex = 20;
            this.FavButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(148, 7);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(61, 61);
            this.ProfileButton.TabIndex = 19;
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // Picture7
            // 
            this.Picture7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Picture7.Image = ((System.Drawing.Image)(resources.GetObject("Picture7.Image")));
            this.Picture7.Location = new System.Drawing.Point(-3, -2);
            this.Picture7.Name = "Picture7";
            this.Picture7.Size = new System.Drawing.Size(797, 680);
            this.Picture7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture7.TabIndex = 18;
            this.Picture7.TabStop = false;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FloralWhite;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.DimGray;
            this.EditButton.Location = new System.Drawing.Point(532, 621);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(247, 44);
            this.EditButton.TabIndex = 23;
            this.EditButton.Text = "РЕДАКТИРОВАТЬ";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FloralWhite;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.DimGray;
            this.SaveButton.Location = new System.Drawing.Point(291, 621);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(221, 44);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "СОХРАНИТЬ";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.Color.Transparent;
            this.Name.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name.Location = new System.Drawing.Point(21, 88);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(173, 47);
            this.Name.TabIndex = 25;
            this.Name.Text = "Название:\r\n\r\n";
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.FloralWhite;
            this.NameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameText.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.ForeColor = System.Drawing.Color.DimGray;
            this.NameText.Location = new System.Drawing.Point(215, 88);
            this.NameText.Multiline = true;
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(527, 42);
            this.NameText.TabIndex = 26;
            // 
            // CollectionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 677);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.MyListsButton);
            this.Controls.Add(this.BlackListButton);
            this.Controls.Add(this.FavButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.Picture7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name.Text = "CollectionCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Picture7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyListsButton;
        private System.Windows.Forms.Button BlackListButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.PictureBox Picture7;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NameText;
    }
}