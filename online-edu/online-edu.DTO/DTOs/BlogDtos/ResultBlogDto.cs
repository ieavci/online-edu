using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using online_edu.DTO.DTOs.BlogCategoryDtos;
using online_edu.Entity.Entities;

namespace OnlineEdu.DTO.DTOs.BlogDtos
{
	public class ResultBlogDto
	{
		public int BlogId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public string ImageUrl { get; set; }
		public DateTime BlogDate { get; set; }
		public int BlogCategoryId { get; set; }
		public ResultBlogCategoryDto BlogCategory { get; set; }
	}
}