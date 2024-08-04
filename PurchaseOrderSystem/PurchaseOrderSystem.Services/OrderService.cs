using PurchaseOrderSystem.Models;
using System;
using System.Collections.Generic;

namespace PurchaseOrderSystem.Services
{
    public class OrderService : IOrderService
    {
        public Order PlaceOrder(Customer customer, List<OrderDetail> orderDetails)
        {
            return new Order
            {
                Customer = customer,
                OrderDate = DateTime.Now,
                OrderDetails = orderDetails
            };
        }
    }
}
