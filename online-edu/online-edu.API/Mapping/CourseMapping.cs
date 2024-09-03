using AutoMapper;
using online_edu.DTO.DTOs.CourseDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Mapping
{
	public class CourseMapping:Profile
	{
        public CourseMapping()
        {
            CreateMap<CreateCourseDtos, Course>().ReverseMap();
            CreateMap<UpdateCourseDtos, Course>().ReverseMap();
            CreateMap<ResultCourseDtos, Course>().ReverseMap();

        }
    }
}
