using ChozaGamer.Business.Services;
using ChozaGamer.DataAccess.Models.DTOs;
using Microsoft.VisualBasic.ApplicationServices;

namespace ChozaGamer.Presentation
{
    public partial class ProductBrowser : Form
    {
        private readonly ProductService productService;
        private readonly UserService userService;
        private readonly BrandService brandService;
        private readonly CategoryService categoryService;
        private readonly SubCategoryService subCategoryService;
        private List<SearchProductDTO> products;

        public ProductBrowser(ProductService productService, UserService userService, BrandService brandService, CategoryService categoryService, SubCategoryService subCategoryService)
        {
            InitializeComponent();
            this.productService = productService;
            this.userService = userService;
            this.brandService = brandService;
            this.categoryService = categoryService;
            this.subCategoryService = subCategoryService;
            LoadProducts();
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
                ProductCard productCard = new ProductCard(product);
                productCard.Dock = DockStyle.Top;
                productCard.Margin = new Padding(0, 0, 0, 10);

                flowLayoutPanel1.Controls.Add(productCard);
            }
        }
        private void ProfileButton_Click(object sender, EventArgs e)
        {
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = SearchBar.Content.Trim();

            if (products != null && products.Any() && !string.IsNullOrEmpty(searchText))
            {
                List<SearchProductDTO> filteredProducts = new List<SearchProductDTO>();

                filteredProducts = products.Where(p => p.name.ToLower().Trim().Contains(searchText.ToLower().Trim())).ToList();

                if (filteredProducts.Any())
                {
                    DisplayProducts(filteredProducts);
                }
                else
                {
                    MessageBox.Show("There are no matches.");
                    DisplayProducts(products);
                }
            }
            else
            {
                DisplayProducts(products);
            }
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
                LoginForm loginForm = new LoginForm(productService, userService, brandService, categoryService, subCategoryService);
                loginForm.Show();
            }
            this.Hide();
        }
    }
}
