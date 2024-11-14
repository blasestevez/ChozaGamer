using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChozaGamer.DataAccess.Models.DTOs
{
    public class RegisterUserDTO
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool userType { get; set; }
    }
}
