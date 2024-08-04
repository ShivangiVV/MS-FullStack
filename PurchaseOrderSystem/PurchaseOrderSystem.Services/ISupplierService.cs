using PurchaseOrderSystem.Models;

namespace PurchaseOrderSystem.Services
{
    public interface ISupplierService
    {
        void SupplyOrder(Order order);
    }
}
