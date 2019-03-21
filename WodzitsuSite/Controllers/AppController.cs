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
        public IActionResult Edit(int Id)
        {
            Tour tour = repo.GetTour(Id);

            if(tour == null)
            {
                return RedirectToAction("Wakacje");
            }

            return View(tour);
        }

        [HttpPost]
        public IActionResult Edit(Tour editTour)
        {
            if(!ModelState.IsValid)
            {
                ModelState.TryAddModelError("", "Nie udało się zaktualizowac wycieczki");
                return View(editTour);
            }
            else
            {
                repo.UpdateTour(editTour);
            }

            return RedirectToAction("Wakacje");
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            bool resutl = Int16.TryParse(id, out short tripID);
            if(resutl)
            {
                repo.DeleteTour(tripID);
            }

            return RedirectToAction("Wakacje");
        }

    }
}
