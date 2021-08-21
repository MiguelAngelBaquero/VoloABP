using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;

namespace Orders.Orders
{
    [RemoteService]
    [Route("api/orders")]
    public class OrderController : OrdersController, IOrderAppService
    {

        private readonly IOrderAppService _orderAppService;

        public OrderController(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<OrderDto> CreateOrderAsync(CreateOrderDto input)
        {
            // throw new System.NotImplementedException();
            return await _orderAppService.CreateOrderAsync(input);
        }
    }
}
