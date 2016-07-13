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
    [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        ILoginService loginservice;
        public LoginController()
        {
            this.loginservice = new Login(new LoginImpl());
        }

        [Route("LoginUser")]
        [HttpPost]
        public Object login([FromBody] JObject jb){

            var g = loginservice.login(jb);
            JObject resultJson = new JObject();
            string json = JsonConvert.SerializeObject(g);
            resultJson = JObject.Parse(json);
            return resultJson;
        }
    }
}
