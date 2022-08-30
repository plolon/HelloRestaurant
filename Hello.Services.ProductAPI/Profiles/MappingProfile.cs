using AutoMapper;
using Hello.Services.ProductAPI.DTOs;
using Hello.Services.ProductAPI.Models;

namespace Hello.Services.ProductAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
