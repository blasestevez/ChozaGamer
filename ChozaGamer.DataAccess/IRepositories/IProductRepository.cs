using ChozaGamer.DataAccess.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.IRepositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync(string search);
        Task<List<Product>> GetProductsByCategoryAsync(string search, int idCategory);
        Task<List<Product>> GetProductsBySubCategoryAsync(string search, int idSubCategory);
    }
}
