using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lcn.demo.Samples
{
    public class SampleAppService : Volo.Abp.Application.Services.CrudAppService<
        Sample,//聚合根类
        SampleDto,//聚合根dto
        Guid,
        GetSamples,
        CreateSampleDto,
        UpdateSampleDto
        >, ISampleAppService//必须继承该接口，因为其他模块调用的时候是通过接口来找实例服务的
    {
        public SampleAppService(
            Volo.Abp.Domain.Repositories.IRepository<Sample, Guid> samples
        //传递仓储类给父类，需要声明主键类型，这样在本类中调用仓储属性就是该实例
        ) : base(samples)
        {

        }

    }
}
