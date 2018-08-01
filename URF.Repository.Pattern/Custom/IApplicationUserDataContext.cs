using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Pattern
{
    public interface IApplicationUserDataContext
    {
        ApplicationUserData GetApplicationUserData();
        bool IsInRole(string roleName);

    }
}
