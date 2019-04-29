using Jobs_Portal_Reporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jobs_Portal_Reporting.Controllers
{
    public class ApplicationsController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Application> Get()
        {
            DBEntities db = new DBEntities();
            return (from applications in db.Applications
                    select applications).AsEnumerable<Application>();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }
    }
}