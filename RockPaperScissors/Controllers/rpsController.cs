using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RPS.Models;

namespace RPS.Controllers
{
    public class RockPaperScissorsController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }
    }
}
