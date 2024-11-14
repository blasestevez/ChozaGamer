using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Models.Domain
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string hashedPassword { get; set; }
        public bool userType { get; set; }
    }
}
