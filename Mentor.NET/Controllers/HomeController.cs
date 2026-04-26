using Mentor.NET.Models;
using Mentor.NET.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Mentor.NET.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Mentor.NET.Controllers
{
    public class HomeController(AppDbContext appDbContext) : Controller
    {
        public IActionResult Index()
        {
            var experts = appDbContext.Experts.AsNoTracking().ToList();

            ExpertVm expertVm = new ExpertVm
            {
                Experts = experts
            };


            return View(expertVm);
        }
    }
}