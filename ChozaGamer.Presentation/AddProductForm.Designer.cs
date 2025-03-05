namespace ChozaGamer.Presentation
{
    partial class AddProductForm
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
            ChangeProductImageButton = new CuoreUI.Controls.cuiButton();
            pictureBox1 = new PictureBox();
            ConfirmButton = new CuoreUI.Controls.cuiButton();
            ProductSaleCheckBox = new CheckBox();
            ProductIvaBar = new CuoreUI.Controls.cuiTextBox2();
            ProductCodeBar = new CuoreUI.Controls.cuiTextBox2();
            ProductStockBar = new CuoreUI.Controls.cuiTextBox2();
            ProductSpecialPriceBar = new CuoreUI.Controls.cuiTextBox2();
            ProductDefaultPriceBar = new CuoreUI.Controls.cuiTextBox2();
            ProductDescriptionBar = new CuoreUI.Controls.cuiTextBox2();
            NameBar = new CuoreUI.Controls.cuiTextBox2();
            BrandsComboBox = new ComboBox();
            CategoriesComboBox = new ComboBox();
            SubCategoriesComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ChangeProductImageButton
            // 
            ChangeProductImageButton.BackgroundImageLayout = ImageLayout.None;
            ChangeProductImageButton.CheckButton = false;
            ChangeProductImageButton.Checked = false;
            ChangeProductImageButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            ChangeProductImageButton.CheckedImageTint = Color.White;
            ChangeProductImageButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            ChangeProductImageButton.Content = "Change Image";
            ChangeProductImageButton.Cursor = Cursors.Hand;
            ChangeProductImageButton.DialogResult = DialogResult.None;
            ChangeProductImageButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            ChangeProductImageButton.ForeColor = Color.White;
            ChangeProductImageButton.HoverBackground = Color.FromArgb(72, 72, 72);
            ChangeProductImageButton.HoveredImageTint = Color.FromArgb(240, 50, 10);
            ChangeProductImageButton.HoverOutline = Color.Empty;
            ChangeProductImageButton.Image = Properties.Resources.ProfileIcon__2_;
            ChangeProductImageButton.ImageAutoCenter = true;
            ChangeProductImageButton.ImageExpand = new Point(7, 7);
            ChangeProductImageButton.ImageOffset = new Point(-5, 0);
            ChangeProductImageButton.ImageTint = Color.White;
            ChangeProductImageButton.Location = new Point(42, 296);
            ChangeProductImageButton.Name = "ChangeProductImageButton";
            ChangeProductImageButton.NormalBackground = Color.FromArgb(33, 33, 33);
            ChangeProductImageButton.NormalOutline = Color.Empty;
            ChangeProductImageButton.OutlineThickness = 1.6F;
            ChangeProductImageButton.PressedBackground = Color.FromArgb(72, 72, 72);
            ChangeProductImageButton.PressedImageTint = Color.White;
            ChangeProductImageButton.PressedOutline = Color.Empty;
            ChangeProductImageButton.Rounding = new Padding(8);
            ChangeProductImageButton.Size = new Size(220, 45);
            ChangeProductImageButton.TabIndex = 24;
            ChangeProductImageButton.TextOffset = new Point(0, 0);
            ChangeProductImageButton.Click += ChangeProductImageButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(27, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackgroundImageLayout = ImageLayout.None;
            ConfirmButton.CheckButton = false;
            ConfirmButton.Checked = false;
            ConfirmButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            ConfirmButton.CheckedImageTint = Color.White;
            ConfirmButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            ConfirmButton.Content = "Confirm Changes";
            ConfirmButton.Cursor = Cursors.Hand;
            ConfirmButton.DialogResult = DialogResult.None;
            ConfirmButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            ConfirmButton.ForeColor = Color.White;
            ConfirmButton.HoverBackground = Color.FromArgb(72, 72, 72);
            ConfirmButton.HoveredImageTint = Color.FromArgb(240, 50, 10);
            ConfirmButton.HoverOutline = Color.Empty;
            ConfirmButton.Image = Properties.Resources.ProfileIcon__2_;
            ConfirmButton.ImageAutoCenter = true;
            ConfirmButton.ImageExpand = new Point(7, 7);
            ConfirmButton.ImageOffset = new Point(-5, 0);
            ConfirmButton.ImageTint = Color.White;
            ConfirmButton.Location = new Point(293, 503);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.NormalBackground = Color.FromArgb(33, 33, 33);
            ConfirmButton.NormalOutline = Color.Empty;
            ConfirmButton.OutlineThickness = 1.6F;
            ConfirmButton.PressedBackground = Color.FromArgb(72, 72, 72);
            ConfirmButton.PressedImageTint = Color.White;
            ConfirmButton.PressedOutline = Color.Empty;
            ConfirmButton.Rounding = new Padding(8);
            ConfirmButton.Size = new Size(220, 45);
            ConfirmButton.TabIndex = 22;
            ConfirmButton.TextOffset = new Point(0, 0);
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // ProductSaleCheckBox
            // 
            ProductSaleCheckBox.AutoSize = true;
            ProductSaleCheckBox.Location = new Point(293, 405);
            ProductSaleCheckBox.Name = "ProductSaleCheckBox";
            ProductSaleCheckBox.Size = new Size(92, 19);
            ProductSaleCheckBox.TabIndex = 21;
            ProductSaleCheckBox.Text = "Product Sale";
            ProductSaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductIvaBar
            // 
            ProductIvaBar.BackColor = Color.FromArgb(33, 33, 33);
            ProductIvaBar.BorderColor = Color.White;
            ProductIvaBar.BorderFocusColor = Color.FromArgb(240, 50, 10);
            ProductIvaBar.BorderSize = 1;
            ProductIvaBar.Content = "";
            ProductIvaBar.Cursor = Cursors.IBeam;
            ProductIvaBar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductIvaBar.ForeColor = Color.Gray;
            ProductIvaBar.Location = new Point(293, 351);
            ProductIvaBar.Margin = new Padding(4);
            ProductIvaBar.Multiline = false;
            ProductIvaBar.Name = "ProductIvaBar";
            ProductIvaBar.Padding = new Padding(15, 16, 15, 0);
            ProductIvaBar.PasswordChar = false;
            ProductIvaBar.PlaceholderColor = Color.DimGray;
            ProductIvaBar.PlaceholderText = "Product IVA%";
            ProductIvaBar.Rounding = 10;
            ProductIvaBar.Size = new Size(220, 47);
            ProductIvaBar.TabIndex = 20;
            ProductIvaBar.TextOffset = new Size(0, 0);
            ProductIvaBar.UnderlinedStyle = false;
            // 
            // ProductCodeBar
            // 
            ProductCodeBar.BackColor = Color.FromArgb(33, 33, 33);
            ProductCodeBar.BorderColor = Color.White;
            ProductCodeBar.BorderFocusColor = Color.FromArgb(240, 50, 10);
            ProductCodeBar.BorderSize = 1;
            ProductCodeBar.Content = "";
            ProductCodeBar.Cursor = Cursors.IBeam;
            ProductCodeBar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductCodeBar.ForeColor = Color.Gray;
            ProductCodeBar.Location = new Point(293, 296);
            ProductCodeBar.Margin = new Padding(4);
            ProductCodeBar.Multiline = false;
            ProductCodeBar.Name = "ProductCodeBar";
            ProductCodeBar.Padding = new Padding(15, 16, 15, 0);
            ProductCodeBar.PasswordChar = false;
            ProductCodeBar.PlaceholderColor = Color.DimGray;
            ProductCodeBar.PlaceholderText = "Product Code";
            ProductCodeBar.Rounding = 10;
            ProductCodeBar.Size = new Size(220, 47);
            ProductCodeBar.TabIndex = 18;
            ProductCodeBar.TextOffset = new Size(0, 0);
            ProductCodeBar.UnderlinedStyle = false;
            // 
            // ProductStockBar
            // 
            ProductStockBar.BackColor = Color.FromArgb(33, 33, 33);
            ProductStockBar.BorderColor = Color.White;
            ProductStockBar.BorderFocusColor = Color.FromArgb(240, 50, 10);
            ProductStockBar.BorderSize = 1;
            ProductStockBar.Content = "";
            ProductStockBar.Cursor = Cursors.IBeam;
            ProductStockBar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductStockBar.ForeColor = Color.Gray;
            ProductStockBar.Location = new Point(293, 241);
            ProductStockBar.Margin = new Padding(4);
            ProductStockBar.Multiline = false;
            ProductStockBar.Name = "ProductStockBar";
            ProductStockBar.Padding = new Padding(15, 16, 15, 0);
            ProductStockBar.PasswordChar = false;
            ProductStockBar.PlaceholderColor = Color.DimGray;
            ProductStockBar.PlaceholderText = "Product Stock";
            ProductStockBar.Rounding = 10;
            ProductStockBar.Size = new Size(220, 47);
            ProductStockBar.TabIndex = 17;
            ProductStockBar.TextOffset = new Size(0, 0);
            ProductStockBar.UnderlinedStyle = false;
            // 
            // ProductSpecialPriceBar
            // 
            ProductSpecialPriceBar.BackColor = Color.FromArgb(33, 33, 33);
            ProductSpecialPriceBar.BorderColor = Color.White;
            ProductSpecialPriceBar.BorderFocusColor = Color.FromArgb(240, 50, 10);
            ProductSpecialPriceBar.BorderSize = 1;
            ProductSpecialPriceBar.Content = "";
            ProductSpecialPriceBar.Cursor = Cursors.IBeam;
            ProductSpecialPriceBar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductSpecialPriceBar.ForeColor = Color.Gray;
            ProductSpecialPriceBar.Location = new Point(293, 186);
            ProductSpecialPriceBar.Margin = new Padding(4);
            ProductSpecialPriceBar.Multiline = false;
            ProductSpecialPriceBar.Name = "ProductSpecialPriceBar";
            ProductSpecialPriceBar.Padding = new Padding(15, 16, 15, 0);
            ProductSpecialPriceBar.PasswordChar = false;
            ProductSpecialPriceBar.PlaceholderColor = Color.DimGray;
            ProductSpecialPriceBar.PlaceholderText = "Special Price";
            ProductSpecialPriceBar.Rounding = 10;
            ProductSpecialPriceBar.Size = new Size(220, 47);
            ProductSpecialPriceBar.TabIndex = 16;
            ProductSpecialPriceBar.TextOffset = new Size(0, 0);
            ProductSpecialPriceBar.UnderlinedStyle = false;
            // 
            // ProductDefaultPriceBar
            // 
            ProductDefaultPriceBar.BackColor = Color.FromArgb(33, 33, 33);
            ProductDefaultPriceBar.BorderColor = Color.White;
            ProductDefaultPriceBar.BorderFocusColor = Color.FromArgb(240, 50, 10);
            ProductDefaultPriceBar.BorderSize = 1;
            ProductDefaultPriceBar.Content = "";
            ProductDefaultPriceBar.Cursor = Cursors.IBeam;
            ProductDefaultPriceBar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductDefaultPriceBar.ForeColor = Color.Gray;
            ProductDefaultPriceBar.Location = new Point(293, 131);
            ProductDefaultPriceBar.Margin = new Padding(4);
            ProductDefaultPriceBar.Multiline = false;
            ProductDefaultPriceBar.Name = "ProductDefaultPriceBar";
            ProductDefaultPriceBar.Padding = new Padding(15, 16, 15, 0);
            ProductDefaultPriceBar.PasswordChar = false;
            ProductDefaultPriceBar.PlaceholderColor = Color.DimGray;
            ProductDefaultPriceBar.PlaceholderText = "Price";
            ProductDefaultPriceBar.Rounding = 10;
            ProductDefaultPriceBar.Size = new Size(220, 47);
            ProductDefaultPriceBar.TabIndex = 15;
            ProductDefaultPriceBar.TextOffset = new Size(0, 0);
            ProductDefaultPriceBar.UnderlinedStyle = false;
            // 
            // ProductDescriptionBar
            // 
            ProductDescriptionBar.BackColor = Color.FromArgb(33, 33, 33);
            ProductDescriptionBar.BorderColor = Color.White;
            ProductDescriptionBar.BorderFocusColor = Color.FromArgb(240, 50, 10);
            ProductDescriptionBar.BorderSize = 1;
            ProductDescriptionBar.Content = "";
            ProductDescriptionBar.Cursor = Cursors.IBeam;
            ProductDescriptionBar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductDescriptionBar.ForeColor = Color.Gray;
            ProductDescriptionBar.Location = new Point(293, 76);
            ProductDescriptionBar.Margin = new Padding(4);
            ProductDescriptionBar.Multiline = false;
            ProductDescriptionBar.Name = "ProductDescriptionBar";
            ProductDescriptionBar.Padding = new Padding(15, 16, 15, 0);
            ProductDescriptionBar.PasswordChar = false;
            ProductDescriptionBar.PlaceholderColor = Color.DimGray;
            ProductDescriptionBar.PlaceholderText = "Product Description";
            ProductDescriptionBar.Rounding = 10;
            ProductDescriptionBar.Size = new Size(220, 47);
            ProductDescriptionBar.TabIndex = 14;
            ProductDescriptionBar.TextOffset = new Size(0, 0);
            ProductDescriptionBar.UnderlinedStyle = false;
            // 
            // NameBar
            // 
            NameBar.BackColor = Color.FromArgb(33, 33, 33);
            NameBar.BorderColor = Color.White;
            NameBar.BorderFocusColor = Color.FromArgb(240, 50, 10);
            NameBar.BorderSize = 1;
            NameBar.Content = "";
            NameBar.Cursor = Cursors.IBeam;
            NameBar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameBar.ForeColor = Color.Gray;
            NameBar.Location = new Point(293, 21);
            NameBar.Margin = new Padding(4);
            NameBar.Multiline = false;
            NameBar.Name = "NameBar";
            NameBar.Padding = new Padding(15, 16, 15, 0);
            NameBar.PasswordChar = false;
            NameBar.PlaceholderColor = Color.DimGray;
            NameBar.PlaceholderText = "Name";
            NameBar.Rounding = 10;
            NameBar.Size = new Size(220, 47);
            NameBar.TabIndex = 13;
            NameBar.TextOffset = new Size(0, 0);
            NameBar.UnderlinedStyle = false;
            // 
            // BrandsComboBox
            // 
            BrandsComboBox.FormattingEnabled = true;
            BrandsComboBox.Location = new Point(566, 32);
            BrandsComboBox.Name = "BrandsComboBox";
            BrandsComboBox.Size = new Size(121, 23);
            BrandsComboBox.TabIndex = 25;
            // 
            // CategoriesComboBox
            // 
            CategoriesComboBox.FormattingEnabled = true;
            CategoriesComboBox.Location = new Point(566, 85);
            CategoriesComboBox.Name = "CategoriesComboBox";
            CategoriesComboBox.Size = new Size(121, 23);
            CategoriesComboBox.TabIndex = 26;
            CategoriesComboBox.SelectedIndexChanged += CategoriesComboBox_SelectedIndexChanged;
            // 
            // SubCategoriesComboBox
            // 
            SubCategoriesComboBox.FormattingEnabled = true;
            SubCategoriesComboBox.Location = new Point(566, 141);
            SubCategoriesComboBox.Name = "SubCategoriesComboBox";
            SubCategoriesComboBox.Size = new Size(121, 23);
            SubCategoriesComboBox.TabIndex = 27;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(SubCategoriesComboBox);
            Controls.Add(CategoriesComboBox);
            Controls.Add(BrandsComboBox);
            Controls.Add(ChangeProductImageButton);
            Controls.Add(pictureBox1);
            Controls.Add(ConfirmButton);
            Controls.Add(ProductSaleCheckBox);
            Controls.Add(ProductIvaBar);
            Controls.Add(ProductCodeBar);
            Controls.Add(ProductStockBar);
            Controls.Add(ProductSpecialPriceBar);
            Controls.Add(ProductDefaultPriceBar);
            Controls.Add(ProductDescriptionBar);
            Controls.Add(NameBar);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiButton ChangeProductImageButton;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiButton ConfirmButton;
        private CheckBox ProductSaleCheckBox;
        private CuoreUI.Controls.cuiTextBox2 ProductIvaBar;
        private CuoreUI.Controls.cuiTextBox2 ProductCodeBar;
        private CuoreUI.Controls.cuiTextBox2 ProductStockBar;
        private CuoreUI.Controls.cuiTextBox2 ProductSpecialPriceBar;
        private CuoreUI.Controls.cuiTextBox2 ProductDefaultPriceBar;
        private CuoreUI.Controls.cuiTextBox2 ProductDescriptionBar;
        private CuoreUI.Controls.cuiTextBox2 NameBar;
        private ComboBox BrandsComboBox;
        private ComboBox CategoriesComboBox;
        private ComboBox SubCategoriesComboBox;
    }
}