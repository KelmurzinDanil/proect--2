namespace design
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Picture3 = new PictureBox();
            label1 = new Label();
            ProfileButton = new Button();
            FavButton = new Button();
            BlackListButton = new Button();
            MyListsButton = new Button();
            StraightButton = new Button();
            BackButton = new Button();
            FormMyRecommendationButton = new Button();
            AddButton = new Button();
            EstimateButton = new Button();
            RealtyPhoto = new PictureBox();
            Price = new Label();
            Square = new Label();
            Address = new Label();
            AmountOfFloors = new Label();
            Floor = new Label();
            AddressText = new Label();
            PriceText = new Label();
            SquareText = new Label();
            AddFavButton = new Button();
            AddBlackListButton = new Button();
            FloorText = new Label();
            ((System.ComponentModel.ISupportInitialize)Picture3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RealtyPhoto).BeginInit();
            SuspendLayout();
            // 
            // Picture3
            // 
            Picture3.BackgroundImageLayout = ImageLayout.Center;
            Picture3.Image = (Image)resources.GetObject("Picture3.Image");
            Picture3.Location = new Point(-1, 0);
            Picture3.Margin = new Padding(3, 4, 3, 4);
            Picture3.Name = "Picture3";
            Picture3.Size = new Size(797, 974);
            Picture3.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture3.TabIndex = 0;
            Picture3.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(195, 116);
            label1.Name = "label1";
            label1.Size = new Size(453, 59);
            label1.TabIndex = 6;
            label1.Text = "Возможно, вам понравится";
            // 
            // ProfileButton
            // 
            ProfileButton.FlatStyle = FlatStyle.Popup;
            ProfileButton.Image = (Image)resources.GetObject("ProfileButton.Image");
            ProfileButton.Location = new Point(148, 15);
            ProfileButton.Margin = new Padding(3, 4, 3, 4);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(61, 76);
            ProfileButton.TabIndex = 7;
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // FavButton
            // 
            FavButton.Image = (Image)resources.GetObject("FavButton.Image");
            FavButton.Location = new Point(232, 11);
            FavButton.Margin = new Padding(3, 4, 3, 4);
            FavButton.Name = "FavButton";
            FavButton.Size = new Size(70, 80);
            FavButton.TabIndex = 8;
            FavButton.UseVisualStyleBackColor = true;
            FavButton.Click += FavButton_Click;
            // 
            // BlackListButton
            // 
            BlackListButton.Image = (Image)resources.GetObject("BlackListButton.Image");
            BlackListButton.Location = new Point(491, 11);
            BlackListButton.Margin = new Padding(3, 4, 3, 4);
            BlackListButton.Name = "BlackListButton";
            BlackListButton.Size = new Size(64, 80);
            BlackListButton.TabIndex = 9;
            BlackListButton.UseVisualStyleBackColor = true;
            BlackListButton.Click += BlackListButton_Click;
            // 
            // MyListsButton
            // 
            MyListsButton.Location = new Point(595, 12);
            MyListsButton.Margin = new Padding(3, 4, 3, 4);
            MyListsButton.Name = "MyListsButton";
            MyListsButton.Size = new Size(64, 80);
            MyListsButton.TabIndex = 10;
            MyListsButton.Text = "мои подбор";
            MyListsButton.UseVisualStyleBackColor = true;
            // 
            // StraightButton
            // 
            StraightButton.FlatStyle = FlatStyle.Flat;
            StraightButton.Image = (Image)resources.GetObject("StraightButton.Image");
            StraightButton.Location = new Point(639, 498);
            StraightButton.Margin = new Padding(3, 4, 3, 4);
            StraightButton.Name = "StraightButton";
            StraightButton.Size = new Size(88, 78);
            StraightButton.TabIndex = 11;
            StraightButton.UseVisualStyleBackColor = true;
            StraightButton.Click += StraightButton_Click;
            // 
            // BackButton
            // 
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Image = (Image)resources.GetObject("BackButton.Image");
            BackButton.Location = new Point(73, 498);
            BackButton.Margin = new Padding(3, 4, 3, 4);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(88, 78);
            BackButton.TabIndex = 12;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // FormMyRecommendationButton
            // 
            FormMyRecommendationButton.BackColor = Color.FloralWhite;
            FormMyRecommendationButton.BackgroundImageLayout = ImageLayout.None;
            FormMyRecommendationButton.FlatStyle = FlatStyle.Flat;
            FormMyRecommendationButton.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormMyRecommendationButton.ForeColor = Color.DimGray;
            FormMyRecommendationButton.Location = new Point(156, 904);
            FormMyRecommendationButton.Margin = new Padding(3, 4, 3, 4);
            FormMyRecommendationButton.Name = "FormMyRecommendationButton";
            FormMyRecommendationButton.Size = new Size(503, 55);
            FormMyRecommendationButton.TabIndex = 14;
            FormMyRecommendationButton.Text = "СФОРМИРОВАТЬ МОИ РЕКОМЕНДАЦИИ";
            FormMyRecommendationButton.UseVisualStyleBackColor = false;
            FormMyRecommendationButton.Click += FormMyRecommendationButton_Click;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(405, 804);
            AddButton.Margin = new Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(59, 70);
            AddButton.TabIndex = 16;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EstimateButton
            // 
            EstimateButton.FlatStyle = FlatStyle.Flat;
            EstimateButton.Image = (Image)resources.GetObject("EstimateButton.Image");
            EstimateButton.Location = new Point(340, 804);
            EstimateButton.Margin = new Padding(3, 4, 3, 4);
            EstimateButton.Name = "EstimateButton";
            EstimateButton.Size = new Size(59, 70);
            EstimateButton.TabIndex = 17;
            EstimateButton.UseVisualStyleBackColor = true;
            // 
            // RealtyPhoto
            // 
            RealtyPhoto.Location = new Point(232, 211);
            RealtyPhoto.Margin = new Padding(3, 4, 3, 4);
            RealtyPhoto.Name = "RealtyPhoto";
            RealtyPhoto.Size = new Size(335, 291);
            RealtyPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            RealtyPhoto.TabIndex = 18;
            RealtyPhoto.TabStop = false;
            // 
            // Price
            // 
            Price.BackColor = Color.Transparent;
            Price.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Price.ForeColor = SystemColors.ButtonHighlight;
            Price.Location = new Point(207, 604);
            Price.Name = "Price";
            Price.Size = new Size(90, 40);
            Price.TabIndex = 19;
            Price.Text = "Цена:";
            // 
            // Square
            // 
            Square.BackColor = Color.Transparent;
            Square.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Square.ForeColor = SystemColors.ButtonHighlight;
            Square.Location = new Point(207, 664);
            Square.Name = "Square";
            Square.Size = new Size(133, 42);
            Square.TabIndex = 20;
            Square.Text = "Площадь:\r\n";
            // 
            // Address
            // 
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Address.ForeColor = SystemColors.ButtonHighlight;
            Address.Location = new Point(207, 535);
            Address.Name = "Address";
            Address.Size = new Size(87, 41);
            Address.TabIndex = 21;
            Address.Text = "Адрес:\r\n";
            // 
            // AmountOfFloors
            // 
            AmountOfFloors.BackColor = Color.Transparent;
            AmountOfFloors.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AmountOfFloors.ForeColor = SystemColors.ButtonHighlight;
            AmountOfFloors.Location = new Point(207, 732);
            AmountOfFloors.Name = "AmountOfFloors";
            AmountOfFloors.Size = new Size(267, 42);
            AmountOfFloors.TabIndex = 22;
            AmountOfFloors.Text = "Количество этажей:\r\n";
            // 
            // Floor
            // 
            Floor.BackColor = Color.Transparent;
            Floor.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Floor.ForeColor = SystemColors.ButtonHighlight;
            Floor.Location = new Point(207, 732);
            Floor.Name = "Floor";
            Floor.Size = new Size(90, 42);
            Floor.TabIndex = 23;
            Floor.Text = "Этаж:\r\n";
            // 
            // AddressText
            // 
            AddressText.BackColor = Color.Transparent;
            AddressText.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressText.ForeColor = SystemColors.ButtonHighlight;
            AddressText.Location = new Point(312, 535);
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(275, 41);
            AddressText.TabIndex = 24;
            // 
            // PriceText
            // 
            PriceText.BackColor = Color.Transparent;
            PriceText.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PriceText.ForeColor = SystemColors.ButtonHighlight;
            PriceText.Location = new Point(312, 602);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(275, 41);
            PriceText.TabIndex = 25;
            // 
            // SquareText
            // 
            SquareText.BackColor = Color.Transparent;
            SquareText.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SquareText.ForeColor = SystemColors.ButtonHighlight;
            SquareText.Location = new Point(346, 664);
            SquareText.Name = "SquareText";
            SquareText.Size = new Size(241, 41);
            SquareText.TabIndex = 26;
            // 
            // AddFavButton
            // 
            AddFavButton.FlatStyle = FlatStyle.Flat;
            AddFavButton.Image = (Image)resources.GetObject("AddFavButton.Image");
            AddFavButton.Location = new Point(528, 804);
            AddFavButton.Margin = new Padding(3, 4, 3, 4);
            AddFavButton.Name = "AddFavButton";
            AddFavButton.Size = new Size(59, 70);
            AddFavButton.TabIndex = 28;
            AddFavButton.UseVisualStyleBackColor = true;
            AddFavButton.Click += AddFavButton_Click;
            // 
            // AddBlackListButton
            // 
            AddBlackListButton.FlatStyle = FlatStyle.Flat;
            AddBlackListButton.Image = (Image)resources.GetObject("AddBlackListButton.Image");
            AddBlackListButton.Location = new Point(212, 804);
            AddBlackListButton.Margin = new Padding(3, 4, 3, 4);
            AddBlackListButton.Name = "AddBlackListButton";
            AddBlackListButton.Size = new Size(59, 70);
            AddBlackListButton.TabIndex = 29;
            AddBlackListButton.UseVisualStyleBackColor = true;
            AddBlackListButton.Click += AddBlackListButton_Click;
            // 
            // FloorText
            // 
            FloorText.BackColor = Color.Transparent;
            FloorText.Font = new Font("Constantia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FloorText.ForeColor = SystemColors.ButtonHighlight;
            FloorText.Location = new Point(440, 732);
            FloorText.Name = "FloorText";
            FloorText.Size = new Size(147, 41);
            FloorText.TabIndex = 30;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 974);
            Controls.Add(FloorText);
            Controls.Add(AddBlackListButton);
            Controls.Add(AddFavButton);
            Controls.Add(SquareText);
            Controls.Add(PriceText);
            Controls.Add(AddressText);
            Controls.Add(Floor);
            Controls.Add(AmountOfFloors);
            Controls.Add(Address);
            Controls.Add(Square);
            Controls.Add(Price);
            Controls.Add(RealtyPhoto);
            Controls.Add(EstimateButton);
            Controls.Add(AddButton);
            Controls.Add(FormMyRecommendationButton);
            Controls.Add(BackButton);
            Controls.Add(StraightButton);
            Controls.Add(MyListsButton);
            Controls.Add(BlackListButton);
            Controls.Add(FavButton);
            Controls.Add(ProfileButton);
            Controls.Add(label1);
            Controls.Add(Picture3);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Picture3).EndInit();
            ((System.ComponentModel.ISupportInitialize)RealtyPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button BlackListButton;
        private System.Windows.Forms.Button MyListsButton;
        private System.Windows.Forms.Button StraightButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button FormMyRecommendationButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EstimateButton;
        private System.Windows.Forms.PictureBox RealtyPhoto;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Square;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label AmountOfFloors;
        private System.Windows.Forms.Label Floor;
        private System.Windows.Forms.Label AddressText;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.Label SquareText;
        private System.Windows.Forms.Button AddFavButton;
        private System.Windows.Forms.Button AddBlackListButton;
        private Label FloorText;
    }
}