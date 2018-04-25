using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RPS.Models;

namespace RPS.Controllers
{
    public class GameController : Controller
    {
        [HttpGet("/game")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/game")]
        public ActionResult Game()
        {
          return View();
        }

        [HttpGet("/game/rock")]
        public ActionResult rock()
        {
          return View();
        }

        [HttpGet("/game/paper")]
        public ActionResult paper()
        {
          return View();
        }

        [HttpGet("/scissors")]
        public ActionResult scissors()
        {
          return View();
        }
    }
}
