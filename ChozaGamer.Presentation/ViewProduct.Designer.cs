namespace ChozaGamer.Presentation
{
    partial class ViewProduct
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
            panel1 = new Panel();
            Logo = new CuoreUI.Controls.cuiPictureBox();
            MinimizeButton = new CuoreUI.Controls.cuiButton();
            CloseButton = new CuoreUI.Controls.cuiButton();
            ProductImage = new CuoreUI.Controls.cuiPictureBox();
            ProductName = new CuoreUI.Controls.cuiLabel();
            BrandLabel = new CuoreUI.Controls.cuiLabel();
            ProductBrand = new CuoreUI.Controls.cuiLabel();
            CategoryLabel = new CuoreUI.Controls.cuiLabel();
            SubCategoryLabel = new CuoreUI.Controls.cuiLabel();
            ProductCategory = new CuoreUI.Controls.cuiLabel();
            ProductSubCategory = new CuoreUI.Controls.cuiLabel();
            StockLabel = new CuoreUI.Controls.cuiLabel();
            ProductStock = new CuoreUI.Controls.cuiLabel();
            ProductDescription = new CuoreUI.Controls.cuiLabel();
            WarrantyLabel = new CuoreUI.Controls.cuiLabel();
            ProductWarranty = new CuoreUI.Controls.cuiLabel();
            PriceLabel = new CuoreUI.Controls.cuiLabel();
            ProductPrice = new CuoreUI.Controls.cuiLabel();
            BuyButton = new CuoreUI.Controls.cuiButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(MinimizeButton);
            panel1.Controls.Add(CloseButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 90);
            panel1.TabIndex = 1;
            // 
            // Logo
            // 
            Logo.Content = Properties.Resources.logo;
            Logo.CornerRadius = 8;
            Logo.ImageTint = Color.White;
            Logo.Location = new Point(77, 4);
            Logo.Margin = new Padding(4, 3, 4, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(270, 75);
            Logo.TabIndex = 5;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackgroundImageLayout = ImageLayout.None;
            MinimizeButton.CheckButton = false;
            MinimizeButton.Checked = false;
            MinimizeButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            MinimizeButton.CheckedImageTint = Color.White;
            MinimizeButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            MinimizeButton.Content = "";
            MinimizeButton.Cursor = Cursors.Hand;
            MinimizeButton.DialogResult = DialogResult.None;
            MinimizeButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            MinimizeButton.ForeColor = Color.White;
            MinimizeButton.HoverBackground = Color.FromArgb(240, 220, 90);
            MinimizeButton.HoveredImageTint = Color.FromArgb(33, 33, 33);
            MinimizeButton.HoverOutline = Color.Empty;
            MinimizeButton.Image = Properties.Resources.MinimizeIcon;
            MinimizeButton.ImageAutoCenter = true;
            MinimizeButton.ImageExpand = new Point(7, 7);
            MinimizeButton.ImageOffset = new Point(0, 0);
            MinimizeButton.ImageTint = Color.White;
            MinimizeButton.Location = new Point(1169, 20);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.NormalBackground = Color.FromArgb(33, 33, 33);
            MinimizeButton.NormalOutline = Color.Empty;
            MinimizeButton.OutlineThickness = 1.6F;
            MinimizeButton.PressedBackground = Color.FromArgb(72, 72, 72);
            MinimizeButton.PressedImageTint = Color.White;
            MinimizeButton.PressedOutline = Color.Empty;
            MinimizeButton.Rounding = new Padding(8);
            MinimizeButton.Size = new Size(45, 45);
            MinimizeButton.TabIndex = 4;
            MinimizeButton.TextOffset = new Point(0, 0);
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImageLayout = ImageLayout.None;
            CloseButton.CheckButton = false;
            CloseButton.Checked = false;
            CloseButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            CloseButton.CheckedImageTint = Color.White;
            CloseButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            CloseButton.Content = "";
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.DialogResult = DialogResult.None;
            CloseButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            CloseButton.ForeColor = Color.White;
            CloseButton.HoverBackground = Color.FromArgb(240, 50, 10);
            CloseButton.HoveredImageTint = Color.FromArgb(33, 33, 33);
            CloseButton.HoverOutline = Color.Empty;
            CloseButton.Image = Properties.Resources.CloseIcon;
            CloseButton.ImageAutoCenter = true;
            CloseButton.ImageExpand = new Point(7, 7);
            CloseButton.ImageOffset = new Point(0, 0);
            CloseButton.ImageTint = Color.White;
            CloseButton.Location = new Point(1220, 20);
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBackground = Color.FromArgb(33, 33, 33);
            CloseButton.NormalOutline = Color.Empty;
            CloseButton.OutlineThickness = 1.6F;
            CloseButton.PressedBackground = Color.FromArgb(72, 72, 72);
            CloseButton.PressedImageTint = Color.White;
            CloseButton.PressedOutline = Color.Empty;
            CloseButton.Rounding = new Padding(8);
            CloseButton.Size = new Size(45, 45);
            CloseButton.TabIndex = 3;
            CloseButton.TextOffset = new Point(0, 0);
            CloseButton.Click += CloseButton_Click;
            // 
            // ProductImage
            // 
            ProductImage.BackgroundImageLayout = ImageLayout.Stretch;
            ProductImage.Content = null;
            ProductImage.CornerRadius = 8;
            ProductImage.ImageTint = Color.White;
            ProductImage.Location = new Point(54, 168);
            ProductImage.Margin = new Padding(4, 3, 4, 3);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(388, 378);
            ProductImage.TabIndex = 2;
            // 
            // ProductName
            // 
            ProductName.Content = "aaa";
            ProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductName.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            ProductName.Location = new Point(472, 168);
            ProductName.Margin = new Padding(4, 3, 4, 3);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(793, 33);
            ProductName.TabIndex = 3;
            // 
            // BrandLabel
            // 
            BrandLabel.Content = "Brand:";
            BrandLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrandLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            BrandLabel.Location = new Point(474, 318);
            BrandLabel.Margin = new Padding(4, 3, 4, 3);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(85, 33);
            BrandLabel.TabIndex = 4;
            // 
            // ProductBrand
            // 
            ProductBrand.Content = "";
            ProductBrand.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductBrand.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            ProductBrand.Location = new Point(552, 318);
            ProductBrand.Margin = new Padding(4, 3, 4, 3);
            ProductBrand.Name = "ProductBrand";
            ProductBrand.Size = new Size(715, 33);
            ProductBrand.TabIndex = 5;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Content = "Category:";
            CategoryLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            CategoryLabel.Location = new Point(474, 357);
            CategoryLabel.Margin = new Padding(4, 3, 4, 3);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(116, 33);
            CategoryLabel.TabIndex = 6;
            // 
            // SubCategoryLabel
            // 
            SubCategoryLabel.Content = "Subcategory:";
            SubCategoryLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubCategoryLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            SubCategoryLabel.Location = new Point(474, 396);
            SubCategoryLabel.Margin = new Padding(4, 3, 4, 3);
            SubCategoryLabel.Name = "SubCategoryLabel";
            SubCategoryLabel.Size = new Size(146, 33);
            SubCategoryLabel.TabIndex = 7;
            // 
            // ProductCategory
            // 
            ProductCategory.Content = "";
            ProductCategory.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductCategory.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            ProductCategory.Location = new Point(582, 357);
            ProductCategory.Margin = new Padding(4, 3, 4, 3);
            ProductCategory.Name = "ProductCategory";
            ProductCategory.Size = new Size(685, 33);
            ProductCategory.TabIndex = 8;
            // 
            // ProductSubCategory
            // 
            ProductSubCategory.Content = "";
            ProductSubCategory.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductSubCategory.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            ProductSubCategory.Location = new Point(628, 396);
            ProductSubCategory.Margin = new Padding(4, 3, 4, 3);
            ProductSubCategory.Name = "ProductSubCategory";
            ProductSubCategory.Size = new Size(648, 33);
            ProductSubCategory.TabIndex = 9;
            // 
            // StockLabel
            // 
            StockLabel.Content = "Stock:";
            StockLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StockLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            StockLabel.Location = new Point(474, 435);
            StockLabel.Margin = new Padding(4, 3, 4, 3);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(85, 33);
            StockLabel.TabIndex = 10;
            // 
            // ProductStock
            // 
            ProductStock.Content = "";
            ProductStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductStock.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            ProductStock.Location = new Point(552, 435);
            ProductStock.Margin = new Padding(4, 3, 4, 3);
            ProductStock.Name = "ProductStock";
            ProductStock.Size = new Size(715, 33);
            ProductStock.TabIndex = 11;
            // 
            // ProductDescription
            // 
            ProductDescription.Content = "aaa";
            ProductDescription.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductDescription.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            ProductDescription.Location = new Point(472, 207);
            ProductDescription.Margin = new Padding(4, 3, 4, 3);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(793, 105);
            ProductDescription.TabIndex = 12;
            // 
            // WarrantyLabel
            // 
            WarrantyLabel.Content = "Warranty:";
            WarrantyLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WarrantyLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            WarrantyLabel.Location = new Point(474, 474);
            WarrantyLabel.Margin = new Padding(4, 3, 4, 3);
            WarrantyLabel.Name = "WarrantyLabel";
            WarrantyLabel.Size = new Size(116, 33);
            WarrantyLabel.TabIndex = 13;
            // 
            // ProductWarranty
            // 
            ProductWarranty.Content = "";
            ProductWarranty.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductWarranty.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            ProductWarranty.Location = new Point(598, 474);
            ProductWarranty.Margin = new Padding(4, 3, 4, 3);
            ProductWarranty.Name = "ProductWarranty";
            ProductWarranty.Size = new Size(667, 33);
            ProductWarranty.TabIndex = 14;
            // 
            // PriceLabel
            // 
            PriceLabel.Content = "Price:";
            PriceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            PriceLabel.Location = new Point(474, 513);
            PriceLabel.Margin = new Padding(4, 3, 4, 3);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(85, 33);
            PriceLabel.TabIndex = 15;
            // 
            // ProductPrice
            // 
            ProductPrice.Content = "";
            ProductPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductPrice.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            ProductPrice.Location = new Point(567, 513);
            ProductPrice.Margin = new Padding(4, 3, 4, 3);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(698, 33);
            ProductPrice.TabIndex = 16;
            // 
            // BuyButton
            // 
            BuyButton.CheckButton = false;
            BuyButton.Checked = false;
            BuyButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            BuyButton.CheckedImageTint = Color.White;
            BuyButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            BuyButton.Content = "Buy";
            BuyButton.DialogResult = DialogResult.None;
            BuyButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            BuyButton.ForeColor = Color.White;
            BuyButton.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            BuyButton.HoveredImageTint = Color.White;
            BuyButton.HoverOutline = Color.Empty;
            BuyButton.Image = null;
            BuyButton.ImageAutoCenter = true;
            BuyButton.ImageExpand = new Point(0, 0);
            BuyButton.ImageOffset = new Point(0, 0);
            BuyButton.ImageTint = Color.White;
            BuyButton.Location = new Point(474, 565);
            BuyButton.Name = "BuyButton";
            BuyButton.NormalBackground = Color.FromArgb(255, 106, 0);
            BuyButton.NormalOutline = Color.Empty;
            BuyButton.OutlineThickness = 1.6F;
            BuyButton.PressedBackground = Color.FromArgb(255, 106, 0);
            BuyButton.PressedImageTint = Color.White;
            BuyButton.PressedOutline = Color.Empty;
            BuyButton.Rounding = new Padding(8);
            BuyButton.Size = new Size(153, 45);
            BuyButton.TabIndex = 17;
            BuyButton.TextOffset = new Point(0, 0);
            BuyButton.Click += BuyButton_Click;
            // 
            // ViewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(BuyButton);
            Controls.Add(ProductPrice);
            Controls.Add(PriceLabel);
            Controls.Add(ProductWarranty);
            Controls.Add(WarrantyLabel);
            Controls.Add(ProductDescription);
            Controls.Add(ProductStock);
            Controls.Add(StockLabel);
            Controls.Add(ProductSubCategory);
            Controls.Add(ProductCategory);
            Controls.Add(SubCategoryLabel);
            Controls.Add(CategoryLabel);
            Controls.Add(ProductBrand);
            Controls.Add(BrandLabel);
            Controls.Add(ProductName);
            Controls.Add(ProductImage);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewProduct";
            Text = "ViewProduct";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CuoreUI.Controls.cuiPictureBox Logo;
        private CuoreUI.Controls.cuiButton MinimizeButton;
        private CuoreUI.Controls.cuiButton CloseButton;
        private CuoreUI.Controls.cuiPictureBox ProductImage;
        private CuoreUI.Controls.cuiLabel ProductName;
        private CuoreUI.Controls.cuiLabel BrandLabel;
        private CuoreUI.Controls.cuiLabel ProductBrand;
        private CuoreUI.Controls.cuiLabel CategoryLabel;
        private CuoreUI.Controls.cuiLabel SubCategoryLabel;
        private CuoreUI.Controls.cuiLabel ProductCategory;
        private CuoreUI.Controls.cuiLabel ProductSubCategory;
        private CuoreUI.Controls.cuiLabel StockLabel;
        private CuoreUI.Controls.cuiLabel ProductStock;
        private CuoreUI.Controls.cuiLabel ProductDescription;
        private CuoreUI.Controls.cuiLabel WarrantyLabel;
        private CuoreUI.Controls.cuiLabel ProductWarranty;
        private CuoreUI.Controls.cuiLabel PriceLabel;
        private CuoreUI.Controls.cuiLabel ProductPrice;
        private CuoreUI.Controls.cuiButton BuyButton;
    }
}