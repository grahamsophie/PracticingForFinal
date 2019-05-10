//Sophie Graham


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCGoTime.Models; //Have to add this because that's what Griffin said.

namespace MVCGoTime.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";


            InformationAboutFootball info = new InformationAboutFootball();                 //
            {                                                                               //
                info.HeadCoach = "Lincoln Riley";                                           // 
                info.BowlRecord = "29-22-1(.567)";                                          //
                info.YearNationalTitle = "7 (1950, 1955, 1956, 1974, 1975, 1985, 2000)";    //
            }

            List<InformationAboutFootball> moreinfo = new List<InformationAboutFootball>(); //
            
            moreinfo.Add(info);                                                             //
            

            return View(info);                                                              //Inserted moreinfo inside of the View    
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}