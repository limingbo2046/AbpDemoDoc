using System;
using System.Collections.Generic;
using System.Text;
using lcn.demo.Localization;
using Volo.Abp.Application.Services;

namespace lcn.demo
{
    /* Inherit your application services from this class.
     */
    public abstract class demoAppService : ApplicationService
    {
        protected demoAppService()
        {
            LocalizationResource = typeof(demoResource);
        }
    }
}
