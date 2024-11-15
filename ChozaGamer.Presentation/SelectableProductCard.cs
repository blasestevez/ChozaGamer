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
    public partial class SelectableProductCard : UserControl
    {
        private readonly SearchProductDTO product;
        private bool isSelected;

        public SelectableProductCard(SearchProductDTO product, bool isSelected)
        {
            InitializeComponent();
            this.product = product;
            this.isSelected = isSelected;
            productName = product.name;
            productPrice = "$" + product.defaultPrice.ToString();
            productImage = ConvertByteToImage(product.productImage);
        }

        private bool isSelected()
        {
            if (true)
            {

            }
            return isSelected;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isSelected = true;
            }
            else
            {
                 isSelected = false;
            }
        }
    }
}
