namespace PurchaseOrderSystem.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Product.Price * Quantity;
    }
}
