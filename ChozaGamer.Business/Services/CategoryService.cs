using ChozaGamer.DataAccess.Models.DTOs;
using ChozaGamer.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.Business.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository repository;

        public CategoryService(CategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<CategoryDTO>> GetCategories()
        {
            var response = await repository.GetCategoriesAsync();
            return response;
        }

        public async Task<bool> UpdateCategory(CategoryDTO category)
        {
            var response = await repository.UpdateCategoryAsync(category);
            return response;
        }

        public async Task<bool> DeleteCategory(int idCategory)
        {
            var response = await repository.DeleteCategoryAsync(idCategory);
            return response;
        }

        public async Task<bool> UploadCategory(CategoryDTO category)
        {
            var response = await repository.UploadCategoryAsync(category);
            return response;
        }
    }
}
