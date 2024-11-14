﻿using ChozaGamer.DataAccess.Models.Domain;
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
    public partial class ProductCard : UserControl
    {
        private readonly SearchProductDTO product;

        public ProductCard(SearchProductDTO product)
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
            if (byteArray == null)
            {
                return null;
            }

            using(MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }
    }
}
