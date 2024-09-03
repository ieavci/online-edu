﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_edu.WebUI.DTOs.BlogDtos
{
	public class UpdateBlogDto
	{
		public int BlogId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public string ImageUrl { get; set; }
		public DateTime BlogDate { get; set; }
		public int BlogCategoryId { get; set; }



	}
}