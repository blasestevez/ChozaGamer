using OverclockStore.DataAccess.Models.DTOs;
using OverclockStore.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.Business.Services
{
    public class InvoiceService
    {
        private readonly InvoiceRepository invoiceRepository;

        public InvoiceService(InvoiceRepository invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
        }

        public async Task<bool> CreateInvoice(InvoiceDTO invoice)
        {
            var response = await invoiceRepository.CreateInvoice(invoice);
            return response;
        }
    }
}
