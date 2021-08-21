using Microsoft.EntityFrameworkCore;
using Orders.EntityFrameworkCore;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Orders.Orders
{
    public class OrderRepository : EfCoreRepository<OrdersDbContext, Order, int>, IOrderRepository
    {
        public OrderRepository(IDbContextProvider<OrdersDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Order> FindOrderByReferenceNumberAsync(string referenceNumber)
        {
            // throw new System.NotImplementedException();
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(order => order.ReferenceNo == referenceNumber);
        }

        public async Task<Order> FindOrderWithOrderLineAsync(string referenceNumber)
        {
            // throw new System.NotImplementedException();
            var dbSet = await WithDetailsAsync(order => order.OrderLines);
            return await dbSet.FirstOrDefaultAsync(order => order.ReferenceNo == referenceNumber);
        }
    }
}
