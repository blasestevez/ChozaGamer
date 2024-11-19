using ChozaGamer.Business.Services;
using ChozaGamer.DataAccess.Models.DTOs;
using System;
using System.Collections;
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
    public partial class ViewProduct : Form
    {
        private readonly SearchProductDTO productDTO;
        private readonly ProductService productService;

        public ViewProduct(SearchProductDTO productDTO, ProductService productService)
        {
            InitializeComponent();
            this.productDTO = productDTO;
            this.productService = productService;
            LoadProduct();
        }

        private void LoadProduct()
        {
            //ProductImage.Content = ConvertByteToImage(productDTO.productImage);
            ProductName.Content = productDTO.name;
            ProductDescription.Content = productDTO.description;
            ProductBrand.Content = productDTO.brandName ?? "marca";
            ProductCategory.Content = productDTO.categoryName;
            ProductSubCategory.Content = productDTO.subCategoryName;
            if (productDTO.stock > 0)
            {
                ProductStock.Content = "In stock";
            }
            else
            {
                ProductStock.Content = "Out of stock";
            }
            ProductWarranty.Content = productDTO.warranty.ToString() + " months";
            if (productDTO.sale)
            {
                ProductPrice.Content = "$" + productDTO.specialPrice.ToString();
            }
            else
            {
                ProductPrice.Content = "$" + productDTO.defaultPrice.ToString();
            }
        }

        private Image ConvertByteToImage(byte[] productImage)
        {
            if (productImage == null || productImage.Length == 0)
            {
                Console.WriteLine("El byte array está vacío o es nulo.");
                return null;
            }

            try
            {
                if (productImage.Length > 50 * 1024 * 1024) // Limitar tamaño (50 MB en este ejemplo)
                {
                    Console.WriteLine("La imagen es demasiado grande para cargarla.");
                    return null;
                }

                using (MemoryStream memoryStream = new MemoryStream(productImage))
                {
                    return Image.FromStream(memoryStream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al convertir byte array a imagen: {ex.Message}");
                return null;
            }
        }


        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BuyButton_Click(object sender, EventArgs e)
        {
            productDTO.stock -= 1;

            var updateResponse = await productService.UpdateProduct(productDTO);

            if (updateResponse)
            {
                MessageBox.Show("Product bought successfully.");
            }
            else
            {
                MessageBox.Show("Error buying product.");
            }
        }
    }
}
