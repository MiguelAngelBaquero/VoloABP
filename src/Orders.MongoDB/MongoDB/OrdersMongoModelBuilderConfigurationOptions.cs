using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Orders.MongoDB
{
    public class OrdersMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public OrdersMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}