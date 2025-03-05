using ChozaGamer.DataAccess.Models.Domain;
using ChozaGamer.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.IRepositories
{
    public interface ICategoryRepository
    {
        Task<List<CategoryDTO>> GetCategoriesAsync();
        Task<bool> UploadCategoryAsync(CategoryDTO brand);
        Task<bool> UpdateCategoryAsync(CategoryDTO brand);
        Task<bool> DeleteCategoryAsync(int idCategory);
    }
}
