using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Models.Domain
{
    public class Invoice
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public int idProduct { get; set; }
        public DateTime date { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
