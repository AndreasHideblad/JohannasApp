using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using JohannasApp.Managers;
using JohannasApp.Models;

namespace JohannasApp.Controllers
{
    [RoutePrefix("Expenses")]

    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ExpensesController : ApiController
    {
        [Route("")]
        [HttpGet]
        public List<Expenses> GetExpenses()
        {
            var expenses = ExpensesManager.Instance.GetExpenses();
            return expenses;
        }

        [Route("{id}")]
        [HttpGet]
        public Expenses ExpensesGetById(int id)
        {
            return ExpensesManager.Instance.GetExpensesById(id);
        }

        [Route("")]
        [HttpPost]
        public void ExpensesPost([FromBody]Expenses expense)
        {
            ExpensesManager.Instance.CreateExpenses(expense);
        }

        // PUT: api/Expenses/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Expenses/5
        public void Delete(int id)
        {
        }
    }
}
