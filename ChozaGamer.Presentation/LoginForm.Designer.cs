namespace ChozaGamer.Presentation
{
    partial class LoginForm
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
            UsernameTextBox = new CuoreUI.Controls.cuiTextBox2();
            PasswordTextBox = new CuoreUI.Controls.cuiTextBox2();
            LoginButton = new CuoreUI.Controls.cuiButton();
            NotRegisteredLabel = new CuoreUI.Controls.cuiLabel();
            NotRegisteredRedirectLabel = new CuoreUI.Controls.cuiLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(MinimizeButton);
            panel1.Controls.Add(CloseButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 90);
            panel1.TabIndex = 2;
            // 
            // Logo
            // 
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
            UsernameTextBox.Location = new Point(45, 144);
            UsernameTextBox.Margin = new Padding(4);
            UsernameTextBox.Multiline = false;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Padding = new Padding(15, 15, 15, 0);
            UsernameTextBox.PasswordChar = false;
            UsernameTextBox.PlaceholderColor = Color.FromArgb(33, 33, 33);
            UsernameTextBox.PlaceholderText = "Username";
            UsernameTextBox.Rounding = 20;
            UsernameTextBox.Size = new Size(210, 45);
            UsernameTextBox.TabIndex = 3;
            UsernameTextBox.TextOffset = new Size(0, 0);
            UsernameTextBox.UnderlinedStyle = false;
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
            PasswordTextBox.Location = new Point(45, 212);
            PasswordTextBox.Margin = new Padding(4);
            PasswordTextBox.Multiline = false;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Padding = new Padding(15, 15, 15, 0);
            PasswordTextBox.PasswordChar = true;
            PasswordTextBox.PlaceholderColor = Color.FromArgb(33, 33, 33);
            PasswordTextBox.PlaceholderText = "Password";
            PasswordTextBox.Rounding = 20;
            PasswordTextBox.Size = new Size(210, 45);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.TextOffset = new Size(0, 0);
            PasswordTextBox.UnderlinedStyle = false;
            // 
            // LoginButton
            // 
            LoginButton.CheckButton = false;
            LoginButton.Checked = false;
            LoginButton.CheckedBackground = Color.FromArgb(72, 72, 72);
            LoginButton.CheckedImageTint = Color.White;
            LoginButton.CheckedOutline = Color.FromArgb(72, 72, 72);
            LoginButton.Content = "Login";
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            LoginButton.ForeColor = Color.White;
            LoginButton.HoverBackground = Color.FromArgb(33, 33, 33);
            LoginButton.HoveredImageTint = Color.White;
            LoginButton.HoverOutline = Color.Empty;
            LoginButton.Image = null;
            LoginButton.ImageAutoCenter = true;
            LoginButton.ImageExpand = new Point(0, 0);
            LoginButton.ImageOffset = new Point(0, 0);
            LoginButton.ImageTint = Color.White;
            LoginButton.Location = new Point(75, 300);
            LoginButton.Name = "LoginButton";
            LoginButton.NormalBackground = Color.FromArgb(72, 72, 72);
            LoginButton.NormalOutline = Color.FromArgb(33, 33, 33);
            LoginButton.OutlineThickness = 2F;
            LoginButton.PressedBackground = Color.FromArgb(255, 106, 0);
            LoginButton.PressedImageTint = Color.White;
            LoginButton.PressedOutline = Color.Empty;
            LoginButton.Rounding = new Padding(8);
            LoginButton.Size = new Size(150, 45);
            LoginButton.TabIndex = 5;
            LoginButton.TextOffset = new Point(0, 0);
            LoginButton.Click += LoginButton_Click;
            // 
            // NotRegisteredLabel
            // 
            NotRegisteredLabel.Content = "Don't\\ have\\ an\\ account\\?";
            NotRegisteredLabel.ForeColor = Color.White;
            NotRegisteredLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            NotRegisteredLabel.Location = new Point(40, 351);
            NotRegisteredLabel.Margin = new Padding(4, 3, 4, 3);
            NotRegisteredLabel.Name = "NotRegisteredLabel";
            NotRegisteredLabel.Size = new Size(142, 19);
            NotRegisteredLabel.TabIndex = 6;
            // 
            // NotRegisteredRedirectLabel
            // 
            NotRegisteredRedirectLabel.BackgroundImageLayout = ImageLayout.None;
            NotRegisteredRedirectLabel.Content = "Register\\ Now\\.";
            NotRegisteredRedirectLabel.Cursor = Cursors.Hand;
            NotRegisteredRedirectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            NotRegisteredRedirectLabel.ForeColor = Color.White;
            NotRegisteredRedirectLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            NotRegisteredRedirectLabel.Location = new Point(175, 351);
            NotRegisteredRedirectLabel.Margin = new Padding(4, 3, 4, 3);
            NotRegisteredRedirectLabel.Name = "NotRegisteredRedirectLabel";
            NotRegisteredRedirectLabel.Size = new Size(88, 19);
            NotRegisteredRedirectLabel.TabIndex = 7;
            NotRegisteredRedirectLabel.Click += NotRegisteredRedirectLabel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 72, 72);
            ClientSize = new Size(300, 400);
            Controls.Add(NotRegisteredRedirectLabel);
            Controls.Add(NotRegisteredLabel);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        
        
        
        private CuoreUI.Controls.cuiTextBox2 UsernameTextBox;
        private CuoreUI.Controls.cuiPictureBox Logo;
        private CuoreUI.Controls.cuiButton MinimizeButton;
        private CuoreUI.Controls.cuiButton CloseButton;
        private CuoreUI.Controls.cuiTextBox2 PasswordTextBox;
        private CuoreUI.Controls.cuiButton LoginButton;
        private CuoreUI.Controls.cuiLabel NotRegisteredLabel;
        private CuoreUI.Controls.cuiLabel NotRegisteredRedirectLabel;
    }
}