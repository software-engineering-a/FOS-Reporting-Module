using Jobs_Portal_Reporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jobs_Portal_Reporting.Controllers
{
    public class InterviewController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Interview> Get()
        {
            DBEntities db = new DBEntities();
            return (from interviews in db.Interviews
                    select interviews).AsEnumerable<Interview>();

        }

        // GET api/<controller>/5
        public IEnumerable<Interview> Get(int id)
        {
            DBEntities db = new DBEntities();
            return (from interviews in db.Interviews
                    where interviews.jobID == id
                    select interviews).AsEnumerable<Interview>();
        }
    }
}