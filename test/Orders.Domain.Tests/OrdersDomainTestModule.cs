﻿using Orders.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Orders
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(OrdersEntityFrameworkCoreTestModule)
        )]
    public class OrdersDomainTestModule : AbpModule
    {
        
    }
}
