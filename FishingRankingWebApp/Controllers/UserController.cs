using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishingRankingWebApp.Abstractions;
using FishingRankingWebApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FishingRankingWebApp.Controllers
{
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
        public IActionResult AddFish()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddFish(FIshViewModel model, IdentityUser user)
        {
            var use3 = userManager.GetUserAsync(HttpContext.User);
            
            var user2 = user.UserName;

            return View();
        }
    }
}
