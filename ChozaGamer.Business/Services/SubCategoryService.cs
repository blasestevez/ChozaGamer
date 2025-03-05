using ChozaGamer.DataAccess.Models.DTOs;
using ChozaGamer.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.Business.Services
{
    public class SubCategoryService
    {
        private readonly SubCategoryRepository repository;

        public SubCategoryService(SubCategoryRepository repository)
        {
            this.repository = repository;
        }
        public async Task<List<SubCategoryDTO>> GetSubCategories()
        {
            var response = await repository.GetSubCategoriesAsync();
            return response;
        }
        public async Task<bool> UpdateSubCategory(SubCategoryDTO subCategory)
        {
            var response = await repository.UpdateSubCategoryAsync(subCategory);
            return response;
        }
        public async Task<bool> DeleteSubCategory(int idSubCategory)
        {
            var response = await repository.DeleteSubCategoryAsync(idSubCategory);
            return response;
        }
        public async Task<bool> UploadSubCategory(SubCategoryDTO subCategory)
        {
            var response = await repository.UploadSubCategoryAsync(subCategory);
            return response;
        }
    }
}
