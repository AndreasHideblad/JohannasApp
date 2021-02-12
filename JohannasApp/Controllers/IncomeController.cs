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
        [Route("")]
        [HttpGet]
        public List<Income> GetIncome()
        {
            var incomes = IncomeManager.Instance.GetIncome();
            return incomes;
        }

        // GET: api/Income/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("")]
        [HttpPost]
        public void IncomePost([FromBody] Income income)
        {
            IncomeManager.Instance.CreateIncome(income);
        }
    }
}
