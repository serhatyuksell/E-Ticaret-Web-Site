using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.Controllers
{
	public class DefaultController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult CategoryDetails(int id) {
			 ViewBag.x = id;
			return View();	
		}
	}
}
