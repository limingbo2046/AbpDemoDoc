using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace lcn.demo.Samples
{
    public class Sample : AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public int Sort { get; set; }

        [DataType("Decimal(18,4)")]//定义decimal的小数和SQL数据库要一致
        public decimal Price { get; set; }
        public SampleStates SampleState { get; set; }
        public ICollection<SampleItem> Items { get; set; }
        public ICollection<SampleProvider> SampleProviders { get; set; }
        public ICollection<SamplePurchaseOrder> SamplePurchaseOrders { get; set; }
        protected Sample()
        {
            //ORM
            Items = new Collection<SampleItem>();
            SampleProviders = new Collection<SampleProvider>();
            SamplePurchaseOrders = new Collection<SamplePurchaseOrder>();
        }
    }
}
