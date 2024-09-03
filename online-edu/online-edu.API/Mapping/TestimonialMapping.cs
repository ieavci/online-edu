using AutoMapper;
using online_edu.Entity.Entities;
using online_edu.DTO.DTOs.TestimonialDtos;
namespace online_edu.API.Mapping
{
	public class TestimonialMapping:Profile
	{
        public TestimonialMapping()
        {
			CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
			CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
		}
    }
}
