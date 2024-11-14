﻿using AutoMapper;
using ChozaGamer.DataAccess.IRepositories;
using ChozaGamer.DataAccess.Models.Domain;
using ChozaGamer.DataAccess.Models.DTOs;
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
        private readonly IMapper mapper;

        public ProductRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<List<SearchProductDTO>> GetProductsAsync()
        {
            var products = await dbContext.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.SubCategory)
                .ToListAsync();

            return mapper.Map<List<SearchProductDTO>>(products);
        }

        public async Task<List<SearchProductDTO>> GetProductsByCategoryAsync(string search, int idCategory)
        {
            var products = await dbContext.Products.Where(x => x.idCategory == idCategory && x.name.Contains(search))
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.SubCategory)
                .ToListAsync();

            return mapper.Map<List<SearchProductDTO>>(products);
        }

        public async Task<List<SearchProductDTO>> GetProductsBySubCategoryAsync(string search, int idSubCategory)
        {
            var products = await dbContext.Products.Where(x => x.idSubCategory == idSubCategory && x.name.Contains(search))
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.SubCategory)
                .ToListAsync();

            return mapper.Map<List<SearchProductDTO>>(products);
        }
    }
}
