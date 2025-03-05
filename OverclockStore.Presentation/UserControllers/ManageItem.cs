using OverclockStore.Business.Services;
using OverclockStore.DataAccess.Models.Domain;
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
    public partial class ManageItem : UserControl
    {
        private readonly SearchProductDTO? product;
        private readonly BrandDTO? brand;
        private readonly CategoryDTO? category;
        private readonly SubCategoryDTO? subCategory;
        private readonly ProductService productService;
        private readonly BrandService brandService;
        private readonly CategoryService categoryService;
        private readonly SubCategoryService subCategoryService;

        public event EventHandler CloseButtonClicked;

        public ManageItem(SearchProductDTO? product, BrandDTO? brand, CategoryDTO? category, SubCategoryDTO? subCategory, ProductService productService, BrandService brandService, CategoryService categoryService, SubCategoryService subCategoryService)
        {
            InitializeComponent();
            this.product = product;
            this.brand = brand;
            this.category = category;
            this.subCategory = subCategory;
            this.productService = productService;
            this.brandService = brandService;
            this.categoryService = categoryService;
            this.subCategoryService = subCategoryService;
            CheckItem();
        }

        private void CheckItem()
        {
            if (product != null)
            {
                NameBar.Content = product.name;
                ProductDescriptionBar.Content = product.description;
                ProductDefaultPriceBar.Content = product.defaultPrice.ToString();
                ProductSpecialPriceBar.Content = product.specialPrice.ToString();
                ProductStockBar.Content = product.stock.ToString();
                ProductCodeBar.Content = product.productCode;
                ProductWarrantyBar.Content = product.warranty.ToString();
                ProductIvaBar.Content = product.iva.ToString();
                ProductSaleCheckBox.Checked = product.sale;

                pictureBox1.Image = ConvertByteToImage(product.productImage);
            }

            if (brand != null)
            {
                ProductDescriptionBar.Hide();
                ProductDefaultPriceBar.Hide();
                ProductSpecialPriceBar.Hide();
                ProductStockBar.Hide();
                ProductCodeBar.Hide();
                ProductIvaBar.Hide();
                ProductSaleCheckBox.Hide();
                ChangeProductImageButton.Hide();

                NameBar.Content = brand.name;
                ProductWarrantyBar.Content = brand.warranty.ToString();
            }

            if (category != null)
            {
                ProductDescriptionBar.Hide();
                ProductDefaultPriceBar.Hide();
                ProductSpecialPriceBar.Hide();
                ProductStockBar.Hide();
                ProductCodeBar.Hide();
                ProductWarrantyBar.Hide();
                ProductIvaBar.Hide();
                ProductSaleCheckBox.Hide();
                ChangeProductImageButton.Hide();

                NameBar.Content = category.name;
            }

            if (subCategory != null)
            {
                ProductDescriptionBar.Hide();
                ProductDefaultPriceBar.Hide();
                ProductSpecialPriceBar.Hide();
                ProductStockBar.Hide();
                ProductCodeBar.Hide();
                ProductWarrantyBar.Hide();
                ProductIvaBar.Hide();
                ProductSaleCheckBox.Hide();
                ChangeProductImageButton.Hide();

                NameBar.Content = subCategory.name;
            }
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

        public event EventHandler ProductUpdated;
        private async void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (product != null)
            {
                try
                {
                    product.name = NameBar.Content;
                    product.description = ProductDescriptionBar.Content;
                    product.defaultPrice = Convert.ToDecimal(ProductDefaultPriceBar.Content);
                    product.specialPrice = Convert.ToDecimal(ProductSpecialPriceBar.Content);
                    product.stock = Convert.ToInt32(ProductStockBar.Content);
                    product.productCode = ProductCodeBar.Content;
                    product.warranty = Convert.ToInt32(ProductWarrantyBar.Content);
                    product.iva = Convert.ToDecimal(ProductIvaBar.Content);
                    product.sale = ProductSaleCheckBox.Checked;
                    product.productImage = ConvertImageToByte(pictureBox1.Image);

                    var productResponse = await productService.UpdateProduct(product);

                    if (productResponse)
                    {
                        MessageBox.Show("Product updated successfully.");
                        ProductUpdated?.Invoke(this, EventArgs.Empty);
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

            if (brand != null)
            {
                try
                {
                    brand.name = NameBar.Content;
                    brand.warranty = Convert.ToInt32(ProductWarrantyBar.Content);

                    var brandResponse = await brandService.UpdateBrand(brand);

                    if (brandResponse)
                    {
                        MessageBox.Show("Brand updated successfully.");
                        ProductUpdated?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Error updating brand.");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            if (category != null)
            {
                try
                {
                    category.name = NameBar.Content;
                    var categoryResponse = await categoryService.UpdateCategory(category);
                    if (categoryResponse)
                    {
                        MessageBox.Show("Category updated successfully.");
                        ProductUpdated?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Error updating category.");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            if (subCategory != null)
            {
                try
                {
                    subCategory.name = NameBar.Content;
                    var subCategoryResponse = await subCategoryService.UpdateSubCategory(subCategory);
                    if (subCategoryResponse)
                    {
                        MessageBox.Show("Subcategory updated successfully.");
                        ProductUpdated?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Error updating subcategory.");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void ManageItem_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Dispose();
        }
    }
}