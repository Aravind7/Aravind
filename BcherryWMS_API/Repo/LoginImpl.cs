using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Models;

namespace WebApplication5.Repo
{
    public class LoginImpl : BaseRepository , ILoginRepo
    {
        AuthDbContext abc = new AuthDbContext();
        public object login(String name, String password)
        {
            //var aa = "";
            var ab="";
           
          var aa =  abc.login.Where(x => x.usm_Login_id == name && x.usm_user_pwd == password && x.usm_log_type == "C").FirstOrDefault();
          if (aa == null) 
          {
              ab = "Check your Permission";
          }
          else {
             // ab= aa.usm_emp_id;
             // List<ClientDetails> client = abc.client.Where(x => x.cmd_clnt_code == aa.usm_emp_id).ToList();
              var client = pr_ClientPortal(aa.usm_emp_id); //calling procedure
              return client;
          }
              return ab; 
        }
         public string getPassword(String name)
        {
            
            var a = abc.login.ToList();
           var  pass = abc.login.Where(x => x.usm_Login_id == name).Select(x => x.usm_user_pwd).FirstOrDefault();
            return pass;

        }
    }
}