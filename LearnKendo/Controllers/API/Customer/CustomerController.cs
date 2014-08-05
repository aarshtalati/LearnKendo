using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.DataContracts.API;

namespace LearnKendo.Controllers.API.Customer
{
    public class CustomerController : _ApiBaseController
    {
        // GET: api/Customer
        public IEnumerable<CustomerContract> Get()
        {
            var customers = repository.EntitySet<NorthwindEntities.DB.Customer>().Take(10).ToArray();

            return new List<CustomerContract>().AsEnumerable();
        }

        // GET: api/Customer/5
        public CustomerContract Get(int id)
        {
            return new CustomerContract();
        }

        // POST: api/Customer
        public void Post([FromBody]CustomerContract value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]CustomerContract value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
