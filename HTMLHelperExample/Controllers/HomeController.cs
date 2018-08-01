using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HTMLHelperExample.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			ViewData["country"] = "United States";
			ViewData["state"] = "Washington";
			ViewData["county"] = "King";
			ViewData["city"] = "Redmond";
			return View();
		}
	}
}