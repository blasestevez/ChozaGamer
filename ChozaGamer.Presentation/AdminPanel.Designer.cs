namespace ChozaGamer.Presentation
{
    partial class AdminPanel
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
            MinimizeButton = new CuoreUI.Controls.cuiButton();
            CloseButton = new CuoreUI.Controls.cuiButton();
            panel1 = new Panel();
            Logo = new CuoreUI.Controls.cuiPictureBox();
            ProfileButton = new CuoreUI.Controls.cuiButton();
            panel1.SuspendLayout();
            SuspendLayout();
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
            MinimizeButton.Location = new Point(1172, 23);
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
            CloseButton.Location = new Point(1223, 23);
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(MinimizeButton);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(ProfileButton);
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
            Logo.Location = new Point(80, 7);
            Logo.Margin = new Padding(4, 3, 4, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(270, 75);
            Logo.TabIndex = 6;
            // 
            // ProfileButton
            // 
            ProfileButton.BackgroundImageLayout = ImageLayout.None;
            ProfileButton.CheckButton = false;
            ProfileButton.Checked = false;
            ProfileButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            ProfileButton.CheckedImageTint = Color.White;
            ProfileButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            ProfileButton.Content = "Profile";
            ProfileButton.Cursor = Cursors.Hand;
            ProfileButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            ProfileButton.ForeColor = Color.White;
            ProfileButton.HoverBackground = Color.FromArgb(72, 72, 72);
            ProfileButton.HoveredImageTint = Color.FromArgb(240, 50, 10);
            ProfileButton.HoverOutline = Color.Empty;
            ProfileButton.Image = Properties.Resources.ProfileIcon__2_;
            ProfileButton.ImageAutoCenter = true;
            ProfileButton.ImageExpand = new Point(7, 7);
            ProfileButton.ImageOffset = new Point(-5, 0);
            ProfileButton.ImageTint = Color.White;
            ProfileButton.Location = new Point(1044, 23);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.NormalBackground = Color.FromArgb(33, 33, 33);
            ProfileButton.NormalOutline = Color.Empty;
            ProfileButton.OutlineThickness = 1.6F;
            ProfileButton.PressedBackground = Color.FromArgb(72, 72, 72);
            ProfileButton.PressedImageTint = Color.White;
            ProfileButton.PressedOutline = Color.Empty;
            ProfileButton.Rounding = new Padding(8);
            ProfileButton.Size = new Size(80, 45);
            ProfileButton.TabIndex = 1;
            ProfileButton.TextOffset = new Point(0, 0);
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            Text = "AdminPanel";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton MinimizeButton;
        private CuoreUI.Controls.cuiButton CloseButton;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton ProfileButton;
        private CuoreUI.Controls.cuiPictureBox Logo;
    }
}