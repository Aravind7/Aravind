using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication5.Repo
{
    interface ILoginRepo 
    {
        Object login(String name, String password);

        String getPassword(String name);

    }
}
