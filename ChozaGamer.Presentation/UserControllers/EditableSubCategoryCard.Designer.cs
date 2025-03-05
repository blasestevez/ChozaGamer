namespace ChozaGamer.Presentation.UserControllers
{
    partial class EditableSubCategoryCard
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
            EditSubCategoryButton = new CuoreUI.Controls.cuiButton();
            SubCategoryName = new Label();
            DeleteButton = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // EditSubCategoryButton
            // 
            EditSubCategoryButton.BackColor = Color.White;
            EditSubCategoryButton.CheckButton = false;
            EditSubCategoryButton.Checked = false;
            EditSubCategoryButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            EditSubCategoryButton.CheckedImageTint = Color.White;
            EditSubCategoryButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            EditSubCategoryButton.Content = "";
            EditSubCategoryButton.Cursor = Cursors.Hand;
            EditSubCategoryButton.DialogResult = DialogResult.None;
            EditSubCategoryButton.Font = new Font("Microsoft Sans Serif", 11F);
            EditSubCategoryButton.ForeColor = Color.White;
            EditSubCategoryButton.HoverBackground = Color.FromArgb(240, 50, 10);
            EditSubCategoryButton.HoveredImageTint = Color.White;
            EditSubCategoryButton.HoverOutline = Color.Empty;
            EditSubCategoryButton.Image = Properties.Resources.EditIcon;
            EditSubCategoryButton.ImageAutoCenter = true;
            EditSubCategoryButton.ImageExpand = new Point(5, 5);
            EditSubCategoryButton.ImageOffset = new Point(0, 0);
            EditSubCategoryButton.ImageTint = Color.White;
            EditSubCategoryButton.Location = new Point(24, 32);
            EditSubCategoryButton.Name = "EditSubCategoryButton";
            EditSubCategoryButton.NormalBackground = Color.FromArgb(240, 50, 10);
            EditSubCategoryButton.NormalOutline = Color.Empty;
            EditSubCategoryButton.OutlineThickness = 1.6F;
            EditSubCategoryButton.PressedBackground = Color.FromArgb(240, 50, 10);
            EditSubCategoryButton.PressedImageTint = Color.White;
            EditSubCategoryButton.PressedOutline = Color.Empty;
            EditSubCategoryButton.Rounding = new Padding(8);
            EditSubCategoryButton.Size = new Size(39, 37);
            EditSubCategoryButton.TabIndex = 11;
            EditSubCategoryButton.TextOffset = new Point(0, 0);
            EditSubCategoryButton.Click += EditSubCategoryButton_Click_1;
            // 
            // SubCategoryName
            // 
            SubCategoryName.AutoSize = true;
            SubCategoryName.BackColor = Color.White;
            SubCategoryName.Font = new Font("Segoe UI", 15F);
            SubCategoryName.Location = new Point(215, 34);
            SubCategoryName.Name = "SubCategoryName";
            SubCategoryName.Size = new Size(384, 28);
            SubCategoryName.TabIndex = 10;
            SubCategoryName.Text = "pruebapruebapruebapruebapruebaprueba";
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
            DeleteButton.Location = new Point(727, 32);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.NormalBackground = Color.FromArgb(240, 50, 10);
            DeleteButton.NormalOutline = Color.Empty;
            DeleteButton.OutlineThickness = 1.6F;
            DeleteButton.PressedBackground = Color.FromArgb(240, 50, 10);
            DeleteButton.PressedImageTint = Color.White;
            DeleteButton.PressedOutline = Color.Empty;
            DeleteButton.Rounding = new Padding(8);
            DeleteButton.Size = new Size(39, 37);
            DeleteButton.TabIndex = 12;
            DeleteButton.TextOffset = new Point(0, 0);
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditableSubCategoryCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteButton);
            Controls.Add(EditSubCategoryButton);
            Controls.Add(SubCategoryName);
            Name = "EditableSubCategoryCard";
            Size = new Size(800, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiButton EditSubCategoryButton;
        private Label SubCategoryName;
        private CuoreUI.Controls.cuiButton DeleteButton;
    }
}
