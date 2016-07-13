using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repo
{
    public class BaseRepository
    {
        AuthDbContext _dbContext = new AuthDbContext();

        public virtual pr_ClientPortal_Result pr_ClientPortal(string clntL3Code)
        {
            var clntL3CodeParameter = clntL3Code != null ?
                new SqlParameter("clntL3Code", clntL3Code) :
                new SqlParameter("clntL3Code", typeof(string));

            pr_ClientPortal_Result res_list = _dbContext.Database.SqlQuery<pr_ClientPortal_Result>("EXEC pr_ClientPortal @clntL3Code", clntL3CodeParameter).FirstOrDefault<pr_ClientPortal_Result>();
            return res_list;
        }

    }
}