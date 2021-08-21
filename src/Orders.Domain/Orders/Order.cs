using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Orders.Orders
{
    public class Order : FullAuditedAggregateRoot<int>
    {
        public string ReferenceNo { get; set; }

        public int TotalItemCount { get; set; }

        public List<OrderLine> OrderLines { get; set; }

        protected Order()
        {

        }

        public Order(string referenceNo)
        {
            Check.NotNull(referenceNo, nameof(referenceNo));
            ReferenceNo = referenceNo;
            OrderLines = new List<OrderLine>();
        }

        public void AddOrderLine(int count)
        {
            OrderLines.Add(new OrderLine
                { 
                    OrderId = this.Id ,
                    Count = count
                }
            );
            TotalItemCount += count;
        }
    }
}
