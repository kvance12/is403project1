using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MissionSite.Controllers
{
    public class MissionController : Controller
    {
        

        // GET: Default
        public ActionResult Mission()
        {
            return View();
        }

        public ActionResult IndMissionFAQ (string MissNumber)
        {
            ViewBag.Mission_Name = MissNumber;
            if (MissNumber == "1")
            {
                ViewBag.MissionName = "WIsconsin";
            }
                

            else if (MissNumber == "2")
            {
                ViewBag.MissionName ="Peru";
            }

            else
            {
                ViewBag.MissionName = "Sydney";
            }
            return View();
        }
    }

   
}