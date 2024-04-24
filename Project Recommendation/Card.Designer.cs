namespace design
{
    partial class Card
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
            Children = new Label();
            Animals = new Label();
            Address = new Label();
            label1 = new Label();
            AddressText = new Label();
            SquareText = new Label();
            PriceText = new Label();
            FloorText = new Label();
            SuspendLayout();
            // 
            // Children
            // 
            Children.BackColor = Color.Transparent;
            Children.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Children.ForeColor = Color.DimGray;
            Children.Location = new Point(12, 70);
            Children.Name = "Children";
            Children.Size = new Size(165, 56);
            Children.TabIndex = 9;
            Children.Text = "Площадь:";
            // 
            // Animals
            // 
            Animals.BackColor = Color.Transparent;
            Animals.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Animals.ForeColor = Color.DimGray;
            Animals.Location = new Point(12, 126);
            Animals.Name = "Animals";
            Animals.Size = new Size(125, 54);
            Animals.TabIndex = 10;
            Animals.Text = "Цена:";
            // 
            // Address
            // 
            Address.BackColor = Color.Transparent;
            Address.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Address.ForeColor = Color.DimGray;
            Address.Location = new Point(12, 11);
            Address.Name = "Address";
            Address.Size = new Size(125, 59);
            Address.TabIndex = 11;
            Address.Text = "Адрес:";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(12, 180);
            label1.Name = "label1";
            label1.Size = new Size(125, 54);
            label1.TabIndex = 12;
            label1.Text = "Этаж:";
            // 
            // AddressText
            // 
            AddressText.BackColor = Color.Transparent;
            AddressText.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressText.ForeColor = Color.DimGray;
            AddressText.Location = new Point(143, 11);
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(369, 59);
            AddressText.TabIndex = 13;
            // 
            // SquareText
            // 
            SquareText.BackColor = Color.Transparent;
            SquareText.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SquareText.ForeColor = Color.DimGray;
            SquareText.Location = new Point(183, 70);
            SquareText.Name = "SquareText";
            SquareText.Size = new Size(329, 59);
            SquareText.TabIndex = 14;
            // 
            // PriceText
            // 
            PriceText.BackColor = Color.Transparent;
            PriceText.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PriceText.ForeColor = Color.DimGray;
            PriceText.Location = new Point(124, 126);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(388, 59);
            PriceText.TabIndex = 15;
            // 
            // FloorText
            // 
            FloorText.BackColor = Color.Transparent;
            FloorText.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FloorText.ForeColor = Color.DimGray;
            FloorText.Location = new Point(113, 180);
            FloorText.Name = "FloorText";
            FloorText.Size = new Size(399, 59);
            FloorText.TabIndex = 16;
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(524, 249);
            Controls.Add(FloorText);
            Controls.Add(PriceText);
            Controls.Add(SquareText);
            Controls.Add(AddressText);
            Controls.Add(label1);
            Controls.Add(Address);
            Controls.Add(Animals);
            Controls.Add(Children);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Card";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label Children;
        private System.Windows.Forms.Label Animals;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AddressText;
        private System.Windows.Forms.Label SquareText;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.Label FloorText;
    }
}