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
                .ReverseMap()
                .ForMember(src => src.id, opt => opt.Ignore());

            CreateMap<LoginUserDTO, User>()
                .ForMember(dest => dest.hashedPassword, opt => opt.Ignore());

            CreateMap<RegisterUserDTO, User>()
                .ForMember(dest => dest.hashedPassword, opt => opt.Ignore());

            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.username, opt => opt.MapFrom(src => src.username))
                .ForMember(dest => dest.userType, opt => opt.MapFrom(src => src.userType))
                .ForSourceMember(src => src.hashedPassword, opt => opt.DoNotValidate())
                .ForSourceMember(src => src.id, opt => opt.DoNotValidate());

            CreateMap<Brand, BrandDTO>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products))
                .ReverseMap();

            CreateMap<Category, CategoryDTO>()
                .ForMember(dest => dest.SubCategories, opt => opt.MapFrom(src => src.SubCategories))
                .ReverseMap();

            CreateMap<SubCategory, SubCategoryDTO>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products))
                .ReverseMap();

            CreateMap<Invoice, InvoiceDTO>()
                .ForMember(dest => dest.date, opt => opt.MapFrom(src => src.date))
                .ForMember(dest => dest.idProduct, opt => opt.MapFrom(src => src.idProduct))
                .ForMember(dest => dest.idUser, opt => opt.MapFrom(src => src.idUser))
                .ReverseMap()
                .ForMember(dest => dest.Product, opt => opt.Ignore())
                .ForMember(dest => dest.User, opt => opt.Ignore());
        }
    }
}
