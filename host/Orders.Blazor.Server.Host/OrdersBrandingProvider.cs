using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Orders.Blazor.Server.Host
{
    [Dependency(ReplaceServices = true)]
    public class OrdersBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Orders";
    }
}
