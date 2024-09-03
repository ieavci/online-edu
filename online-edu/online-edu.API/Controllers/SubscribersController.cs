using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using online_edu.Business.Abstract;
using online_edu.DTO.DTOs.SubscriberDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SubscribersController(IGenericService<Subscriber> _genericService, IMapper _mapper) : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			var values = _genericService.TGetList();
			return Ok(values);
		}
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var value= _genericService.TGetById(id);
			return Ok(value);
		}
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_genericService.TDelete(id);
			return Ok();
		}
		[HttpPost]
		public IActionResult Create(CreateSubscriberDto createSubscriberDto)
		{
			var value=_mapper.Map<Subscriber>(createSubscriberDto);
			_genericService.TCreate(value);
			return Ok();
		}
		[HttpPut]
		public IActionResult Update(UpdateSubscriberDto updateSubscriberDto)
		{
			var value = _mapper.Map<Subscriber>(updateSubscriberDto);
			_genericService.TUpdate(value);
			return Ok();
		}
	}
}
