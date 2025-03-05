using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.DataAccess.Models.Domain
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public int? idCategory { get; set; }
        public int? idBrand { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? specialPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal defaultPrice { get; set; }
        public int? idSubCategory { get; set; }
        public int? stock { get; set; }
        public string? productCode { get; set; }
        public byte[]? productImage { get; set; }
        public bool? sale { get; set; }
        public int? warranty { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal? iva { get; set; }
        public Category? Category { get; set; }
        public Brand? Brand { get; set; }
        public SubCategory? SubCategory { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

        public void ModifyStock(int quantity)
        {
            stock = quantity;
        }

        public void ModifyPrice(decimal price)
        {
            defaultPrice = price;
        }

        public void ModifySpecialPrice(decimal price)
        {
            specialPrice = price;
        }

        public decimal CalculatePrice()
        {
            decimal finalIva = iva ?? 0;
            decimal finalPrice = defaultPrice + (defaultPrice * finalIva);
            return finalPrice;
        }

        public Product()
        {
        }

        public Product(int id, string name, string description, int idCategory, int idBrand, byte[] productImage, decimal specialPrice, decimal defaultPrice, int idSubCategory, int stock, string productCode, bool sale, int warranty, decimal iva)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.idCategory = idCategory;
            this.idBrand = idBrand;
            this.productImage = productImage;
            this.specialPrice = specialPrice;
            this.defaultPrice = defaultPrice;
            this.idSubCategory = idSubCategory;
            this.stock = stock;
            this.productCode = productCode;
            this.sale = sale;
            this.warranty = warranty;
            this.iva = iva;
        }
    }
}
