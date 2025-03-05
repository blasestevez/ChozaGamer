using OverclockStore.Business.Services;
using OverclockStore.DataAccess.Models.DTOs;
using OverclockStore.Presentation.Utils;
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

namespace OverclockStore.Presentation
{
    public partial class ViewProduct : Form
    {
        private readonly SearchProductDTO productDTO;
        private readonly ProductService productService;
        private readonly InvoiceService invoiceService;
        private InvoiceDTO invoice = new InvoiceDTO();
        public ViewProduct(SearchProductDTO productDTO, ProductService productService, InvoiceService invoiceService)
        {
            InitializeComponent();
            this.productDTO = productDTO;
            this.productService = productService;
            this.invoiceService = invoiceService;
            LoadProduct();
        }

        private void LoadProduct()
        {
            var image = ConvertByteToImage(productDTO.productImage);
            if (image != null)
            {
                ProductImage.Image = image;
            }
            else
            {
                Console.WriteLine("No se pudo cargar la imagen.");
            }
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
            if (productDTO.stock <= 0)
            {
                MessageBox.Show("Product out of stock.");
                return;
            }
            else
            {
                productDTO.stock -= 1;

                var updateResponse = await productService.UpdateProduct(productDTO);

                if (updateResponse)
                {
                    MessageBox.Show("Product bought successfully.");
                    invoice.idProduct = productDTO.id;
                    invoice.idUser = UserSession.userId;
                    invoice.date = DateTime.Now;
                    await invoiceService.CreateInvoice(invoice);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error buying product.");
                }

            }
        }
    }
}
