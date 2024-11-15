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
    public partial class ManageItem : UserControl
    {
        private readonly SearchProductDTO? product;
        private readonly BrandDTO? brand;
        private readonly CategoryDTO? category;
        private readonly SubCategoryDTO? subCategory;
        private readonly ProductService productService;

        public ManageItem(SearchProductDTO? product, BrandDTO? brand, CategoryDTO? category, SubCategoryDTO? subCategory, ProductService productService)
        {
            InitializeComponent();
            this.product = product;
            this.brand = brand;
            this.category = category;
            this.subCategory = subCategory;
            this.productService = productService;
            CheckItem();
        }

        private void CheckItem()
        {
            if (brand != null || category != null || subCategory != null)
            {
                ProductDescriptionBar.Hide();
                ProductDefaultPriceBar.Hide();
                ProductSpecialPriceBar.Hide();
                ProductStockBar.Hide();
                ProductCodeBar.Hide();
                ProductWarrantyBar.Hide();
                ProductIvaBar.Hide();
                ProductSaleCheckBox.Hide();
            }
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

                    var response = await productService.UpdateProduct(product);

                    if (response)
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
        }
    }
}
