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
            adminRepository.EditMember(member);
            var list = adminRepository.ListOfMembers();
            return View("ListOfMembers", list);
        }
        [HttpGet]
        public IActionResult EdiUser(int id)
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
            var user = adminRepository.AddMember(member);
            return View("DetailMember", user);
        }

  
    }
}
