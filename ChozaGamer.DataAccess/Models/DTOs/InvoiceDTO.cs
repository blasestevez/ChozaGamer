using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Models.DTOs
{
    public class InvoiceDTO
    {
        public int idUser { get; set; }
        public int idProduct { get; set; }
        public DateTime date { get; set; }
    }
}
