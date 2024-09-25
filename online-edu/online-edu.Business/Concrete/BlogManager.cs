using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using online_edu.Business.Abstract;
using online_edu.DataAccess.Abstract;
using online_edu.Entity.Entities;

namespace online_edu.Business.Concrete
{
	public class BlogManager : GenericManager<Blog>, IBlogService
	{
		private readonly IBlogRepository _blogRepository;
		public BlogManager(IRepository<Blog> _repository, IBlogRepository blogRepository) : base(_repository)
		{
			_blogRepository = blogRepository;
		}

		public List<Blog> TGetBlogsWithCategories()
		{
			return _blogRepository.GetBlogsWithCategories();
		}
	}
}
