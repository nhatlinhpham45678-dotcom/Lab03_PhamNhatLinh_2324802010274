using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.DTOs
{
    public class CreateOrderRequestDTO
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public AddressDTO ShippingAddress { get; set; } = null!;
        [Required]
        [MinLength(1, ErrorMessage = "At least one order item is required")]
        public List<OrderItemRequestDTO> Items { get; set; } = new();
    }
}
