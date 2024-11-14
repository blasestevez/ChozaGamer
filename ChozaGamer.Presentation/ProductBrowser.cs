using ChozaGamer.Business.Services;
using ChozaGamer.DataAccess.Models.DTOs;
using Microsoft.VisualBasic.ApplicationServices;

namespace ChozaGamer.Presentation
{
    public partial class ProductBrowser : Form
    {
        private readonly ProductService service;
        private List<SearchProductDTO> products;

        public ProductBrowser(ProductService service)
        {
            InitializeComponent();
            this.service = service;
            LoadProducts();
        }

        private async void LoadProducts()
        {
            products = await service.GetProducts();
            DisplayProducts(products);
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
            var filteredProducts = products.Where(x => x.name.Contains(SearchBar.Text)).ToList();
        }
    }
}
