using AutoMapper;
using Tasty.Services.ProductAPI.Models;
using Tasty.Services.ProductAPI.Models.Dto;

namespace Tasty.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
            });
            return mappingConfig;
        }
    }
}
