using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishingRankingWebApp.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace FishingRankingWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepository homeRepository;

        public HomeController(IHomeRepository homeRepository)
        {
            this.homeRepository = homeRepository;
        }
        public IActionResult Index()
        {
            var list = homeRepository.GetListOfFishes();
            return View(list);
        }
        public IActionResult DeleteFish(int id)
        {
            var list = homeRepository.DeleteFish(id);
            return View("Index",list);
        }
    }
}
