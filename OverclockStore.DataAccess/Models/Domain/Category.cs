using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.DataAccess.Models.Domain
{
    public class Category
    {
        public int id { get; set; }
        public string? name { get; set; }
        public List<Product>? Products { get; set; } = new List<Product>();
        public List<SubCategory>? SubCategories { get; set; } = new List<SubCategory>();
    }
}
