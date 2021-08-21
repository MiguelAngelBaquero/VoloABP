using System.ComponentModel.DataAnnotations;

namespace Orders.Orders
{
    public class CreateOrderDto
    {
        [Required]
        public string ReferenceNumber { get; set; }
    }
}
