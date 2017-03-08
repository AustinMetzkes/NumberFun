using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NumberFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            return View();
        }
        public IActionResult Results(string number, string color)

        {
            int n;

            if (int.TryParse(number, out n))
            {
                return View(n);
            }
            else
            {
                return Error();
            }
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}