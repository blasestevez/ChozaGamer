using ChozaGamer.DataAccess.Models.DTOs;
using ChozaGamer.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.Business.Services
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
