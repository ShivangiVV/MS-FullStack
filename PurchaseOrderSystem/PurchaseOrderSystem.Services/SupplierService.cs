using PurchaseOrderSystem.Models;
using System;

namespace PurchaseOrderSystem.Services
{
    public class SupplierService : ISupplierService
    {
        public void SupplyOrder(Order order)
        {
            // Logic to supply order
            Console.WriteLine($"Order {order.OrderId} supplied.");
        }
    }
}
