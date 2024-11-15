using ChozaGamer.Business.Services;
using ChozaGamer.DataAccess.Models.Domain;
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
    public partial class AdminPanel : Form
    {
        private readonly ProductService productService;
        private readonly UserService userService;
        private List<SearchProductDTO> products;

        public AdminPanel(ProductService productService, UserService userService)
        {
            InitializeComponent();
            this.productService = productService;
            this.userService = userService;
            LoadProducts();
            ManageProductPanel.Hide();
        }

        private async void LoadProducts()
        {
            products = await productService.GetProducts();
            if (products == null || !products.Any())
            {
                Console.WriteLine("No se cargaron productos.");
            }
            else
            {
                Console.WriteLine("Productos cargados exitosamente.");
                DisplayProducts(products);
            }
        }

        private void DisplayProducts(List<SearchProductDTO> products)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var product in products)
            {
                SelectableProductCard selectableProductCard = new SelectableProductCard(product, false);
                selectableProductCard.Dock = DockStyle.Top;
                selectableProductCard.Margin = new Padding(0, 0, 0, 10);

                flowLayoutPanel1.Controls.Add(selectableProductCard);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm existingLoginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();

            if (existingLoginForm != null && !existingLoginForm.IsDisposed)
            {
                existingLoginForm.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm(productService, userService);
                loginForm.Show();
            }
            this.Hide();
        }

        private void ManageProductsButton_Click(object sender, EventArgs e)
        {
            ManageProduct();
        }

        private void ManageProduct()
        {
            var selectedProduct = flowLayoutPanel1.Controls.OfType<SelectableProductCard>().FirstOrDefault();
            ManageItem manageItem = new ManageItem(products[0], null, null, null, productService);
            flowLayoutPanel1.Hide();
            ManageProductPanel.Show();
            ManageProductPanel.Controls.Add(manageItem);

            manageItem.ProductUpdated += ManageItem_ProductUpdated;
        }

        private void ManageItem_ProductUpdated(object sender, EventArgs e)
        {
            flowLayoutPanel1.Show();
            ManageProductPanel.Controls.Clear();
            ManageProductPanel.Hide();
            LoadProducts();
        }
    }
}
