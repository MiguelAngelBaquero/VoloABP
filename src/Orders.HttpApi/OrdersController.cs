using Orders.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Orders
{
    public abstract class OrdersController : AbpController
    {
        protected OrdersController()
        {
            LocalizationResource = typeof(OrdersResource);
        }
    }
}
