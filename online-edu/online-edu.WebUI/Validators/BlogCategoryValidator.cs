using FluentValidation;
using online_edu.WebUI.DTOs.BlogCategoryDtos;

namespace online_edu.WebUI.Validators
{
	public class BlogCategoryValidator: AbstractValidator<CreateBlogCategoryDto>
	{
        public BlogCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Blog Category Name is Required");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Max Blog Category Name Can Be 30 Characters");
        }
    }
}
