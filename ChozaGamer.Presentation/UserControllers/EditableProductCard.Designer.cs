namespace ChozaGamer.Presentation
{
    partial class EditableProductCard
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
            EditProductButton = new CuoreUI.Controls.cuiButton();
            cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            DeleteButton = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)ProductCardImage).BeginInit();
            cuiBorder1.SuspendLayout();
            SuspendLayout();
            // 
            // ProductCardImage
            // 
            ProductCardImage.BackColor = Color.White;
            ProductCardImage.BackgroundImageLayout = ImageLayout.Center;
            ProductCardImage.Location = new Point(72, 25);
            ProductCardImage.Name = "ProductCardImage";
            ProductCardImage.Size = new Size(150, 150);
            ProductCardImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductCardImage.TabIndex = 1;
            ProductCardImage.TabStop = false;
            // 
            // ProductCardProdName
            // 
            ProductCardProdName.AutoSize = true;
            ProductCardProdName.BackColor = Color.White;
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
            ProductCardProdPrice.BackColor = Color.White;
            ProductCardProdPrice.Font = new Font("Segoe UI", 15F);
            ProductCardProdPrice.Location = new Point(246, 147);
            ProductCardProdPrice.Name = "ProductCardProdPrice";
            ProductCardProdPrice.Size = new Size(147, 28);
            ProductCardProdPrice.TabIndex = 4;
            ProductCardProdPrice.Text = "$pruebaprueba";
            // 
            // EditProductButton
            // 
            EditProductButton.BackColor = Color.White;
            EditProductButton.CheckButton = false;
            EditProductButton.Checked = false;
            EditProductButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            EditProductButton.CheckedImageTint = Color.White;
            EditProductButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            EditProductButton.Content = "";
            EditProductButton.Cursor = Cursors.Hand;
            EditProductButton.DialogResult = DialogResult.None;
            EditProductButton.Font = new Font("Microsoft Sans Serif", 11F);
            EditProductButton.ForeColor = Color.White;
            EditProductButton.HoverBackground = Color.FromArgb(240, 50, 10);
            EditProductButton.HoveredImageTint = Color.White;
            EditProductButton.HoverOutline = Color.Empty;
            EditProductButton.Image = Properties.Resources.EditIcon;
            EditProductButton.ImageAutoCenter = true;
            EditProductButton.ImageExpand = new Point(5, 5);
            EditProductButton.ImageOffset = new Point(0, 0);
            EditProductButton.ImageTint = Color.White;
            EditProductButton.Location = new Point(14, 78);
            EditProductButton.Name = "EditProductButton";
            EditProductButton.NormalBackground = Color.FromArgb(240, 50, 10);
            EditProductButton.NormalOutline = Color.Empty;
            EditProductButton.OutlineThickness = 1.6F;
            EditProductButton.PressedBackground = Color.FromArgb(240, 50, 10);
            EditProductButton.PressedImageTint = Color.White;
            EditProductButton.PressedOutline = Color.Empty;
            EditProductButton.Rounding = new Padding(8);
            EditProductButton.Size = new Size(39, 37);
            EditProductButton.TabIndex = 6;
            EditProductButton.TextOffset = new Point(0, 0);
            EditProductButton.Click += EditProductButton_Click;
            // 
            // cuiBorder1
            // 
            cuiBorder1.BackColor = Color.Transparent;
            cuiBorder1.Controls.Add(DeleteButton);
            cuiBorder1.ForeColor = Color.White;
            cuiBorder1.Location = new Point(3, 3);
            cuiBorder1.Name = "cuiBorder1";
            cuiBorder1.OutlineThickness = 1F;
            cuiBorder1.PanelColor = Color.White;
            cuiBorder1.PanelOutlineColor = Color.White;
            cuiBorder1.Rounding = new Padding(8);
            cuiBorder1.Size = new Size(794, 194);
            cuiBorder1.TabIndex = 7;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.White;
            DeleteButton.CheckButton = false;
            DeleteButton.Checked = false;
            DeleteButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            DeleteButton.CheckedImageTint = Color.White;
            DeleteButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            DeleteButton.Content = "";
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.DialogResult = DialogResult.None;
            DeleteButton.Font = new Font("Microsoft Sans Serif", 11F);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.HoverBackground = Color.FromArgb(240, 50, 10);
            DeleteButton.HoveredImageTint = Color.White;
            DeleteButton.HoverOutline = Color.Empty;
            DeleteButton.Image = Properties.Resources.DeleteIcon;
            DeleteButton.ImageAutoCenter = true;
            DeleteButton.ImageExpand = new Point(5, 5);
            DeleteButton.ImageOffset = new Point(0, 0);
            DeleteButton.ImageTint = Color.White;
            DeleteButton.Location = new Point(737, 13);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.NormalBackground = Color.FromArgb(240, 50, 10);
            DeleteButton.NormalOutline = Color.Empty;
            DeleteButton.OutlineThickness = 1.6F;
            DeleteButton.PressedBackground = Color.FromArgb(240, 50, 10);
            DeleteButton.PressedImageTint = Color.White;
            DeleteButton.PressedOutline = Color.Empty;
            DeleteButton.Rounding = new Padding(8);
            DeleteButton.Size = new Size(39, 37);
            DeleteButton.TabIndex = 8;
            DeleteButton.TextOffset = new Point(0, 0);
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditableProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(EditProductButton);
            Controls.Add(ProductCardProdPrice);
            Controls.Add(ProductCardProdName);
            Controls.Add(ProductCardImage);
            Controls.Add(cuiBorder1);
            Name = "EditableProductCard";
            Size = new Size(800, 200);
            ((System.ComponentModel.ISupportInitialize)ProductCardImage).EndInit();
            cuiBorder1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProductCardImage;
        private Label ProductCardProdName;
        private Label ProductCardProdPrice;
        private CuoreUI.Controls.cuiButton EditProductButton;
        private CuoreUI.Controls.cuiBorder cuiBorder1;
        private CuoreUI.Controls.cuiButton DeleteButton;
    }
}
