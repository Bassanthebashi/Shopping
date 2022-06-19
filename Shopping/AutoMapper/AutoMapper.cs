using AutoMapper;
using Shopping.Data.Models;
using Shopping.Dtos.OrderDTOs;
using Shopping.Dtos.OrderItemDTOs;
using Shopping.Dtos.ProductDTOs;

namespace Shopping.AutoMapper
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            //CreateMap<>();
            CreateMap<Order,OrderReadDTO>();
            CreateMap<Product, ProductChildReadDTO>();
            CreateMap<OrderItem,OrderItemChildReadDTO>();
            
            CreateMap<OrderWriteDTO,Order>();
            CreateMap<ProductChildWriteDTO,Product>();
            CreateMap<OrderItemChildWriteDTO, OrderItem>();

        }
    }
}
