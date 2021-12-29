using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace lcn.demo.Samples
{
    //自定义仓储类
    public interface ISampleRepository : IRepository<Sample, Guid>
    {
        Task DeleteSampleByState(SampleStates sampleState);//自定义方法
        Task<IEnumerable<Sample>> GetSamplesByState(SampleStates sampleState);//自定义方法二
        Task<List<Sample>> GetSampleListAsync(int skipCount, int maxResultCount, string sorting, string filter = null);
    }
}