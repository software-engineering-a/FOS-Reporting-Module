using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jobs_Portal_Reporting.Models;

namespace Jobs_Portal_Reporting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBEntities db = new DBEntities();

            ViewBag.ApplicationsCount = (from applications in db.Applications
                                         select applications).Count();

            ViewBag.InterviewsCount = (from Interview in db.Interviews
                                       select Interview).Count();

            ViewBag.InterviewsOnTime = ViewBag.InterviewsCount - (from Interview in db.Interviews
                                                                  where Interview.scheduledTime < Interview.happendTime
                                                                  select Interview).Count();

            ViewBag.scheduledInterviews = (from Interview in db.Interviews
                                           where Interview.scheduledTime > DateTime.Now
                                           group Interview.scheduledTime by Interview.jobID into scheduled
                                           select new
                                           {
                                               jobID = scheduled.Key,
                                               scheduled = scheduled.ToList().Count()
                                           });
            ViewBag.conductedInterviews = (from Interview in db.Interviews
                                           where Interview.happendTime != null
                                           group Interview.happendTime by Interview.jobID into conducted
                                           select new
                                           {
                                               jobID = conducted.Key,
                                               scheduled = conducted.ToList().Count()
                                           });

            return View();
        }
    }
}