using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeApplication.Domain;
using TraineeApplication.Domain.Entities;
using TraineeApplication.Model;

namespace TraineeApplication.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly DataManager dataManager;
        private readonly IToastNotification toastNotification;
        public AccountController(DataManager dataMgr, IToastNotification toastNtfication, UserManager<IdentityUser> userMgr, SignInManager<IdentityUser> signInMgr)
        {
            userManager = userMgr;
            signInManager = signInMgr;
            dataManager = dataMgr;
            toastNotification = toastNtfication;
        }
        [AllowAnonymous]
        public IActionResult Login(string retutnUrl)
        {
            ViewBag.returnUrl = retutnUrl;
            return View(new LoginViewModel());
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(model.Username);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                    {
                        FireNotifications();
                        return Redirect(returnUrl ?? "/");
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.Username), "Невірний логін або пароль");
            }
            return View(model);
        }

        [NonAction]
        private void FireNotifications()
        {
            foreach (NewsNotification notification in dataManager.NewsNotifications.GetNewsNotificationItems())
            {
                if (notification.Approved)
                {
                    toastNotification.AddSuccessToastMessage($"Новина \"{notification.Title}\" була опублікована");
                }
                if (!notification.Approved)
                {
                    toastNotification.AddSuccessToastMessage($"Новина \"{notification.Title}\" не була опублікована");
                }
            }
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        
    }
}
