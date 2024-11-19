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
            GetItems();
            FillComboBoxes();
        }

        private async void FillComboBoxes()
        {
            await GetItems();
            foreach (var brand in brands)
            {
            BrandsComboBox.AddItem(brand.name);
            }
            //foreach (var category in categories)
            //{
            //    CategoryComboBox.AddItem(category.name);
            //}
            //foreach (var subCategory in subCategories)
            //{
            //    SubCategoryComboBox.AddItem(subCategory.name);
            //}
        }

        private async Task GetItems()
        {
            categories = await categoryService.GetCategories();
            brands = await brandService.GetBrands();
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
        private Image ConvertByteToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                return null;
            }

            try
            {
                using (MemoryStream memoryStream = new MemoryStream(byteArray))
                {
                    memoryStream.Position = 0;
                    return Image.FromStream(memoryStream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting byte array to image: {ex.Message}");
                Console.WriteLine($"Byte array length: {byteArray.Length}");
                return null;
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
            try
            {
                product.name = NameBar.Content;
                product.description = ProductDescriptionBar.Content;
                product.defaultPrice = Convert.ToDecimal(ProductDefaultPriceBar.Content);
                product.specialPrice = Convert.ToDecimal(ProductSpecialPriceBar.Content);
                product.stock = Convert.ToInt32(ProductStockBar.Content);
                product.productCode = ProductCodeBar.Content;

                if (BrandsComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a category.");
                    return;
                }
                //if (CategoryComboBox.SelectedIndex == -1)
                //{
                //    MessageBox.Show("Select a category.");
                //    return;
                //}
                //if (SubCategoryComboBox.SelectedIndex == -1)
                //{
                //    MessageBox.Show("Select a subcategory.");
                //    return;
                //}
                var selectedBrand = brands.FirstOrDefault(x => x.name == BrandsComboBox.SelectedItem.ToString());
                //product.brandName = selectedBrand.name;
                //product.categoryName = categories.FirstOrDefault(x => x.name == CategoryComboBox.SelectedItem.ToString()).name;
                //product.subCategoryName = subCategories.FirstOrDefault(x => x.name == SubCategoryComboBox.SelectedItem.ToString()).name;
                product.warranty =  brands.Where(x => x.name == BrandsComboBox.SelectedItem?.ToString())
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
    }
}
