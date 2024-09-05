using Microsoft.AspNetCore.Mvc;
using online_edu.WebUI.DTOs.AboutDtos;
using online_edu.WebUI.Helpers;

namespace online_edu.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]
	public class AboutController : Controller
	{
		private readonly HttpClient _client = HttpClientInstance.CreateClient();
		public async Task<IActionResult> Index()
		{

			var values = await _client.GetFromJsonAsync<List<ResultAboutDto>>("abouts");
			return View(values);
		}
	}
}
