//Sophie Graham


using MVCGoTime.Models;     //Add this before adding the private blah blah part underneath
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGoTime.Controllers
{
    public class ScheduleController : Controller
    {
        //I added this controller. To add it to the database, do the code underneath.
        private DB_128040_practiceEntities db = new DB_128040_practiceEntities();


        // GET: Schedule
        public ActionResult Index(int? year)         //Added int year. The question mark means it can be a null value
        {
            //Added the IF statement
            if(year == null)
            {
                year = DateTime.Now.Year;
            }
            //Created the code underneath and added the variable "games" inside the View() below.
            var games = db.FootballSchedules.Where(s => s.Season == year.Value);

            //Instead of the var games=.... , I could do the code below:

            //var g = new List<FootballSchedule>();
            //foreach (var s in db.FootballSchedules)
            //{
            //    if (s.Season == year.Value)
            //    {
            //        g.Add(s);
            //    }
            //}


            //Right click on View and Add View. Title the View as Index.
            return View(games);
        }
    }
}