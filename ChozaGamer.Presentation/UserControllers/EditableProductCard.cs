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
    public partial class EditableProductCard : UserControl
    {
        private readonly SearchProductDTO product;
        public event EventHandler EditButtonClicked;
        public event EventHandler DeleteButtonClicked;
        public EditableProductCard(SearchProductDTO product)
        {
            InitializeComponent();
            this.product = product;
            productName = product.name;
            productPrice = "$" + product.defaultPrice.ToString();
            productImage = ConvertByteToImage(product.productImage);
        }
        public string productName
        {
            set { ProductCardProdName.Text = value; }
        }

        public string productPrice
        {
            set { ProductCardProdPrice.Text = value; }
        }

        public Image productImage
        {
            set { ProductCardImage.Image = value; }
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

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
