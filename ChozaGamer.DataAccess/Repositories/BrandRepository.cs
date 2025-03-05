using AutoMapper;
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
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public BrandRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<bool> DeleteBrandAsync(int idBrand)
        {
            var brand = await dbContext.Brands.FindAsync(idBrand);

            if (brand == null)
            {
                return false;
            }

            dbContext.Brands.Remove(brand);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<BrandDTO>> GetBrandsAsync()
        {
            var brandsEntities = await dbContext.Brands.ToListAsync();

            var brandsDTO = mapper.Map<List<BrandDTO>>(brandsEntities);

            return brandsDTO;
        }

        public async Task<bool> UpdateBrandAsync(BrandDTO brandDTO)
        {
            var brandEntity = await dbContext.Brands.FindAsync(brandDTO.id);

            if (brandEntity == null)
            {
                return false;
            }

            var updatedProduct = mapper.Map(brandDTO, brandEntity);

            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UploadBrandAsync(BrandDTO brandDTO)
        {
            Brand brand = new Brand();
            mapper.Map(brandDTO, brand);

            await dbContext.Brands.AddAsync(brand);
            await dbContext.SaveChangesAsync();

            return true;
        }
    }
}
