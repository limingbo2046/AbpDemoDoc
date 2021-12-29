using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace lcn.demo.Samples
{
    public class SampleProvider : Volo.Abp.Domain.Entities.AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public ICollection<Sample> Samples { get; set; }
        public ICollection<SamplePurchaseOrder> SamplePurchaseOrders { get; set; }
        protected SampleProvider()
        {
            Samples = new Collection<Sample>();
            SamplePurchaseOrders = new Collection<SamplePurchaseOrder>();
        }
    }
}