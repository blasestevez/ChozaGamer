using ChozaGamer.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.IRepositories
{
    public interface ISubCategoryRepository
    {
        Task<List<SubCategoryDTO>> GetSubCategoriesAsync();
        Task<bool> UploadSubCategoryAsync(SubCategoryDTO subCategory);
        Task<bool> UpdateSubCategoryAsync(SubCategoryDTO subCategory);
        Task<bool> DeleteSubCategoryAsync(int idSubCategory);
    }
}
