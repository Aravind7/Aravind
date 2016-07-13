using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Repo;

namespace WebApplication5.Service
{
    public class UsmService : IUsm
    {
        IUsmRepo usmrepo;
        public UsmService(UsmrepoImpl usmimpl)
         {
             usmrepo = usmimpl;
         }

        public object listUsm()
        { 
             JObject jb = new JObject();
            var usm_list = usmrepo.listUsm();
            if (usm_list != null)
            {
                string jsonClient = JsonConvert.SerializeObject(usm_list);
                jb.Add("Message", JObject.Parse(jsonClient));
                return jb;
            }
            else
            {
                jb.Add("Message", "No data");
            }
            return jb;
            //throw new NotImplementedException();
        }
    }
}