using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Orders.Orders
{
    public class OrderLine : Entity<int>
    {
        public int OrderId { get; set; }
        public int Count { get; set; }

    }
}
