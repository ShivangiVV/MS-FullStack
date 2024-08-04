using PurchaseOrderSystem.Models;
using System.Collections.Generic;

namespace PurchaseOrderSystem.Services
{
    public interface IOrderService
    {
        Order PlaceOrder(Customer customer, List<OrderDetail> orderDetails);
    }
}
