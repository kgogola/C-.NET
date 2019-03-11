using BasketballService.DAL;
using BasketballService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasketballService.Controllers
{
    public class HomeController : Controller
    {

        private TeamsContext db = new TeamsContext();

        public ActionResult Index()
        {
            var teamsList = db.Teams.ToList();
            var playerList = db.Players.ToList();
            return View(teamsList);
        }

        public ActionResult TeamsList()
        {
            var teamsList = db.Teams.ToList();
            var playerList = db.Players.ToList();
            return View(teamsList);
        }

        public ActionResult PlayersList()
        {
            var players = db.Players.ToList();
            return View(players);
        }
    }
}