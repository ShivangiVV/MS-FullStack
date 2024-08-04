using System;
using System.Collections.Generic;
using Bosch.PO.Modules;

namespace Bosch.PO.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                CustomerId = 1,
                Name = "John Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "123-456-7890",
                Address = "123 Main St"
            };

            var product1 = new Product
            {
                ProductId = 1,
                Name = "Product 1",
                Description = "Description for Product 1",
                Price = 99.99m,
                Stock = 50
            };

            var product2 = new Product
            {
                ProductId = 2,
                Name = "Product 2",
                Description = "Description for Product 2",
                Price = 149.99m,
                Stock = 30
            };

            var order = new Order
            {
                OrderId = 1,
                CustomerId = customer.CustomerId,
                ProductIds = new List<int> { product1.ProductId, product2.ProductId },
                OrderDate = DateTime.Now,
                TotalAmount = product1.Price + product2.Price
            };

            Console.WriteLine("Customer Details:");
            Console.WriteLine($"ID: {customer.CustomerId}, Name: {customer.Name}, Email: {customer.Email}, Phone: {customer.PhoneNumber}, Address: {customer.Address}");

            Console.WriteLine("\nProduct Details:");
            Console.WriteLine($"ID: {product1.ProductId}, Name: {product1.Name}, Description: {product1.Description}, Price: {product1.Price}, Stock: {product1.Stock}");
            Console.WriteLine($"ID: {product2.ProductId}, Name: {product2.Name}, Description: {product2.Description}, Price: {product2.Price}, Stock: {product2.Stock}");

            Console.WriteLine("\nOrder Details:");
            Console.WriteLine($"Order ID: {order.OrderId}, Customer ID: {order.CustomerId}, Order Date: {order.OrderDate}, Total Amount: {order.TotalAmount}");
        }
    }
}
