using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using online_edu.Business.Abstract;
using online_edu.DTO.DTOs.BlogCategoryDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogCategoriesController(IGenericService<BlogCategory> _blogCategoryService, IMapper _mapper) : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			var values = _blogCategoryService.TGetList();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var values = _blogCategoryService.TGetById(id);
			return Ok(values);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_blogCategoryService.TDelete(id);

			return Ok();
		}

		[HttpPost]
		public IActionResult Create(CreateBlogCategoryDto createBlogCategoryDto)
		{
			var newValue = _mapper.Map<BlogCategory>(createBlogCategoryDto);
			_blogCategoryService.TCreate(newValue);
			ResultBlogCategoryDto nes = new ResultBlogCategoryDto();
			return Ok();
		}

		[HttpPut]
		public IActionResult Update(UpdateBlogCategoryDto updateBlogCategoryDto)
		{
			var value = _mapper.Map<BlogCategory>(updateBlogCategoryDto);
			_blogCategoryService.TUpdate(value);
			return Ok();
		}
	}
}
