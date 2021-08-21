using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Orders.Orders
{
    public interface IOrderRepository : IRepository<Order, int>
    {
        Task<Order> FindOrderByReferenceNumberAsync(string referenceNumber);
        Task<Order> FindOrderWithOrderLineAsync(string referenceNumber);
    }
}

