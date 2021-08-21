using JetBrains.Annotations;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Orders.Orders
{
    public class OrderManager : DomainService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> CreateOrderAsync(
            [NotNull] string referenceNo)
        {
            var existingOrder = await _orderRepository.FindOrderByReferenceNumberAsync(referenceNo);
            if(existingOrder == null)
            {
                var order = new Order(referenceNo);
                await _orderRepository.InsertAsync(order);
                return order;
            }
            return existingOrder;
        }

        public async Task<Order> AddOrderLine(int orderId, int count)
        {
            var order = await _orderRepository.FindAsync(orderId);
            if(order != null)
            {
                order.AddOrderLine(count);
            }
            return order;
        }
    }
}
