using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Models;
using WebApplication5.Repo;

namespace WebApplication5.Service
{
    public class Login : ILoginService
    {
        ILoginRepo  loginrepo;   

        public Login(LoginImpl logg)
        {
            loginrepo = logg;
        }

        public Object login(dynamic logindetails)
        {
           // var loginemp = "Invalid User / Password";
            JObject jb = new JObject();
            
            String username = logindetails.name.ToString();
            String password =  logindetails.password.ToString();
            String encrypt_pass = getPassword(username); //encrypted password  //getting encrypted password by sending username
            if(encrypt_pass == null)
            {
                jb.Add("Message", "Invalid User / Password");
                return jb;
            }
            //Encrypt the password 
            EncryptDecrypt enrypt=new EncryptDecrypt();
            var decryptPass = enrypt.GetDecryptedPassword(encrypt_pass);
            if (decryptPass == password) 
            {
              var clt_list = loginrepo.login(username, encrypt_pass);
              if (clt_list != null)
              {
                 if(!clt_list.ToString().Contains("Check your Permission"))
                 {
                   string jsonClient = JsonConvert.SerializeObject(clt_list);
                   jb.Add("Message", JObject.Parse(jsonClient));
                 }
                 else
                 {
                     jb.Add("Message", clt_list.ToString()); 
                 }
               }
               else
               {
                   jb.Add("Message", "No Records Found");
               }
              
            }
            else
            {
                jb.Add("Message", "Invalid User / Password");
            }
            
            return jb;
           
        }

        public String getPassword(String username)
        {
            String password = "";
            String uname = username;
            //return loginrepo.getPassword(uname);
            password = loginrepo.getPassword(uname);
            if (password != "")
            {
                return password;
            }
            return password;
        }

       
    }
}