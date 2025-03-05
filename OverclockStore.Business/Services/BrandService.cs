using OverclockStore.DataAccess.Models.DTOs;
using OverclockStore.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.Business.Services
{
    public class BrandService
    {
        private readonly BrandRepository repository;

        public BrandService(BrandRepository repository)
        {
            this.repository = repository;
        }
        public async Task<List<BrandDTO>> GetBrands()
        {
            var response = await repository.GetBrandsAsync();
            return response;
        }

        public async Task<bool> UpdateBrand(BrandDTO brand)
        {
            var response = await repository.UpdateBrandAsync(brand);
            return response;
        }

        public async Task<bool> DeleteBrand(int idBrand)
        {
            var response = await repository.DeleteBrandAsync(idBrand);
            return response;
        }

        public async Task<bool> UploadBrand(BrandDTO brand)
        {
            var response = await repository.UploadBrandAsync(brand);
            return response;
        }

    }
}
