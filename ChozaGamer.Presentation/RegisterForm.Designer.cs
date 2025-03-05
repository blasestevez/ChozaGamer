namespace ChozaGamer.Presentation
{
    partial class RegisterForm
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
            panel1 = new Panel();
            Logo = new CuoreUI.Controls.cuiPictureBox();
            MinimizeButton = new CuoreUI.Controls.cuiButton();
            CloseButton = new CuoreUI.Controls.cuiButton();
            RegisteredRedirectLabel = new CuoreUI.Controls.cuiLabel();
            RegisteredLabel = new CuoreUI.Controls.cuiLabel();
            RegisterButton = new CuoreUI.Controls.cuiButton();
            PasswordTextBox = new CuoreUI.Controls.cuiTextBox2();
            UsernameTextBox = new CuoreUI.Controls.cuiTextBox2();
            UserTypeListBox = new CuoreUI.Controls.cuiComboBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 90);
            panel1.TabIndex = 8;
            // 
            // Logo
            // 
            Logo.BackColor = Color.FromArgb(33, 33, 33);
            Logo.Content = Properties.Resources.logo;
            Logo.CornerRadius = 8;
            Logo.ImageTint = Color.White;
            Logo.Location = new Point(7, 20);
            Logo.Margin = new Padding(4, 3, 4, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(185, 49);
            Logo.TabIndex = 8;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.FromArgb(33, 33, 33);
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
            MinimizeButton.Location = new Point(195, 22);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.NormalBackground = Color.FromArgb(33, 33, 33);
            MinimizeButton.NormalOutline = Color.Empty;
            MinimizeButton.OutlineThickness = 1.6F;
            MinimizeButton.PressedBackground = Color.FromArgb(72, 72, 72);
            MinimizeButton.PressedImageTint = Color.White;
            MinimizeButton.PressedOutline = Color.Empty;
            MinimizeButton.Rounding = new Padding(8);
            MinimizeButton.Size = new Size(45, 45);
            MinimizeButton.TabIndex = 7;
            MinimizeButton.TextOffset = new Point(0, 0);
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(33, 33, 33);
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
            CloseButton.Location = new Point(246, 22);
            CloseButton.Name = "CloseButton";
            CloseButton.NormalBackground = Color.FromArgb(33, 33, 33);
            CloseButton.NormalOutline = Color.Empty;
            CloseButton.OutlineThickness = 1.6F;
            CloseButton.PressedBackground = Color.FromArgb(72, 72, 72);
            CloseButton.PressedImageTint = Color.White;
            CloseButton.PressedOutline = Color.Empty;
            CloseButton.Rounding = new Padding(8);
            CloseButton.Size = new Size(45, 45);
            CloseButton.TabIndex = 6;
            CloseButton.TextOffset = new Point(0, 0);
            CloseButton.Click += CloseButton_Click;
            // 
            // RegisteredRedirectLabel
            // 
            RegisteredRedirectLabel.BackgroundImageLayout = ImageLayout.None;
            RegisteredRedirectLabel.Content = "Login\\ now\\.";
            RegisteredRedirectLabel.Cursor = Cursors.Hand;
            RegisteredRedirectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            RegisteredRedirectLabel.ForeColor = Color.White;
            RegisteredRedirectLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            RegisteredRedirectLabel.Location = new Point(172, 351);
            RegisteredRedirectLabel.Margin = new Padding(4, 3, 4, 3);
            RegisteredRedirectLabel.Name = "RegisteredRedirectLabel";
            RegisteredRedirectLabel.Size = new Size(68, 19);
            RegisteredRedirectLabel.TabIndex = 13;
            RegisteredRedirectLabel.Click += RegisteredRedirectLabel_Click;
            // 
            // RegisteredLabel
            // 
            RegisteredLabel.Content = "Already\\ registered\\?";
            RegisteredLabel.ForeColor = Color.White;
            RegisteredLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            RegisteredLabel.Location = new Point(53, 351);
            RegisteredLabel.Margin = new Padding(4, 3, 4, 3);
            RegisteredLabel.Name = "RegisteredLabel";
            RegisteredLabel.Size = new Size(111, 19);
            RegisteredLabel.TabIndex = 12;
            // 
            // RegisterButton
            // 
            RegisterButton.CheckButton = false;
            RegisterButton.Checked = false;
            RegisterButton.CheckedBackground = Color.FromArgb(72, 72, 72);
            RegisterButton.CheckedImageTint = Color.White;
            RegisterButton.CheckedOutline = Color.FromArgb(72, 72, 72);
            RegisterButton.Content = "Register";
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.HoverBackground = Color.FromArgb(33, 33, 33);
            RegisterButton.HoveredImageTint = Color.White;
            RegisterButton.HoverOutline = Color.Empty;
            RegisterButton.Image = null;
            RegisterButton.ImageAutoCenter = true;
            RegisterButton.ImageExpand = new Point(0, 0);
            RegisterButton.ImageOffset = new Point(0, 0);
            RegisterButton.ImageTint = Color.White;
            RegisterButton.Location = new Point(75, 300);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.NormalBackground = Color.FromArgb(72, 72, 72);
            RegisterButton.NormalOutline = Color.FromArgb(33, 33, 33);
            RegisterButton.OutlineThickness = 2F;
            RegisterButton.PressedBackground = Color.FromArgb(255, 106, 0);
            RegisterButton.PressedImageTint = Color.White;
            RegisterButton.PressedOutline = Color.Empty;
            RegisterButton.Rounding = new Padding(8);
            RegisterButton.Size = new Size(150, 45);
            RegisterButton.TabIndex = 11;
            RegisterButton.TextOffset = new Point(0, 0);
            RegisterButton.Click += RegisterButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(72, 72, 72);
            PasswordTextBox.BorderColor = Color.FromArgb(33, 33, 33);
            PasswordTextBox.BorderFocusColor = Color.FromArgb(255, 106, 0);
            PasswordTextBox.BorderSize = 2;
            PasswordTextBox.Content = "";
            PasswordTextBox.Cursor = Cursors.IBeam;
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextBox.ForeColor = Color.Gray;
            PasswordTextBox.Location = new Point(45, 182);
            PasswordTextBox.Margin = new Padding(4);
            PasswordTextBox.Multiline = false;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Padding = new Padding(15, 15, 15, 0);
            PasswordTextBox.PasswordChar = true;
            PasswordTextBox.PlaceholderColor = Color.FromArgb(33, 33, 33);
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Rounding = 20;
            PasswordTextBox.Size = new Size(210, 45);
            PasswordTextBox.TabIndex = 10;
            PasswordTextBox.TextOffset = new Size(0, 0);
            PasswordTextBox.UnderlinedStyle = false;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = Color.FromArgb(72, 72, 72);
            UsernameTextBox.BorderColor = Color.FromArgb(33, 33, 33);
            UsernameTextBox.BorderFocusColor = Color.FromArgb(255, 106, 0);
            UsernameTextBox.BorderSize = 2;
            UsernameTextBox.Content = "";
            UsernameTextBox.Cursor = Cursors.IBeam;
            UsernameTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTextBox.ForeColor = Color.Gray;
            UsernameTextBox.Location = new Point(45, 114);
            UsernameTextBox.Margin = new Padding(4);
            UsernameTextBox.Multiline = false;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Padding = new Padding(15, 15, 15, 0);
            UsernameTextBox.PasswordChar = false;
            UsernameTextBox.PlaceholderColor = Color.FromArgb(33, 33, 33);
            UsernameTextBox.PlaceholderText = "Username";
            UsernameTextBox.Rounding = 20;
            UsernameTextBox.Size = new Size(210, 45);
            UsernameTextBox.TabIndex = 9;
            UsernameTextBox.TextOffset = new Size(0, 0);
            UsernameTextBox.UnderlinedStyle = false;
            // 
            // UserTypeListBox
            // 
            UserTypeListBox.BackgroundColor = Color.FromArgb(10, 10, 10);
            UserTypeListBox.ButtonHoverBackground = Color.FromArgb(200, 255, 106, 0);
            UserTypeListBox.ButtonHoverOutline = Color.FromArgb(255, 106, 0);
            UserTypeListBox.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            UserTypeListBox.ButtonNormalOutline = Color.FromArgb(255, 106, 0);
            UserTypeListBox.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            UserTypeListBox.ButtonPressedOutline = Color.FromArgb(255, 106, 0);
            UserTypeListBox.Cursor = Cursors.Hand;
            UserTypeListBox.DropDownBackgroundColor = Color.FromArgb(14, 14, 14);
            UserTypeListBox.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            UserTypeListBox.ExpandArrowColor = Color.White;
            UserTypeListBox.ForeColor = SystemColors.Control;
            UserTypeListBox.Items = new string[]
    {
    "Admin",
    "Client"
    };
            UserTypeListBox.Location = new Point(75, 243);
            UserTypeListBox.Margin = new Padding(4, 3, 4, 3);
            UserTypeListBox.Name = "UserTypeListBox";
            UserTypeListBox.OutlineColor = Color.FromArgb(35, 255, 255, 255);
            UserTypeListBox.OutlineThickness = 1F;
            UserTypeListBox.Rounding = 0;
            UserTypeListBox.Size = new Size(147, 39);
            UserTypeListBox.TabIndex = 14;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 72, 72);
            ClientSize = new Size(300, 400);
            Controls.Add(UserTypeListBox);
            Controls.Add(Logo);
            Controls.Add(CloseButton);
            Controls.Add(MinimizeButton);
            Controls.Add(panel1);
            Controls.Add(RegisteredRedirectLabel);
            Controls.Add(RegisteredLabel);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CuoreUI.Controls.cuiPictureBox Logo;
        private CuoreUI.Controls.cuiButton MinimizeButton;
        private CuoreUI.Controls.cuiButton CloseButton;
        private CuoreUI.Controls.cuiLabel RegisteredRedirectLabel;
        private CuoreUI.Controls.cuiLabel RegisteredLabel;
        private CuoreUI.Controls.cuiButton RegisterButton;
        private CuoreUI.Controls.cuiTextBox2 PasswordTextBox;
        private CuoreUI.Controls.cuiTextBox2 UsernameTextBox;
        private CuoreUI.Controls.cuiComboBox UserTypeListBox;
    }
}