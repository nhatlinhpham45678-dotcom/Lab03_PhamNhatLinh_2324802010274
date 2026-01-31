using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Application.DTOs;

namespace ECommerce.Application.Services
{
    public interface IOrderService
    {
        Task<int> PlaceOrderAsync(CreateOrderRequestDTO orderRequest);
        Task<OrderDTO?> GetOrderByIdAsync(int orderId);
    }
}
