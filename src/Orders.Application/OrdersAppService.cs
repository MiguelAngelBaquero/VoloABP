using Orders.Localization;
using Volo.Abp.Application.Services;

namespace Orders
{
    public abstract class OrdersAppService : ApplicationService
    {
        protected OrdersAppService()
        {
            LocalizationResource = typeof(OrdersResource);
            ObjectMapperContext = typeof(OrdersApplicationModule);
        }
    }
}
