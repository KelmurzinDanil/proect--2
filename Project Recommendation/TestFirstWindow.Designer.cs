namespace design
{
    partial class TestFirstWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestFirstWindow));
            Picture7 = new PictureBox();
            label1 = new Label();
            Town = new Label();
            TypeOfRealty = new Label();
            Purpose = new Label();
            TownCombo = new ComboBox();
            RealtyCombo = new ComboBox();
            PurposeCombo = new ComboBox();
            NextButtonButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Picture7).BeginInit();
            SuspendLayout();
            // 
            // Picture7
            // 
            Picture7.Image = (Image)resources.GetObject("Picture7.Image");
            Picture7.Location = new Point(-1, -4);
            Picture7.Margin = new Padding(3, 4, 3, 4);
            Picture7.Name = "Picture7";
            Picture7.Size = new Size(801, 482);
            Picture7.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture7.TabIndex = 0;
            Picture7.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(175, 22);
            label1.Name = "label1";
            label1.Size = new Size(478, 59);
            label1.TabIndex = 7;
            label1.Text = "Выберите один вариант ответа\r\n";
            // 
            // Town
            // 
            Town.BackColor = Color.Transparent;
            Town.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Town.ForeColor = SystemColors.ButtonHighlight;
            Town.Location = new Point(122, 111);
            Town.Name = "Town";
            Town.Size = new Size(137, 52);
            Town.TabIndex = 8;
            Town.Text = "Город:\r\n";
            // 
            // TypeOfRealty
            // 
            TypeOfRealty.BackColor = Color.Transparent;
            TypeOfRealty.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TypeOfRealty.ForeColor = SystemColors.ButtonHighlight;
            TypeOfRealty.Location = new Point(122, 196);
            TypeOfRealty.Name = "TypeOfRealty";
            TypeOfRealty.Size = new Size(343, 52);
            TypeOfRealty.TabIndex = 9;
            TypeOfRealty.Text = "Тип недвижимости:\r\n\r\n";
            // 
            // Purpose
            // 
            Purpose.BackColor = Color.Transparent;
            Purpose.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Purpose.ForeColor = SystemColors.ButtonHighlight;
            Purpose.Location = new Point(122, 296);
            Purpose.Name = "Purpose";
            Purpose.Size = new Size(152, 49);
            Purpose.TabIndex = 10;
            Purpose.Text = "Для чего:\r\n\r\n";
            // 
            // TownCombo
            // 
            TownCombo.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TownCombo.ForeColor = Color.DimGray;
            TownCombo.FormattingEnabled = true;
            TownCombo.Items.AddRange(new object[] { "Казань", "Москва" });
            TownCombo.Location = new Point(308, 111);
            TownCombo.Margin = new Padding(3, 4, 3, 4);
            TownCombo.Name = "TownCombo";
            TownCombo.Size = new Size(419, 45);
            TownCombo.TabIndex = 11;
            // 
            // RealtyCombo
            // 
            RealtyCombo.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RealtyCombo.ForeColor = Color.DimGray;
            RealtyCombo.FormattingEnabled = true;
            RealtyCombo.Items.AddRange(new object[] { "Дом", "Квартира ", "Комната" });
            RealtyCombo.Location = new Point(484, 192);
            RealtyCombo.Margin = new Padding(3, 4, 3, 4);
            RealtyCombo.Name = "RealtyCombo";
            RealtyCombo.Size = new Size(243, 45);
            RealtyCombo.TabIndex = 12;
            // 
            // PurposeCombo
            // 
            PurposeCombo.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PurposeCombo.ForeColor = Color.DimGray;
            PurposeCombo.FormattingEnabled = true;
            PurposeCombo.Items.AddRange(new object[] { "Купить", "Снять посуточно", "Снять длительно" });
            PurposeCombo.Location = new Point(308, 292);
            PurposeCombo.Margin = new Padding(3, 4, 3, 4);
            PurposeCombo.Name = "PurposeCombo";
            PurposeCombo.Size = new Size(419, 45);
            PurposeCombo.TabIndex = 13;
            // 
            // NextButtonButton
            // 
            NextButtonButton.BackColor = Color.FloralWhite;
            NextButtonButton.BackgroundImageLayout = ImageLayout.None;
            NextButtonButton.FlatStyle = FlatStyle.Flat;
            NextButtonButton.Font = new Font("Microsoft JhengHei UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NextButtonButton.ForeColor = Color.DimGray;
            NextButtonButton.Location = new Point(529, 386);
            NextButtonButton.Margin = new Padding(3, 4, 3, 4);
            NextButtonButton.Name = "NextButtonButton";
            NextButtonButton.Size = new Size(217, 55);
            NextButtonButton.TabIndex = 16;
            NextButtonButton.Text = "ДАЛЕЕ";
            NextButtonButton.UseVisualStyleBackColor = false;
            NextButtonButton.Click += NextButtonButton_Click;
            // 
            // TestFirstWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(NextButtonButton);
            Controls.Add(PurposeCombo);
            Controls.Add(RealtyCombo);
            Controls.Add(TownCombo);
            Controls.Add(Purpose);
            Controls.Add(TypeOfRealty);
            Controls.Add(Town);
            Controls.Add(label1);
            Controls.Add(Picture7);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TestFirstWindow";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Picture7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Town;
        private System.Windows.Forms.Label TypeOfRealty;
        private System.Windows.Forms.Label Purpose;
        private System.Windows.Forms.ComboBox TownCombo;
        private System.Windows.Forms.ComboBox RealtyCombo;
        private System.Windows.Forms.ComboBox PurposeCombo;
        private System.Windows.Forms.Button NextButtonButton;
    }
}