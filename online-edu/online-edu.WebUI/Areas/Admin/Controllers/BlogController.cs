using Microsoft.AspNetCore.Mvc;
using online_edu.WebUI.DTOs.BlogDtos;
using online_edu.WebUI.Helpers;

namespace online_edu.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]
	public class BlogController : Controller
	{
		private readonly HttpClient _httpClient=HttpClientInstance.CreateClient();
		public async Task< IActionResult> Index()
		{
			var values = await _httpClient.GetFromJsonAsync<List<ResultBlogDto>>("blogs");
			return View(values);
		}
	}
}
