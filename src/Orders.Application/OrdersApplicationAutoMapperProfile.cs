using AutoMapper;
using Orders.Orders;

namespace Orders
{
    public class OrdersApplicationAutoMapperProfile : Profile
    {
        public OrdersApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Order, OrderDto>();
        }
    }
}