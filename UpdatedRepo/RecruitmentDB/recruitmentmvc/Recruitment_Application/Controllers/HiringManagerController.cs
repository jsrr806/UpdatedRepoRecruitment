using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary_Recruitment;

namespace Recruitment_Application.Controllers
{
    public class HiringManagerController : Controller
    {
        Class1 cl = new Class1();

        public HiringManagerController()
        {
            ViewBag.Show = true;
        }
        // GET: HiringManager
        public ActionResult ReqAllotment()
        {
            return View(cl.DisplayPendingRequests());
        }

        public ActionResult Allotment(int p_bid, int p_rid)
        {
            return View(cl.DisplayAvailableEmployees());
        }

        public ActionResult AssignEmployee(int p_rid, int p_bid, int p_eid,string p_type)
        {
            cl.UpdateBusinessRequirements(p_rid, p_bid, p_eid, p_type);
            return RedirectToAction("Allotment");
        }
    }
}