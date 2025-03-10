﻿namespace ChozaGamer.Presentation
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProductCardImage = new PictureBox();
            ProductCardProdName = new Label();
            ProductCardProdPrice = new Label();
            ProductCardButton = new CuoreUI.Controls.cuiButton();
            cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            ((System.ComponentModel.ISupportInitialize)ProductCardImage).BeginInit();
            SuspendLayout();
            // 
            // ProductCardImage
            // 
            ProductCardImage.BackColor = Color.White;
            ProductCardImage.BackgroundImageLayout = ImageLayout.Center;
            ProductCardImage.Location = new Point(25, 25);
            ProductCardImage.Name = "ProductCardImage";
            ProductCardImage.Size = new Size(150, 150);
            ProductCardImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ProductCardImage.TabIndex = 0;
            ProductCardImage.TabStop = false;
            ProductCardImage.Click += ProductCardImage_Click;
            // 
            // ProductCardProdName
            // 
            ProductCardProdName.AutoSize = true;
            ProductCardProdName.BackColor = Color.White;
            ProductCardProdName.Font = new Font("Segoe UI", 15F);
            ProductCardProdName.Location = new Point(199, 25);
            ProductCardProdName.Name = "ProductCardProdName";
            ProductCardProdName.Size = new Size(384, 28);
            ProductCardProdName.TabIndex = 2;
            ProductCardProdName.Text = "pruebapruebapruebapruebapruebaprueba";
            // 
            // ProductCardProdPrice
            // 
            ProductCardProdPrice.AutoSize = true;
            ProductCardProdPrice.BackColor = Color.White;
            ProductCardProdPrice.Font = new Font("Segoe UI", 15F);
            ProductCardProdPrice.Location = new Point(199, 147);
            ProductCardProdPrice.Name = "ProductCardProdPrice";
            ProductCardProdPrice.Size = new Size(147, 28);
            ProductCardProdPrice.TabIndex = 3;
            ProductCardProdPrice.Text = "$pruebaprueba";
            // 
            // ProductCardButton
            // 
            ProductCardButton.BackColor = Color.White;
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
            ProductCardButton.Location = new Point(588, 147);
            ProductCardButton.Name = "ProductCardButton";
            ProductCardButton.NormalBackground = Color.FromArgb(240, 50, 10);
            ProductCardButton.NormalOutline = Color.Empty;
            ProductCardButton.OutlineThickness = 1.6F;
            ProductCardButton.PressedBackground = Color.FromArgb(240, 50, 10);
            ProductCardButton.PressedImageTint = Color.White;
            ProductCardButton.PressedOutline = Color.Empty;
            ProductCardButton.Rounding = new Padding(8);
            ProductCardButton.Size = new Size(145, 37);
            ProductCardButton.TabIndex = 4;
            ProductCardButton.TextOffset = new Point(0, 0);
            ProductCardButton.Click += ProductCardButton_Click;
            // 
            // cuiBorder1
            // 
            cuiBorder1.BackColor = Color.Transparent;
            cuiBorder1.ForeColor = Color.White;
            cuiBorder1.Location = new Point(3, 3);
            cuiBorder1.Name = "cuiBorder1";
            cuiBorder1.OutlineThickness = 1F;
            cuiBorder1.PanelColor = Color.White;
            cuiBorder1.PanelOutlineColor = Color.White;
            cuiBorder1.Rounding = new Padding(8);
            cuiBorder1.Size = new Size(794, 194);
            cuiBorder1.TabIndex = 8;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ProductCardButton);
            Controls.Add(ProductCardProdPrice);
            Controls.Add(ProductCardProdName);
            Controls.Add(ProductCardImage);
            Controls.Add(cuiBorder1);
            Name = "ProductCard";
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
        private CuoreUI.Controls.cuiBorder cuiBorder1;
    }
}
