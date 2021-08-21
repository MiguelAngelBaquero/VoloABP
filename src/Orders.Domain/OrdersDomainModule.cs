using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Orders
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(OrdersDomainSharedModule)
    )]
    public class OrdersDomainModule : AbpModule
    {

    }
}
