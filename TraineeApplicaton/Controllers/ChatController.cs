using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
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
        private readonly IToastNotification toastNotification;

        public ChatController(DataManager dataManager, IWebHostEnvironment hostEnvironment, IToastNotification toastNotification)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
            this.toastNotification = toastNotification;
        }

        [HttpPost]
        public IActionResult SendMessage(MessageItem model)
        {
            if (ModelState.IsValid)
            {
                dataManager.MessageItems.SaveMessageItem(model);
                toastNotification.AddSuccessToastMessage("Ваше повідомлення було надіслане адміністратору");
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
            }
            toastNotification.AddErrorToastMessage("Виникла помилка при надсиланні повідомлення адміністратору");
            return View("Error", "Model is not valid");
        }
    }
}
