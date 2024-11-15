using ChozaGamer.DataAccess.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Models.DTOs
{
    public class BrandDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int warranty { get; set; }
        public List<SearchProductDTO> Products { get; set; } = new List<SearchProductDTO>();
    }
}
