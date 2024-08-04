namespace Bosch.PO.Modules
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public List<int> ProductIds { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
