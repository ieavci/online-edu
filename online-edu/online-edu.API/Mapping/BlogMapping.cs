using AutoMapper;
using online_edu.Entity.Entities;
using OnlineEdu.DTO.DTOs.BlogDtos;

namespace online_edu.API.Mapping
{
	public class BlogMapping:Profile
	{
        public BlogMapping()
        {
			CreateMap<CreateBlogDto, Blog>().ReverseMap();
			CreateMap<UpdateBlogDto, Blog>().ReverseMap();
			CreateMap<ResultBlogDto, Blog>().ReverseMap();
		}
    }
}
