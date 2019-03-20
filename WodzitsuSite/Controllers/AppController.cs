using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WodzitsuSite.Data.Entities;
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
        [Authorize]
        public IActionResult Wakacje()
        {
            var trips = repo.GetAllTours();

            return View(trips);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Tour createTour)
        {
            if(ModelState.IsValid)
            {
                repo.SaveTour(createTour);

                return RedirectToAction("Wakacje", "App");
            }
            else
            {
                ModelState.TryAddModelError("", "Failed to login");
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int tourID)
        {
            Tour tour = repo.GetTour(tourID);
            return RedirectToAction("Index", "App", tour);
        }

    }
}
