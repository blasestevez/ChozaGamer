namespace OverclockStore.Presentation.UserControllers
{
    partial class EditableCategoryCard
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
            EditCategoryButton = new CuoreUI.Controls.cuiButton();
            CategoryName = new Label();
            DeleteButton = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // EditCategoryButton
            // 
            EditCategoryButton.BackColor = Color.White;
            EditCategoryButton.CheckButton = false;
            EditCategoryButton.Checked = false;
            EditCategoryButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            EditCategoryButton.CheckedImageTint = Color.White;
            EditCategoryButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            EditCategoryButton.Content = "";
            EditCategoryButton.Cursor = Cursors.Hand;
            EditCategoryButton.DialogResult = DialogResult.None;
            EditCategoryButton.Font = new Font("Microsoft Sans Serif", 11F);
            EditCategoryButton.ForeColor = Color.White;
            EditCategoryButton.HoverBackground = Color.FromArgb(240, 50, 10);
            EditCategoryButton.HoveredImageTint = Color.White;
            EditCategoryButton.HoverOutline = Color.Empty;
            EditCategoryButton.Image = Properties.Resources.EditIcon;
            EditCategoryButton.ImageAutoCenter = true;
            EditCategoryButton.ImageExpand = new Point(5, 5);
            EditCategoryButton.ImageOffset = new Point(0, 0);
            EditCategoryButton.ImageTint = Color.White;
            EditCategoryButton.Location = new Point(18, 32);
            EditCategoryButton.Name = "EditCategoryButton";
            EditCategoryButton.NormalBackground = Color.FromArgb(240, 50, 10);
            EditCategoryButton.NormalOutline = Color.Empty;
            EditCategoryButton.OutlineThickness = 1.6F;
            EditCategoryButton.PressedBackground = Color.FromArgb(240, 50, 10);
            EditCategoryButton.PressedImageTint = Color.White;
            EditCategoryButton.PressedOutline = Color.Empty;
            EditCategoryButton.Rounding = new Padding(8);
            EditCategoryButton.Size = new Size(39, 37);
            EditCategoryButton.TabIndex = 9;
            EditCategoryButton.TextOffset = new Point(0, 0);
            EditCategoryButton.Click += EditCategoryButton_Click;
            // 
            // CategoryName
            // 
            CategoryName.AutoSize = true;
            CategoryName.BackColor = Color.White;
            CategoryName.Font = new Font("Segoe UI", 15F);
            CategoryName.Location = new Point(209, 34);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(384, 28);
            CategoryName.TabIndex = 8;
            CategoryName.Text = "pruebapruebapruebapruebapruebaprueba";
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
            DeleteButton.Location = new Point(722, 32);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.NormalBackground = Color.FromArgb(240, 50, 10);
            DeleteButton.NormalOutline = Color.Empty;
            DeleteButton.OutlineThickness = 1.6F;
            DeleteButton.PressedBackground = Color.FromArgb(240, 50, 10);
            DeleteButton.PressedImageTint = Color.White;
            DeleteButton.PressedOutline = Color.Empty;
            DeleteButton.Rounding = new Padding(8);
            DeleteButton.Size = new Size(39, 37);
            DeleteButton.TabIndex = 10;
            DeleteButton.TextOffset = new Point(0, 0);
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditableCategoryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteButton);
            Controls.Add(EditCategoryButton);
            Controls.Add(CategoryName);
            Name = "EditableCategoryCard";
            Size = new Size(800, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiButton EditCategoryButton;
        private Label CategoryName;
        private CuoreUI.Controls.cuiButton DeleteButton;
    }
}
