using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace lcn.demo.Samples
{
    //依赖类,如果没有样本,本来就没有存在的意义
    public class SampleItem : Entity<Guid>
    {
        public string ItemName { get; set; }
        public double Qty { get; set; }
        public double Score { get; set; }
        public Guid SampleId { get; set; }

        [ForeignKey(nameof(SampleId))]//导航属性需要指定外键
        public Sample Sample { get; set; }

        protected SampleItem()
        {
            //FOR ORM
        }
    }
}