using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Orders.MongoDB
{
    public static class OrdersMongoDbContextExtensions
    {
        public static void ConfigureOrders(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new OrdersMongoModelBuilderConfigurationOptions(
                OrdersDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}