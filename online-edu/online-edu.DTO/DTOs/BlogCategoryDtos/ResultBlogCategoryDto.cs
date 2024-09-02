using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using online_edu.Entity.Entities;
using OnlineEdu.DTO.DTOs.BlogDtos;

namespace online_edu.DTO.DTOs.BlogCategoryDtos
{
	public class ResultBlogCategoryDto
	{
		public int BlogCategoryId { get; set; }
		public string Name { get; set; }

		public List<ResultBlogDto> Blogs { get; set; }
	}
}
