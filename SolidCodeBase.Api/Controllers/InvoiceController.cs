using Microsoft.AspNetCore.Mvc;
using SolidCodeBase.Core.Interfaces;
using SolidCodeBase.Core.Models;

namespace SolidCodeBase.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        public IActionResult ProcessInvoice([FromBody] Invoice invoice)
        {
            _invoiceService.ProcessInvoice(invoice);
            return Ok();
        }
    }
}