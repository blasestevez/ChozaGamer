using OverclockStore.Business.Services;
using OverclockStore.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverclockStore.Presentation
{
    public partial class RegisterForm : Form
    {
        private readonly ProductService productService;
        private readonly UserService userService;
        private readonly BrandService brandService;
        private readonly CategoryService categoryService;
        private readonly SubCategoryService subCategoryService;
        private readonly InvoiceService invoiceService;

        public RegisterForm(ProductService productService, UserService userService, BrandService brandService, CategoryService categoryService, SubCategoryService subCategoryService, InvoiceService invoiceService)
        {
            InitializeComponent();
            this.productService = productService;
            this.userService = userService;
            this.brandService = brandService;
            this.categoryService = categoryService;
            this.subCategoryService = subCategoryService;
            this.invoiceService = invoiceService;
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
            if (this.IsDisposed) return;

            if (UserTypeListBox.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Select a user type.");
                return;
            }

            RegisterUserDTO registerUserDTO = new RegisterUserDTO
            {
                username = UsernameTextBox.Content,
                password = PasswordTextBox.Content,
                userType = false
            };

            if (UserTypeListBox.SelectedIndex.ToString() == "0")
            {
                registerUserDTO.userType = true;
            }
            var response = await userService.RegisterUserAsync(registerUserDTO);
            if (!response)
            {
                MessageBox.Show("Error trying to register. Check the credentials.");
            }
            else
            {
                MessageBox.Show("User registered successfully.");
            }

            LoginForm existingLoginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (existingLoginForm != null && !existingLoginForm.IsDisposed)
            {
                existingLoginForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm(productService, userService, brandService, categoryService, subCategoryService, invoiceService);
                loginForm.Show();
            }
            this.Hide();
        }

        private void RegisteredRedirectLabel_Click(object sender, EventArgs e)
        {
            LoginForm existingLoginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();

            if (existingLoginForm != null && !existingLoginForm.IsDisposed)
            {
                existingLoginForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm(productService, userService, brandService, categoryService, subCategoryService, invoiceService);
                loginForm.Show();
            }
            this.Hide();
        }
    }
}
