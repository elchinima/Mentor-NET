using Mentor.NET.Models;
using Mentor.NET.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Mentor.NET.ViewModels;

namespace Mentor.NET.Controllers
{
    public class HomeController(AppDbContext appDbContext) : Controller
    {
        
        public IActionResult Index()
        {
            var expert = appDbContext.Experts.FirstOrDefault();

            ExpertVm expertVm = new ExpertVm
            {
                Expert = expert
            };


            return View(expertVm);
        }
    }
}