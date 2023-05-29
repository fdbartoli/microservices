using AutoMapper;
using Mango.Services.Products.API.Models;
using Mango.Services.Products.API.Models.Dto;

namespace Mango.Services.Products.API
{
    public class MappingConfig
    {
        public static MapperConfiguration Registermaps ()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
