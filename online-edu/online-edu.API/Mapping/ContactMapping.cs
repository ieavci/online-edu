using AutoMapper;
using online_edu.DTO.DTOs.ContactDtos;
using online_edu.Entity.Entities;

namespace online_edu.API.Mapping
{
	public class ContactMapping:Profile
	{
        public ContactMapping()
        {
            CreateMap<CreateContactDtos, Contact>().ReverseMap();
            CreateMap<UpdateContactDtos, Contact>().ReverseMap();
        }
    }
}
