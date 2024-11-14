using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Models.DTOs
{
    public class ProductDTO
    {
        public string name { get; set; }
        public byte[] productImage { get; set; }
        public decimal defaultPrice { get; set; }
    }
}
