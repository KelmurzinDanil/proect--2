namespace design
{
    partial class AddList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddList));
            this.Picture4 = new System.Windows.Forms.PictureBox();
            this.Text1 = new System.Windows.Forms.Label();
            this.AddFavButton = new System.Windows.Forms.RadioButton();
            this.ChooseButton = new System.Windows.Forms.RadioButton();
            this.CollectionsCombo = new System.Windows.Forms.ComboBox();
            this.CreateCollectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture4)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture4
            // 
            this.Picture4.Image = ((System.Drawing.Image)(resources.GetObject("Picture4.Image")));
            this.Picture4.Location = new System.Drawing.Point(-1, -2);
            this.Picture4.Name = "Picture4";
            this.Picture4.Size = new System.Drawing.Size(709, 381);
            this.Picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture4.TabIndex = 0;
            this.Picture4.TabStop = false;
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Text1.Location = new System.Drawing.Point(65, 39);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(453, 47);
            this.Text1.TabIndex = 7;
            this.Text1.Text = "Добавить в \r\n";
            // 
            // AddFavButton
            // 
            this.AddFavButton.AutoSize = true;
            this.AddFavButton.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFavButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddFavButton.Location = new System.Drawing.Point(136, 111);
            this.AddFavButton.Name = "AddFavButton";
            this.AddFavButton.Size = new System.Drawing.Size(212, 41);
            this.AddFavButton.TabIndex = 8;
            this.AddFavButton.TabStop = true;
            this.AddFavButton.Text = "\"Избранное\"";
            this.AddFavButton.UseVisualStyleBackColor = true;
            // 
            // ChooseButton
            // 
            this.ChooseButton.AutoSize = true;
            this.ChooseButton.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChooseButton.Location = new System.Drawing.Point(136, 183);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(154, 41);
            this.ChooseButton.TabIndex = 9;
            this.ChooseButton.TabStop = true;
            this.ChooseButton.Text = "Выбрать";
            this.ChooseButton.UseVisualStyleBackColor = true;
            // 
            // CollectionsCombo
            // 
            this.CollectionsCombo.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CollectionsCombo.ForeColor = System.Drawing.Color.DimGray;
            this.CollectionsCombo.FormattingEnabled = true;
            this.CollectionsCombo.Location = new System.Drawing.Point(349, 182);
            this.CollectionsCombo.Name = "CollectionsCombo";
            this.CollectionsCombo.Size = new System.Drawing.Size(169, 45);
            this.CollectionsCombo.TabIndex = 10;
            // 
            // CreateCollectionButton
            // 
            this.CreateCollectionButton.BackColor = System.Drawing.Color.FloralWhite;
            this.CreateCollectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCollectionButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCollectionButton.ForeColor = System.Drawing.Color.DimGray;
            this.CreateCollectionButton.Location = new System.Drawing.Point(427, 283);
            this.CreateCollectionButton.Name = "CreateCollectionButton";
            this.CreateCollectionButton.Size = new System.Drawing.Size(217, 44);
            this.CreateCollectionButton.TabIndex = 15;
            this.CreateCollectionButton.Text = "СОЗДАТЬ\r\n\r\n";
            this.CreateCollectionButton.UseVisualStyleBackColor = false;
            this.CreateCollectionButton.Click += new System.EventHandler(this.CreateCollectionButton_Click);
            // 
            // AddList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(707, 379);
            this.Controls.Add(this.CreateCollectionButton);
            this.Controls.Add(this.CollectionsCombo);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.AddFavButton);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Picture4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Picture4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture4;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.RadioButton AddFavButton;
        private System.Windows.Forms.RadioButton ChooseButton;
        private System.Windows.Forms.ComboBox CollectionsCombo;
        private System.Windows.Forms.Button CreateCollectionButton;
    }
}