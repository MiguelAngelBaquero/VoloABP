using Orders.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Orders.Blazor.Server.Host
{
    public abstract class OrdersComponentBase : AbpComponentBase
    {
        protected OrdersComponentBase()
        {
            LocalizationResource = typeof(OrdersResource);
        }
    }
}
