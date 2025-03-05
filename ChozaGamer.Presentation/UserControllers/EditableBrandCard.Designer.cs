namespace ChozaGamer.Presentation
{
    partial class EditableBrandCard
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
            BrandName = new Label();
            EditBrandButton = new CuoreUI.Controls.cuiButton();
            cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            DeleteButton = new CuoreUI.Controls.cuiButton();
            cuiBorder1.SuspendLayout();
            SuspendLayout();
            // 
            // BrandName
            // 
            BrandName.AutoSize = true;
            BrandName.BackColor = Color.White;
            BrandName.Font = new Font("Segoe UI", 15F);
            BrandName.Location = new Point(208, 36);
            BrandName.Name = "BrandName";
            BrandName.Size = new Size(384, 28);
            BrandName.TabIndex = 4;
            BrandName.Text = "pruebapruebapruebapruebapruebaprueba";
            BrandName.Click += BrandName_Click;
            // 
            // EditBrandButton
            // 
            EditBrandButton.BackColor = Color.White;
            EditBrandButton.CheckButton = false;
            EditBrandButton.Checked = false;
            EditBrandButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            EditBrandButton.CheckedImageTint = Color.White;
            EditBrandButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            EditBrandButton.Content = "";
            EditBrandButton.Cursor = Cursors.Hand;
            EditBrandButton.DialogResult = DialogResult.None;
            EditBrandButton.Font = new Font("Microsoft Sans Serif", 11F);
            EditBrandButton.ForeColor = Color.White;
            EditBrandButton.HoverBackground = Color.FromArgb(240, 50, 10);
            EditBrandButton.HoveredImageTint = Color.White;
            EditBrandButton.HoverOutline = Color.Empty;
            EditBrandButton.Image = Properties.Resources.EditIcon;
            EditBrandButton.ImageAutoCenter = true;
            EditBrandButton.ImageExpand = new Point(5, 5);
            EditBrandButton.ImageOffset = new Point(0, 0);
            EditBrandButton.ImageTint = Color.White;
            EditBrandButton.Location = new Point(17, 34);
            EditBrandButton.Name = "EditBrandButton";
            EditBrandButton.NormalBackground = Color.FromArgb(240, 50, 10);
            EditBrandButton.NormalOutline = Color.Empty;
            EditBrandButton.OutlineThickness = 1.6F;
            EditBrandButton.PressedBackground = Color.FromArgb(240, 50, 10);
            EditBrandButton.PressedImageTint = Color.White;
            EditBrandButton.PressedOutline = Color.Empty;
            EditBrandButton.Rounding = new Padding(8);
            EditBrandButton.Size = new Size(39, 37);
            EditBrandButton.TabIndex = 7;
            EditBrandButton.TextOffset = new Point(0, 0);
            EditBrandButton.Click += EditBrandButton_Click;
            // 
            // cuiBorder1
            // 
            cuiBorder1.BackColor = Color.Transparent;
            cuiBorder1.Controls.Add(DeleteButton);
            cuiBorder1.ForeColor = Color.White;
            cuiBorder1.Location = new Point(4, 1);
            cuiBorder1.Name = "cuiBorder1";
            cuiBorder1.OutlineThickness = 1F;
            cuiBorder1.PanelColor = Color.White;
            cuiBorder1.PanelOutlineColor = Color.White;
            cuiBorder1.Rounding = new Padding(8);
            cuiBorder1.Size = new Size(797, 96);
            cuiBorder1.TabIndex = 8;
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
            DeleteButton.Location = new Point(734, 33);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.NormalBackground = Color.FromArgb(240, 50, 10);
            DeleteButton.NormalOutline = Color.Empty;
            DeleteButton.OutlineThickness = 1.6F;
            DeleteButton.PressedBackground = Color.FromArgb(240, 50, 10);
            DeleteButton.PressedImageTint = Color.White;
            DeleteButton.PressedOutline = Color.Empty;
            DeleteButton.Rounding = new Padding(8);
            DeleteButton.Size = new Size(39, 37);
            DeleteButton.TabIndex = 9;
            DeleteButton.TextOffset = new Point(0, 0);
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditableBrandCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(EditBrandButton);
            Controls.Add(BrandName);
            Controls.Add(cuiBorder1);
            Name = "EditableBrandCard";
            Size = new Size(800, 100);
            cuiBorder1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BrandName;
        private CuoreUI.Controls.cuiButton EditBrandButton;
        private CuoreUI.Controls.cuiBorder cuiBorder1;
        private CuoreUI.Controls.cuiButton DeleteButton;
    }
}
