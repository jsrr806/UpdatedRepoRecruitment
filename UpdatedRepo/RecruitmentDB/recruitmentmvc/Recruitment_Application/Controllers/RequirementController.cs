using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary_Recruitment;

namespace Recruitment_Application.Controllers
{
    public class RequirementController : Controller
    {
        public RequirementController()
        {
            ViewBag.Show = true;
        }

        Class1 cl = new Class1();

        public ActionResult DisplayRequests(int p_bid1)
        {
            List<proc_display_requrests_Result> temp = cl.DisplayRequests(p_bid1);
            return View(temp);
        }

        public ActionResult ReqInput()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ReqInput(int p_bid, int p_javareq, int p_dotnetreq, int p_breq)
        {
            cl.InsertRequest(p_bid, p_javareq, p_dotnetreq, p_breq);
            return RedirectToAction("DisplayRequests","Requirement",new { p_bid1 = p_bid});
        }
    }
}