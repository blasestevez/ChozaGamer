using AutoMapper;
using OverclockStore.DataAccess.IRepositories;
using OverclockStore.DataAccess.Models.Domain;
using OverclockStore.DataAccess.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.DataAccess.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public CategoryRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<bool> DeleteCategoryAsync(int idCategory)
        {
            var category = await dbContext.Categories.FindAsync(idCategory);

            if (category == null)
            {
                return false;
            }

            dbContext.Categories.Remove(category);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<CategoryDTO>> GetCategoriesAsync()
        {
            var categoriesEntities = await dbContext.Categories.ToListAsync();

            var categoriesDTO = mapper.Map<List<CategoryDTO>>(categoriesEntities);

            return categoriesDTO;
        }

        public async Task<bool> UpdateCategoryAsync(CategoryDTO categoryDTO)
        {
            var categoryEntity = await dbContext.Categories.FindAsync(categoryDTO.id);

            if (categoryEntity == null)
            {
                return false;
            }

            var updatedProduct = mapper.Map(categoryDTO, categoryEntity);

            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UploadCategoryAsync(CategoryDTO categoryDTO)
        {
            var categoryEntity = mapper.Map<Category>(categoryDTO);

            await dbContext.Categories.AddAsync(categoryEntity);
            await dbContext.SaveChangesAsync();

            return true;
        }
    }
}
