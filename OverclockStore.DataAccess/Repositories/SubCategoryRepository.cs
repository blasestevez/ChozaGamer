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
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public SubCategoryRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<List<SubCategoryDTO>> GetSubCategoriesAsync()
        {
            var subCategoryEntities = await dbContext.SubCategories.ToListAsync();

            var subCategoryDTOs = mapper.Map<List<SubCategoryDTO>>(subCategoryEntities);

            return subCategoryDTOs;
        }

        public async Task<bool> UpdateSubCategoryAsync(SubCategoryDTO subCategoryDTO)
        {
            var subCategoryEntity = await dbContext.SubCategories.FindAsync(subCategoryDTO.id);

            if (subCategoryEntity == null)
            {
                return false;
            }

            var updatedSubCategory = mapper.Map(subCategoryDTO, subCategoryEntity);

            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteSubCategoryAsync(int idSubCategory)
        {
            var subCategoryEntity = await dbContext.SubCategories.FindAsync(idSubCategory);

            if (subCategoryEntity == null)
            {
            }

            dbContext.SubCategories.Remove(subCategoryEntity);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UploadSubCategoryAsync(SubCategoryDTO subCategoryDTO)
        {
            var subCategoryEntity = mapper.Map<SubCategory>(subCategoryDTO);

            await dbContext.SubCategories.AddAsync(subCategoryEntity);
            await dbContext.SaveChangesAsync();

            return true;
        }
    }
}
