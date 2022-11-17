using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain;

namespace TraineeApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChatController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        public ChatController(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }
        public IActionResult Show(Guid id)
        {
            return View(dataManager.MessageItems.GetMessageItemById(id));
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.MessageItems.DeleteMessageItem(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
        }
    }
}
