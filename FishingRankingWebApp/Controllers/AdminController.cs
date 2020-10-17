using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishingRankingWebApp.Abstractions;
using FishingRankingWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FishingRankingWebApp.Controllers
{
   [Authorize(Roles = "admin")]
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
            return View("ListOfMembers", list);
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
        [HttpPost]
        public IActionResult EditUser(Member member)
        {
            if (ModelState.IsValid)
            {
                adminRepository.EditMember(member);
                var list = adminRepository.ListOfMembers();
                return View("ListOfMembers", list);
            }
            return View();
          
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
                var member = adminRepository.GetMember(id);
                return View(member);
        }
        [HttpGet]
        public IActionResult AddMember()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMember(Member member)
        {
            if (ModelState.IsValid)
            {
                var user = adminRepository.AddMember(member);
                return View("DetailMember", user);
            }
            return View();
        }

  
    }
}
