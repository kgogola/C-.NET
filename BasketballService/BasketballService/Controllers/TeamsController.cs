using BasketballService.DAL;
using BasketballService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasketballService.Controllers
{
    public class TeamsController : Controller
    {
        private TeamsContext db = new TeamsContext();

        public ActionResult Details(int id)
        {
            var team = db.Teams.Find(id); //i want to take details, so i looking for specific team due to id
            return View(team);
        }

        [ChildActionOnly]
        public ActionResult PlayersList(int id)
        {
            //Here i am looking for appropriate values and my key is TeamId which is passed from view
            var players = db.Players.ToList().FindAll(k => k.TeamId == id);
            return PartialView("_PlayersList", players);
        }

        public ActionResult Delete(int id)
        {
            Team team = db.Teams.Find(id);
            db.Teams.Remove(team);
            db.SaveChanges();
            return View();
        }

        public ActionResult NewTeam()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewTeamCreated(Team team)
        {
            db.Teams.Add(team);
            db.SaveChanges();
            return View();
        }
    }
}