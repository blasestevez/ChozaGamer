namespace ChozaGamer.Presentation
{
    partial class SelectableProductCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            ProductCardImage = new PictureBox();
            ProductCardProdName = new Label();
            ProductCardProdPrice = new Label();
            ProductCardButton = new CuoreUI.Controls.cuiButton();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ProductCardImage).BeginInit();
            SuspendLayout();
            // 
            // ProductCardImage
            // 
            ProductCardImage.BackgroundImageLayout = ImageLayout.Center;
            ProductCardImage.Location = new Point(72, 25);
            ProductCardImage.Name = "ProductCardImage";
            ProductCardImage.Size = new Size(150, 150);
            ProductCardImage.TabIndex = 1;
            ProductCardImage.TabStop = false;
            // 
            // ProductCardProdName
            // 
            ProductCardProdName.AutoSize = true;
            ProductCardProdName.Font = new Font("Segoe UI", 15F);
            ProductCardProdName.Location = new Point(246, 25);
            ProductCardProdName.Name = "ProductCardProdName";
            ProductCardProdName.Size = new Size(384, 28);
            ProductCardProdName.TabIndex = 3;
            ProductCardProdName.Text = "pruebapruebapruebapruebapruebaprueba";
            // 
            // ProductCardProdPrice
            // 
            ProductCardProdPrice.AutoSize = true;
            ProductCardProdPrice.Font = new Font("Segoe UI", 15F);
            ProductCardProdPrice.Location = new Point(246, 147);
            ProductCardProdPrice.Name = "ProductCardProdPrice";
            ProductCardProdPrice.Size = new Size(147, 28);
            ProductCardProdPrice.TabIndex = 4;
            ProductCardProdPrice.Text = "$pruebaprueba";
            // 
            // ProductCardButton
            // 
            ProductCardButton.CheckButton = false;
            ProductCardButton.Checked = false;
            ProductCardButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            ProductCardButton.CheckedImageTint = Color.White;
            ProductCardButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            ProductCardButton.Content = "Ver Producto";
            ProductCardButton.Cursor = Cursors.Hand;
            ProductCardButton.DialogResult = DialogResult.None;
            ProductCardButton.Font = new Font("Microsoft Sans Serif", 11F);
            ProductCardButton.ForeColor = Color.White;
            ProductCardButton.HoverBackground = Color.FromArgb(240, 50, 10);
            ProductCardButton.HoveredImageTint = Color.White;
            ProductCardButton.HoverOutline = Color.Empty;
            ProductCardButton.Image = Properties.Resources.CartIcon;
            ProductCardButton.ImageAutoCenter = true;
            ProductCardButton.ImageExpand = new Point(5, 5);
            ProductCardButton.ImageOffset = new Point(-5, 0);
            ProductCardButton.ImageTint = Color.White;
            ProductCardButton.Location = new Point(572, 147);
            ProductCardButton.Name = "ProductCardButton";
            ProductCardButton.NormalBackground = Color.FromArgb(240, 50, 10);
            ProductCardButton.NormalOutline = Color.Empty;
            ProductCardButton.OutlineThickness = 1.6F;
            ProductCardButton.PressedBackground = Color.FromArgb(240, 50, 10);
            ProductCardButton.PressedImageTint = Color.White;
            ProductCardButton.PressedOutline = Color.Empty;
            ProductCardButton.Rounding = new Padding(8);
            ProductCardButton.Size = new Size(145, 37);
            ProductCardButton.TabIndex = 5;
            ProductCardButton.TextOffset = new Point(0, 0);
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 93);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 6;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SelectableProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(checkBox1);
            Controls.Add(ProductCardButton);
            Controls.Add(ProductCardProdPrice);
            Controls.Add(ProductCardProdName);
            Controls.Add(ProductCardImage);
            Name = "SelectableProductCard";
            Size = new Size(800, 200);
            ((System.ComponentModel.ISupportInitialize)ProductCardImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProductCardImage;
        private Label ProductCardProdName;
        private Label ProductCardProdPrice;
        private CuoreUI.Controls.cuiButton ProductCardButton;
        private CheckBox checkBox1;
    }
}
