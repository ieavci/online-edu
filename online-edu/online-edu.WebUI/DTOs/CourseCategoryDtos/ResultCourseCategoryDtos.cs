using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_edu.WebUI.DTOs.CourseCategoryDtos
{
	public class ResultCourseCategoryDtos
	{
		public int CourseCategoryId { get; set; }
		public string CategoryName { get; set; }
		public string Icon { get; set; }
		public string Description { get; set; }
		public bool IsShown { get; set; }
		
		public List<ResultCourseCategoryDtos> Categories { get; set; }
	}
}
