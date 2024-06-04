namespace SolidCodeBase.Core.Interfaces
{
    using SolidCodeBase.Core.Models;

    public interface IInvoiceService
    {
        void ProcessInvoice(Invoice invoice);
    }
}