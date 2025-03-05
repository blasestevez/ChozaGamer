using OverclockStore.DataAccess.Models.Domain;
using OverclockStore.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.DataAccess.IRepositories
{
    public interface ICategoryRepository
    {
        Task<List<CategoryDTO>> GetCategoriesAsync();
        Task<bool> UploadCategoryAsync(CategoryDTO brand);
        Task<bool> UpdateCategoryAsync(CategoryDTO brand);
        Task<bool> DeleteCategoryAsync(int idCategory);
    }
}
