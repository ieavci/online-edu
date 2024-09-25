using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using online_edu.WebUI.DTOs.BlogCategoryDtos;
using online_edu.WebUI.DTOs.BlogDtos;
using online_edu.WebUI.Helpers;

namespace online_edu.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]
	public class BlogController : Controller
	{
		private readonly HttpClient _httpClient = HttpClientInstance.CreateClient();
		public async Task CategoryDropdown()
		{
			var categoryList = await _httpClient.GetFromJsonAsync<List<ResultBlogCategoryDto>>("blogCategories");

			List<SelectListItem> categories = (from x in categoryList
											   select new SelectListItem
											   {
												   Text = x.Name,
												   Value = x.BlogCategoryId.ToString()
											   }
											   ).ToList();
			ViewBag.categorias = categories;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _httpClient.GetFromJsonAsync<List<ResultBlogDto>>("blogs");
			return View(values);
		}

		public async Task<IActionResult> DeleteBlog(int id)
		{
			await _httpClient.DeleteAsync($"blogs/{id}");
			return RedirectToAction(nameof(Index));
		}

		
		[HttpGet]
		public async Task<IActionResult> CreateBlog()
		{
			await CategoryDropdown();
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateBlog(CreateBlogDto dto)
		{
			await _httpClient.PostAsJsonAsync("blogs", dto);
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> UpdateBlog(int id)
		{
			await CategoryDropdown();
			await _httpClient.GetFromJsonAsync<UpdateBlogDto>($"blogs/{id}");
			return RedirectToAction(nameof(Index));
		}
	}
}
