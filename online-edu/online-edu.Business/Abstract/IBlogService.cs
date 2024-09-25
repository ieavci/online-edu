using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using online_edu.Entity.Entities;

namespace online_edu.Business.Abstract
{
	public interface IBlogService :IGenericService<Blog>
	{
		List<Blog> TGetBlogsWithCategories();

	}
}
