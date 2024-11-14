using ChozaGamer.DataAccess.Models.Domain;
using ChozaGamer.DataAccess.Models.DTOs;
using ChozaGamer.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.Business.Services
{
    public class ProductService
    {
        private readonly ProductRepository repository;

        public ProductService(ProductRepository repository)
        {
            this.repository = repository;
        }
        public async Task<List<SearchProductDTO>> GetProducts()
        {
            var response = await repository.GetProductsAsync();
            return response;
        }

        public async Task<List<SearchProductDTO>> GetProductsByCategory(string search, int idCategory)
        {
            var response = await repository.GetProductsByCategoryAsync(search, idCategory);
            return response;
        }

        public async Task<List<SearchProductDTO>> GetProductsBySubCategory(string search, int idSubCategory)
        {
            var response = await repository.GetProductsBySubCategoryAsync(search, idSubCategory);
            return response;
        }
    }
}
