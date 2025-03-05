using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.DataAccess.Models.DTOs
{
    public class UserDTO
    {
        public int id { get; set; }
        public string username { get; set; }
        public bool userType { get; set; }
    }
}
