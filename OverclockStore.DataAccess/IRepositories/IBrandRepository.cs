using OverclockStore.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.DataAccess.IRepositories
{
    public interface IBrandRepository
    {
        Task<List<BrandDTO>> GetBrandsAsync();
        Task<bool> UploadBrandAsync(BrandDTO brand);
        Task<bool> UpdateBrandAsync(BrandDTO brand);
        Task<bool> DeleteBrandAsync(int idBrand);
    }
}
