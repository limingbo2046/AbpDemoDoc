using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace lcn.demo
{
    [Dependency(ReplaceServices = true)]
    public class demoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "demo";
    }
}
