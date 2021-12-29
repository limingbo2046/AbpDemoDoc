using Volo.Abp.Modularity;

namespace lcn.demo
{
    [DependsOn(
        typeof(demoApplicationModule),
        typeof(demoDomainTestModule)
        )]
    public class demoApplicationTestModule : AbpModule
    {

    }
}