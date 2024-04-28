using MaaHayat.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace MaaHayat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MainMapPage()
        {

            return View();
        }

    }
}
