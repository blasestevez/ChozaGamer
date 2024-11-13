using ChozaGamer.DataAccess.Models.Domain;
using ChozaGamer.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.IRepositories
{
    public interface IProductRepository
    {
        Task<List<SearchProductDTO>> GetProductsAsync(string search);
        Task<List<SearchProductDTO>> GetProductsByCategoryAsync(string search, int idCategory);
        Task<List<SearchProductDTO>> GetProductsBySubCategoryAsync(string search, int idSubCategory);
    }
}
