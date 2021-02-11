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
    [RoutePrefix("Income")]

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class IncomeController : ApiController
    {
        // GET: api/Income
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Income/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("create")]
        [HttpPost]
        public void IncomePost([FromBody] Income income)
        {
            IncomeManager.Instance.CreateIncome(income);
        }
    }
}
