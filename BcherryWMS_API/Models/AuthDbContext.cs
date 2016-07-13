using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication5.Service;

namespace WebApplication5.Models
{
    public class AuthDbContext : DbContext

    {
        static string StrSqlCon = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public AuthDbContext()
            : base(StrSqlCon)
        {

        }

       // public virtual DbSet<SampleEmp> Milestones { get; set; }
        public virtual DbSet<Login> login { get; set; } //here login is model's name
        public virtual DbSet<ClientDetails> client { get; set; }
        public virtual DbSet<pr_ClientPortal_Result> pr_client { get; set; }
    }
}