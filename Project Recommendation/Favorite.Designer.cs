namespace design
{
    partial class Favorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorite));
            Picture6 = new PictureBox();
            ProfileButton = new Button();
            FavButton = new Button();
            BlackListButton = new Button();
            listView1 = new ListView();
            PhotoList = new ColumnHeader();
            PriceList = new ColumnHeader();
            AddressList = new ColumnHeader();
            NameList = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)Picture6).BeginInit();
            SuspendLayout();
            // 
            // Picture6
            // 
            Picture6.BackgroundImageLayout = ImageLayout.Center;
            Picture6.Image = (Image)resources.GetObject("Picture6.Image");
            Picture6.Location = new Point(-5, 0);
            Picture6.Margin = new Padding(3, 4, 3, 4);
            Picture6.Name = "Picture6";
            Picture6.Size = new Size(797, 850);
            Picture6.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture6.TabIndex = 1;
            Picture6.TabStop = false;
            // 
            // ProfileButton
            // 
            ProfileButton.FlatStyle = FlatStyle.Popup;
            ProfileButton.Image = (Image)resources.GetObject("ProfileButton.Image");
            ProfileButton.Location = new Point(146, 11);
            ProfileButton.Margin = new Padding(3, 4, 3, 4);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(61, 76);
            ProfileButton.TabIndex = 8;
            ProfileButton.UseVisualStyleBackColor = true;
            // 
            // FavButton
            // 
            FavButton.Image = (Image)resources.GetObject("FavButton.Image");
            FavButton.Location = new Point(233, 8);
            FavButton.Margin = new Padding(3, 4, 3, 4);
            FavButton.Name = "FavButton";
            FavButton.Size = new Size(70, 80);
            FavButton.TabIndex = 9;
            FavButton.UseVisualStyleBackColor = true;
            // 
            // BlackListButton
            // 
            BlackListButton.Image = (Image)resources.GetObject("BlackListButton.Image");
            BlackListButton.Location = new Point(485, 8);
            BlackListButton.Margin = new Padding(3, 4, 3, 4);
            BlackListButton.Name = "BlackListButton";
            BlackListButton.Size = new Size(64, 80);
            BlackListButton.TabIndex = 10;
            BlackListButton.UseVisualStyleBackColor = true;
            BlackListButton.Click += BlackListButton_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { PhotoList, PriceList, AddressList, NameList });
            listView1.Location = new Point(30, 129);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(729, 507);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // PhotoList
            // 
            PhotoList.Text = "Изображение";
            PhotoList.Width = 120;
            // 
            // PriceList
            // 
            PriceList.Text = "Цена";
            PriceList.Width = 220;
            // 
            // AddressList
            // 
            AddressList.Text = "Адрес";
            AddressList.Width = 260;
            // 
            // NameList
            // 
            NameList.Text = "Название";
            NameList.Width = 120;
            // 
            // Favorite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 670);
            Controls.Add(listView1);
            Controls.Add(BlackListButton);
            Controls.Add(FavButton);
            Controls.Add(ProfileButton);
            Controls.Add(Picture6);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Favorite";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Picture6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture6;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button BlackListButton;
        private ListView listView1;
        private ColumnHeader PhotoList;
        private ColumnHeader NameList;
        private ColumnHeader PriceList;
        private ColumnHeader AddressList;
    }
}