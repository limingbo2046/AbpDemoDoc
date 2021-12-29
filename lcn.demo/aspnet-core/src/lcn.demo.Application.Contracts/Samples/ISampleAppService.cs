using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application;

namespace lcn.demo.Samples
{
    public interface ISampleAppService : Volo.Abp.Application.Services.ICrudAppService<
        SampleDto,//聚合根对应的dto
        Guid,
        GetSamples,
        CreateSampleDto,
        UpdateSampleDto
        >
    {

    }
}
