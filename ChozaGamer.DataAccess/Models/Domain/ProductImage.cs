using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Models.Domain
{
    public class ProductImage
    {
        public int id { get; set; }
        public byte[] image { get; set; }
        public int idProduct { get; set; }
        public Product Product { get; set; }
    }
}
