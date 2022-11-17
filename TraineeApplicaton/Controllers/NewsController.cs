using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraineeApplication.Domain;

namespace TraineeApplication.Controllers
{
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;

        public NewsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
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
