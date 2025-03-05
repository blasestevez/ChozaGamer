using ChozaGamer.Business.Services;
using ChozaGamer.DataAccess.Models.DTOs;
using ChozaGamer.Presentation.Utils;
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
    public partial class LoginForm : Form
    {
        private readonly ProductService productService;
        private readonly UserService userService;
        private readonly BrandService brandService;
        private readonly CategoryService categoryService;
        private readonly SubCategoryService subCategoryService;
        private readonly InvoiceService invoiceService;

        public LoginForm(ProductService productService, UserService userService, BrandService brandService, CategoryService categoryService, SubCategoryService subCategoryService, InvoiceService invoiceService)
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

        private void NotRegisteredRedirectLabel_Click(object sender, EventArgs e)
        {
            RegisterForm existingRegisterForm = Application.OpenForms.OfType<RegisterForm>().FirstOrDefault();

            if (existingRegisterForm != null && !existingRegisterForm.IsDisposed)
            {
                existingRegisterForm.Show();
            }
            else
            {
                RegisterForm registerForm = new RegisterForm(productService, userService, brandService, categoryService, subCategoryService, invoiceService);
                registerForm.Show();
            }
            this.Hide();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {

            LoginUserDTO loginUserDTO = new LoginUserDTO
            {
                username = UsernameTextBox.Content,
                password = PasswordTextBox.Content
            };

            var response = await userService.LoginUserAsync(loginUserDTO);
            if (!response)
            {
                MessageBox.Show("Error trying to login. Check the credentials.");
            }
            else
            {
                var user = await userService.GetUserByUsernameAsync(loginUserDTO.username);
                UserSession.userId = user.id;
                UserSession.username = user.username;
                UserSession.userType = user.userType;
                MessageBox.Show("User logged in successfully.");
                if (user.userType)
                {
                    AdminPanel existingAdminPanelForm = Application.OpenForms.OfType<AdminPanel>().FirstOrDefault();

                    if (existingAdminPanelForm != null)
                    {
                        existingAdminPanelForm.Show();
                    }
                    else
                    {
                        AdminPanel adminPanel = new AdminPanel(productService, userService, brandService, categoryService, subCategoryService, invoiceService);
                        adminPanel.Show();
                    }
                }
                else
                {
                    ProductBrowser existingProductBrowserForm = Application.OpenForms.OfType<ProductBrowser>().FirstOrDefault();

                    if (existingProductBrowserForm != null)
                    {
                        existingProductBrowserForm.Show();
                    }
                    else
                    {
                        ProductBrowser productBrowser = new ProductBrowser(productService, userService, brandService, categoryService, subCategoryService, invoiceService);
                        productBrowser.Show();
                    }
                }
                this.Hide();
            }
        }
    }
}
