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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("Categories")]
    public class ExpensesCategoryController : ApiController
    {
        //[Route("get")]
        [HttpGet] 
        public ExpensesCategory expensesCategoriesGet(int id)
        {
            return ExpensesCategoryManager.Instance.GetExpensesCategoryById(id);
        }

        //[Route("create")]
        [HttpPost]
        public void expensesCategoriesPost([FromBody]ExpensesCategory categories)
        {
            ExpensesCategoryManager.Instance.CreateExpensesCategory(categories);
        }

        // PUT: api/ExpensesCategory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ExpensesCategory/5
        public void Delete(int id)
        {
        }
    }
}