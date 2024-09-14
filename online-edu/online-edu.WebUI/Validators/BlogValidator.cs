using FluentValidation;
using online_edu.WebUI.DTOs.BlogDtos;

namespace online_edu.WebUI.Validators
{
	public class BlogValidator: AbstractValidator<CreateBlogDto>
	{
        public BlogValidator()
        {
			RuleFor(x => x.Title).NotEmpty().WithMessage("Blog Title is Required");
			RuleFor(x => x.Content).NotEmpty().WithMessage("Blog  Content is Required");
			RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image Url is Required");
			RuleFor(x => x.BlogDate).NotEmpty().WithMessage("Blog Date is Required");
			RuleFor(x => x.BlogCategoryId).NotEmpty().WithMessage("Blog Category Name is Required");

		}
	}
}

