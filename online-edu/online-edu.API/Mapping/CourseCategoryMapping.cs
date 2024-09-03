using AutoMapper;
using online_edu.DTO.DTOs.CourseCategoryDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Mapping
{
	public class CourseCategoryMapping:Profile
	{
        public CourseCategoryMapping()
        {
            CreateMap<CreateCourseCategoryDtos, CourseCategory>().ReverseMap();
            CreateMap<UpdateCourseCategoryDtos, CourseCategory>().ReverseMap();
            CreateMap<ResultCourseCategoryDtos, CourseCategory>().ReverseMap();
        }
    }
}
