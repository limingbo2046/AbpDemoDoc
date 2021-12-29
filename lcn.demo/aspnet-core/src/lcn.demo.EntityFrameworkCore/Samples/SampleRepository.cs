using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using System.Linq.Dynamic.Core;//OrderBy 所在的命名空间
using lcn.demo.EntityFrameworkCore;

namespace lcn.demo.Samples
{
    public class SampleRepository : EfCoreRepository<demoDbContext, Sample, Guid>, ISampleRepository
    {
        public SampleRepository(IDbContextProvider<demoDbContext> dbContextProvider) : base(dbContextProvider)
        {
            //该构造函数必须实现，向父类传递上下文提供者
        }

        public async/*添加async异步关键词*/ Task DeleteSampleByState(SampleStates sampleState)
        {
            var db = await GetDbContextAsync();//这里获得整个数据库，可以操作其他表
            await db.Database.ExecuteSqlRawAsync($"delete from sample where samplestate={(int)sampleState}");//执行原生SQL的方法
        }

        public async Task<IEnumerable<Sample>> GetSamplesByState(SampleStates sampleState)
        {
            //using System.Linq; 的用法
            var samples = await GetDbSetAsync();//这里是指sample这张表而已
            return await samples.Where(p => p.SampleState == sampleState).ToListAsync();//异步必须调用Async结尾的方法
        }

        public async Task<List<Sample>> GetSampleListAsync(int skipCount, int maxResultCount, string sorting, string filter = null)
        {
            var dbset = await GetDbSetAsync();
            return await dbset.WhereIf(
                !filter.IsNullOrWhiteSpace(),//静态拓展函数
                p => p.Name.Contains(filter)
                ).OrderBy(sorting)//直接传递属性名，然后对该列进行排序 需要特定的命名空间 using System.Linq.Dynamic.Core;
                .Skip(skipCount).Take(maxResultCount)//分页查询，不支持SQL2008 R2之前的数据库
                .ToListAsync();//
        }
    }
}
