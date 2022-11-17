using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain;
using TraineeApplication.Domain.Entities;

namespace TraineeApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        public NewsItemsController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Edit(Guid id)
        {
            NewsItem entity = id == default ? new NewsItem() : dataManager.NewsItems.GetNewsItemById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(NewsItem model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, "images/news/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.NewsItems.SaveNewsItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.NewsItems.DeleteNewsItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult IsTitleAvailable(string Title)
        {
            try
            {
                var tag = dataManager.NewsItems.GetNewsItems().Single(m => m.Title == Title);
                return Json(false);
            }
            catch (Exception)
            {
                return Json(true);
            }

        }
    }
}
