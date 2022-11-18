using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain;

namespace TraineeApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        private IToastNotification toastNotification;
        public HomeController(DataManager dataManager, IToastNotification toastNotification)
        {
            this.dataManager = dataManager;
            this.toastNotification = toastNotification;
        }
        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageIndex"));
        }
        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }
    }
}
