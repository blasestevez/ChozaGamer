using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Models.Domain
{
    public class SubCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public int idCategory { get; set; }
        public Category Category { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
