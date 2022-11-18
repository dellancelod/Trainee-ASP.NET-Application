using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using TraineeApplication.Domain;
using TraineeApplication.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace TraineeApplication.Controllers
{
    public class NewsItemsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly IToastNotification toastNotification;
        public NewsItemsController(DataManager dataManager, IWebHostEnvironment hostEnvironment, IToastNotification toastNotification)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
            this.toastNotification = toastNotification;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.NewsItems.GetNewsItemById(id));
            }

            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageNews");
            return View(dataManager.NewsItems.GetNewsItems());
        }
        public IActionResult Suggest(Guid id)
        {
            return View(new NewsItem());
        }

        [HttpPost]
        public IActionResult Suggest(NewsItem model, IFormFile titleImageFile)
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
                model.Hidden = true;
                model.AuthorID = User.FindFirstValue(ClaimTypes.NameIdentifier);
                dataManager.NewsItems.SaveNewsItem(model);
                toastNotification.AddSuccessToastMessage("Новина надійшла на розгляд адміністратору");
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
            }
            toastNotification.AddErrorToastMessage("Виникли проблеми при надсиланні новини");
            return View(model);
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
