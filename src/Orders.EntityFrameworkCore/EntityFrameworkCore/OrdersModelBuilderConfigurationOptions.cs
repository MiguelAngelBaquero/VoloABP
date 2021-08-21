using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Orders.EntityFrameworkCore
{
    public class OrdersModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public OrdersModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}