using AutoMapper;
using TopMagazine.ProductApi.Models;

namespace TopMagazine.ProductApi.DTOs.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDTO>().ReverseMap();

        CreateMap<Product, ProductDTO>().ReverseMap();
    }
}
