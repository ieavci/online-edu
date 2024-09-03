using AutoMapper;
using online_edu.DTO.DTOs.MessageDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Mapping
{
	public class MessageMapping:Profile
	{
        public MessageMapping()
        {
            CreateMap<UpdateMessageDtos, Message>().ReverseMap();
            CreateMap<CreateMessageDtos, Message>().ReverseMap();
        }
    }
}
