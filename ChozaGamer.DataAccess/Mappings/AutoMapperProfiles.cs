using AutoMapper;
using ChozaGamer.DataAccess.Models.Domain;
using ChozaGamer.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Product, SearchProductDTO>()
                .ForMember(dest => dest.categoryName, opt => opt.MapFrom(src => src.Category.name))
                .ForMember(dest => dest.brandName, opt => opt.MapFrom(src => src.Brand.name))
                .ForMember(dest => dest.subCategoryName, opt => opt.MapFrom(src => src.SubCategory.name))
                .ForMember(dest => dest.productImages, opt => opt.MapFrom(src => src.ProductImages.Select(pi => pi.image).ToList()));
        }
    }
}
