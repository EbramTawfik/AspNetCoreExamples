using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LayoutViewExample.Controllers
{
    public class HomeController : Controller
    {
		public IActionResult Home() => View();
		public IActionResult Page1() => View();
		public IActionResult Page2() => View();
	}
}