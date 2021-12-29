using lcn.demo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace lcn.demo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class demoController : AbpController
    {
        protected demoController()
        {
            LocalizationResource = typeof(demoResource);
        }
    }
}