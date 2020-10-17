using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishingRankingWebApp.Abstractions;
using FishingRankingWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FishingRankingWebApp.Controllers
{
 [Authorize(Roles = "admin, normalUser")]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userReposiotry, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userRepository = userReposiotry;
        }
        public IActionResult Punctation()
        {
            return View();
        }
        public IActionResult Ranking()
        {
            var list = userRepository.GetMembers();
            return View(list);
        }
        [HttpGet]
        public IActionResult AddFish()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFish(FishViewModel model, string currentUser)
        {
            if (ModelState.IsValid)
            {
                userRepository.AddFish(model, currentUser);

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
