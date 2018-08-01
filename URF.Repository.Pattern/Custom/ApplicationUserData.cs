using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Pattern
{
    public class ApplicationUserData
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        //public string SessionId { get; set; }
        public string[] Roles { get; set; }
    }
}
