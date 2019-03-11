using BasketballService.DAL;
using BasketballService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasketballService.Controllers
{

    public class PlayersController : Controller
    {
        private TeamsContext db = new TeamsContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var player = db.Players.Find(id); //i want to take details, so i looking for specific team due to id
            return View(player);
        }

        public ActionResult NewPlayer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewPlayerCreated(Player player)
        {
            db.Players.Add(player);
            db.SaveChanges();
            return View();

        }
    }
}