﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using online_edu.DTO.DTOs.CourseCategoryDtos;
using online_edu.Entity.Entities;

namespace online_edu.DTO.DTOs.CourseDtos
{
	public class ResultCourseDtos
	{
		public int CourseId { get; set; }

		public string CourseName { get; set; }
		public string ImageUrl { get; set; }

		public decimal PriceCourse { get; set; }
		public bool IsShown { get; set; }
		
		public int CourseCategoryId { get; set; }
		public ResultCourseCategoryDtos CategoryDtos { get; set; }
	}
}
