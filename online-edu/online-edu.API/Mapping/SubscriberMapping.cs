using AutoMapper;
using online_edu.DTO.DTOs.SubscriberDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Mapping
{
	public class SubscriberMapping:Profile
	{
        public SubscriberMapping()
        {
			CreateMap<CreateSubscriberDto, Subscriber>().ReverseMap();
			CreateMap<UpdateSubscriberDto, Subscriber>().ReverseMap();
		}
    }
}
