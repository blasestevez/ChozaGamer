using ChozaGamer.Business.Services;
using ChozaGamer.DataAccess.Models.Domain;
using ChozaGamer.DataAccess.Models.DTOs;
using ChozaGamer.Presentation.UserControllers;
using ChozaGamer.Presentation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChozaGamer.Presentation
{
    public partial class AdminPanel : Form
    {
        private readonly ProductService productService;
        private readonly UserService userService;
        private readonly BrandService brandService;
        private readonly CategoryService categoryService;
        private readonly SubCategoryService subCategoryService;
        private readonly InvoiceService invoiceService;
        private List<SearchProductDTO> products;
        private List<BrandDTO> brands;
        private List<CategoryDTO> categories;
        private List<SubCategoryDTO> subCategories;

        public AdminPanel(ProductService productService, UserService userService, BrandService brandService, CategoryService categoryService, SubCategoryService subCategoryService, InvoiceService invoiceService)
        {
            InitializeComponent();
            this.productService = productService;
            this.userService = userService;
            this.brandService = brandService;
            this.categoryService = categoryService;
            this.subCategoryService = subCategoryService;
            this.invoiceService = invoiceService;
            LoadBrands();
            LoadProducts();
            LoadCategories();
            LoadSubCategories();

            ManageItemPanel.Hide();
        }

        private async Task LoadBrands()
        {
            brands = await brandService.GetBrands();
        }

        private async Task LoadProducts()
        {
            products = await productService.GetProducts();
        }

        private async Task LoadCategories()
        {
            categories = await categoryService.GetCategories();
        }

        private async Task LoadSubCategories()
        {
            subCategories = await subCategoryService.GetSubCategories();
        }

        private void DisplayProducts(List<SearchProductDTO> products)
        {
            ItemsPanel.Controls.Clear();
            if (products == null || !products.Any())
            {
                Label noProductsLabel = new Label
                {
                    Text = "No hay productos disponibles.",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                ItemsPanel.Controls.Add(noProductsLabel);
                return;
            }

            foreach (var product in products)
            {
                EditableProductCard selectableProductCard = new EditableProductCard(product);
                selectableProductCard.Dock = DockStyle.Top;
                selectableProductCard.Margin = new Padding(0, 0, 0, 10);

                selectableProductCard.DeleteButtonClicked += async (s, e) =>
                {
                    var response = await productService.DeleteProduct(product.id);
                    if (response)
                    {
                        MessageBox.Show("Producto eliminado exitosamente.");
                        LoadProducts();
                    }
                };
                selectableProductCard.EditButtonClicked += (s, e) =>
                {
                    ManageProduct(product);
                };
                ItemsPanel.Controls.Add(selectableProductCard);
            }
            AddButton addButton = new AddButton();
            ItemsPanel.Controls.Add(addButton);
            addButton.OpenAddFormButtonClick += (s, e) =>
            {
                AddProductForm addProductForm = new AddProductForm(productService, brandService, categoryService, subCategoryService);
                addProductForm.Show();
            };
        }

        private void DisplayBrands(List<BrandDTO> brands)
        {
            ItemsPanel.Controls.Clear();

            if (brands == null || !brands.Any())
            {
                Label noBrandsLabel = new Label
                {
                    Text = "No hay marcas disponibles.",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                ItemsPanel.Controls.Add(noBrandsLabel);
                return;
            }

            foreach (var brand in brands)
            {
                EditableBrandCard selectableBrandCard = new EditableBrandCard(brand);
                selectableBrandCard.Dock = DockStyle.Top;
                selectableBrandCard.Margin = new Padding(0, 0, 0, 10);

                selectableBrandCard.DeleteButtonClicked += async (s, e) =>
                {
                    var response = await brandService.DeleteBrand(brand.id);
                    if (response)
                    {
                        MessageBox.Show("Marca eliminada exitosamente.");
                        LoadBrands();
                    }
                };
                selectableBrandCard.EditButtonClicked += (s, e) =>
                {
                    ManageBrand(brand);
                };
                ItemsPanel.Controls.Add(selectableBrandCard);
            }
            AddButton addButton = new AddButton();
            ItemsPanel.Controls.Add(addButton);
            addButton.OpenAddFormButtonClick += (s, e) =>
            {
                AddBrandForm addBrandForm = new AddBrandForm(brandService);
                addBrandForm.Show();
            };
        }

        private void DisplayCategories(List<CategoryDTO> categories)
        {
            ItemsPanel.Controls.Clear();

            if (categories == null || !categories.Any())
            {
                Label noCategoriesLabel = new Label
                {
                    Text = "No hay categorías disponibles.",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                ItemsPanel.Controls.Add(noCategoriesLabel);
                return;
            }

            foreach (var category in categories)
            {
                EditableCategoryCard selectableCategoryCard = new EditableCategoryCard(category);
                selectableCategoryCard.Dock = DockStyle.Top;
                selectableCategoryCard.Margin = new Padding(0, 0, 0, 10);

                selectableCategoryCard.DeleteButtonClicked += async (s, e) =>
                {
                    var response = await categoryService.DeleteCategory(category.id);
                    if (response)
                    {
                        MessageBox.Show("Categoría eliminada exitosamente.");
                        LoadCategories();
                    }
                };
                selectableCategoryCard.EditButtonClicked += (s, e) =>
                {
                    ManageCategory(category);
                };
                ItemsPanel.Controls.Add(selectableCategoryCard);
            }
            AddButton addButton = new AddButton();
            ItemsPanel.Controls.Add(addButton);
            addButton.OpenAddFormButtonClick += (s, e) =>
            {
                AddCategoryForm addCategoryForm = new AddCategoryForm(categoryService);
                addCategoryForm.Show();
            };
        }

        private void DisplaySubCategories(List<SubCategoryDTO> subCategories)
        {
            ItemsPanel.Controls.Clear();

            if (subCategories == null || !subCategories.Any())
            {
                Label noSubCategoriesLabel = new Label
                {
                    Text = "No hay subcategorías disponibles.",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                ItemsPanel.Controls.Add(noSubCategoriesLabel);
                return;
            }

            foreach (var subCategory in subCategories)
            {
                EditableSubCategoryCard selectableSubCategoryCard = new EditableSubCategoryCard(subCategory);
                selectableSubCategoryCard.Dock = DockStyle.Top;
                selectableSubCategoryCard.Margin = new Padding(0, 0, 0, 10);

                selectableSubCategoryCard.DeleteButtonClicked += async (s, e) =>
                {
                    var response = await subCategoryService.DeleteSubCategory(subCategory.id);
                    if (response)
                    {
                        MessageBox.Show("Subcategoría eliminada exitosamente.");
                        LoadSubCategories();
                    }
                };
                selectableSubCategoryCard.EditButtonClicked += (s, e) =>
                {
                    ManageSubCategory(subCategory);
                };
                ItemsPanel.Controls.Add(selectableSubCategoryCard);
            }
            AddButton addButton = new AddButton();
            ItemsPanel.Controls.Add(addButton);
            addButton.OpenAddFormButtonClick += (s, e) =>
            {
                AddSubCategoryForm addSubCategoryForm = new AddSubCategoryForm(subCategoryService, categoryService);
                addSubCategoryForm.Show();
            };
        }

        private void ManageBrand(BrandDTO brand)
        {
            ManageItem manageBrand = new ManageItem(null, brand, null, null, productService, brandService, categoryService, subCategoryService);
            ItemsPanel.Hide();
            ManageItemPanel.Show();
            ManageItemPanel.Controls.Add(manageBrand);
            manageBrand.ProductUpdated += ManageItem_ProductUpdated;
            manageBrand.CloseButtonClicked += (s, e) =>
            {
                ItemsPanel.Show();
                ManageItemPanel.Controls.Clear();
                ManageItemPanel.Hide();
            };
        }

        private void ManageProduct(SearchProductDTO productDTO)
        {
            ManageItem manageProduct = new ManageItem(productDTO, null, null, null, productService, brandService, categoryService, subCategoryService);
            ItemsPanel.Hide();
            ManageItemPanel.Show();
            ManageItemPanel.Controls.Add(manageProduct);

            manageProduct.ProductUpdated += ManageItem_ProductUpdated;
            manageProduct.CloseButtonClicked += (s, e) =>
            {
                ItemsPanel.Show();
                ManageItemPanel.Controls.Clear();
                ManageItemPanel.Hide();
            };
        }

        private void ManageCategory(CategoryDTO category)
        {
            ManageItem manageCategory = new ManageItem(null, null, category, null, productService, brandService, categoryService, subCategoryService);
            ItemsPanel.Hide();
            ManageItemPanel.Show();
            ManageItemPanel.Controls.Add(manageCategory);
            manageCategory.ProductUpdated += ManageItem_ProductUpdated;
            manageCategory.CloseButtonClicked += (s, e) =>
            {
                ItemsPanel.Show();
                ManageItemPanel.Controls.Clear();
                ManageItemPanel.Hide();
            };
        }

        private void ManageSubCategory(SubCategoryDTO subCategory)
        {
            ManageItem manageSubCategory = new ManageItem(null, null, null, subCategory, productService, brandService, categoryService, subCategoryService);
            ItemsPanel.Hide();
            ManageItemPanel.Show();
            ManageItemPanel.Controls.Add(manageSubCategory);
            manageSubCategory.ProductUpdated += ManageItem_ProductUpdated;
            manageSubCategory.CloseButtonClicked += (s, e) =>
            {
                ItemsPanel.Show();
                ManageItemPanel.Controls.Clear();
                ManageItemPanel.Hide();
            };
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
                UserSession.Logout();
            }
            else
            {
                LoginForm loginForm = new LoginForm(productService, userService, brandService, categoryService, subCategoryService, invoiceService);
                UserSession.Logout();
                loginForm.Show();
            }
            this.Hide();
        }

        private async void ManageProductsButton_Click(object sender, EventArgs e)
        {
            await LoadProducts();
            DisplayProducts(products);
        }

        private async void ManageBrandsButton_Click(object sender, EventArgs e)
        {
            await LoadBrands();
            ItemsPanel.Show();
            DisplayBrands(brands);
        }

        private async void ManageCategoriesButton_Click(object sender, EventArgs e)
        {
            await LoadCategories();
            ItemsPanel.Show();
            DisplayCategories(categories);
        }

        private async void ManagesSubcategoriesButton_Click(object sender, EventArgs e)
        {
            await LoadSubCategories();
            ItemsPanel.Show();
            DisplaySubCategories(subCategories);
        }

        private void ManageItem_ProductUpdated(object sender, EventArgs e)
        {
            ItemsPanel.Show();
            ManageItemPanel.Controls.Clear();
            ManageItemPanel.Hide();
            LoadProducts();
            LoadCategories();
            LoadSubCategories();
        }
    }
}
