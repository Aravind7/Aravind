using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repo
{
    public class UsmrepoImpl : BaseRepository, IUsmRepo
    {
        AuthDbContext abc = new AuthDbContext();
        public object listUsm()

        {
          
            var usmList = abc.login.FirstOrDefault();
            return usmList;
           
        }
    }
}