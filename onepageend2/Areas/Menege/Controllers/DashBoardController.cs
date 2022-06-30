using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onepageend2.Areas.Menege.Controllers
{
    [Area("Menege")]
    public class DashBoardController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

    }
}
