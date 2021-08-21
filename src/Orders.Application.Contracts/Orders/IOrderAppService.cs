using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Orders.Orders
{
    public interface IOrderAppService : IApplicationService
    {
        Task<OrderDto> CreateOrderAsync(CreateOrderDto input);
    }
}
