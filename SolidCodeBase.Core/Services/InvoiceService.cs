namespace SolidCodeBase.Core.Services
{
    using SolidCodeBase.Core.Interfaces;
    using SolidCodeBase.Core.Models;

    public class InvoiceService : IInvoiceService
    {
        private readonly IBaseRepository<Invoice> _invoiceRepository;

        public InvoiceService(IBaseRepository<Invoice> invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public void ProcessInvoice(Invoice invoice)
        {
            _invoiceRepository.Add(invoice);
        }
    }
}