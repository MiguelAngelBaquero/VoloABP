using System.Threading.Tasks;

namespace Orders.Orders
{
    public class OrderAppService : OrdersAppService, IOrderAppService
    {
        private readonly OrderManager _orderManager;

        public OrderAppService(OrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        public async Task<OrderDto> CreateOrderAsync(CreateOrderDto input)
        {
            // throw new NotImplementedException();
            var order = await _orderManager.CreateOrderAsync(input.ReferenceNumber);
            return ObjectMapper.Map<Order, OrderDto>(order);
        }
    }
}
