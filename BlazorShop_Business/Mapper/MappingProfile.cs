using AutoMapper;
using BlazorShop_DataAccess;
using BlazorShop_Models.DTO;

namespace BlazorShop_Business.Mapper {
    public class MappingProfile : Profile {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}