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
    public partial class AddProductForm : Form
    {
        private readonly ProductService productService;
        private readonly BrandService brandService;
        private readonly CategoryService categoryService;
        private readonly SubCategoryService subCategoryService;
        private List<BrandDTO> brands = new List<BrandDTO>();
        private List<CategoryDTO> categories = new List<CategoryDTO>();
        private List<SubCategoryDTO> subCategories = new List<SubCategoryDTO>();
        private SearchProductDTO product = new SearchProductDTO();

        public AddProductForm(ProductService productService, BrandService brandService, CategoryService categoryService, SubCategoryService subCategoryService)
        {
            InitializeComponent();
            this.productService = productService;
            this.brandService = brandService;
            this.categoryService = categoryService;
            this.subCategoryService = subCategoryService;

            FillComboBoxes();
        }

        private async void FillComboBoxes()
        {
            await GetBrands();
            var nonNullBrands = brands.Where(x => x.name != null).Select(x => x.name).ToArray();
            BrandsComboBox.Items.AddRange(nonNullBrands);
            var nonNullCategories = categories.Where(x => x.name != null).Select(x => x.name).ToArray();
            CategoriesComboBox.Items.AddRange(nonNullCategories);
            var nonNullSubCategories = subCategories.Where(x => x.name != null).Select(x => x.name).ToArray();
            SubCategoriesComboBox.Items.AddRange(nonNullSubCategories);
        }

        private async Task GetBrands()
        {
            brands = await brandService.GetBrands();
            await GetCategories();
        }

        private async Task GetCategories()
        {
            categories = await categoryService.GetCategories();
            await GetSubCategories();
        }

        private async Task GetSubCategories()
        {
            subCategories = await subCategoryService.GetSubCategories();
        }

        private void ChangeProductImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.Title = "Select an image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        Image selectedImage = Image.FromFile(filePath);
                        pictureBox1.Image = selectedImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }
        private byte[] ConvertImageToByte(Image image)
        {
            if (image == null)
            {
                return null;
            }

            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, image.RawFormat);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting image to byte: " + ex.Message);
                return null;
            }
        }

        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBar.Content))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            if (string.IsNullOrEmpty(ProductDescriptionBar.Content))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }
            if (string.IsNullOrEmpty(ProductDefaultPriceBar.Content))
            {
                MessageBox.Show("Please enter a default price.");
                return;
            }
            if (string.IsNullOrEmpty(ProductSpecialPriceBar.Content))
            {
                MessageBox.Show("Please enter a special price.");
                return;
            }
            if (string.IsNullOrEmpty(ProductStockBar.Content))
            {
                MessageBox.Show("Please enter a stock.");
                return;
            }
            if(string.IsNullOrEmpty(ProductCodeBar.Content))
            {
                MessageBox.Show("Please enter a product code.");
                return;
            }
            if (string.IsNullOrEmpty(ProductIvaBar.Content))
            {
                MessageBox.Show("Please enter an IVA.");
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }
            try
            {
                product.name = NameBar.Content;
                product.description = ProductDescriptionBar.Content;
                product.defaultPrice = Convert.ToDecimal(ProductDefaultPriceBar.Content);
                product.specialPrice = Convert.ToDecimal(ProductSpecialPriceBar.Content);
                product.stock = Convert.ToInt32(ProductStockBar.Content);
                product.brandName = BrandsComboBox.SelectedItem.ToString();
                product.categoryName = CategoriesComboBox.SelectedItem.ToString();
                product.subCategoryName = SubCategoriesComboBox.SelectedItem.ToString();
                product.idBrand = brands.FirstOrDefault(x => x.name == BrandsComboBox.SelectedItem.ToString()).id;
                product.idCategory = categories.FirstOrDefault(x => x.name == CategoriesComboBox.SelectedItem.ToString()).id;
                product.idSubCategory = subCategories.FirstOrDefault(x => x.name == SubCategoriesComboBox.SelectedItem.ToString()).id;
                product.productCode = ProductCodeBar.Content;

                if (BrandsComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a category.");
                    return;
                }
                if (CategoriesComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("select a category.");
                    return;
                }
                if (SubCategoriesComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("select a subcategory.");
                    return;
                }
                var selectedBrand = brands.FirstOrDefault(x => x.name == BrandsComboBox.SelectedItem.ToString());
                product.warranty = brands.Where(x => x.name == BrandsComboBox.SelectedItem?.ToString())
                                        .Select(x => x.warranty)
                                        .FirstOrDefault();
                product.iva = Convert.ToDecimal(ProductIvaBar.Content);
                product.sale = ProductSaleCheckBox.Checked;
                product.productImage = ConvertImageToByte(pictureBox1.Image);

                var productResponse = await productService.UploadProduct(product);

                if (productResponse)
                {
                    MessageBox.Show("Product updated successfully.");
                }
                else
                {
                    MessageBox.Show("Error updating product.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubCategoriesComboBox.Items.Clear();

            var selectedCategory = CategoriesComboBox.SelectedItem?.ToString();

            if (selectedCategory != null)
            {
                var categoryId = categories.FirstOrDefault(x => x.name == selectedCategory)?.id;

                if (categoryId.HasValue)
                {
                    var filteredSubCategories = subCategories
                        .Where(x => x.idCategory == categoryId)
                        .Select(x => x.name)
                        .ToArray();

                    SubCategoriesComboBox.Items.AddRange(filteredSubCategories);
                }
            }
        }
    }
}
