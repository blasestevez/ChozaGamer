using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverclockStore.Presentation.Utils
{
    public class UserSession
    {
        public static int userId { get; set; }
        public static string username { get; set; }
        public static bool userType { get; set; }

        public static void Logout()
        {
            userId = 0;
            username = "";
            userType = false;
        }
    }
}
