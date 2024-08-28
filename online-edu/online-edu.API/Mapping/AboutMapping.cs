using AutoMapper;
using online_edu.DTO.DTOs.AboutDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Mapping
{
	public class AboutMapping:Profile
	{
        public AboutMapping()
        {
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
