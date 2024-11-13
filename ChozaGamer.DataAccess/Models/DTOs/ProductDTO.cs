using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Models.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public string SubCategoryName { get; set; }
        public decimal SpecialPrice { get; set; }
        public decimal DefaultPrice { get; set; }
        public int Stock { get; set; }
        public string ProductCode { get; set; }
        public bool Sale { get; set; }
        public int Warranty { get; set; }
        public decimal Iva { get; set; }
    }
}
