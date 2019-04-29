using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Jobs_Portal_Reporting.Models;

namespace Jobs_Portal_Reporting.Controllers
{
    public class JobsController : ApiController
    {
        private DBEntities db = new DBEntities();

        // GET: api/Jobs
        public IQueryable<Job> Get()
        {
            return db.Jobs;
        }

        // GET: api/Jobs/5
        [ResponseType(typeof(Job))]
        public async Task<IHttpActionResult> Get(int id)
        {
            Job job = await db.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }

            return Ok(job);
        }
    }
}