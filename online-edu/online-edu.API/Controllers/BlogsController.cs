﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using online_edu.Business.Abstract;
using online_edu.Entity.Entities;
using OnlineEdu.DTO.DTOs.BlogDtos;

namespace online_edu.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogsController(IMapper _mapper, IBlogService _blogService) : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			var values = _blogService.TGetBlogsWithCategories();
			var blogs=_mapper.Map<List<ResultBlogDto>>(values);
			return Ok(blogs);
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var values = _blogService.TGetById(id);
			return Ok(values);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_blogService.TDelete(id);

			return Ok();
		}

		[HttpPost]
		public IActionResult Create(CreateBlogDto createBlogDto)
		{
			var newValue = _mapper.Map<Blog>(createBlogDto);
			_blogService.TCreate(newValue);
			return Ok();
		}

		[HttpPut]
		public IActionResult Update(UpdateBlogDto updateBlogDto)
		{
			var value = _mapper.Map<Blog>(updateBlogDto);
			_blogService.TUpdate(value);
			return Ok();
		}
	}
}