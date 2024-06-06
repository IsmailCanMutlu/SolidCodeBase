using SolidCodeBase.Core.Interfaces;
using SolidCodeBase.Core.Models;

namespace SolidCodeBase.Data.Repositories
{
    public class InvoiceRepository : IBaseRepository<Invoice>
    {
        private readonly ApplicationDbContext _context;

        public InvoiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Invoice entity)
        {
            _context.Invoices.Add(entity);
            _context.SaveChanges();
        }

        public Invoice Get(int id)
        {
            return _context.Invoices.Find(id);
        }
    }
}