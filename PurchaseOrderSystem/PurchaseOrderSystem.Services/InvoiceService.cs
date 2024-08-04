using PurchaseOrderSystem.Models;
using System;
using System.Linq;

namespace PurchaseOrderSystem.Services
{
    public class InvoiceService : IInvoiceService
    {
        public Invoice GenerateInvoice(Order order)
        {
            return new Invoice
            {
                Order = order,
                InvoiceDate = DateTime.Now,
                TotalAmount = order.OrderDetails.Sum(od => od.TotalPrice)
            };
        }
    }
}
