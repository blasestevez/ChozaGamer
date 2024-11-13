using ChozaGamer.DataAccess.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Models.DTOs
{
    public class SearchProductDTO
    {
        public string name { get; set; }
        public string description { get; set; }
        public string categoryName { get; set; }
        public string brandName { get; set; }
        public string subCategoryName { get; set; }
        public List<byte[]> productImages { get; set; } = new List<byte[]>();
        public decimal specialPrice { get; set; }
        public decimal defaultPrice { get; set; }
        public int stock { get; set; }
        public string productCode { get; set; }
        public bool sale { get; set; }
        public int warranty { get; set; }
        public decimal iva { get; set; }
    }
}
