using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication5.Service
{
    interface ILoginService
    {
        Object login(dynamic logindetails);
        String getPassword(String username);
    }
}
