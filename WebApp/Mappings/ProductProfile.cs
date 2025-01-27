using AutoMapper;
using Entities;
using RiraTask.WebApp.ViewModels;

namespace RiraTask.WebApp.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductViewModel>();

            CreateMap<List<Product>, ProductListViewModel>();
        }
    }
}
