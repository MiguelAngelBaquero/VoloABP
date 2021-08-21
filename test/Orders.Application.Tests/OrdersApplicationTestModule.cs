using Volo.Abp.Modularity;

namespace Orders
{
    [DependsOn(
        typeof(OrdersApplicationModule),
        typeof(OrdersDomainTestModule)
        )]
    public class OrdersApplicationTestModule : AbpModule
    {

    }
}
