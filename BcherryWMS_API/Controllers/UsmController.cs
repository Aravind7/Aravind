using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication5.Repo;
using WebApplication5.Service;

namespace WebApplication5.Controllers
{
     [RoutePrefix("api/Usm")]
    public class UsmController : ApiController
    {
         IUsm usm;
         public UsmController ()
         {
             this.usm = new UsmService(new UsmrepoImpl());
         }
            [Route("UsmList")]
           [HttpPost]
         public Object UsmList()
         {
             var l = usm.listUsm();
             JObject resultJson = new JObject();
             string json = JsonConvert.SerializeObject(l);
             resultJson = JObject.Parse(json);
             return resultJson;
         }
    }
}
