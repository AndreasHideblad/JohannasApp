using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace JohannasApp.Controllers
{
    [RoutePrefix("api/expenses")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ExpensesController : ApiController
    {
        // GET: api/Expenses
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Expenses/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Expenses
        public void Post([FromBody]string value)
        {
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
