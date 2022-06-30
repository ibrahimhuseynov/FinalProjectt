using Microsoft.AspNetCore.Mvc;
using onepageend2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onepageend2.Areas.Menege.Controllers
{
    public class TableController : Controller
    {
        [Area("Menege")]
       
            public IActionResult Index()
            {
                return View();
            }

        
    }
}
   // {
   //[Area("Menege")]
   //public AppContext _context;
   //public IActionResult Index()
   //  {
   //return View();
   //  }
   //[HttpPost]
   //[ValidateAntiForgeryToken]
   //  public ActionResult Create(Catagory catagory)
   //{



//  }
// public ActionResult Delete(int id)
// {
// var data = _context.Catagories.Where(x => x.CatagoryId == id).FirstOrDefault();
// _context.Employees.Remove(data);
//  _context.SaveChanges();

// return RedirectToAction("index");
// }
// [HttpPost]
// public ActionResult Edit(int id)
//{
//     var data = _context.Catagories.Where(x => x.CatagoryId == id).FirstOrDefault();
//        if (data != null)  
// {  

// _context.SaveChanges();  
// }
//   

//}

//}
