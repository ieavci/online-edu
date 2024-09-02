using AutoMapper;
using online_edu.DTO.DTOs.BannerDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Mapping
{
	public class BannerMapping:Profile
	{
        public BannerMapping()
        {
			CreateMap<CreateBannerDto, Banner>().ReverseMap();
			CreateMap<UpdateBannerDto, Banner>().ReverseMap();
		}
    }
}
