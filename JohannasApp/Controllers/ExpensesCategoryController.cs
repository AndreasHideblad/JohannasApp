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
    [RoutePrefix("ExpensesCategories")]

    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ExpensesCategoryController : ApiController
    {
        [Route("get/{id}")]
        [HttpGet] 
        public ExpensesCategory ExpensesCategoriesGet(int id)
        {
            return ExpensesCategoryManager.Instance.GetExpensesCategoryById(id);
        }

        //public IHttpActionResult GetExpensesCategories(int id)
        //{
        //    var expensesCategory = ExpensesCategoryManager.Instance.GetExpensesCategoryById(id);
        //    if (expensesCategory == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(expensesCategory);
        //}


        [Route("create")]
        [HttpPost]
        public void ExpensesCategoriesPost([FromBody]ExpensesCategory categories)
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