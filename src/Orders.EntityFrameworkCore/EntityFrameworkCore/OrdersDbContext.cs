using Microsoft.EntityFrameworkCore;
using Orders.Orders;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Orders.EntityFrameworkCore
{
    [ConnectionStringName(OrdersDbProperties.ConnectionStringName)]
    public class OrdersDbContext : AbpDbContext<OrdersDbContext>, IOrdersDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public DbSet<Order> Orders { get; set; }

        public OrdersDbContext(DbContextOptions<OrdersDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureOrders();
        }
    }
}