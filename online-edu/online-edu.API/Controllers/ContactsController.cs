using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using online_edu.Business.Abstract;
using online_edu.DTO.DTOs.ContactDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactsController(IGenericService<Contact> _contactService, IMapper _mapper) : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			var values = _contactService.TGetList();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var values = _contactService.TGetById(id);
			return Ok(values);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_contactService.TDelete(id);
			return Ok();
		}

		[HttpPost]
		public IActionResult Create(CreateContactDtos createContactDtos)
		{
			var newValue = _mapper.Map<Contact>(createContactDtos);
			_contactService.TCreate(newValue);
			return Ok();
		}

		[HttpPut]
		public IActionResult Update(UpdateContactDtos updateContactDtos)
		{
			var value = _mapper.Map<Contact>(updateContactDtos);
			_contactService.TUpdate(value);
			return Ok();
		}
	}
}
