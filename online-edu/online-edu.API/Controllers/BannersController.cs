﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using online_edu.Business.Abstract;
using online_edu.DTO.DTOs.BannerDtos;
using online_edu.Entity.Entities;


namespace OnlineEdu.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BannersController(IGenericService<Banner> _bannerService, IMapper _mapper) : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			var values = _bannerService.TGetList();
			return Ok(values);
		}

		[HttpGet("{id}")]

		public IActionResult GetById(int id)
		{
			var value = _bannerService.TGetById(id);
			return Ok(value);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_bannerService.TDelete(id);
			return Ok("Banner Alanı Silindi");
		}

		[HttpPost]
		public IActionResult Create(CreateBannerDto createBannerDto)
		{
			var newValue = _mapper.Map<Banner>(createBannerDto);
			_bannerService.TCreate(newValue);
			return Ok("Yeni Banner Alanı Oluşturuldu");
		}

		[HttpPut]
		public IActionResult Update(UpdateBannerDto updateBannerDto)
		{
			var value = _mapper.Map<Banner>(updateBannerDto);
			_bannerService.TUpdate(value);
			return Ok("Banner Alanı Güncellendi");
		}
	}
}