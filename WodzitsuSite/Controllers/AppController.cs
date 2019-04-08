using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WodzitsuSite.Data.Entities;
using WodzitsuSite.Data.Repositories;
using WodzitsuSite.ViewModels;

namespace WodzitsuSite.Controllers
{
    public class AppController : Controller
    {
        private readonly ITourRepository repo;
        private readonly IHostingEnvironment env;
        private readonly UserManager<Czlopok> userManager;
        private readonly ILogger<AppController> logger;

        public AppController(ITourRepository repo, IHostingEnvironment environment, UserManager<Czlopok> userManager, ILogger<AppController> logger)
        {
            this.repo = repo;
            env = environment;
            this.userManager = userManager;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Wakacje")]
        [Authorize]
        public IActionResult Wakacje()
        {
            var model = new List<ScoreViewModel>();
            var trips = repo.GetAllTours();
            foreach (var trip in trips)
            {
                var scoreViewModel = new ScoreViewModel()
                {
                    tour = trip,
                    scores = repo.GetTourScores(trip.Id).ToList()
                };

                model.Add(scoreViewModel);
            }
           
            return View(model.OrderByDescending(t => t.ScoreTotal));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Tour createTour, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var zdjęcia = UploadFiles(files);
                    zdjęcia.Wait();
                    createTour.Zdjecie = zdjęcia.Result.ToString();

                    repo.SaveTour(createTour);

                    return RedirectToAction("Wakacje", "App");
                }
                catch (Exception ex)
                {
                    logger.LogError($"Error while adding Trip: {ex.Message}");
                    ModelState.TryAddModelError("", $"Failed to add trip");
                    return View();
                }

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

            if (tour == null)
            {
                return RedirectToAction("Wakacje");
            }

            return View(tour);
        }

        [HttpPost]
        public IActionResult Edit(Tour editTour, List<IFormFile> files)
        {
            if (!ModelState.IsValid)
            {
                ModelState.TryAddModelError("", "Nie udało się zaktualizowac wycieczki");
                return View(editTour);
            }
            else
            {
                try
                {
                    if (files.Count() > 0)
                    {
                        //remove old picture
                        RemoveFile(editTour.Zdjecie);

                        var zdjęcia = UploadFiles(files);
                        zdjęcia.Wait();
                        editTour.Zdjecie = zdjęcia.Result.ToString();
                    }

                    repo.UpdateTour(editTour);
                }
                catch (Exception ex)
                {
                    logger.LogError($"Error while editing Trip: {ex.Message}");
                    ModelState.TryAddModelError("", $"Nie udało się załadować zdjęcia: {ex.Message}");
                    return View(editTour);
                }
            }

            return RedirectToAction("Wakacje");
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            bool resutl = Int16.TryParse(id, out short tripID);
            if (resutl)
            {
                repo.DeleteTour(tripID);
            }

            return RedirectToAction("Wakacje");
        }

        private void RemoveFile(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
            {
                return;
            }
            try
            {
                var fullName = Path.Combine(env.WebRootPath, "img", Path.GetFileName(fileName));
                if (System.IO.File.Exists(fullName))
                {
                    System.IO.File.Delete(fullName);
                }
            }
            catch (Exception ex)
            {
                ModelState.TryAddModelError("", $"Nie udało się usunąć zdjęcia: {ex.Message}");
            }
            
        }

        private async Task<string> UploadFiles(List<IFormFile> files)
        {
            string retrunImg = String.Empty;
            long size = files.Sum(f => f.Length);

            // full path to file in temp location
            var filePath = Path.Combine(env.WebRootPath, "img");

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    var destPath = Path.Combine(filePath, Path.GetFileName(formFile.FileName));
                    if (retrunImg.Length > 0)
                    {
                        retrunImg += ";";
                    }
                    retrunImg += Path.GetFileName(formFile.FileName);

                    using (var stream = new FileStream(destPath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }

            return retrunImg;
        }

        [HttpGet]
        public IActionResult Score(int Id)
        {
            ScoreViewModel model = new ScoreViewModel();
            model.tour = repo.GetTour(Id);
            model.scores = repo.GetTourScores(Id).ToList();

            if (model.tour != null)
            {
                return View(model);
            }
            else
            {
                return RedirectToAction("Wakacje");
            }
        }

        [HttpPost]
        public IActionResult Score(int TourId, decimal score)
        {
            repo.ScoreTour(TourId, score, userManager.GetUserId(User));

            return RedirectToAction("Wakacje");
        }
    }
}
