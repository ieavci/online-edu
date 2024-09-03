using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_edu.WebUI.DTOs.CourseDtos
{
    public class UpdateCourseDtos
	{
		public int CourseId { get; set; }
		public string CourseName { get; set; }
		public string ImageUrl { get; set; }
 
		public decimal PriceCourse { get; set; }
		public bool IsShown { get; set; }
		public int CourseCategoryId { get; set; }
	}
}
