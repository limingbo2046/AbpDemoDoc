using lcn.demo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace lcn.demo
{
    [DependsOn(
        typeof(demoEntityFrameworkCoreTestModule)
        )]
    public class demoDomainTestModule : AbpModule
    {

    }
}