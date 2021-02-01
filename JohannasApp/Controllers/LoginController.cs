using JohannasApp.Managers;
using JohannasApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JohannasApp.Controllers
{
    [RoutePrefix("user")]

    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class LoginController : ApiController
    {
        [HttpGet]
        [HttpPost]
        [Route("login")]
        public IHttpActionResult Login([FromBody]LoginDetails loginRequest)
        {
            var user = UserManager.Instance.GetUserByUsername(loginRequest.UserName);
            if (user != null && loginRequest.Password == user.Password)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
