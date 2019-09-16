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
            //ViewBag.Show = true;
        }
        // GET: HiringManager
        public ActionResult ReqAllotment()
        {
            return View(cl.DisplayPendingRequests());
        }

      
        public ActionResult NReqAllotment(int p_bid,int p_rid)
        {
            TempData["p_bid"] = p_bid;
            TempData["p_rid"] = p_rid;          
            return RedirectToAction("Allotment");
        }


        public ActionResult Allotment()/**/
        {
            return View(cl.DisplayAvailableEmployees());
        }

        public ActionResult NAllotment(int p_eid,string p_type)/**/
        {
            TempData["p_eid"] = p_eid;
            TempData["p_type"] = p_type;
            cl.UpdateBusinessRequirements(Convert.ToInt32(TempData["p_rid"]), Convert.ToInt32(TempData["p_bid"]), Convert.ToInt32(TempData["p_eid"]), Convert.ToString(TempData["p_type"]));
            return RedirectToAction("Allotment");
        }
    }
}