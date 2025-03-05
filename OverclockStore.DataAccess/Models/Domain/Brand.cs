using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.DataAccess.Models.Domain
{
    public class Brand
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int? warranty { get; set; }
        public List<Product>? Products { get; set; } = new List<Product>();
    }
}
