using Microsoft.AspNetCore.Mvc;
using RockPaperScissors.Models;
using System;
using System.Collections.Generic;
namespace RockPaperScissors.Controllers
{
    public class RockPaperScissorsController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index ()
        {
            return View();
        }

    }
}
