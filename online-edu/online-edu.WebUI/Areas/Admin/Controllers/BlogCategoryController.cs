using Microsoft.AspNetCore.Mvc;
using online_edu.WebUI.DTOs.BlogCategoryDtos;
using online_edu.WebUI.Helpers;
using online_edu.WebUI.Validators;

namespace online_edu.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]

	public class BlogCategoryController : Controller
	{
		private readonly HttpClient _httpClient=HttpClientInstance.CreateClient();
		public async Task<IActionResult> Index()
		{
			var values = await _httpClient.GetFromJsonAsync<List<ResultBlogCategoryDto>>("blogCategories");
			return View(values);
		}

		public async Task<IActionResult> DeleteBlogCategory(int id)
		{
			await _httpClient.DeleteAsync($"blogCategories/{id}");
			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		public IActionResult CreateBlogcategory()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateBlogcategory(CreateBlogCategoryDto dto)
		{
			var validator = new BlogCategoryValidator();
			var result=await validator.ValidateAsync(dto);
			if (!result.IsValid)
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View();
			}

			await _httpClient.PostAsJsonAsync("blogCategories", dto);
			return RedirectToAction(nameof(Index));

		}

		[HttpGet]
		public async Task<IActionResult> UpdateBlogCategory(int id)
		{
			var value = await _httpClient.GetFromJsonAsync<UpdateBlogCategoryDto>($"blogCategories/{id}");
			return View(value);

		}

		[HttpPost]
		public async Task<IActionResult> UpdateBlogCategory(UpdateBlogCategoryDto dto)
		{
			await _httpClient.PutAsJsonAsync("blogCategories", dto);
			return RedirectToAction($"{nameof(Index)}");
		}
	}
}
