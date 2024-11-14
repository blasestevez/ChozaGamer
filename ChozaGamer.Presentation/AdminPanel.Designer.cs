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
            AdminPanelTitle = new CuoreUI.Controls.cuiLabel();
            Logo = new CuoreUI.Controls.cuiPictureBox();
            ProfileButton = new CuoreUI.Controls.cuiButton();
            AdminPanelComboBox = new CuoreUI.Controls.cuiComboBox();
            AdminPanelLayout = new CuoreUI.Controls.cuiBorder();
            PriceLabel = new CuoreUI.Controls.cuiLabel();
            PriceNUD = new NumericUpDown();
            AdminPanelProductNameBar = new CuoreUI.Controls.cuiTextBox2();
            AdminPanelAddButton = new CuoreUI.Controls.cuiButton();
            AdminPanelProductPicture = new CuoreUI.Controls.cuiPictureBox();
            AdminPanelSelectFileButton = new CuoreUI.Controls.cuiButton();
            openFileDialog1 = new OpenFileDialog();
            LogoutButton = new CuoreUI.Controls.cuiButton();
            panel1.SuspendLayout();
            AdminPanelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PriceNUD).BeginInit();
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
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(AdminPanelTitle);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(MinimizeButton);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(ProfileButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 90);
            panel1.TabIndex = 1;
            // 
            // AdminPanelTitle
            // 
            AdminPanelTitle.Content = "Admin\\ Panel";
            AdminPanelTitle.Font = new Font("Segoe UI", 15F);
            AdminPanelTitle.ForeColor = Color.White;
            AdminPanelTitle.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            AdminPanelTitle.Location = new Point(608, 30);
            AdminPanelTitle.Margin = new Padding(4, 3, 4, 3);
            AdminPanelTitle.Name = "AdminPanelTitle";
            AdminPanelTitle.Size = new Size(135, 28);
            AdminPanelTitle.TabIndex = 7;
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
            // AdminPanelComboBox
            // 
            AdminPanelComboBox.BackgroundColor = Color.FromArgb(10, 10, 10);
            AdminPanelComboBox.ButtonHoverBackground = Color.FromArgb(200, 255, 106, 0);
            AdminPanelComboBox.ButtonHoverOutline = Color.FromArgb(255, 106, 0);
            AdminPanelComboBox.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            AdminPanelComboBox.ButtonNormalOutline = Color.FromArgb(255, 106, 0);
            AdminPanelComboBox.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            AdminPanelComboBox.ButtonPressedOutline = Color.FromArgb(255, 106, 0);
            AdminPanelComboBox.DropDownBackgroundColor = Color.FromArgb(14, 14, 14);
            AdminPanelComboBox.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            AdminPanelComboBox.ExpandArrowColor = Color.White;
            AdminPanelComboBox.ForeColor = SystemColors.Control;
            AdminPanelComboBox.Items = new string[]
    {
    "Product",
    "Brand",
    "Category",
    "SubCategory"
    };
            AdminPanelComboBox.Location = new Point(80, 161);
            AdminPanelComboBox.Margin = new Padding(4, 3, 4, 3);
            AdminPanelComboBox.Name = "AdminPanelComboBox";
            AdminPanelComboBox.OutlineColor = Color.FromArgb(35, 255, 255, 255);
            AdminPanelComboBox.OutlineThickness = 1F;
            AdminPanelComboBox.Rounding = 0;
            AdminPanelComboBox.Size = new Size(197, 52);
            AdminPanelComboBox.TabIndex = 2;
            AdminPanelComboBox.TabIndexChanged += AdminPanelComboBox_TabIndexChanged;
            // 
            // AdminPanelLayout
            // 
            AdminPanelLayout.Controls.Add(PriceLabel);
            AdminPanelLayout.Controls.Add(PriceNUD);
            AdminPanelLayout.Controls.Add(AdminPanelProductNameBar);
            AdminPanelLayout.Controls.Add(AdminPanelAddButton);
            AdminPanelLayout.Controls.Add(AdminPanelProductPicture);
            AdminPanelLayout.Controls.Add(AdminPanelSelectFileButton);
            AdminPanelLayout.Location = new Point(420, 161);
            AdminPanelLayout.Name = "AdminPanelLayout";
            AdminPanelLayout.OutlineThickness = 2F;
            AdminPanelLayout.PanelColor = Color.FromArgb(72, 72, 72);
            AdminPanelLayout.PanelOutlineColor = Color.FromArgb(33, 33, 33);
            AdminPanelLayout.Rounding = new Padding(8);
            AdminPanelLayout.Size = new Size(760, 499);
            AdminPanelLayout.TabIndex = 3;
            // 
            // PriceLabel
            // 
            PriceLabel.BackColor = Color.FromArgb(72, 72, 72);
            PriceLabel.Content = "Price";
            PriceLabel.Font = new Font("Segoe UI", 15F);
            PriceLabel.ForeColor = Color.White;
            PriceLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            PriceLabel.Location = new Point(584, 16);
            PriceLabel.Margin = new Padding(4, 3, 4, 3);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(55, 30);
            PriceLabel.TabIndex = 8;
            // 
            // PriceNUD
            // 
            PriceNUD.Location = new Point(584, 52);
            PriceNUD.Name = "PriceNUD";
            PriceNUD.Size = new Size(120, 23);
            PriceNUD.TabIndex = 4;
            // 
            // AdminPanelProductNameBar
            // 
            AdminPanelProductNameBar.BackColor = Color.FromArgb(33, 33, 33);
            AdminPanelProductNameBar.BorderColor = Color.White;
            AdminPanelProductNameBar.BorderFocusColor = Color.FromArgb(240, 50, 10);
            AdminPanelProductNameBar.BorderSize = 1;
            AdminPanelProductNameBar.Content = "";
            AdminPanelProductNameBar.Cursor = Cursors.IBeam;
            AdminPanelProductNameBar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminPanelProductNameBar.ForeColor = Color.Gray;
            AdminPanelProductNameBar.Location = new Point(239, 15);
            AdminPanelProductNameBar.Margin = new Padding(4);
            AdminPanelProductNameBar.Multiline = false;
            AdminPanelProductNameBar.Name = "AdminPanelProductNameBar";
            AdminPanelProductNameBar.Padding = new Padding(15, 16, 15, 0);
            AdminPanelProductNameBar.PasswordChar = false;
            AdminPanelProductNameBar.PlaceholderColor = Color.DimGray;
            AdminPanelProductNameBar.PlaceholderText = "Name";
            AdminPanelProductNameBar.Rounding = 10;
            AdminPanelProductNameBar.Size = new Size(305, 47);
            AdminPanelProductNameBar.TabIndex = 3;
            AdminPanelProductNameBar.TextOffset = new Size(0, 0);
            AdminPanelProductNameBar.UnderlinedStyle = false;
            // 
            // AdminPanelAddButton
            // 
            AdminPanelAddButton.BackColor = Color.FromArgb(72, 72, 72);
            AdminPanelAddButton.CheckButton = false;
            AdminPanelAddButton.Checked = false;
            AdminPanelAddButton.CheckedBackground = Color.FromArgb(72, 72, 72);
            AdminPanelAddButton.CheckedImageTint = Color.White;
            AdminPanelAddButton.CheckedOutline = Color.White;
            AdminPanelAddButton.Content = "Confirm Action";
            AdminPanelAddButton.Cursor = Cursors.Hand;
            AdminPanelAddButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            AdminPanelAddButton.ForeColor = Color.White;
            AdminPanelAddButton.HoverBackground = Color.FromArgb(33, 33, 33);
            AdminPanelAddButton.HoveredImageTint = Color.White;
            AdminPanelAddButton.HoverOutline = Color.Empty;
            AdminPanelAddButton.Image = Properties.Resources.ConfirmUploadIcon;
            AdminPanelAddButton.ImageAutoCenter = true;
            AdminPanelAddButton.ImageExpand = new Point(5, 5);
            AdminPanelAddButton.ImageOffset = new Point(-5, 0);
            AdminPanelAddButton.ImageTint = Color.White;
            AdminPanelAddButton.Location = new Point(318, 439);
            AdminPanelAddButton.Name = "AdminPanelAddButton";
            AdminPanelAddButton.NormalBackground = Color.FromArgb(33, 33, 33);
            AdminPanelAddButton.NormalOutline = Color.Empty;
            AdminPanelAddButton.OutlineThickness = 1.6F;
            AdminPanelAddButton.PressedBackground = Color.FromArgb(255, 106, 0);
            AdminPanelAddButton.PressedImageTint = Color.Wheat;
            AdminPanelAddButton.PressedOutline = Color.Empty;
            AdminPanelAddButton.Rounding = new Padding(8);
            AdminPanelAddButton.Size = new Size(153, 45);
            AdminPanelAddButton.TabIndex = 2;
            AdminPanelAddButton.TextOffset = new Point(0, 0);
            AdminPanelAddButton.Click += AdminPanelAddButton_Click;
            // 
            // AdminPanelProductPicture
            // 
            AdminPanelProductPicture.BackgroundImageLayout = ImageLayout.Zoom;
            AdminPanelProductPicture.Content = null;
            AdminPanelProductPicture.CornerRadius = 0;
            AdminPanelProductPicture.ImageTint = Color.White;
            AdminPanelProductPicture.Location = new Point(51, 15);
            AdminPanelProductPicture.Margin = new Padding(4, 3, 4, 3);
            AdminPanelProductPicture.Name = "AdminPanelProductPicture";
            AdminPanelProductPicture.Size = new Size(162, 154);
            AdminPanelProductPicture.TabIndex = 1;
            // 
            // AdminPanelSelectFileButton
            // 
            AdminPanelSelectFileButton.BackColor = Color.FromArgb(72, 72, 72);
            AdminPanelSelectFileButton.CheckButton = false;
            AdminPanelSelectFileButton.Checked = false;
            AdminPanelSelectFileButton.CheckedBackground = Color.FromArgb(72, 72, 72);
            AdminPanelSelectFileButton.CheckedImageTint = Color.White;
            AdminPanelSelectFileButton.CheckedOutline = Color.White;
            AdminPanelSelectFileButton.Content = "Upload Image";
            AdminPanelSelectFileButton.Cursor = Cursors.Hand;
            AdminPanelSelectFileButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            AdminPanelSelectFileButton.ForeColor = Color.White;
            AdminPanelSelectFileButton.HoverBackground = Color.FromArgb(33, 33, 33);
            AdminPanelSelectFileButton.HoveredImageTint = Color.White;
            AdminPanelSelectFileButton.HoverOutline = Color.Empty;
            AdminPanelSelectFileButton.Image = Properties.Resources.UploadFileIcon;
            AdminPanelSelectFileButton.ImageAutoCenter = true;
            AdminPanelSelectFileButton.ImageExpand = new Point(5, 5);
            AdminPanelSelectFileButton.ImageOffset = new Point(-5, 0);
            AdminPanelSelectFileButton.ImageTint = Color.White;
            AdminPanelSelectFileButton.Location = new Point(55, 175);
            AdminPanelSelectFileButton.Name = "AdminPanelSelectFileButton";
            AdminPanelSelectFileButton.NormalBackground = Color.FromArgb(33, 33, 33);
            AdminPanelSelectFileButton.NormalOutline = Color.Empty;
            AdminPanelSelectFileButton.OutlineThickness = 1.6F;
            AdminPanelSelectFileButton.PressedBackground = Color.FromArgb(255, 106, 0);
            AdminPanelSelectFileButton.PressedImageTint = Color.Wheat;
            AdminPanelSelectFileButton.PressedOutline = Color.Empty;
            AdminPanelSelectFileButton.Rounding = new Padding(8);
            AdminPanelSelectFileButton.Size = new Size(153, 45);
            AdminPanelSelectFileButton.TabIndex = 0;
            AdminPanelSelectFileButton.TextOffset = new Point(0, 0);
            AdminPanelSelectFileButton.Click += AdminPanelSelectFileButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // LogoutButton
            // 
            LogoutButton.BackgroundImageLayout = ImageLayout.None;
            LogoutButton.CheckButton = false;
            LogoutButton.Checked = false;
            LogoutButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            LogoutButton.CheckedImageTint = Color.White;
            LogoutButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            LogoutButton.Content = "Logout";
            LogoutButton.Cursor = Cursors.Hand;
            LogoutButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.HoverBackground = Color.FromArgb(72, 72, 72);
            LogoutButton.HoveredImageTint = Color.FromArgb(240, 50, 10);
            LogoutButton.HoverOutline = Color.Empty;
            LogoutButton.Image = Properties.Resources.ProfileIcon__2_;
            LogoutButton.ImageAutoCenter = true;
            LogoutButton.ImageExpand = new Point(7, 7);
            LogoutButton.ImageOffset = new Point(-5, 0);
            LogoutButton.ImageTint = Color.White;
            LogoutButton.Location = new Point(947, 23);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.NormalBackground = Color.FromArgb(33, 33, 33);
            LogoutButton.NormalOutline = Color.Empty;
            LogoutButton.OutlineThickness = 1.6F;
            LogoutButton.PressedBackground = Color.FromArgb(72, 72, 72);
            LogoutButton.PressedImageTint = Color.White;
            LogoutButton.PressedOutline = Color.Empty;
            LogoutButton.Rounding = new Padding(8);
            LogoutButton.Size = new Size(80, 45);
            LogoutButton.TabIndex = 9;
            LogoutButton.TextOffset = new Point(0, 0);
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(AdminPanelLayout);
            Controls.Add(AdminPanelComboBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            Text = "AdminPanel";
            panel1.ResumeLayout(false);
            AdminPanelLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PriceNUD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton MinimizeButton;
        private CuoreUI.Controls.cuiButton CloseButton;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton ProfileButton;
        private CuoreUI.Controls.cuiPictureBox Logo;
        private CuoreUI.Controls.cuiLabel AdminPanelTitle;
        private CuoreUI.Controls.cuiComboBox AdminPanelComboBox;
        private CuoreUI.Controls.cuiBorder AdminPanelLayout;
        private CuoreUI.Controls.cuiButton AdminPanelSelectFileButton;
        private OpenFileDialog openFileDialog1;
        private CuoreUI.Controls.cuiPictureBox AdminPanelProductPicture;
        private CuoreUI.Controls.cuiButton AdminPanelAddButton;
        private CuoreUI.Controls.cuiLabel PriceLabel;
        private NumericUpDown PriceNUD;
        private CuoreUI.Controls.cuiTextBox2 AdminPanelProductNameBar;
        private CuoreUI.Controls.cuiButton LogoutButton;
    }
}