using OverclockStore.DataAccess.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.DataAccess.Models.DTOs
{
    public class SubCategoryDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public int idCategory { get; set; }
        public CategoryDTO Category { get; set; }
        public List<SearchProductDTO> Products { get; set; } = new List<SearchProductDTO>();
    }
}
