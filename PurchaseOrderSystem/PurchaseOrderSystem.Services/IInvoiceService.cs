using PurchaseOrderSystem.Models;

namespace PurchaseOrderSystem.Services
{
    public interface IInvoiceService
    {
        Invoice GenerateInvoice(Order order);
    }
}
