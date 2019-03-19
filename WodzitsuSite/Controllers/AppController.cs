using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodzitsuSite.Data.Repositories;

namespace WodzitsuSite.Controllers
{
    public class AppController : Controller
    {
        private readonly ITourRepository repo;

        public AppController(ITourRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Wakacje")]
        public IActionResult Wakacje()
        {
            var trips = repo.GetAllTours();

            return View(trips);
        }
    }
}
