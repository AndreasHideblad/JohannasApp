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
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("register")]
        public IHttpActionResult Register([FromBody]User user)
        {
            bool ok = UserManager.Instance.CreateUser(user);
            if(ok == true)
            {
                return Ok();
            }
            else
            {
                return Conflict();
            }
        }

        [HttpPost]
        [Route("login")]
        public IHttpActionResult Login([FromBody] LoginDetails loginRequest)
        {
            var user = UserManager.Instance.GetUserByUsername(loginRequest.Username);
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
