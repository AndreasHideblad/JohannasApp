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
        //[Route("get")]
        //[HttpGet]
        //public Expenses ExpensesGet(int id)
        //{
        //    return ExpensesManager.Instance.GetExpensesById(id);
        //}

        [Route("get/{id}")]
        [HttpGet]
        public Expenses ExpensesGet(int id)
        {
            return ExpensesManager.Instance.GetExpensesById(id);
        }

        [Route("create")]
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
