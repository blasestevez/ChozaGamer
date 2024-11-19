namespace ChozaGamer.Presentation.UserControllers
{
    partial class AddButton
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
            OpenAddFormButton = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // OpenAddFormButton
            // 
            OpenAddFormButton.CheckButton = false;
            OpenAddFormButton.Checked = false;
            OpenAddFormButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            OpenAddFormButton.CheckedImageTint = Color.White;
            OpenAddFormButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            OpenAddFormButton.Content = "";
            OpenAddFormButton.DialogResult = DialogResult.None;
            OpenAddFormButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            OpenAddFormButton.ForeColor = Color.White;
            OpenAddFormButton.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            OpenAddFormButton.HoveredImageTint = Color.White;
            OpenAddFormButton.HoverOutline = Color.Empty;
            OpenAddFormButton.Image = Properties.Resources.ConfirmUploadIcon;
            OpenAddFormButton.ImageAutoCenter = true;
            OpenAddFormButton.ImageExpand = new Point(10, 10);
            OpenAddFormButton.ImageOffset = new Point(0, 0);
            OpenAddFormButton.ImageTint = Color.White;
            OpenAddFormButton.Location = new Point(0, 0);
            OpenAddFormButton.Name = "OpenAddFormButton";
            OpenAddFormButton.NormalBackground = Color.FromArgb(255, 106, 0);
            OpenAddFormButton.NormalOutline = Color.Empty;
            OpenAddFormButton.OutlineThickness = 1.6F;
            OpenAddFormButton.PressedBackground = Color.FromArgb(255, 106, 0);
            OpenAddFormButton.PressedImageTint = Color.White;
            OpenAddFormButton.PressedOutline = Color.Empty;
            OpenAddFormButton.Rounding = new Padding(8);
            OpenAddFormButton.Size = new Size(50, 47);
            OpenAddFormButton.TabIndex = 0;
            OpenAddFormButton.TextOffset = new Point(0, 0);
            OpenAddFormButton.Click += OpenAddFormButton_Click;
            // 
            // AddButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(OpenAddFormButton);
            Name = "AddButton";
            Size = new Size(50, 50);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton OpenAddFormButton;
    }
}
