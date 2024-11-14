using ChozaGamer.Business.Services;
using ChozaGamer.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChozaGamer.Presentation
{
    public partial class RegisterForm : Form
    {
        private readonly ProductService productService;
        private readonly UserService userService;

        public RegisterForm(ProductService productService, UserService userService)
        {
            InitializeComponent();
            this.productService = productService;
            this.userService = userService;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterUserDTO registerUserDTO = new RegisterUserDTO
            {
                username = UsernameTextBox.Content,
                password = PasswordTextBox.Content,
                userType = false
            };

            var response =  await userService.RegisterUserAsync(registerUserDTO);
            if (!response)
            {
                MessageBox.Show("Error trying to register. Check the credentials.");
            }
            else
            {
                MessageBox.Show("User registered successfully.");
            }
            LoginForm loginForm = new LoginForm(productService, userService);
            loginForm.Show();
            this.Close();
        }

        private void RegisteredRedirectLabel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(productService, userService);
            loginForm.Show();
            this.Close();
        }
    }
}
