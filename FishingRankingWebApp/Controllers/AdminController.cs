using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishingRankingWebApp.Abstractions;
using FishingRankingWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FishingRankingWebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminRepository adminRepository;

        public AdminController(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }
        public IActionResult DeleteMember(int id)
        {
            adminRepository.DeleteMember(id);
            var list = adminRepository.ListOfMembers();
            return View("ListOfUsers", list);
        }
        [HttpGet]
        public IActionResult DetailMember(int id)
        {
            var user = adminRepository.GetMember(id);
            return View(user);
        }

        public IActionResult ListOfMembers()
        {
            var list = adminRepository.ListOfMembers();
            return View(list);
        }
        public IActionResult FishToCheck()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditMember(Member member)
        {
            
            var user = adminRepository.EditMember(member);
            return View(member);
        }
        [HttpPost]
        public IActionResult EditUser(Member member)
        {
            var newUser = adminRepository.EditMember(member);
            return View("DetailUser", newUser);
        }
  
    }
}
