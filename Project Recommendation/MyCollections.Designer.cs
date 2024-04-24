namespace design
{
    partial class MyCollections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCollections));
            this.MyListsButton = new System.Windows.Forms.Button();
            this.BlackListButton = new System.Windows.Forms.Button();
            this.FavButton = new System.Windows.Forms.Button();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.Picture7 = new System.Windows.Forms.PictureBox();
            this.AddCollectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture7)).BeginInit();
            this.SuspendLayout();
            // 
            // MyListsButton
            // 
            this.MyListsButton.Image = ((System.Drawing.Image)(resources.GetObject("MyListsButton.Image")));
            this.MyListsButton.Location = new System.Drawing.Point(584, 4);
            this.MyListsButton.Name = "MyListsButton";
            this.MyListsButton.Size = new System.Drawing.Size(64, 64);
            this.MyListsButton.TabIndex = 16;
            this.MyListsButton.UseVisualStyleBackColor = true;
            // 
            // BlackListButton
            // 
            this.BlackListButton.Image = ((System.Drawing.Image)(resources.GetObject("BlackListButton.Image")));
            this.BlackListButton.Location = new System.Drawing.Point(487, 4);
            this.BlackListButton.Name = "BlackListButton";
            this.BlackListButton.Size = new System.Drawing.Size(64, 64);
            this.BlackListButton.TabIndex = 15;
            this.BlackListButton.UseVisualStyleBackColor = true;
            // 
            // FavButton
            // 
            this.FavButton.Image = ((System.Drawing.Image)(resources.GetObject("FavButton.Image")));
            this.FavButton.Location = new System.Drawing.Point(235, 4);
            this.FavButton.Name = "FavButton";
            this.FavButton.Size = new System.Drawing.Size(70, 64);
            this.FavButton.TabIndex = 14;
            this.FavButton.UseVisualStyleBackColor = true;
            // 
            // ProfileButton
            // 
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("ProfileButton.Image")));
            this.ProfileButton.Location = new System.Drawing.Point(148, 7);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(61, 61);
            this.ProfileButton.TabIndex = 13;
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
            this.Picture7.TabIndex = 12;
            this.Picture7.TabStop = false;
            // 
            // AddCollectionButton
            // 
            this.AddCollectionButton.BackColor = System.Drawing.Color.FloralWhite;
            this.AddCollectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCollectionButton.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCollectionButton.ForeColor = System.Drawing.Color.DimGray;
            this.AddCollectionButton.Location = new System.Drawing.Point(554, 616);
            this.AddCollectionButton.Name = "AddCollectionButton";
            this.AddCollectionButton.Size = new System.Drawing.Size(225, 39);
            this.AddCollectionButton.TabIndex = 17;
            this.AddCollectionButton.Text = "ДОБАВИТЬ\r\n\r\n";
            this.AddCollectionButton.UseVisualStyleBackColor = false;
            this.AddCollectionButton.Click += new System.EventHandler(this.AddCollectionButton_Click);
            // 
            // MyCollections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 677);
            this.Controls.Add(this.AddCollectionButton);
            this.Controls.Add(this.MyListsButton);
            this.Controls.Add(this.BlackListButton);
            this.Controls.Add(this.FavButton);
            this.Controls.Add(this.ProfileButton);
            this.Controls.Add(this.Picture7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MyCollections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Picture7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MyListsButton;
        private System.Windows.Forms.Button BlackListButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.PictureBox Picture7;
        private System.Windows.Forms.Button AddCollectionButton;
    }
}