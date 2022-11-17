using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain;
using TraineeApplication.Domain.Entities;

namespace TraineeApplication.Controllers
{
    public class ChatController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        public ChatController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }

        [HttpPost]
        public IActionResult SendMessage(MessageItem model)
        {
            if (ModelState.IsValid)
            {
                dataManager.MessageItems.SaveMessageItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
            }
            return View("Error", "Model is not valid");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.MessageItems.DeleteMessageItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
        }
    }
}
