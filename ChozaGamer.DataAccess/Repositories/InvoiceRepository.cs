using AutoMapper;
using ChozaGamer.DataAccess.IRepositories;
using ChozaGamer.DataAccess.Models.Domain;
using ChozaGamer.DataAccess.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public InvoiceRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<bool> CreateInvoice(InvoiceDTO invoice)
        {
            var invoiceEntity = mapper.Map<Invoice>(invoice);

            await dbContext.Invoices.AddAsync(invoiceEntity);
            await dbContext.SaveChangesAsync();
            return true;
        }
    }
}
