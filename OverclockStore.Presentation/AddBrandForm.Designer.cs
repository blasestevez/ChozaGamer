namespace OverclockStore.Presentation.UserControllers
{
    partial class AddBrandForm
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
            ConfirmButton = new CuoreUI.Controls.cuiButton();
            NameBar = new CuoreUI.Controls.cuiTextBox2();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
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
            ConfirmButton.Location = new Point(75, 210);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.NormalBackground = Color.FromArgb(33, 33, 33);
            ConfirmButton.NormalOutline = Color.Empty;
            ConfirmButton.OutlineThickness = 1.6F;
            ConfirmButton.PressedBackground = Color.FromArgb(72, 72, 72);
            ConfirmButton.PressedImageTint = Color.White;
            ConfirmButton.PressedOutline = Color.Empty;
            ConfirmButton.Rounding = new Padding(8);
            ConfirmButton.Size = new Size(220, 45);
            ConfirmButton.TabIndex = 24;
            ConfirmButton.TextOffset = new Point(0, 0);
            ConfirmButton.Click += ConfirmButton_Click;
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
            NameBar.Location = new Point(75, 90);
            NameBar.Margin = new Padding(4);
            NameBar.Multiline = false;
            NameBar.Name = "NameBar";
            NameBar.Padding = new Padding(15, 16, 15, 0);
            NameBar.PasswordChar = false;
            NameBar.PlaceholderColor = Color.DimGray;
            NameBar.PlaceholderText = "Name";
            NameBar.Rounding = 10;
            NameBar.Size = new Size(220, 47);
            NameBar.TabIndex = 23;
            NameBar.TextOffset = new Size(0, 0);
            NameBar.UnderlinedStyle = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(126, 162);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 25;
            // 
            // AddBrandForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(numericUpDown1);
            Controls.Add(ConfirmButton);
            Controls.Add(NameBar);
            Name = "AddBrandForm";
            Text = "AddBrandForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton ConfirmButton;
        private CuoreUI.Controls.cuiTextBox2 NameBar;
        private NumericUpDown numericUpDown1;
    }
}