using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HTMLHelperForTable.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			ViewData["columnNames"] = new string[] { "ID", "Name", "Price" };
			ViewData["content"] = new string[,]{
	              	                              {"101", "Apple", "1.01"},
	              	                              {"202", "Back", "2.02"},
	            	                              {"303", "Cup", "3.03"},
	             	                              {"404", "Donut", "3.03"}
	                                               };
			return View();
		}
	}
}