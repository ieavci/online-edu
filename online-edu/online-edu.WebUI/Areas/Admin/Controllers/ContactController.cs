using Microsoft.AspNetCore.Mvc;
using online_edu.WebUI.DTOs.ContactDtos;
using online_edu.WebUI.Helpers;

namespace online_edu.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("[area]/[controller]/[action]/{id?}")]
	public class ContactController : Controller
	{

		private readonly HttpClient _client=HttpClientInstance.CreateClient();
		public async Task<IActionResult> Index()
		{
			var values = await _client.GetFromJsonAsync<List<ResultContactDtos>>("contacts");
			return View(values);
		}

		public async Task<IActionResult> DeleteContact(int id)
		{
			await _client.DeleteAsync($"contacts/{id}");
			return RedirectToAction(nameof(Index));
		}

		public IActionResult CreateContact() { return View(); }

		[HttpPost]
		public async Task<IActionResult> CreateContact(CreateContactDtos createContactDtos)
		{
			var values=await _client.PostAsJsonAsync("contacts",createContactDtos);
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> UpdateContact(int id)
		{
			var value =await _client.GetFromJsonAsync<UpdateContactDtos>($"contacts/{id}");
			return View(value);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateContact(UpdateContactDtos updateContactDtos)
		{
			await _client.PutAsJsonAsync("contacts", updateContactDtos);
			return RedirectToAction(nameof(Index));
		}
	}
}
