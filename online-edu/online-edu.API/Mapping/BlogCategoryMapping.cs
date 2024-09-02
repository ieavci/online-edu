using AutoMapper;
using online_edu.DTO.DTOs.BlogCategoryDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Mapping
{
	public class BlogCategoryMapping:Profile
	{
        public BlogCategoryMapping()
        {
            CreateMap<UpdateBlogCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<CreateBlogCategoryDto, BlogCategory>().ReverseMap();
            CreateMap<ResultBlogCategoryDto, BlogCategory>().ReverseMap();
        }
    }
}
