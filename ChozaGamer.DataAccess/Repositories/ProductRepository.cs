using ChozaGamer.DataAccess.IRepositories;
using ChozaGamer.DataAccess.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<Product>> GetProductsAsync(string search)
        {
            return await dbContext.Products.Where(x => x.name.Contains(search))
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.SubCategory)
                .ToListAsync();
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string search, int idCategory)
        {
            return await dbContext.Products.Where(x => x.idCategory == idCategory && x.name.Contains(search)).ToListAsync();
        }

        public async Task<List<Product>> GetProductsBySubCategoryAsync(string search, int idSubCategory)
        {
            return await dbContext.Products.Where(x => x.idSubCategory == idSubCategory && x.name.Contains(search)).ToListAsync();
        }
    }
}
