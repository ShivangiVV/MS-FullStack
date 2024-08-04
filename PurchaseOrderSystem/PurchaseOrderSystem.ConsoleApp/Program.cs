using PurchaseOrderSystem.Models;
using PurchaseOrderSystem.Services;
using System;
using System.Collections.Generic;

namespace PurchaseOrderSystem.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer { Name = "John Doe", CustomerNumber = "C123" };
            var category = new Category { CategoryId = 1, CategoryName = "Electronics" };
            var product = new Product { ProductId = 1, ProductName = "Laptop", Price = 1000m, Category = category };
            var orderDetail = new OrderDetail { Product = product, Quantity = 2 };

            IOrderService orderService = new OrderService();
            var order = orderService.PlaceOrder(customer, new List<OrderDetail> { orderDetail });

            IInvoiceService invoiceService = new InvoiceService();
            var invoice = invoiceService.GenerateInvoice(order);

            ISupplierService supplierService = new SupplierService();
            supplierService.SupplyOrder(order);

            Console.WriteLine($"Invoice generated for customer {invoice.Order.Customer.Name}, Total Amount: {invoice.TotalAmount}");
        }
    }
}
