using AutoMapper;
using StoreWebApi.Models;

namespace StoreWebApi.DTOs
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Customer, CustomerDTO>()
                .ForMember(x => x.CustomerOrder, o => o.Ignore())
                .ReverseMap();

                config.CreateMap<CustomerOrder, CustomerOrderDTO>()
                .ForMember(x => x.OrderDetail, o => o.Ignore())
                .ReverseMap();

                config.CreateMap<Employee, EmployeeDTO>()
                .ReverseMap();

                config.CreateMap<OrderDetail, OrderDetailDTO>()
                .ReverseMap();

                config.CreateMap<OrderStatus, OrderStatusDTO>()
                .ForMember(x => x.CustomerOrder, o => o.Ignore())
                .ReverseMap();

                config.CreateMap<Product, ProductDTO>()
                .ForMember(x => x.OrderDetail, o => o.Ignore())
                .ReverseMap();
            });
        }
    }
}
