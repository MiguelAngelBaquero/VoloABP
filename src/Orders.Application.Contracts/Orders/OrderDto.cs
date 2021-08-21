using Volo.Abp.Application.Dtos;

namespace Orders.Orders
{
    public class OrderDto : AuditedEntityDto<int>
    {
        public string ReferenceNo { get; set; }
        public int TotalItemCount { get; set; }
    }
}