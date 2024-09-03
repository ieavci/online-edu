using AutoMapper;
using online_edu.DTO.DTOs.SocialMediaDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Mapping
{
	public class SocialMediaMapping:Profile
	{
        public SocialMediaMapping()
        {
            CreateMap<UpdateSocialMediaDtos, SocialMedia>().ReverseMap();
            CreateMap<CreateSocialMediaDtos, SocialMedia>().ReverseMap();
        }
    }
}
