using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using NorthwindEntities.DB;

namespace LearnKendo.Controllers.API
{
    public class _ApiBaseController : ApiController
    {
        public IDbContext repository;

        public _ApiBaseController() : this(new NorthwindContext()) { }
        public _ApiBaseController(IDbContext repository)
        {
            this.repository = repository;
        }
    }
}