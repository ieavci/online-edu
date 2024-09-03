using Microsoft.AspNetCore.Mvc;

namespace online_edu.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
