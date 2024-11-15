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
            LogoutButton = new CuoreUI.Controls.cuiButton();
            AdminPanelTitle = new CuoreUI.Controls.cuiLabel();
            Logo = new CuoreUI.Controls.cuiPictureBox();
            ProfileButton = new CuoreUI.Controls.cuiButton();
            openFileDialog1 = new OpenFileDialog();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ManageProductsButton = new CuoreUI.Controls.cuiButton();
            ManageBrandsButton = new CuoreUI.Controls.cuiButton();
            ManageCategoriesButton = new CuoreUI.Controls.cuiButton();
            ManagesSubcategoriesButton = new CuoreUI.Controls.cuiButton();
            ManageProductPanel = new FlowLayoutPanel();
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
            MinimizeButton.DialogResult = DialogResult.None;
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
            CloseButton.DialogResult = DialogResult.None;
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
            LogoutButton.DialogResult = DialogResult.None;
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
            ProfileButton.DialogResult = DialogResult.None;
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(350, 155);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(867, 501);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // ManageProductsButton
            // 
            ManageProductsButton.BackgroundImageLayout = ImageLayout.None;
            ManageProductsButton.CheckButton = false;
            ManageProductsButton.Checked = false;
            ManageProductsButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            ManageProductsButton.CheckedImageTint = Color.White;
            ManageProductsButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            ManageProductsButton.Content = "Manage Products";
            ManageProductsButton.Cursor = Cursors.Hand;
            ManageProductsButton.DialogResult = DialogResult.None;
            ManageProductsButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            ManageProductsButton.ForeColor = Color.White;
            ManageProductsButton.HoverBackground = Color.FromArgb(72, 72, 72);
            ManageProductsButton.HoveredImageTint = Color.FromArgb(240, 50, 10);
            ManageProductsButton.HoverOutline = Color.Empty;
            ManageProductsButton.Image = Properties.Resources.ProfileIcon__2_;
            ManageProductsButton.ImageAutoCenter = true;
            ManageProductsButton.ImageExpand = new Point(7, 7);
            ManageProductsButton.ImageOffset = new Point(-5, 0);
            ManageProductsButton.ImageTint = Color.White;
            ManageProductsButton.Location = new Point(45, 250);
            ManageProductsButton.Name = "ManageProductsButton";
            ManageProductsButton.NormalBackground = Color.FromArgb(33, 33, 33);
            ManageProductsButton.NormalOutline = Color.Empty;
            ManageProductsButton.OutlineThickness = 1.6F;
            ManageProductsButton.PressedBackground = Color.FromArgb(72, 72, 72);
            ManageProductsButton.PressedImageTint = Color.White;
            ManageProductsButton.PressedOutline = Color.Empty;
            ManageProductsButton.Rounding = new Padding(8);
            ManageProductsButton.Size = new Size(183, 45);
            ManageProductsButton.TabIndex = 10;
            ManageProductsButton.TextOffset = new Point(0, 0);
            ManageProductsButton.Click += ManageProductsButton_Click;
            // 
            // ManageBrandsButton
            // 
            ManageBrandsButton.BackgroundImageLayout = ImageLayout.None;
            ManageBrandsButton.CheckButton = false;
            ManageBrandsButton.Checked = false;
            ManageBrandsButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            ManageBrandsButton.CheckedImageTint = Color.White;
            ManageBrandsButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            ManageBrandsButton.Content = "Manage Brands";
            ManageBrandsButton.Cursor = Cursors.Hand;
            ManageBrandsButton.DialogResult = DialogResult.None;
            ManageBrandsButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            ManageBrandsButton.ForeColor = Color.White;
            ManageBrandsButton.HoverBackground = Color.FromArgb(72, 72, 72);
            ManageBrandsButton.HoveredImageTint = Color.FromArgb(240, 50, 10);
            ManageBrandsButton.HoverOutline = Color.Empty;
            ManageBrandsButton.Image = Properties.Resources.ProfileIcon__2_;
            ManageBrandsButton.ImageAutoCenter = true;
            ManageBrandsButton.ImageExpand = new Point(7, 7);
            ManageBrandsButton.ImageOffset = new Point(-5, 0);
            ManageBrandsButton.ImageTint = Color.White;
            ManageBrandsButton.Location = new Point(45, 339);
            ManageBrandsButton.Name = "ManageBrandsButton";
            ManageBrandsButton.NormalBackground = Color.FromArgb(33, 33, 33);
            ManageBrandsButton.NormalOutline = Color.Empty;
            ManageBrandsButton.OutlineThickness = 1.6F;
            ManageBrandsButton.PressedBackground = Color.FromArgb(72, 72, 72);
            ManageBrandsButton.PressedImageTint = Color.White;
            ManageBrandsButton.PressedOutline = Color.Empty;
            ManageBrandsButton.Rounding = new Padding(8);
            ManageBrandsButton.Size = new Size(183, 45);
            ManageBrandsButton.TabIndex = 11;
            ManageBrandsButton.TextOffset = new Point(0, 0);
            // 
            // ManageCategoriesButton
            // 
            ManageCategoriesButton.BackgroundImageLayout = ImageLayout.None;
            ManageCategoriesButton.CheckButton = false;
            ManageCategoriesButton.Checked = false;
            ManageCategoriesButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            ManageCategoriesButton.CheckedImageTint = Color.White;
            ManageCategoriesButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            ManageCategoriesButton.Content = "Manage Categories";
            ManageCategoriesButton.Cursor = Cursors.Hand;
            ManageCategoriesButton.DialogResult = DialogResult.None;
            ManageCategoriesButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            ManageCategoriesButton.ForeColor = Color.White;
            ManageCategoriesButton.HoverBackground = Color.FromArgb(72, 72, 72);
            ManageCategoriesButton.HoveredImageTint = Color.FromArgb(240, 50, 10);
            ManageCategoriesButton.HoverOutline = Color.Empty;
            ManageCategoriesButton.Image = Properties.Resources.ProfileIcon__2_;
            ManageCategoriesButton.ImageAutoCenter = true;
            ManageCategoriesButton.ImageExpand = new Point(7, 7);
            ManageCategoriesButton.ImageOffset = new Point(-5, 0);
            ManageCategoriesButton.ImageTint = Color.White;
            ManageCategoriesButton.Location = new Point(45, 427);
            ManageCategoriesButton.Name = "ManageCategoriesButton";
            ManageCategoriesButton.NormalBackground = Color.FromArgb(33, 33, 33);
            ManageCategoriesButton.NormalOutline = Color.Empty;
            ManageCategoriesButton.OutlineThickness = 1.6F;
            ManageCategoriesButton.PressedBackground = Color.FromArgb(72, 72, 72);
            ManageCategoriesButton.PressedImageTint = Color.White;
            ManageCategoriesButton.PressedOutline = Color.Empty;
            ManageCategoriesButton.Rounding = new Padding(8);
            ManageCategoriesButton.Size = new Size(183, 45);
            ManageCategoriesButton.TabIndex = 12;
            ManageCategoriesButton.TextOffset = new Point(0, 0);
            // 
            // ManagesSubcategoriesButton
            // 
            ManagesSubcategoriesButton.BackgroundImageLayout = ImageLayout.None;
            ManagesSubcategoriesButton.CheckButton = false;
            ManagesSubcategoriesButton.Checked = false;
            ManagesSubcategoriesButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            ManagesSubcategoriesButton.CheckedImageTint = Color.White;
            ManagesSubcategoriesButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            ManagesSubcategoriesButton.Content = "Manage Subcategories";
            ManagesSubcategoriesButton.Cursor = Cursors.Hand;
            ManagesSubcategoriesButton.DialogResult = DialogResult.None;
            ManagesSubcategoriesButton.Font = new Font("Microsoft Sans Serif", 9.5F);
            ManagesSubcategoriesButton.ForeColor = Color.White;
            ManagesSubcategoriesButton.HoverBackground = Color.FromArgb(72, 72, 72);
            ManagesSubcategoriesButton.HoveredImageTint = Color.FromArgb(240, 50, 10);
            ManagesSubcategoriesButton.HoverOutline = Color.Empty;
            ManagesSubcategoriesButton.Image = Properties.Resources.ProfileIcon__2_;
            ManagesSubcategoriesButton.ImageAutoCenter = true;
            ManagesSubcategoriesButton.ImageExpand = new Point(7, 7);
            ManagesSubcategoriesButton.ImageOffset = new Point(-5, 0);
            ManagesSubcategoriesButton.ImageTint = Color.White;
            ManagesSubcategoriesButton.Location = new Point(45, 517);
            ManagesSubcategoriesButton.Name = "ManagesSubcategoriesButton";
            ManagesSubcategoriesButton.NormalBackground = Color.FromArgb(33, 33, 33);
            ManagesSubcategoriesButton.NormalOutline = Color.Empty;
            ManagesSubcategoriesButton.OutlineThickness = 1.6F;
            ManagesSubcategoriesButton.PressedBackground = Color.FromArgb(72, 72, 72);
            ManagesSubcategoriesButton.PressedImageTint = Color.White;
            ManagesSubcategoriesButton.PressedOutline = Color.Empty;
            ManagesSubcategoriesButton.Rounding = new Padding(8);
            ManagesSubcategoriesButton.Size = new Size(183, 45);
            ManagesSubcategoriesButton.TabIndex = 13;
            ManagesSubcategoriesButton.TextOffset = new Point(0, 0);
            // 
            // ManageProductPanel
            // 
            ManageProductPanel.AutoScroll = true;
            ManageProductPanel.Location = new Point(350, 108);
            ManageProductPanel.Name = "ManageProductPanel";
            ManageProductPanel.Size = new Size(800, 600);
            ManageProductPanel.TabIndex = 3;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(ManageProductPanel);
            Controls.Add(ManagesSubcategoriesButton);
            Controls.Add(ManageCategoriesButton);
            Controls.Add(ManageBrandsButton);
            Controls.Add(ManageProductsButton);
            Controls.Add(flowLayoutPanel1);
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
        private CuoreUI.Controls.cuiLabel AdminPanelTitle;
        private OpenFileDialog openFileDialog1;
        private CuoreUI.Controls.cuiButton LogoutButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private CuoreUI.Controls.cuiButton ManageProductsButton;
        private CuoreUI.Controls.cuiButton ManageBrandsButton;
        private CuoreUI.Controls.cuiButton ManageCategoriesButton;
        private CuoreUI.Controls.cuiButton ManagesSubcategoriesButton;
        private FlowLayoutPanel ManageProductPanel;
    }
}