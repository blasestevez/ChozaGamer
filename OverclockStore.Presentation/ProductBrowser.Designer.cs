namespace OverclockStore.Presentation
{
    partial class ProductBrowser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            searchProductDTOBindingSource = new BindingSource(components);
            panel1 = new Panel();
            LogoutButton = new CuoreUI.Controls.cuiButton();
            Logo = new CuoreUI.Controls.cuiPictureBox();
            MinimizeButton = new CuoreUI.Controls.cuiButton();
            CloseButton = new CuoreUI.Controls.cuiButton();
            SearchButton = new CuoreUI.Controls.cuiButton();
            ProfileButton = new CuoreUI.Controls.cuiButton();
            SearchBar = new CuoreUI.Controls.cuiTextBox2();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)searchProductDTOBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchProductDTOBindingSource
            // 
            searchProductDTOBindingSource.DataSource = typeof(DataAccess.Models.DTOs.SearchProductDTO);
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(MinimizeButton);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(ProfileButton);
            panel1.Controls.Add(SearchBar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 90);
            panel1.TabIndex = 0;
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
            LogoutButton.Location = new Point(977, 23);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.NormalBackground = Color.FromArgb(33, 33, 33);
            LogoutButton.NormalOutline = Color.Empty;
            LogoutButton.OutlineThickness = 1.6F;
            LogoutButton.PressedBackground = Color.FromArgb(72, 72, 72);
            LogoutButton.PressedImageTint = Color.White;
            LogoutButton.PressedOutline = Color.Empty;
            LogoutButton.Rounding = new Padding(8);
            LogoutButton.Size = new Size(80, 45);
            LogoutButton.TabIndex = 6;
            LogoutButton.TextOffset = new Point(0, 0);
            LogoutButton.Click += LogoutButton_Click;
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
            Logo.TabIndex = 5;
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
            // SearchButton
            // 
            SearchButton.BackgroundImageLayout = ImageLayout.None;
            SearchButton.CheckButton = false;
            SearchButton.Checked = false;
            SearchButton.CheckedBackground = Color.FromArgb(33, 33, 33);
            SearchButton.CheckedImageTint = Color.White;
            SearchButton.CheckedOutline = Color.FromArgb(33, 33, 33);
            SearchButton.Content = "";
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            SearchButton.ForeColor = Color.White;
            SearchButton.HoverBackground = Color.FromArgb(72, 72, 72);
            SearchButton.HoveredImageTint = Color.FromArgb(240, 50, 10);
            SearchButton.HoverOutline = Color.Empty;
            SearchButton.Image = Properties.Resources.SearchIcon;
            SearchButton.ImageAutoCenter = true;
            SearchButton.ImageExpand = new Point(7, 7);
            SearchButton.ImageOffset = new Point(0, 0);
            SearchButton.ImageTint = Color.White;
            SearchButton.Location = new Point(907, 23);
            SearchButton.Name = "SearchButton";
            SearchButton.NormalBackground = Color.FromArgb(33, 33, 33);
            SearchButton.NormalOutline = Color.Empty;
            SearchButton.OutlineThickness = 1.6F;
            SearchButton.PressedBackground = Color.FromArgb(72, 72, 72);
            SearchButton.PressedImageTint = Color.White;
            SearchButton.PressedOutline = Color.Empty;
            SearchButton.Rounding = new Padding(8);
            SearchButton.Size = new Size(45, 45);
            SearchButton.TabIndex = 2;
            SearchButton.TextOffset = new Point(0, 0);
            SearchButton.Click += SearchButton_Click;
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
            ProfileButton.Location = new Point(1075, 23);
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
            ProfileButton.Click += ProfileButton_Click;
            // 
            // SearchBar
            // 
            SearchBar.BackColor = Color.FromArgb(33, 33, 33);
            SearchBar.BorderColor = Color.White;
            SearchBar.BorderFocusColor = Color.FromArgb(240, 50, 10);
            SearchBar.BorderSize = 1;
            SearchBar.Content = "";
            SearchBar.Cursor = Cursors.IBeam;
            SearchBar.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBar.ForeColor = Color.Gray;
            SearchBar.Location = new Point(480, 23);
            SearchBar.Margin = new Padding(4);
            SearchBar.Multiline = false;
            SearchBar.Name = "SearchBar";
            SearchBar.Padding = new Padding(15, 15, 15, 0);
            SearchBar.PasswordChar = false;
            SearchBar.PlaceholderColor = Color.DimGray;
            SearchBar.PlaceholderText = "Search Products";
            SearchBar.Rounding = 10;
            SearchBar.Size = new Size(420, 45);
            SearchBar.TabIndex = 0;
            SearchBar.TextOffset = new Size(0, 0);
            SearchBar.UnderlinedStyle = false;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 50);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 50);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(350, 155);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(867, 501);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // ProductBrowser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductBrowser";
            Text = "Product Browser";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)searchProductDTOBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource searchProductDTOBindingSource;
        private Panel panel1;
        private CuoreUI.Controls.cuiTextBox2 SearchBar;
        private CuoreUI.Controls.cuiButton ProfileButton;
        private CuoreUI.Controls.cuiButton SearchButton;
        private CuoreUI.Controls.cuiButton CloseButton;
        private CuoreUI.Controls.cuiButton MinimizeButton;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanel1;
        private CuoreUI.Controls.cuiPictureBox Logo;
        private CuoreUI.Controls.cuiButton LogoutButton;
    }
}
